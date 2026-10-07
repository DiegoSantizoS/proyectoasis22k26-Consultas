using System;
using System.IO;
using System.Collections.Generic;
using CapaControlador_Consultas;
using System.Windows.Forms;

namespace CapaVista_Consultas
{
    internal static class ClsInteraccionConsultas
    {
        private static readonly HashSet<Control> _Operaciones = new HashSet<Control>();

        internal static void ConsultasProcEjecutar(Control Vista, Action Accion)
        {
            if (!_Operaciones.Add(Vista))
            {
                return;
            }
            bool Habilitada = Vista.Enabled;
            Cursor CursorAnterior = Vista.Cursor;
            if (Habilitada)
            {
                Vista.Enabled = false;
            }
            try
            {
                Accion();
            }
            catch (ClsErrorValidacion Excepcion)
            {
                if (Vista is IEstadoVistaConsultas) ((IEstadoVistaConsultas)Vista).ConsultasProcMostrarError(Excepcion);
                else MessageBox.Show(Vista, Excepcion.Message, "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show(Vista, Excepcion.Message, "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Vista.Cursor = CursorAnterior;
                if (Habilitada)
                {
                    Vista.Enabled = true;
                }
                _Operaciones.Remove(Vista);
                (Vista as IEstadoVistaConsultas)?.ConsultasProcActualizarEstado();
            }
        }

        internal static void ConsultasProcAyuda(Control Vista)
        {
            DirectoryInfo Directorio = new DirectoryInfo(Application.StartupPath);
            while (Directorio != null)
            {
                string Ruta = Path.Combine(Directorio.FullName, "ayuda", "componentes", "consultas", "Ayuda_Consultas.chm");
                if (File.Exists(Ruta))
                {
                    Help.ShowHelp(Vista, Ruta);
                    return;
                }
                Directorio = Directorio.Parent;
            }
            MessageBox.Show(Vista, "No se encontró el archivo de ayuda.", "Consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
