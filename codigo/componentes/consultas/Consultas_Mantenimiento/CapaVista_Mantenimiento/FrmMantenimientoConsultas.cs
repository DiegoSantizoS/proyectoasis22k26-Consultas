using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaControlador_Consultas;

namespace CapaVista_Consultas
{

    public partial class FrmMantenimientoConsultas : Componentes.ClsBaseTerminus
    {
        private readonly ClsControladorMantenimiento _ctrl = new ClsControladorMantenimiento();
        private Dictionary<string, string> _tipos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private string _tabla;

        private const int _ColCampo = 0;
        private const int _ColOperador = 1;
        private const int _ColValor = 2;
        private const int _ColOrden = 3;

        public FrmMantenimientoConsultas(string tabla)
        {
            InitializeComponent();
            _tabla = (tabla ?? "").Trim();
            Load += FrmMantenimientoConsultas_Load;
        }

        private void FrmMantenimientoConsultas_Load(object sender, EventArgs e)
        {
            try
            {
                ConsultasProcConectarEventos();
                ConsultasProcCargarOperadores();


                if (_tabla == "")
                {
                    BeginInvoke(new MethodInvoker(Close));
                    return;
                }

                ConsultasProcCargarColumnas();
                Text = "4003 – MantenimientoConsultas – " + _tabla;
            }
            catch (Exception ex)
            {
                ConsultasProcMostrarError("No se pudo cargar el formulario.", ex);
                BeginInvoke(new MethodInvoker(Close));
            }
        }

        private void ConsultasProcConectarEventos()
        {
            ConsultasCboOperador.SelectedIndexChanged += ConsultasCboOperador_SelectedIndexChanged;
            ConsultasBtnIngresar.Click += ConsultasBtnIngresar_Click;
            ConsultasBtnEliminar.Click += ConsultasBtnEliminar_Click;
            ConsultasBtnGuardar.Click += ConsultasBtnGuardar_Click;
        }

        private void ConsultasProcCargarOperadores()
        {
            ConsultasCboOperador.Items.Clear();
            ConsultasCboOperador.Items.AddRange(new object[]
            {
                "=", "<>", ">", "<", ">=", "<=", "LIKE", "NOT LIKE", "IS NULL", "IS NOT NULL"
            });
            ConsultasCboOperador.SelectedIndex = -1;
        }

        private void ConsultasProcCargarColumnas()
        {
            _tipos = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            ConsultasCboOperadorCampo.Items.Clear();

            foreach (KeyValuePair<string, string> col in _ctrl.ConsultasMetObtenerColumnas(_tabla))
            {
                _tipos[col.Key] = col.Value;
                ConsultasCboOperadorCampo.Items.Add(col.Key);
            }

            if (_tipos.Count == 0)
            {
                throw new ArgumentException(
                    "No se encontraron campos para \"" + _tabla + "\". Revisa que exista en la base de datos dbConsulta.");
            }

            ConsultasCboOperadorCampo.SelectedIndex = -1;
        }


        /*private string PedirTabla()
        {
            using (Form dlg = new Form())
            using (Label lbl = new Label())
            using (ComboBox cmb = new ComboBox())
            using (Button ok = new Button())
            using (Button cancelar = new Button())
            {
                dlg.Text = "Mantenimiento de consultas";
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
                dlg.MinimizeBox = false;
                dlg.MaximizeBox = false;
                dlg.ClientSize = new Size(360, 120);

                lbl.Text = "¿Sobre que tabla o vista quieres crear la consulta?";
                lbl.AutoSize = true;
                lbl.Location = new Point(12, 14);

                cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                cmb.Location = new Point(12, 40);
                cmb.Width = 336;
                foreach (string t in _ctrl.ObtenerTablas())
                {
                    cmb.Items.Add(t);
                }

                ok.Text = "Aceptar";
                ok.Location = new Point(192, 80);
                ok.Click += delegate
                {
                    if (cmb.SelectedIndex < 0)
                    {
                        MessageBox.Show(dlg, "Selecciona una tabla o vista.", "Mantenimiento de consultas",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dlg.DialogResult = DialogResult.OK;
                };

                cancelar.Text = "Cancelar";
                cancelar.Location = new Point(273, 80);
                cancelar.DialogResult = DialogResult.Cancel;

                dlg.AcceptButton = ok;
                dlg.CancelButton = cancelar;
                dlg.Controls.Add(lbl);
                dlg.Controls.Add(cmb);
                dlg.Controls.Add(ok);
                dlg.Controls.Add(cancelar);

                if (dlg.ShowDialog(this) == DialogResult.OK && cmb.SelectedItem != null)
                {
                    return cmb.SelectedItem.ToString();
                }
                return "";
            }
        }*/


        private void ConsultasCboOperador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string op = ConsultasCboOperador.SelectedItem == null ? "" : ConsultasCboOperador.SelectedItem.ToString();
            bool sinValor = op == "IS NULL" || op == "IS NOT NULL";

            ConsultasTxtValor.Enabled = !sinValor;
            if (sinValor)
            {
                ConsultasTxtValor.Clear();
            }
        }

