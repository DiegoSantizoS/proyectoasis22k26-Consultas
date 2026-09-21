namespace CapaVista_Consultas
{
    partial class FrmMantenimientoConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenimientoConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ConsultasTlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTlpFiltros = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasFlpBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnEliminar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasDgvConsultasFiltros = new CapaVista_Consultas.Componentes.ClsTablaDatosConsultas();
            this.ConsultasColCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColOperador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColOrdenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasGbxCondicionesLogicas = new CapaVista_Consultas.Componentes.ClsGrupoConsultas();
            this.ConsultasTlpCondicionesLogicas = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasBtnIngresar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasLblOrdenamiento = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasTlpOrdenamiento = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasRdoDescendente = new CapaVista_Consultas.Componentes.ClsBotonRadioConsultas();
            this.ConsultasRdoAscendente = new CapaVista_Consultas.Componentes.ClsBotonRadioConsultas();
            this.ConsultasLblCampo = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboOperadorCampo = new CapaVista_Consultas.Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblOperador = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasCboOperador = new CapaVista_Consultas.Componentes.ClsListaComboBoxConsultas();
            this.ConsultasLblValor = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasTxtValor = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasGbxGuardarConsultas = new CapaVista_Consultas.Componentes.ClsGrupoConsultas();
            this.ConsultasTlpGuardarConsulta = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasLblNombre = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasBtnGuardar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasTxtNombre = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasGbxConsultasGuardadas = new CapaVista_Consultas.Componentes.ClsGrupoConsultas();
            this.ConsultasTlpGuardadas = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasTxtBuscar = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasCboTablaFiltro = new CapaVista_Consultas.Componentes.ClsListaComboBoxConsultas();
            this.ConsultasPnlEdicion = new System.Windows.Forms.Panel();
            this.ConsultasLblEdicion = new CapaVista_Consultas.Componentes.ClsEtiquetaConsultas();
            this.ConsultasBtnCancelarEdicion = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasTlpLista = new System.Windows.Forms.TableLayoutPanel();
            this.ConsultasDgvConsultasGuardadas = new CapaVista_Consultas.Componentes.ClsTablaDatosConsultas();
            this.ConsultasColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasColActualizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsultasFlpBotonesGuardadas = new System.Windows.Forms.FlowLayoutPanel();
            this.ConsultasBtnModificar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnEliminarConsulta = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasBtnRefrescar = new CapaVista_Consultas.Componentes.ClsBotonConsultas();
            this.ConsultasTxtQuerySeleccionado = new CapaVista_Consultas.Componentes.ClsCajaTextoConsultas();
            this.ConsultasTlpPrincipal.SuspendLayout();
            this.ConsultasTlpFiltros.SuspendLayout();
            this.ConsultasFlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).BeginInit();
            this.ConsultasGbxCondicionesLogicas.SuspendLayout();
            this.ConsultasTlpCondicionesLogicas.SuspendLayout();
            this.ConsultasTlpOrdenamiento.SuspendLayout();
            this.ConsultasGbxGuardarConsultas.SuspendLayout();
            this.ConsultasTlpGuardarConsulta.SuspendLayout();
            this.ConsultasGbxConsultasGuardadas.SuspendLayout();
            this.ConsultasTlpGuardadas.SuspendLayout();
            this.ConsultasTlpBusqueda.SuspendLayout();
            this.ConsultasPnlEdicion.SuspendLayout();
            this.ConsultasTlpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasGuardadas)).BeginInit();
            this.ConsultasFlpBotonesGuardadas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsultasTlpPrincipal
            // 
            this.ConsultasTlpPrincipal.ColumnCount = 2;
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ConsultasTlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasTlpFiltros, 1, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxCondicionesLogicas, 0, 0);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxGuardarConsultas, 0, 1);
            this.ConsultasTlpPrincipal.Controls.Add(this.ConsultasGbxConsultasGuardadas, 0, 2);
            this.ConsultasTlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.ConsultasTlpPrincipal.Name = "ConsultasTlpPrincipal";
            this.ConsultasTlpPrincipal.RowCount = 3;
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.ConsultasTlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpPrincipal.Size = new System.Drawing.Size(1307, 780);
            this.ConsultasTlpPrincipal.TabIndex = 16;
            this.ConsultasTlpPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsultasTlpPrincipal_Paint);
            // 
            // ConsultasTlpFiltros
            // 
            this.ConsultasTlpFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasTlpFiltros.ColumnCount = 2;
            this.ConsultasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpFiltros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.ConsultasTlpFiltros.Controls.Add(this.ConsultasFlpBotones, 1, 0);
            this.ConsultasTlpFiltros.Controls.Add(this.ConsultasDgvConsultasFiltros, 0, 0);
            this.ConsultasTlpFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpFiltros.Location = new System.Drawing.Point(525, 4);
            this.ConsultasTlpFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpFiltros.Name = "ConsultasTlpFiltros";
            this.ConsultasTlpFiltros.RowCount = 1;
            this.ConsultasTlpPrincipal.SetRowSpan(this.ConsultasTlpFiltros, 2);
            this.ConsultasTlpFiltros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpFiltros.Size = new System.Drawing.Size(779, 472);
            this.ConsultasTlpFiltros.TabIndex = 19;
            this.ConsultasTlpFiltros.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsultasTlpFiltros_Paint);
            // 
            // ConsultasFlpBotones
            // 
            this.ConsultasFlpBotones.Controls.Add(this.ConsultasBtnEliminar);
            this.ConsultasFlpBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConsultasFlpBotones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsultasFlpBotones.Location = new System.Drawing.Point(699, 0);
            this.ConsultasFlpBotones.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasFlpBotones.Name = "ConsultasFlpBotones";
            this.ConsultasFlpBotones.Size = new System.Drawing.Size(80, 362);
            this.ConsultasFlpBotones.TabIndex = 2;
            this.ConsultasFlpBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.ConsultasFlpBotones_Paint);
            // 
            // ConsultasBtnEliminar
            // 
            this.ConsultasBtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnEliminar.BackgroundImage")));
            this.ConsultasBtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnEliminar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnEliminar.Location = new System.Drawing.Point(0, 0);
            this.ConsultasBtnEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnEliminar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.Name = "ConsultasBtnEliminar";
            this.ConsultasBtnEliminar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminar.TabIndex = 2;
            this.ConsultasBtnEliminar.UseVisualStyleBackColor = false;
            // 
            // ConsultasDgvConsultasFiltros
            // 
            this.ConsultasDgvConsultasFiltros.AllowUserToAddRows = false;
            this.ConsultasDgvConsultasFiltros.AllowUserToDeleteRows = false;
            this.ConsultasDgvConsultasFiltros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasFiltros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ConsultasDgvConsultasFiltros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvConsultasFiltros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvConsultasFiltros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultasDgvConsultasFiltros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ConsultasDgvConsultasFiltros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasFiltros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ConsultasDgvConsultasFiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvConsultasFiltros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultasColCampo,
            this.ConsultasColOperador,
            this.ConsultasColValor,
            this.ConsultasColOrdenamiento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultasDgvConsultasFiltros.DefaultCellStyle = dataGridViewCellStyle3;
            this.ConsultasDgvConsultasFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvConsultasFiltros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsultasDgvConsultasFiltros.EnableHeadersVisualStyles = false;
            this.ConsultasDgvConsultasFiltros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasDgvConsultasFiltros.GridColor = System.Drawing.Color.LightGray;
            this.ConsultasDgvConsultasFiltros.Location = new System.Drawing.Point(3, 4);
            this.ConsultasDgvConsultasFiltros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasDgvConsultasFiltros.MultiSelect = false;
            this.ConsultasDgvConsultasFiltros.Name = "ConsultasDgvConsultasFiltros";
            this.ConsultasDgvConsultasFiltros.ReadOnly = true;
            this.ConsultasDgvConsultasFiltros.RowHeadersVisible = false;
            this.ConsultasDgvConsultasFiltros.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasFiltros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ConsultasDgvConsultasFiltros.RowTemplate.Height = 28;
            this.ConsultasDgvConsultasFiltros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultasDgvConsultasFiltros.Size = new System.Drawing.Size(693, 464);
            this.ConsultasDgvConsultasFiltros.TabIndex = 3;
            this.ConsultasDgvConsultasFiltros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultasDgvConsultasFiltros_CellContentClick);
            // 
            // ConsultasColCampo
            // 
            this.ConsultasColCampo.HeaderText = "Campo";
            this.ConsultasColCampo.MinimumWidth = 6;
            this.ConsultasColCampo.Name = "ConsultasColCampo";
            this.ConsultasColCampo.ReadOnly = true;
            // 
            // ConsultasColOperador
            // 
            this.ConsultasColOperador.HeaderText = "Operador";
            this.ConsultasColOperador.MinimumWidth = 6;
            this.ConsultasColOperador.Name = "ConsultasColOperador";
            this.ConsultasColOperador.ReadOnly = true;
            // 
            // ConsultasColValor
            // 
            this.ConsultasColValor.HeaderText = "Valor";
            this.ConsultasColValor.MinimumWidth = 6;
            this.ConsultasColValor.Name = "ConsultasColValor";
            this.ConsultasColValor.ReadOnly = true;
            // 
            // ConsultasColOrdenamiento
            // 
            this.ConsultasColOrdenamiento.HeaderText = "Ordenamiento";
            this.ConsultasColOrdenamiento.MinimumWidth = 6;
            this.ConsultasColOrdenamiento.Name = "ConsultasColOrdenamiento";
            this.ConsultasColOrdenamiento.ReadOnly = true;
            // 
            // ConsultasGbxCondicionesLogicas
            // 
            this.ConsultasGbxCondicionesLogicas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxCondicionesLogicas.Controls.Add(this.ConsultasTlpCondicionesLogicas);
            this.ConsultasGbxCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxCondicionesLogicas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxCondicionesLogicas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxCondicionesLogicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxCondicionesLogicas.Location = new System.Drawing.Point(3, 3);
            this.ConsultasGbxCondicionesLogicas.Name = "ConsultasGbxCondicionesLogicas";
            this.ConsultasGbxCondicionesLogicas.Size = new System.Drawing.Size(516, 294);
            this.ConsultasGbxCondicionesLogicas.TabIndex = 16;
            this.ConsultasGbxCondicionesLogicas.TabStop = false;
            this.ConsultasGbxCondicionesLogicas.Text = "Agregar Condición";
            // 
            // ConsultasTlpCondicionesLogicas
            // 
            this.ConsultasTlpCondicionesLogicas.ColumnCount = 2;
            this.ConsultasTlpCondicionesLogicas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.ConsultasTlpCondicionesLogicas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasBtnIngresar, 1, 4);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblOrdenamiento, 0, 3);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasTlpOrdenamiento, 1, 3);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblCampo, 0, 0);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasCboOperadorCampo, 1, 0);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblOperador, 0, 1);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasCboOperador, 1, 1);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasLblValor, 0, 2);
            this.ConsultasTlpCondicionesLogicas.Controls.Add(this.ConsultasTxtValor, 1, 2);
            this.ConsultasTlpCondicionesLogicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpCondicionesLogicas.Location = new System.Drawing.Point(3, 24);
            this.ConsultasTlpCondicionesLogicas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpCondicionesLogicas.Name = "ConsultasTlpCondicionesLogicas";
            this.ConsultasTlpCondicionesLogicas.RowCount = 5;
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ConsultasTlpCondicionesLogicas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.ConsultasTlpCondicionesLogicas.Size = new System.Drawing.Size(510, 267);
            this.ConsultasTlpCondicionesLogicas.TabIndex = 2;
            // 
            // ConsultasBtnIngresar
            // 
            this.ConsultasBtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnIngresar.BackgroundImage")));
            this.ConsultasBtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnIngresar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnIngresar.Location = new System.Drawing.Point(283, 179);
            this.ConsultasBtnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnIngresar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.Name = "ConsultasBtnIngresar";
            this.ConsultasBtnIngresar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnIngresar.TabIndex = 9;
            this.ConsultasBtnIngresar.UseVisualStyleBackColor = false;
            // 
            // ConsultasLblOrdenamiento
            // 
            this.ConsultasLblOrdenamiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblOrdenamiento.AutoSize = true;
            this.ConsultasLblOrdenamiento.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOrdenamiento.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOrdenamiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOrdenamiento.Location = new System.Drawing.Point(24, 141);
            this.ConsultasLblOrdenamiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOrdenamiento.Name = "ConsultasLblOrdenamiento";
            this.ConsultasLblOrdenamiento.Size = new System.Drawing.Size(110, 19);
            this.ConsultasLblOrdenamiento.TabIndex = 10;
            this.ConsultasLblOrdenamiento.Text = "Ordenamiento";
            this.ConsultasLblOrdenamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasTlpOrdenamiento
            // 
            this.ConsultasTlpOrdenamiento.ColumnCount = 2;
            this.ConsultasTlpOrdenamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.ConsultasTlpOrdenamiento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.ConsultasTlpOrdenamiento.Controls.Add(this.ConsultasRdoDescendente, 1, 0);
            this.ConsultasTlpOrdenamiento.Controls.Add(this.ConsultasRdoAscendente, 0, 0);
            this.ConsultasTlpOrdenamiento.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConsultasTlpOrdenamiento.Location = new System.Drawing.Point(137, 129);
            this.ConsultasTlpOrdenamiento.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpOrdenamiento.Name = "ConsultasTlpOrdenamiento";
            this.ConsultasTlpOrdenamiento.RowCount = 1;
            this.ConsultasTlpOrdenamiento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpOrdenamiento.Size = new System.Drawing.Size(169, 43);
            this.ConsultasTlpOrdenamiento.TabIndex = 8;
            // 
            // ConsultasRdoDescendente
            // 
            this.ConsultasRdoDescendente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultasRdoDescendente.AutoSize = true;
            this.ConsultasRdoDescendente.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasRdoDescendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasRdoDescendente.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasRdoDescendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasRdoDescendente.Location = new System.Drawing.Point(79, 11);
            this.ConsultasRdoDescendente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 4);
            this.ConsultasRdoDescendente.Name = "ConsultasRdoDescendente";
            this.ConsultasRdoDescendente.Size = new System.Drawing.Size(69, 23);
            this.ConsultasRdoDescendente.TabIndex = 2;
            this.ConsultasRdoDescendente.TabStop = true;
            this.ConsultasRdoDescendente.Text = "DESC";
            this.ConsultasRdoDescendente.UseVisualStyleBackColor = true;
            // 
            // ConsultasRdoAscendente
            // 
            this.ConsultasRdoAscendente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasRdoAscendente.AutoSize = true;
            this.ConsultasRdoAscendente.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasRdoAscendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasRdoAscendente.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasRdoAscendente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasRdoAscendente.Location = new System.Drawing.Point(13, 11);
            this.ConsultasRdoAscendente.Margin = new System.Windows.Forms.Padding(3, 7, 3, 4);
            this.ConsultasRdoAscendente.Name = "ConsultasRdoAscendente";
            this.ConsultasRdoAscendente.Size = new System.Drawing.Size(60, 23);
            this.ConsultasRdoAscendente.TabIndex = 1;
            this.ConsultasRdoAscendente.TabStop = true;
            this.ConsultasRdoAscendente.Text = "ASC";
            this.ConsultasRdoAscendente.UseVisualStyleBackColor = true;
            // 
            // ConsultasLblCampo
            // 
            this.ConsultasLblCampo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblCampo.AutoSize = true;
            this.ConsultasLblCampo.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblCampo.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblCampo.Location = new System.Drawing.Point(75, 12);
            this.ConsultasLblCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblCampo.Name = "ConsultasLblCampo";
            this.ConsultasLblCampo.Size = new System.Drawing.Size(59, 19);
            this.ConsultasLblCampo.TabIndex = 11;
            this.ConsultasLblCampo.Text = "Campo";
            this.ConsultasLblCampo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasCboOperadorCampo
            // 
            this.ConsultasCboOperadorCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboOperadorCampo.BackColor = System.Drawing.Color.White;
            this.ConsultasCboOperadorCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboOperadorCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboOperadorCampo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboOperadorCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboOperadorCampo.FormattingEnabled = true;
            this.ConsultasCboOperadorCampo.Location = new System.Drawing.Point(140, 6);
            this.ConsultasCboOperadorCampo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperadorCampo.Name = "ConsultasCboOperadorCampo";
            this.ConsultasCboOperadorCampo.Size = new System.Drawing.Size(367, 31);
            this.ConsultasCboOperadorCampo.TabIndex = 17;
            // 
            // ConsultasLblOperador
            // 
            this.ConsultasLblOperador.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblOperador.AutoSize = true;
            this.ConsultasLblOperador.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblOperador.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblOperador.Location = new System.Drawing.Point(58, 55);
            this.ConsultasLblOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblOperador.Name = "ConsultasLblOperador";
            this.ConsultasLblOperador.Size = new System.Drawing.Size(76, 19);
            this.ConsultasLblOperador.TabIndex = 12;
            this.ConsultasLblOperador.Text = "Operador";
            this.ConsultasLblOperador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasCboOperador
            // 
            this.ConsultasCboOperador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboOperador.BackColor = System.Drawing.Color.White;
            this.ConsultasCboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboOperador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboOperador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboOperador.FormattingEnabled = true;
            this.ConsultasCboOperador.Location = new System.Drawing.Point(140, 49);
            this.ConsultasCboOperador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboOperador.Name = "ConsultasCboOperador";
            this.ConsultasCboOperador.Size = new System.Drawing.Size(367, 31);
            this.ConsultasCboOperador.TabIndex = 18;
            // 
            // ConsultasLblValor
            // 
            this.ConsultasLblValor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblValor.AutoSize = true;
            this.ConsultasLblValor.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblValor.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblValor.Location = new System.Drawing.Point(88, 98);
            this.ConsultasLblValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasLblValor.Name = "ConsultasLblValor";
            this.ConsultasLblValor.Size = new System.Drawing.Size(46, 19);
            this.ConsultasLblValor.TabIndex = 13;
            this.ConsultasLblValor.Text = "Valor";
            this.ConsultasLblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasTxtValor
            // 
            this.ConsultasTxtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTxtValor.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtValor.Location = new System.Drawing.Point(140, 92);
            this.ConsultasTxtValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTxtValor.Name = "ConsultasTxtValor";
            this.ConsultasTxtValor.Size = new System.Drawing.Size(367, 30);
            this.ConsultasTxtValor.TabIndex = 16;
            // 
            // ConsultasGbxGuardarConsultas
            // 
            this.ConsultasGbxGuardarConsultas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasGbxGuardarConsultas.Controls.Add(this.ConsultasTlpGuardarConsulta);
            this.ConsultasGbxGuardarConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxGuardarConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxGuardarConsultas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxGuardarConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxGuardarConsultas.Location = new System.Drawing.Point(3, 303);
            this.ConsultasGbxGuardarConsultas.Name = "ConsultasGbxGuardarConsultas";
            this.ConsultasGbxGuardarConsultas.Size = new System.Drawing.Size(516, 174);
            this.ConsultasGbxGuardarConsultas.TabIndex = 18;
            this.ConsultasGbxGuardarConsultas.TabStop = false;
            this.ConsultasGbxGuardarConsultas.Text = "Guardar Consulta";
            // 
            // ConsultasTlpGuardarConsulta
            // 
            this.ConsultasTlpGuardarConsulta.ColumnCount = 2;
            this.ConsultasTlpGuardarConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.ConsultasTlpGuardarConsulta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpGuardarConsulta.Controls.Add(this.ConsultasLblNombre, 0, 0);
            this.ConsultasTlpGuardarConsulta.Controls.Add(this.ConsultasBtnGuardar, 1, 1);
            this.ConsultasTlpGuardarConsulta.Controls.Add(this.ConsultasTxtNombre, 1, 0);
            this.ConsultasTlpGuardarConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpGuardarConsulta.Location = new System.Drawing.Point(3, 24);
            this.ConsultasTlpGuardarConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpGuardarConsulta.Name = "ConsultasTlpGuardarConsulta";
            this.ConsultasTlpGuardarConsulta.RowCount = 2;
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpGuardarConsulta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ConsultasTlpGuardarConsulta.Size = new System.Drawing.Size(510, 147);
            this.ConsultasTlpGuardarConsulta.TabIndex = 2;
            // 
            // ConsultasLblNombre
            // 
            this.ConsultasLblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConsultasLblNombre.AutoSize = true;
            this.ConsultasLblNombre.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblNombre.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblNombre.Location = new System.Drawing.Point(68, 17);
            this.ConsultasLblNombre.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLblNombre.Name = "ConsultasLblNombre";
            this.ConsultasLblNombre.Size = new System.Drawing.Size(66, 19);
            this.ConsultasLblNombre.TabIndex = 3;
            this.ConsultasLblNombre.Text = "Nombre";
            this.ConsultasLblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasBtnGuardar
            // 
            this.ConsultasBtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasBtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConsultasBtnGuardar.BackgroundImage")));
            this.ConsultasBtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnGuardar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnGuardar.Location = new System.Drawing.Point(283, 60);
            this.ConsultasBtnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnGuardar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.Name = "ConsultasBtnGuardar";
            this.ConsultasBtnGuardar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnGuardar.TabIndex = 2;
            this.ConsultasBtnGuardar.UseVisualStyleBackColor = false;
            // 
            // ConsultasTxtNombre
            // 
            this.ConsultasTxtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConsultasTxtNombre.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtNombre.Location = new System.Drawing.Point(140, 11);
            this.ConsultasTxtNombre.Name = "ConsultasTxtNombre";
            this.ConsultasTxtNombre.Size = new System.Drawing.Size(237, 30);
            this.ConsultasTxtNombre.TabIndex = 0;
            // 
            // ConsultasGbxConsultasGuardadas
            // 
            this.ConsultasGbxConsultasGuardadas.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasTlpPrincipal.SetColumnSpan(this.ConsultasGbxConsultasGuardadas, 2);
            this.ConsultasGbxConsultasGuardadas.Controls.Add(this.ConsultasTlpGuardadas);
            this.ConsultasGbxConsultasGuardadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasGbxConsultasGuardadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasGbxConsultasGuardadas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ConsultasGbxConsultasGuardadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasGbxConsultasGuardadas.Location = new System.Drawing.Point(3, 483);
            this.ConsultasGbxConsultasGuardadas.Name = "ConsultasGbxConsultasGuardadas";
            this.ConsultasGbxConsultasGuardadas.Size = new System.Drawing.Size(1301, 294);
            this.ConsultasGbxConsultasGuardadas.TabIndex = 20;
            this.ConsultasGbxConsultasGuardadas.TabStop = false;
            this.ConsultasGbxConsultasGuardadas.Text = "Consultas guardadas";
            // 
            // ConsultasTlpGuardadas
            // 
            this.ConsultasTlpGuardadas.ColumnCount = 1;
            this.ConsultasTlpGuardadas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpGuardadas.Controls.Add(this.ConsultasTlpBusqueda, 0, 0);
            this.ConsultasTlpGuardadas.Controls.Add(this.ConsultasTlpLista, 0, 1);
            this.ConsultasTlpGuardadas.Controls.Add(this.ConsultasTxtQuerySeleccionado, 0, 2);
            this.ConsultasTlpGuardadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpGuardadas.Location = new System.Drawing.Point(3, 24);
            this.ConsultasTlpGuardadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTlpGuardadas.Name = "ConsultasTlpGuardadas";
            this.ConsultasTlpGuardadas.RowCount = 3;
            this.ConsultasTlpGuardadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.ConsultasTlpGuardadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpGuardadas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.ConsultasTlpGuardadas.Size = new System.Drawing.Size(1295, 267);
            this.ConsultasTlpGuardadas.TabIndex = 0;
            // 
            // ConsultasTlpBusqueda
            // 
            this.ConsultasTlpBusqueda.ColumnCount = 3;
            this.ConsultasTlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.ConsultasTlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.ConsultasTlpBusqueda.Controls.Add(this.ConsultasTxtBuscar, 0, 0);
            this.ConsultasTlpBusqueda.Controls.Add(this.ConsultasCboTablaFiltro, 1, 0);
            this.ConsultasTlpBusqueda.Controls.Add(this.ConsultasPnlEdicion, 2, 0);
            this.ConsultasTlpBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpBusqueda.Location = new System.Drawing.Point(0, 0);
            this.ConsultasTlpBusqueda.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpBusqueda.Name = "ConsultasTlpBusqueda";
            this.ConsultasTlpBusqueda.RowCount = 1;
            this.ConsultasTlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpBusqueda.Size = new System.Drawing.Size(1295, 44);
            this.ConsultasTlpBusqueda.TabIndex = 0;
            // 
            // ConsultasTxtBuscar
            // 
            this.ConsultasTxtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasTxtBuscar.BackColor = System.Drawing.Color.White;
            this.ConsultasTxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtBuscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasTxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtBuscar.Location = new System.Drawing.Point(3, 7);
            this.ConsultasTxtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTxtBuscar.Name = "ConsultasTxtBuscar";
            this.ConsultasTxtBuscar.Size = new System.Drawing.Size(689, 30);
            this.ConsultasTxtBuscar.TabIndex = 0;
            // 
            // ConsultasCboTablaFiltro
            // 
            this.ConsultasCboTablaFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasCboTablaFiltro.BackColor = System.Drawing.Color.White;
            this.ConsultasCboTablaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConsultasCboTablaFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasCboTablaFiltro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ConsultasCboTablaFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasCboTablaFiltro.FormattingEnabled = true;
            this.ConsultasCboTablaFiltro.Location = new System.Drawing.Point(698, 6);
            this.ConsultasCboTablaFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasCboTablaFiltro.Name = "ConsultasCboTablaFiltro";
            this.ConsultasCboTablaFiltro.Size = new System.Drawing.Size(234, 31);
            this.ConsultasCboTablaFiltro.TabIndex = 1;
            // 
            // ConsultasPnlEdicion
            // 
            this.ConsultasPnlEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.ConsultasPnlEdicion.Controls.Add(this.ConsultasLblEdicion);
            this.ConsultasPnlEdicion.Controls.Add(this.ConsultasBtnCancelarEdicion);
            this.ConsultasPnlEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasPnlEdicion.Location = new System.Drawing.Point(935, 0);
            this.ConsultasPnlEdicion.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasPnlEdicion.Name = "ConsultasPnlEdicion";
            this.ConsultasPnlEdicion.Size = new System.Drawing.Size(360, 44);
            this.ConsultasPnlEdicion.TabIndex = 2;
            this.ConsultasPnlEdicion.Visible = false;
            // 
            // ConsultasLblEdicion
            // 
            this.ConsultasLblEdicion.AutoSize = true;
            this.ConsultasLblEdicion.BackColor = System.Drawing.Color.Transparent;
            this.ConsultasLblEdicion.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ConsultasLblEdicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasLblEdicion.Location = new System.Drawing.Point(10, 13);
            this.ConsultasLblEdicion.Margin = new System.Windows.Forms.Padding(3);
            this.ConsultasLblEdicion.Name = "ConsultasLblEdicion";
            this.ConsultasLblEdicion.Size = new System.Drawing.Size(151, 19);
            this.ConsultasLblEdicion.TabIndex = 0;
            this.ConsultasLblEdicion.Text = "Editando la consulta";
            this.ConsultasLblEdicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConsultasBtnCancelarEdicion
            // 
            this.ConsultasBtnCancelarEdicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultasBtnCancelarEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            this.ConsultasBtnCancelarEdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnCancelarEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnCancelarEdicion.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnCancelarEdicion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ConsultasBtnCancelarEdicion.ForeColor = System.Drawing.Color.White;
            this.ConsultasBtnCancelarEdicion.Location = new System.Drawing.Point(189, 0);
            this.ConsultasBtnCancelarEdicion.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasBtnCancelarEdicion.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnCancelarEdicion.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnCancelarEdicion.Name = "ConsultasBtnCancelarEdicion";
            this.ConsultasBtnCancelarEdicion.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnCancelarEdicion.TabIndex = 1;
            this.ConsultasBtnCancelarEdicion.Text = "Cancelar edición";
            this.ConsultasBtnCancelarEdicion.UseVisualStyleBackColor = false;
            // 
            // ConsultasTlpLista
            // 
            this.ConsultasTlpLista.ColumnCount = 2;
            this.ConsultasTlpLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ConsultasTlpLista.Controls.Add(this.ConsultasDgvConsultasGuardadas, 0, 0);
            this.ConsultasTlpLista.Controls.Add(this.ConsultasFlpBotonesGuardadas, 1, 0);
            this.ConsultasTlpLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTlpLista.Location = new System.Drawing.Point(0, 44);
            this.ConsultasTlpLista.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasTlpLista.Name = "ConsultasTlpLista";
            this.ConsultasTlpLista.RowCount = 1;
            this.ConsultasTlpLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsultasTlpLista.Size = new System.Drawing.Size(1295, 153);
            this.ConsultasTlpLista.TabIndex = 1;
            // 
            // ConsultasDgvConsultasGuardadas
            // 
            this.ConsultasDgvConsultasGuardadas.AllowUserToAddRows = false;
            this.ConsultasDgvConsultasGuardadas.AllowUserToDeleteRows = false;
            this.ConsultasDgvConsultasGuardadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(242)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasGuardadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ConsultasDgvConsultasGuardadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultasDgvConsultasGuardadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ConsultasDgvConsultasGuardadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsultasDgvConsultasGuardadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ConsultasDgvConsultasGuardadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasGuardadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ConsultasDgvConsultasGuardadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultasDgvConsultasGuardadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultasColId,
            this.ConsultasColNombre,
            this.ConsultasColTabla,
            this.ConsultasColActualizada});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ConsultasDgvConsultasGuardadas.DefaultCellStyle = dataGridViewCellStyle7;
            this.ConsultasDgvConsultasGuardadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasDgvConsultasGuardadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsultasDgvConsultasGuardadas.EnableHeadersVisualStyles = false;
            this.ConsultasDgvConsultasGuardadas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConsultasDgvConsultasGuardadas.GridColor = System.Drawing.Color.LightGray;
            this.ConsultasDgvConsultasGuardadas.Location = new System.Drawing.Point(3, 4);
            this.ConsultasDgvConsultasGuardadas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasDgvConsultasGuardadas.MultiSelect = false;
            this.ConsultasDgvConsultasGuardadas.Name = "ConsultasDgvConsultasGuardadas";
            this.ConsultasDgvConsultasGuardadas.ReadOnly = true;
            this.ConsultasDgvConsultasGuardadas.RowHeadersVisible = false;
            this.ConsultasDgvConsultasGuardadas.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.ConsultasDgvConsultasGuardadas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ConsultasDgvConsultasGuardadas.RowTemplate.Height = 28;
            this.ConsultasDgvConsultasGuardadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultasDgvConsultasGuardadas.Size = new System.Drawing.Size(1189, 145);
            this.ConsultasDgvConsultasGuardadas.TabIndex = 0;
            // 
            // ConsultasColId
            // 
            this.ConsultasColId.FillWeight = 25F;
            this.ConsultasColId.HeaderText = "ID";
            this.ConsultasColId.MinimumWidth = 6;
            this.ConsultasColId.Name = "ConsultasColId";
            this.ConsultasColId.ReadOnly = true;
            // 
            // ConsultasColNombre
            // 
            this.ConsultasColNombre.HeaderText = "Nombre";
            this.ConsultasColNombre.MinimumWidth = 6;
            this.ConsultasColNombre.Name = "ConsultasColNombre";
            this.ConsultasColNombre.ReadOnly = true;
            // 
            // ConsultasColTabla
            // 
            this.ConsultasColTabla.FillWeight = 80F;
            this.ConsultasColTabla.HeaderText = "Tabla o vista";
            this.ConsultasColTabla.MinimumWidth = 6;
            this.ConsultasColTabla.Name = "ConsultasColTabla";
            this.ConsultasColTabla.ReadOnly = true;
            // 
            // ConsultasColActualizada
            // 
            this.ConsultasColActualizada.FillWeight = 55F;
            this.ConsultasColActualizada.HeaderText = "Actualizada";
            this.ConsultasColActualizada.MinimumWidth = 6;
            this.ConsultasColActualizada.Name = "ConsultasColActualizada";
            this.ConsultasColActualizada.ReadOnly = true;
            // 
            // ConsultasFlpBotonesGuardadas
            // 
            this.ConsultasFlpBotonesGuardadas.Controls.Add(this.ConsultasBtnModificar);
            this.ConsultasFlpBotonesGuardadas.Controls.Add(this.ConsultasBtnEliminarConsulta);
            this.ConsultasFlpBotonesGuardadas.Controls.Add(this.ConsultasBtnRefrescar);
            this.ConsultasFlpBotonesGuardadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasFlpBotonesGuardadas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ConsultasFlpBotonesGuardadas.Location = new System.Drawing.Point(1195, 0);
            this.ConsultasFlpBotonesGuardadas.Margin = new System.Windows.Forms.Padding(0);
            this.ConsultasFlpBotonesGuardadas.Name = "ConsultasFlpBotonesGuardadas";
            this.ConsultasFlpBotonesGuardadas.Size = new System.Drawing.Size(100, 153);
            this.ConsultasFlpBotonesGuardadas.TabIndex = 1;
            this.ConsultasFlpBotonesGuardadas.WrapContents = false;
            // 
            // ConsultasBtnModificar
            // 
            this.ConsultasBtnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(128)))), ((int)(((byte)(120)))));
            this.ConsultasBtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnModificar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ConsultasBtnModificar.ForeColor = System.Drawing.Color.White;
            this.ConsultasBtnModificar.Location = new System.Drawing.Point(6, 4);
            this.ConsultasBtnModificar.Margin = new System.Windows.Forms.Padding(6, 4, 3, 6);
            this.ConsultasBtnModificar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnModificar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnModificar.Name = "ConsultasBtnModificar";
            this.ConsultasBtnModificar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnModificar.TabIndex = 0;
            this.ConsultasBtnModificar.Text = "Modificar";
            this.ConsultasBtnModificar.UseVisualStyleBackColor = false;
            // 
            // ConsultasBtnEliminarConsulta
            // 
            this.ConsultasBtnEliminarConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnEliminarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ConsultasBtnEliminarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnEliminarConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnEliminarConsulta.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnEliminarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnEliminarConsulta.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ConsultasBtnEliminarConsulta.ForeColor = System.Drawing.Color.White;
            this.ConsultasBtnEliminarConsulta.Location = new System.Drawing.Point(6, 94);
            this.ConsultasBtnEliminarConsulta.Margin = new System.Windows.Forms.Padding(6, 4, 3, 6);
            this.ConsultasBtnEliminarConsulta.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminarConsulta.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminarConsulta.Name = "ConsultasBtnEliminarConsulta";
            this.ConsultasBtnEliminarConsulta.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnEliminarConsulta.TabIndex = 1;
            this.ConsultasBtnEliminarConsulta.Text = "Eliminar consulta";
            this.ConsultasBtnEliminarConsulta.UseVisualStyleBackColor = false;
            // 
            // ConsultasBtnRefrescar
            // 
            this.ConsultasBtnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsultasBtnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasBtnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConsultasBtnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultasBtnRefrescar.FlatAppearance.BorderSize = 0;
            this.ConsultasBtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultasBtnRefrescar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ConsultasBtnRefrescar.ForeColor = System.Drawing.Color.White;
            this.ConsultasBtnRefrescar.Location = new System.Drawing.Point(6, 184);
            this.ConsultasBtnRefrescar.Margin = new System.Windows.Forms.Padding(6, 4, 3, 6);
            this.ConsultasBtnRefrescar.MaximumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.MinimumSize = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.Name = "ConsultasBtnRefrescar";
            this.ConsultasBtnRefrescar.Size = new System.Drawing.Size(80, 80);
            this.ConsultasBtnRefrescar.TabIndex = 2;
            this.ConsultasBtnRefrescar.Text = "Refrescar";
            this.ConsultasBtnRefrescar.UseVisualStyleBackColor = false;
            // 
            // ConsultasTxtQuerySeleccionado
            // 
            this.ConsultasTxtQuerySeleccionado.BackColor = System.Drawing.Color.Gainsboro;
            this.ConsultasTxtQuerySeleccionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsultasTxtQuerySeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultasTxtQuerySeleccionado.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.ConsultasTxtQuerySeleccionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.ConsultasTxtQuerySeleccionado.Location = new System.Drawing.Point(3, 201);
            this.ConsultasTxtQuerySeleccionado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConsultasTxtQuerySeleccionado.Multiline = true;
            this.ConsultasTxtQuerySeleccionado.Name = "ConsultasTxtQuerySeleccionado";
            this.ConsultasTxtQuerySeleccionado.ReadOnly = true;
            this.ConsultasTxtQuerySeleccionado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsultasTxtQuerySeleccionado.Size = new System.Drawing.Size(1289, 62);
            this.ConsultasTxtQuerySeleccionado.TabIndex = 2;
            // 
            // FrmMantenimientoConsultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1307, 780);
            this.Controls.Add(this.ConsultasTlpPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMantenimientoConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4003 – MantenimientoConsultas";
            this.TopMost = true;
            this.ConsultasTlpPrincipal.ResumeLayout(false);
            this.ConsultasTlpFiltros.ResumeLayout(false);
            this.ConsultasFlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasFiltros)).EndInit();
            this.ConsultasGbxCondicionesLogicas.ResumeLayout(false);
            this.ConsultasTlpCondicionesLogicas.ResumeLayout(false);
            this.ConsultasTlpCondicionesLogicas.PerformLayout();
            this.ConsultasTlpOrdenamiento.ResumeLayout(false);
            this.ConsultasTlpOrdenamiento.PerformLayout();
            this.ConsultasGbxGuardarConsultas.ResumeLayout(false);
            this.ConsultasTlpGuardarConsulta.ResumeLayout(false);
            this.ConsultasTlpGuardarConsulta.PerformLayout();
            this.ConsultasGbxConsultasGuardadas.ResumeLayout(false);
            this.ConsultasTlpGuardadas.ResumeLayout(false);
            this.ConsultasTlpGuardadas.PerformLayout();
            this.ConsultasTlpBusqueda.ResumeLayout(false);
            this.ConsultasTlpBusqueda.PerformLayout();
            this.ConsultasPnlEdicion.ResumeLayout(false);
            this.ConsultasPnlEdicion.PerformLayout();
            this.ConsultasTlpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultasDgvConsultasGuardadas)).EndInit();
            this.ConsultasFlpBotonesGuardadas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpPrincipal;
        private Componentes.ClsGrupoConsultas ConsultasGbxCondicionesLogicas;
        private Componentes.ClsGrupoConsultas ConsultasGbxGuardarConsultas;
        private Componentes.ClsCajaTextoConsultas ConsultasTxtNombre;
        private Componentes.ClsBotonConsultas ConsultasBtnGuardar;
        private Componentes.ClsEtiquetaConsultas ConsultasLblNombre;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpGuardarConsulta;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpCondicionesLogicas;
        private Componentes.ClsBotonConsultas ConsultasBtnIngresar;
        private Componentes.ClsEtiquetaConsultas ConsultasLblOrdenamiento;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpOrdenamiento;
        private Componentes.ClsBotonRadioConsultas ConsultasRdoDescendente;
        private Componentes.ClsBotonRadioConsultas ConsultasRdoAscendente;
        private Componentes.ClsEtiquetaConsultas ConsultasLblCampo;
        private Componentes.ClsListaComboBoxConsultas ConsultasCboOperadorCampo;
        private Componentes.ClsEtiquetaConsultas ConsultasLblOperador;
        private Componentes.ClsListaComboBoxConsultas ConsultasCboOperador;
        private Componentes.ClsEtiquetaConsultas ConsultasLblValor;
        private Componentes.ClsCajaTextoConsultas ConsultasTxtValor;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpFiltros;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotones;
        private Componentes.ClsBotonConsultas ConsultasBtnEliminar;
        private Componentes.ClsTablaDatosConsultas ConsultasDgvConsultasFiltros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColOperador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColOrdenamiento;
        private Componentes.ClsGrupoConsultas ConsultasGbxConsultasGuardadas;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpGuardadas;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpBusqueda;
        private Componentes.ClsCajaTextoConsultas ConsultasTxtBuscar;
        private Componentes.ClsListaComboBoxConsultas ConsultasCboTablaFiltro;
        private System.Windows.Forms.Panel ConsultasPnlEdicion;
        private Componentes.ClsEtiquetaConsultas ConsultasLblEdicion;
        private Componentes.ClsBotonConsultas ConsultasBtnCancelarEdicion;
        private System.Windows.Forms.TableLayoutPanel ConsultasTlpLista;
        private Componentes.ClsTablaDatosConsultas ConsultasDgvConsultasGuardadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultasColActualizada;
        private System.Windows.Forms.FlowLayoutPanel ConsultasFlpBotonesGuardadas;
        private Componentes.ClsBotonConsultas ConsultasBtnModificar;
        private Componentes.ClsBotonConsultas ConsultasBtnEliminarConsulta;
        private Componentes.ClsBotonConsultas ConsultasBtnRefrescar;
        private Componentes.ClsCajaTextoConsultas ConsultasTxtQuerySeleccionado;
    }
}