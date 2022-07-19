using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SCG.SyncBCCR.ConfigurationHost
{
    /// <summary>
    /// Ofrece un servicio para grabar en un archivo txt los errores ocurridos en la aplicación
    /// </summary>
    public class ErrorLog
    {
        /// <summary>
        /// Escribe el detalle del error en un archivo txt
        /// </summary>
        /// <param name="ex">Exception que contiene el detalle del error</param>
        public static void WriteError(Exception ex)
        {
            try
            {
                string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\ErrorLog.txt";

                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine("Source:       " + ex.Source.ToString().Trim());
                    sw.WriteLine("Method:       " + ex.TargetSite.Name.ToString());
                    sw.WriteLine("Date:         " + DateTime.Now.ToShortDateString());
                    sw.WriteLine("Time:         " + DateTime.Now.ToLongTimeString());
                    sw.WriteLine("Computer:     " + System.Environment.MachineName);
                    sw.WriteLine("Error:        " + ex.Message.ToString().Trim());
                    sw.WriteLine("Stack Trace:  " + ex.StackTrace.ToString().Trim());
                    sw.WriteLine();
                }
            }
            catch (Exception e)
            {
                Message.Error("No fue posible escribir en el log. Causa: " + e.Message);
            }
        }
    }
}