        private void ConsultasBtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConsultasCboOperadorCampo.SelectedItem == null)
                {
                    ConsultasProcAviso("Selecciona un campo.");
                    return;
                }

                string campo = ConsultasCboOperadorCampo.SelectedItem.ToString();
                string op = ConsultasCboOperador.SelectedItem == null ? "" : ConsultasCboOperador.SelectedItem.ToString();
                string valor = ConsultasTxtValor.Text.Trim();
                string orden = ConsultasRdoAscendente.Checked ? "ASC" : (ConsultasRdoDescendente.Checked ? "DESC" : "");

                if (op == "" && valor != "")
                {
                    ConsultasProcAviso("Selecciona un operador para usar el valor.");
                    return;
                }
                if (op == "" && orden == "")
                {
                    ConsultasProcAviso("Selecciona un operador con su valor, o un ordenamiento (ASC / DESC).");
                    return;
                }

                ClsCondicion fila = new ClsCondicion();
                fila.Campo = campo;
                fila.Operador = op;
                fila.Valor = valor;
                fila.Orden = orden;

                _ctrl.ConsultasProcValidarCondicion(fila, _tipos);

                ConsultasDgvConsultasFiltros.Rows.Add(fila.Campo, fila.Operador, fila.Valor, fila.Orden);

                ConsultasTxtValor.Clear();
                ConsultasCboOperadorCampo.SelectedIndex = -1;
                ConsultasCboOperador.SelectedIndex = -1;
                ConsultasRdoAscendente.Checked = false;
                ConsultasRdoDescendente.Checked = false;
            }
            catch (ArgumentException ex)
            {
                ConsultasProcAviso(ex.Message);
            }
            catch (Exception ex)
            {
                ConsultasProcMostrarError("No se pudo agregar la condicion.", ex);
            }
        }

        private void ConsultasBtnEliminar_Click(object sender, EventArgs e)
        {
            if (ConsultasDgvConsultasFiltros.SelectedRows.Count == 0)
            {
                ConsultasProcAviso("Selecciona en la tabla la condicion que quieres quitar.");
                return;
            }

            ConsultasDgvConsultasFiltros.Rows.Remove(ConsultasDgvConsultasFiltros.SelectedRows[0]);
        }

        private void ConsultasBtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = ConsultasTxtNombre.Text.Trim();
                if (nombre == "")
                {
                    ConsultasProcAviso("Escribe un nombre para la consulta.");
                    ConsultasTxtNombre.Focus();
                    return;
                }

                string query = _ctrl.ConsultasFuncConstruirQuery(_tabla, ConsultasMetLeerCondiciones(), _tipos);

                DialogResult r = MessageBox.Show(this,
                    "Se guardara la consulta \"" + nombre + "\":" + Environment.NewLine + Environment.NewLine +
                    query + Environment.NewLine + Environment.NewLine + "¿Guardar?",
                    "Guardar consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r != DialogResult.Yes)
                {
                    return;
                }

                _ctrl.ConsultasProcGuardar(nombre, _tabla, query);

                MessageBox.Show(this, "Consulta guardada.", "Mantenimiento de consultas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConsultasProcLimpiarFormulario();
            }
            catch (ArgumentException ex)
            {
                ConsultasProcAviso(ex.Message);
            }
            catch (Exception ex)
            {
                ConsultasProcMostrarError("No se pudo guardar la consulta.", ex);
            }
        }



        private List<ClsCondicion> ConsultasMetLeerCondiciones()
        {
            List<ClsCondicion> lista = new List<ClsCondicion>();
            bool hayCondicionPrevia = false;

            foreach (DataGridViewRow fila in ConsultasDgvConsultasFiltros.Rows)
            {
                ClsCondicion c = new ClsCondicion();
                c.Campo = ConsultasFuncTexto(fila.Cells[_ColCampo]);
                c.Operador = ConsultasFuncTexto(fila.Cells[_ColOperador]);
                c.Valor = ConsultasFuncTexto(fila.Cells[_ColValor]);
                c.Orden = ConsultasFuncTexto(fila.Cells[_ColOrden]);

                if (c.Operador != "")
                {
                    c.Conector = hayCondicionPrevia ? "AND" : "";
                    hayCondicionPrevia = true;
                }
                lista.Add(c);
            }
            return lista;
        }

        private void ConsultasProcLimpiarFormulario()
        {
            ConsultasDgvConsultasFiltros.Rows.Clear();
            ConsultasTxtNombre.Clear();
            ConsultasTxtValor.Clear();
            ConsultasTxtValor.Enabled = true;
            ConsultasCboOperadorCampo.SelectedIndex = -1;
            ConsultasCboOperador.SelectedIndex = -1;
            ConsultasRdoAscendente.Checked = false;
            ConsultasRdoDescendente.Checked = false;
        }

        private static string ConsultasFuncTexto(DataGridViewCell celda)
        {
            return celda.Value == null ? "" : celda.Value.ToString();
        }

        private void ConsultasProcAviso(string mensaje)
        {
            MessageBox.Show(this, mensaje, "Mantenimiento de consultas",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ConsultasProcMostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(this, mensaje + Environment.NewLine + Environment.NewLine + ex.Message,
                "Mantenimiento de consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
