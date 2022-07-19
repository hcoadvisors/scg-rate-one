//Autor: Werner Flores
//Fecha: 21/04/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCG.SyncBCCR.Config
{
    /// <summary>
    /// Clase para representar un tipo de opción utilizado por el objeto Company del DI API
    /// </summary>
    public class DIOption
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}