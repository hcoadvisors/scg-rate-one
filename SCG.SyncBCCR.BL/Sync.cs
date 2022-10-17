using System;
using System.Linq;
using SAPbobsCOM;
using SCG.SyncBCCR.Config;
using System.Data;
using System.Net;
using System.IO;
using System.Reflection;
using System.Globalization;
using SCG.Cifrado;
using Nager.Date;
using SCG.SyncBCCR.BL.WebServiceTRMReference;
using SCG.SyncBCCR.BL.WebServiceGUATReference;


namespace SCG.SyncBCCR.BL
{


    public class Sync
    {

        #region Declaraciones
        private const string LLAVE = "28AF0447C8C24547892C3EA083098FF0";
        private const string VECTOR = "C91F7F3B36564ac2BCC53B10";
        //   int countDebug = 0;
        //    private EventLog _log;
        #endregion


        public void ConsultarTipoCambioMoneda(String CompraVenta, String appTipoMoneda, String appSiglas,
                                              SAPbobsCOM.Company appCompany, String Codigo)
        {
            try
            {
                Double CompraMoneda = 0;
                Double VentaMoneda = 0;
                string Fecha = string.Empty;
                System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                Fecha = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();

                cr.fi.bccr.gee.wsindicadoreseconomicos x = new cr.fi.bccr.gee.wsindicadoreseconomicos();

                DataSet tipoCompraDolar = x.ObtenerIndicadoresEconomicos("317", Fecha, Fecha, "SCG", "N", "webapprovalservice@gmail.com", "ER75S0GACE");
                Double compraDolar = Convert.ToDouble((from row in tipoCompraDolar.Tables[0].AsEnumerable()
                                                       select row.ItemArray[2]).FirstOrDefault());

                DataSet tipoVentaDolar = x.ObtenerIndicadoresEconomicos("318", Fecha, Fecha, "SCG", "N", "webapprovalservice@gmail.com", "ER75S0GACE");
                Double ventaDolar = Convert.ToDouble(tipoVentaDolar.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault());

                //var fecha = tipoVentaDolar.Tables[0].AsEnumerable().Select(row => row.ItemArray[1]).FirstOrDefault();

                if (Codigo != "0" && Codigo != "326")
                {
                    var PorcentajeMoneda = x.ObtenerIndicadoresEconomicos(Codigo, Fecha, Fecha, "SCG", "N", "webapprovalservice@gmail.com", "ER75S0GACE");
                    if (PorcentajeMoneda.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault() != null)
                    {
                        CompraMoneda = Convert.ToDouble((PorcentajeMoneda.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault())) * compraDolar;
                        VentaMoneda = Convert.ToDouble((PorcentajeMoneda.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault())) * ventaDolar;
                    }
                }

                //Compatibilidad con Franco Suizo
                if (Codigo == "326")
                {
                    var PorcentajeMoneda = x.ObtenerIndicadoresEconomicos(Codigo, Fecha, Fecha, "SCG", "N", "webapprovalservice@gmail.com", "ER75S0GACE");
                    if (PorcentajeMoneda.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault() != null)
                    {
                        CompraMoneda = compraDolar * (1 / Convert.ToDouble((PorcentajeMoneda.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault())));
                        VentaMoneda = ventaDolar * (1 / Convert.ToDouble((PorcentajeMoneda.Tables[0].AsEnumerable().Select(row => row.ItemArray[2]).FirstOrDefault())));
                    }

                }

                if (CompraVenta == "1") //Si es VENTA
                {
                    if (Codigo == "0") //Si la moneda SON dólares américanos
                        IngresarTipoCambioMoneda(appTipoMoneda, ventaDolar, appCompany, Convert.ToDateTime(System.DateTime.Now.ToShortDateString()));
                    else //Si la moneda NO SON dólares américanos
                        IngresarTipoCambioMoneda(appTipoMoneda, VentaMoneda, appCompany, Convert.ToDateTime(System.DateTime.Now.ToShortDateString()));
                }
                else //Si es COMPRA 
                {
                    if (Codigo == "0") //Si la moneda SON dólares américanos
                        IngresarTipoCambioMoneda(appTipoMoneda, compraDolar, appCompany, Convert.ToDateTime(System.DateTime.Now.ToShortDateString()));
                    else //Si la moneda NO SON dólares américanos
                        IngresarTipoCambioMoneda(appTipoMoneda, CompraMoneda, appCompany, Convert.ToDateTime(System.DateTime.Now.ToShortDateString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private NumberFormatInfo GetNumberFormatInfo(SAPbobsCOM.Company appCompan)
        {

            SAPbobsCOM.CompanyService companyService = appCompan.GetCompanyService();
            SAPbobsCOM.AdminInfo adminInfo = companyService.GetAdminInfo();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.CurrencyDecimalSeparator = adminInfo.DecimalSeparator;
            numberFormatInfo.CurrencyGroupSeparator = adminInfo.ThousandsSeparator;
            numberFormatInfo.CurrencyDecimalDigits = adminInfo.PriceAccuracy;
            numberFormatInfo.NumberDecimalDigits = adminInfo.AccuracyofQuantities;

            if (companyService != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(companyService);
            }
            if (adminInfo != null)
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(adminInfo);
            }
            return numberFormatInfo;


        }



        private bool ValidarTipoCambio(string p_TipoCambio, SAPbobsCOM.Company appCompany)
        {
            SAPbobsCOM.SBObob oSBObob;//objeto de SAP para consultar tipo de cmabio
            SAPbobsCOM.Recordset oRecordSet;//Recordset para efectuar conversiones
            NumberFormatInfo numberFormatInfo = GetNumberFormatInfo(appCompany);
            decimal TipoCambio = 0;
            DateTime sToday = DateTime.Now;
            //Se inicializan los objetos
            oSBObob = (SAPbobsCOM.SBObob)appCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);
            oRecordSet = (SAPbobsCOM.Recordset)appCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

            try
            {

                oRecordSet = oSBObob.GetCurrencyRate(p_TipoCambio, sToday);
                TipoCambio = Convert.ToDecimal(oRecordSet.Fields.Item(0).Value.ToString(), numberFormatInfo);


                if (TipoCambio != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //Libera los recursos usados por el DI API
                if (oSBObob != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oSBObob);
                    oSBObob = null;
                }
                if (oRecordSet != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecordSet);
                    oRecordSet = null;
                }

            }



        }

        public void ConsultarTipoCambioChile(String appTipoMoneda, SAPbobsCOM.Company appCompany, String Codigo, String WSUser, String WSPass, string horamax)
        {
            NumberFormatInfo numberFormatInfo = GetNumberFormatInfo(appCompany);
            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            //numberFormatInfo.NumberDecimalSeparator = ",";
            //numberFormatInfo.CurrencyGroupSeparator = ".";

            try
            {

                Double ValorTC = 0;
                string Fecha = string.Empty;//variable para formato de la fecha
                DateTime FechaSAP;
                string[] serie = new string[1];//Serie a consultar para el tipo de cambio
                string formato = string.Empty;
                serie[0] = Codigo;
                DateTime HoraMT;
                if (!string.IsNullOrEmpty(horamax))
                {
                    HoraMT = Convert.ToDateTime(horamax);

                }
                else
                {
                    HoraMT = Convert.ToDateTime("08:00");

                }
                DateTime FechaN = DateTime.Now;
                FechaSAP = FechaN;

                System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                //Instanacia el WS del banco de chile
                cl.bcentral.si3.SieteWS WSChile = new cl.bcentral.si3.SieteWS();
                //Consulta el WebService para obtener el tipo de cambio
                if (DateSystem.IsWeekend(FechaN, CountryCode.CL))
                {

                    while (DateSystem.IsWeekend(FechaN, CountryCode.CL))
                    {

                        FechaN = FechaN.AddDays(-1);


                    }
                    Fecha = FechaN.ToString("yyyy-MM-dd");
                    cl.bcentral.si3.Respuesta TipoCambio = WSChile.GetSeries(WSUser, WSPass, Fecha, Fecha, serie);
                    if (TipoCambio.Series[0].obs != null)
                    {
                        formato = TipoCambio.Series[0].obs[0].value.ToString();
                        //formato = formato.Replace(".", "");
                        //formato = formato.Replace(",", ".");
                        ValorTC = double.Parse(formato, numberFormatInfo);
                        IngresarTipoCambioMoneda(appTipoMoneda, ValorTC, appCompany, Convert.ToDateTime(FechaSAP.ToShortDateString()));
                    }
                    else
                    {
                        while (TipoCambio.Series[0].obs == null)
                        {
                            FechaN = FechaN.AddDays(-1);
                            Fecha = FechaN.ToString("yyyy-MM-dd");
                            TipoCambio = WSChile.GetSeries(WSUser, WSPass, Fecha, Fecha, serie);
                        }
                        if (TipoCambio.Series[0].obs != null)
                        {
                            formato = TipoCambio.Series[0].obs[0].value.ToString();
                            //formato = formato.Replace(".", "");
                            //formato = formato.Replace(",", ".");
                            ValorTC = double.Parse(formato, numberFormatInfo);
                            IngresarTipoCambioMoneda(appTipoMoneda, ValorTC, appCompany, Convert.ToDateTime(FechaSAP.ToShortDateString()));
                        }

                    }

                }
                else
                {
                    Fecha = FechaN.ToString("yyyy-MM-dd");
                    cl.bcentral.si3.Respuesta TipoCambio = WSChile.GetSeries(WSUser, WSPass, Fecha, Fecha, serie);
                    if (TipoCambio.Series[0].obs != null)
                    {
                        formato = TipoCambio.Series[0].obs[0].value.ToString();
                        //formato = formato.Replace(".", "");
                        //formato = formato.Replace(",", ".");
                        ValorTC = double.Parse(formato, numberFormatInfo);
                        IngresarTipoCambioMoneda(appTipoMoneda, ValorTC, appCompany, Convert.ToDateTime(FechaSAP.ToShortDateString()));
                    }
                    else
                    {
                        if (FechaSAP > HoraMT)
                        {
                            while (TipoCambio.Series[0].obs == null)
                            {
                                FechaN = FechaN.AddDays(-1);
                                Fecha = FechaN.ToString("yyyy-MM-dd");
                                TipoCambio = WSChile.GetSeries(WSUser, WSPass, Fecha, Fecha, serie);
                            }
                            if (TipoCambio.Series[0].obs != null)
                            {
                                formato = TipoCambio.Series[0].obs[0].value.ToString();
                                //formato = formato.Replace(".", "");
                                //formato = formato.Replace(",", ".");
                                ValorTC = double.Parse(formato, numberFormatInfo);
                                IngresarTipoCambioMoneda(appTipoMoneda, ValorTC, appCompany, Convert.ToDateTime(FechaSAP.ToShortDateString()));
                                Debuguer("Se Actualizó el tipo de cambio para moneda " + appTipoMoneda.ToString() + " por Tiempo Maxímo de Tolerancia");
                            }

                        }
                        //Debuguer("No se Actualizó el tipo de cambio para moneda " + appTipoMoneda.ToString() + " debido a que el WebService no tiene tipo de cambio para la fecha: " + Fecha);
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ConsultarTipoCambioMonedaCO(String appTipoMoneda, SAPbobsCOM.Company appCompany)
        {
            NumberFormatInfo numberFormatInfo = GetNumberFormatInfo(appCompany);
            try
            {
                string Fecha = string.Empty;
                DateTime FechaSAP;
                DateTime FechaN = DateTime.Now;
                FechaSAP = FechaN;

                Fecha = DateTime.Now.ToString("yyyy-MM-dd");

                WebServiceTRMReference.TCRMServicesWebService client = new WebServiceTRMReference.TCRMServicesWebService();
                WebServiceTRMReference.tcrmResponse response;

                response = client.queryTCRM(Fecha);
                double tipocambio = 0;

                //tipocambio = response.value;

                tipocambio = Convert.ToDouble(response.value, numberFormatInfo);

                IngresarTipoCambioMoneda("USD", tipocambio, appCompany, Convert.ToDateTime(FechaSAP.ToShortDateString()));

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void ConsultarTipoCamioMonedaGT(String appTipoMoneda, SAPbobsCOM.Company appCompany)
        {
            NumberFormatInfo numberFormatInfo = GetNumberFormatInfo(appCompany);
            try
            {

                string Fecha = string.Empty;
                DateTime FechaSAP;
                Fecha = System.DateTime.Now.Day.ToString() + "/" + System.DateTime.Now.Month.ToString() + "/" + System.DateTime.Now.Year.ToString();
                DateTime FechaN = DateTime.Now;
                FechaSAP = FechaN;

                WebServiceGUATReference.TipoCambio clientGuat = new WebServiceGUATReference.TipoCambio();
                WebServiceGUATReference.InfoVariable responseguat = new WebServiceGUATReference.InfoVariable();

                double tipocambio = 0;

                responseguat = clientGuat.TipoCambioDia();
                if (responseguat.TotalItems != 0)
                {
                    tipocambio = Convert.ToDouble(responseguat.CambioDolar[0].referencia, numberFormatInfo);
                    IngresarTipoCambioMoneda("USD", tipocambio, appCompany, Convert.ToDateTime(FechaSAP.ToShortDateString()));

                }
                else
                {
                    Debuguer("No se encontró tipo de cambio para el dia de hoy, se intentará obtenerlo nuevamente");
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        //public void ConsultarTipoCambioChile(String appTipoMoneda,SAPbobsCOM.Company appCompany, String Codigo, String Apikey, String appSumarX)
        //{
        //    try
        //    {
        //        NumberFormatInfo numberFormatInfo = GetNumberFormatInfo(appCompany);
        //        string Url = "";
        //        string ValorF = "";
        //        double TCmoneda = 0;
        //        dynamic JMoneda;
        //        DateTime Fecha;
        //        WebClient PostWS = new WebClient();
        //        //Arma el string de consulta de moneda según el parametro que se le envie
        //        switch (Codigo)
        //        {
        //            case "0":
        //                {

        //                    Url = "https://api.sbif.cl/api-sbifv3/recursos_api/dolar?apikey=" + Apikey + "&formato=json";

        //                    var Json = PostWS.DownloadString(Url);
        //                    JMoneda = JsonConvert.DeserializeObject(Json);
        //                    ValorF= JMoneda["Dolares"][0].Valor;
        //                    if (!string.IsNullOrEmpty(ValorF))
        //                    {
        //                        ValorF = ValorF.Replace(".", "");
        //                        ValorF = ValorF.Replace(",", ".");
        //                        TCmoneda = double.Parse(ValorF, numberFormatInfo);
        //                        Fecha = Convert.ToDateTime(JMoneda["Dolares"][0].Fecha);
        //                        if (TCmoneda != 0)
        //                        {
        //                        IngresarTipoCambioMoneda(appTipoMoneda.Trim(), TCmoneda, appCompany, appSumarX, Fecha);
        //                        }
        //                    }
        //                        break;
        //                }
        //            case "1":
        //                {
        //                    Url = "https://api.sbif.cl/api-sbifv3/recursos_api/euro?apikey=" + Apikey + "&formato=json";
        //                    var Json = PostWS.DownloadString(Url);
        //                    JMoneda = JsonConvert.DeserializeObject(Json);
        //                    ValorF = JMoneda["Euros"][0].Valor;
        //                    if (!string.IsNullOrEmpty(ValorF))
        //                    {
        //                        ValorF = ValorF.Replace(".", "");
        //                        ValorF = ValorF.Replace(",", ".");
        //                        TCmoneda = double.Parse(ValorF, numberFormatInfo);
        //                        Fecha = Convert.ToDateTime(JMoneda["Euros"][0].Fecha);
        //                        if (TCmoneda != 0)
        //                        {
        //                            IngresarTipoCambioMoneda(appTipoMoneda.Trim(), TCmoneda, appCompany, appSumarX, Fecha);
        //                        }
        //                    }
        //                    break;                            
        //                }
        //            case "2":
        //                {
        //                    Url = "https://api.sbif.cl/api-sbifv3/recursos_api/uf?apikey=" + Apikey + "&formato=json";
        //                    var Json = PostWS.DownloadString(Url);
        //                    JMoneda = JsonConvert.DeserializeObject(Json);
        //                    ValorF = JMoneda["UFs"][0].Valor;
        //                    if (!string.IsNullOrEmpty(ValorF))
        //                    {
        //                        ValorF = ValorF.Replace(".", "");
        //                        ValorF = ValorF.Replace(",", ".");
        //                        TCmoneda = double.Parse(ValorF, numberFormatInfo);
        //                        Fecha = Convert.ToDateTime(JMoneda["UFs"][0].Fecha);
        //                        if (TCmoneda != 0)
        //                        {
        //                            IngresarTipoCambioMoneda(appTipoMoneda.Trim(), TCmoneda, appCompany, appSumarX, Fecha);
        //                        }
        //                    }
        //                    break;

        //                }

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        public void IngresarTipoCambioMoneda(String Moneda, Double Value, SAPbobsCOM.Company oCompany, DateTime sToday)
        {
            SAPbobsCOM.SBObob oSBObob;
            oSBObob = (SAPbobsCOM.SBObob)oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge);

            try
            {
                double valor = Value;

                if (sToday == null)
                {
                    sToday = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                }

                //valor = valor + Convert.ToDouble(SumarX);
                if (valor > 0)
                {
                    oSBObob.SetCurrencyRate(Moneda, sToday, valor, true);
                }
                //return valor.ToString();
                //Se agrego linea para mantenimiento y para liberar recursos


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (oSBObob != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(oSBObob);
                    oSBObob = null;
                }

            }

        }
        private void Debuguer(string msj)//metodo de debugueo solo pruebas
        {
            StreamWriter sw;
            try
            {
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

                path = path.Replace(@"file:\", "");

                string logFile = Path.Combine(path, "Debuger.txt");

                using (sw = new StreamWriter(logFile, true))
                {
                    sw.WriteLine(msj + "            : ");
                    //  sw.WriteLine();
                    sw.Close();



                }
            }
            catch (Exception)
            {

            }
            finally
            {
                sw = null;

            }
        }

        public void SyncExchangeRate()
        {

            SAPbobsCOM.Company oCompany = null;

            try
            {
                for (int i = 1; i <= Utility.GetCount(); i++)
                {
                    Settings.ConnectionCompanyRow connectionConfigRow = null;
                    Settings.ExchangeRateTypesDataTable drtest = null;

                    connectionConfigRow = Utility.GetConnectionConfig(i.ToString().Trim());

                    oCompany = new SAPbobsCOM.Company();
                    oCompany.Server = connectionConfigRow.Server;
                    oCompany.CompanyDB = connectionConfigRow.CompanyDB;
                    oCompany.DbServerType = (BoDataServerTypes)Convert.ToInt16(connectionConfigRow.DbServerType);
                    oCompany.UserName = connectionConfigRow.UserName;
                    oCompany.Password = Cifra.DesEncripta(connectionConfigRow.Password, LLAVE, VECTOR);

                    //Utility.CreateDiConnection(connectionConfigRow, ref oCompany);


                    int result = oCompany.Connect();
                    if (result != 0)
                    {

                        throw new Exception(oCompany.GetLastErrorDescription() + oCompany.CompanyDB);
                    }
                    else
                    {

                        drtest = Utility.GetExchangeTypeConfig();
                        //Validar Costa Rica o Chile
                        foreach (DataRow row in drtest.Rows)
                        {

                            if (int.Parse(row["company"].ToString()) == connectionConfigRow.Code)
                            {
                                //Valida la localizacion para utilizar los metodos de Costa Rica o Chile
                                if (connectionConfigRow.Localizacion.Equals("CR"))
                                {
                                    ConsultarTipoCambioMoneda(row["Type"].ToString(), row["Code"].ToString(), row["Code"].ToString(), oCompany, row["BCCRCode"].ToString());
                                }
                                else if (connectionConfigRow.Localizacion.Equals("CL"))
                                {
                                    if (!ValidarTipoCambio(row["Code"].ToString(), oCompany))
                                    {
                                        Debuguer("No se encontro Tipo de cambio se procede a Actualizar");
                                        ConsultarTipoCambioChile(row["Code"].ToString(), oCompany, row["BCCRCode"].ToString(), connectionConfigRow.WSUsername, connectionConfigRow.WSPassword, connectionConfigRow.MaxTime);
                                        Debuguer("Se Actualizó el tipo de cambio: " + row["Code"].ToString() + " Correctamente");
                                    }
                                    else
                                    {
                                        Debuguer("El tipo de cambio: " + row["Code"].ToString() + " ya esta actualizado (no se va actualizar) ");
                                    }
                                }
                                else if (connectionConfigRow.Localizacion.Equals("CO"))
                                {
                                    //ConsultarTipoCambioMonedaCO(row["Code"].ToString(), oCompany);

                                    if (!ValidarTipoCambio(row["Code"].ToString(), oCompany))
                                    {
                                        Debuguer("No se encontro Tipo de cambio se procede a Actualizar");
                                        ConsultarTipoCambioMonedaCO(row["Code"].ToString(), oCompany);
                                        Debuguer("Se Actualizó el tipo de cambio: " + row["Code"].ToString() + " Correctamente");
                                    }
                                    else
                                    {
                                        Debuguer("El tipo de cambio: " + row["Code"].ToString() + " ya esta actualizado (no se va actualizar) ");
                                    }
                                }
                                else if (connectionConfigRow.Localizacion.Equals("GT"))
                                {
                                    ConsultarTipoCamioMonedaGT(row["Code"].ToString(), oCompany);
                                }
                            }

                        }


                    }//Cierra el else de condicion if (result != 0)



                }//Cierra el for para recorrer las compañias


            }//Cierra el try
            catch (Exception ex)
            {
                //if (oCompany != null && oCompany.Connected)
                //{
                //    oCompany.Disconnect();
                //    //Se agrego linea para mantenimiento y para liberar recursos
                //    //System.Runtime.InteropServices.Marshal.ReleaseComObject(oCompany);
                //}
                throw ex;
            }
            finally
            {
                if (oCompany != null && oCompany.Connected)
                {
                    oCompany.Disconnect();
                    if (oCompany != null)
                    {
                        //Se agrego linea para mantenimiento y para liberar recursos
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(oCompany);
                        oCompany = null;
                    }

                }
            }
        }



    }
}
