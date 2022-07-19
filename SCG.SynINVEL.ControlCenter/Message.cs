//Autor: Werner Flores
//Fecha: 22/04/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCG.SyncBCCR.ConfigurationHost
{
    /// <summary>
    /// Ofrece varios métodos para estandarizar los mensajes que deplegará la aplicación
    /// </summary>
    public class Message
    {

        private const string APP_NAME = "SCG SYNC BCCR EXCHANGE RATE";

        /// <summary>
        /// Muestra un mensaje de operación exitosa
        /// </summary>
        public static void SuccessfulOperation()
        {
            MessageBox.Show("Operación finalizada con éxito.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Muestra un mensaje de información
        /// </summary>
        /// <param name="msg">Mensaje a mostrar</param>
        public static void Show(string msg)
        {
            MessageBox.Show(msg, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Muestra un mensaje de error
        /// </summary>
        /// <param name="msg">Mensaje a mostrar</param>
        public static void Error(string msg)
        {
            MessageBox.Show(msg, APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de pregunta
        /// </summary>
        /// <param name="msg">Pregunta a mostrar</param>
        /// <returns>Si o no según la elección del usuario</returns>
        public static DialogResult Question(string msg)
        {
            return MessageBox.Show(msg, APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

    }
}
