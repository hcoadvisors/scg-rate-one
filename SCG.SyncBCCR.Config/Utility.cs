//Autor: Werner Flores
//Fecha: 22/04/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using SAPbobsCOM;

namespace SCG.SyncBCCR.Config
{
    /// <summary>
    /// Ofrece funciones reutilizables para toda la solución
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Obtiene la ruta del archivo xml de configuración
        /// </summary>
        /// <returns>Ruta del archivo xml de configuración</returns>
        public static string GetConfigFilePath()
        {

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

            path = path.Replace(@"file:\", "");

            string configFile = Path.Combine(path, "Settings.xml");

            return configFile;
        }

        /// <summary>
        /// Obtiene una fila con los datos de conexión según el código de conexión especificado
        /// </summary>
        /// <param name="code">Código de configuración</param>
        /// <returns>Objeto Datarow con los parámetros de conexión</returns>
        public static Settings.ConnectionCompanyRow GetConnectionConfig(string code)
        {

            Settings dsConfig = new Settings();
            Settings.ConnectionCompanyRow drConfig = null;

            string configPath = GetConfigFilePath();

            if (File.Exists(configPath))
            {
                dsConfig.ReadXml(configPath);
                drConfig = dsConfig.ConnectionCompany.FindByCode(int.Parse (code));
            }

            return drConfig;
        }

        public static Settings.ExchangeRateTypesDataTable GetExchangeTypeConfig()
        {

            Settings dsConfig = new Settings();
            //Settings.ExchangeRateTypes drConfig = null ;
           // Settings.ExchangeRateTypesDataTable  dtExchangeRates = null; 

            string configPath = GetConfigFilePath();

            if (File.Exists(configPath))
            {
                dsConfig.ReadXml(configPath);

                
            }

            return dsConfig .ExchangeRateTypes ;
        }

     
       

        public static int GetCount()
        {

            Settings dsConfig = new Settings();

            int cont = 0;

            string configPath = GetConfigFilePath();

            if (File.Exists(configPath))
            {
               
                dsConfig.ReadXml(configPath);
                cont = dsConfig.ConnectionCompany.Count();

            }

            return cont;
        }

        /// <summary>
        /// Obtiene una colección con los tipos de servidores soportados por el DI API
        /// </summary>
        /// <returns>Colección con los tipo de servidores soportados por el DI API</returns>
        public static List<DIOption> GetDiApiDbServerTypes()
        {

            List<DIOption> dbServerTypes = new List<DIOption>();

            dbServerTypes.Add(new DIOption { Code = "", Name = "" });
            dbServerTypes.Add(new DIOption { Code = "1", Name = "MSSQL" });
            dbServerTypes.Add(new DIOption { Code = "4", Name = "MSSQL2005" });
            dbServerTypes.Add(new DIOption { Code = "6", Name = "MSSQL2008" });
            dbServerTypes.Add(new DIOption { Code = "7", Name = "MSSQL2012" });
            dbServerTypes.Add(new DIOption { Code = "8", Name = "MSSQL2014" });
            dbServerTypes.Add(new DIOption { Code = "9", Name = "HANADB" });
            dbServerTypes.Add(new DIOption { Code = "10", Name = "MSSQL2016" });
            dbServerTypes.Add(new DIOption { Code = "11", Name = "MSSQL2017" });
            dbServerTypes.Add(new DIOption { Code = "15", Name = "MSSQL2019" });

            return dbServerTypes;
        }

        /// <summary>
        /// Obtiene una colección con los tipos de cambio existentes
        /// </summary>
        /// <returns>Colección con los tipos de cambio existentes</returns>
        public static List<ExchangeRateTypeOption> GetExchangeRateTypes()
        {

            List<ExchangeRateTypeOption> ExchangeRateTypes = new List<ExchangeRateTypeOption>();

            ExchangeRateTypes.Add(new ExchangeRateTypeOption { Code = "0", Name = "Compra" });
            ExchangeRateTypes.Add(new ExchangeRateTypeOption { Code = "1", Name = "Venta" });

            return ExchangeRateTypes;
        }

        public static List<DIOption> GetLocations()
        {

            List<DIOption> LocationTypes = new List<DIOption>();

            LocationTypes.Add(new DIOption { Code = "CR", Name = "Costa Rica" });
            LocationTypes.Add(new DIOption { Code = "CL", Name = "Chile" });
            LocationTypes.Add(new DIOption { Code = "CO", Name = "Colombia" });
            LocationTypes.Add(new DIOption { Code = "GT", Name = "Guatemala" });

            return LocationTypes;
        }


        /// <summary>
        /// Obtiene una colección con los tipos de idiomas soportados por el DI API
        /// </summary>
        /// <returns>Coleccion con los tipos de idiomas soportados por el DI API</returns>
        public static List<DIOption> GetDiApiLanguages()
        {
            List<DIOption> languages = new List<DIOption>();

            languages = new List<DIOption>();
            languages.Add(new DIOption { Code = "", Name = "" });
            languages.Add(new DIOption { Code = "3", Name = "Inglés" });
            languages.Add(new DIOption { Code = "25", Name = "Español" });

            return languages;
        }

        /// <summary>
        /// Crea un objeto company y establece los parámetros de conexión
        /// </summary>
        /// <param name="server">Nombre del servidor de base de datos</param>
        /// <param name="companyDb">Nombre de la base de datos de Sap</param>
        /// <param name="dbServerType">Tipo de servidor de base de datos</param>
        /// <param name="useTrusted">Indica si utiliza autenticación de Windows</param>
        /// <param name="dbUserName">Usuario de base de datos</param>
        /// <param name="dbPassword">Contraseña del usuario de base de datos</param>
        /// <param name="userName">Usuario de Sap</param>
        /// <param name="password">Contraseña de Sap</param>
        /// <param name="licenseServer">Servidor de licencias</param>
        /// <param name="language">Idioma en que el DI API debe retornar los mensajes de error</param>
        /// <returns>Objeto company instanciado</returns>
        public static Company CreateDiConnection(string server,
                                                 string companyDb,
                                                 string dbServerType,
                                                 bool useTrusted,
                                                 string dbUserName,
                                                 string dbPassword,
                                                 string userName,
                                                 string password,
                                                 string licenseServer,
                                                 int  language)
        {
            BoSuppLangs lenguaje = (BoSuppLangs)language;
            Company company = new Company();

            company.Server = server;
            company.CompanyDB = companyDb;
            switch (dbServerType)
            {
                case "1":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL;
                    break;
                case "4":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2005;
                    break;
                case "6":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2008;
                    break;
                case "7":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2012;
                    break;
                case "8":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2014;
                    break;
                case "9":
                    company.DbServerType = (BoDataServerTypes) 9;
                    break;
                case "10":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2016;
                    break;
                case "11":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2017;
                    break;
                case "15":
                    company.DbServerType = BoDataServerTypes.dst_MSSQL2019;
                    break;

            }           

            //company.UseTrusted = useTrusted;
            //company.DbUserName = dbUserName;
            //company.DbPassword = dbPassword;
            company.UserName = userName;
            company.Password = password;
            //company.LicenseServer = licenseServer;
            //company.language = language;

            return company;
        }

        /// <summary>
        /// Crea un objeto company y establece los parámetros de conexión
        /// </summary>
        /// <param name="connectionConfigRow">Fila que contiene los parámetros de conexión</param>
        /// <returns>Objeto company instanciado</returns>
        public static void  CreateDiConnection(Settings.ConnectionCompanyRow connectionConfigRow, ref SAPbobsCOM.Company oCompany)
        {
            //SAPbobsCOM.Company company = new SAPbobsCOM .Company ();

            oCompany.Server = connectionConfigRow.Server;
            oCompany.CompanyDB = connectionConfigRow.CompanyDB;
            oCompany.DbServerType = (BoDataServerTypes)Convert.ToInt16(connectionConfigRow.DbServerType);
            oCompany.UserName = connectionConfigRow.UserName;
            oCompany.Password = connectionConfigRow.Password;
            

           // return oCompany;

        }

    }
}
