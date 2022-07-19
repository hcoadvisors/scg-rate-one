using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using SCG.SyncBCCR.BL;
using System.Threading;
using System.IO;
using System.Reflection;
using System.Configuration;



namespace SCG_Syn_BCCR
{
    public partial class SCGSync : ServiceBase
    {
        # region Declaraciones

        static int countDebug = 0;
      
        public EventLog _log;
        static object _locker = null;
        private System.Threading.Timer _timerSync;
        static int contadorInteracion = 0; //  bloqueos 
        private const string SOURCE = "SCGSyncBCCR";
        private const string LOGNAME = "SCG Syn BCCR Exchange Rate";
        //private bool stopping;//CAMBIO TIMER A WHILE
        //private ManualResetEvent stoppedEvent;//CAMBIO TIMER A WHILE
        

        #endregion




        public SCGSync()
        {
            InitializeComponent();

            //this.stopping = false; //CAMBIO TIMER A WHILE
            //this.stoppedEvent = new ManualResetEvent(false); //CAMBIO TIMER A WHILE

        }

        protected override void OnStart(string[] args)
        {
            StartService();
        }

        protected override void OnStop()
        {
            StopService();
        }


        #region Métodos privados

        private void StartService()
        {
            try
            {
                Debuguer("inicio: " + System.DateTime.Now);

                _locker = new object();

                if (!EventLog.SourceExists(SOURCE))
                {
                    EventLog.CreateEventSource(SOURCE, LOGNAME);
                }

                _log = new EventLog();
                _log.Source = SOURCE;
                StartTimerSynchronization();

                // Queue the main service function for execution in a worker thread.
                //ThreadPool.QueueUserWorkItem(new WaitCallback(ServiceWorkerThread));//CAMBIO TIMER A WHILE
            }
            catch (Exception ex)
            {
                Debuguer("error nivel 1 : " + ex.Message);
                if (_log != null)
                {
                    _log.WriteEntry("(" + contadorInteracion + ")" + " Se produjo un error(1), causa: " + ex.Message + "\n Detalle: " + ex.StackTrace, EventLogEntryType.Error);
                }
            }
        }


        private void StopService()
        {
            Debuguer("StopService");//opcion 1


            // Indicate that the service is stopping and wait for the finish 
            // of the main service function (ServiceWorkerThread).
            //this.stopping = true;//CAMBIO TIMER A WHILE
            //this.stoppedEvent.WaitOne();//CAMBIO TIMER A WHILE

        }

         /// <summary>
        /// Inicializa el timer de sincronizacion 
        /// </summary>
        private void StartTimerSynchronization()
        {
            try
            {
                Debuguer("IniciarTimerSincronizacion: ");
                int periodo = SynTime();

                if (periodo != 0)
                {
                    periodo = periodo * 60 * 1000;
                    //periodo = periodo * 1000;
                    TimerCallback timerSesionDelegate = new TimerCallback(SyncExchangeRate);
                    _timerSync = new System.Threading.Timer(timerSesionDelegate, null, 0, periodo);
                }
            }
            catch (Exception ex)
            {
                if (_log != null)
                {
                    _log.WriteEntry("(" + contadorInteracion + ")" + "  Se produjo un error(6), causa: " + ex.Message + "\n Detalle: " + ex.StackTrace, EventLogEntryType.Error);
                }
            } 
        }

        private void Debuguer(string msj)//metodo de debugueo solo pruebas
        {
            StreamWriter sw;
            Sync oSync;
            try
            {
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);

                path = path.Replace(@"file:\", "");

                string logFile = Path.Combine(path, "Debuger.txt");
                if (countDebug == 250)
                {
                    oSync = new Sync();

                    oSync.SyncExchangeRate();
                    oSync = null;

                    File.Delete(logFile);
                    countDebug = 0;
                }

                using (sw = new StreamWriter(logFile, true))
                {
                    sw.WriteLine(msj + "            : " + countDebug);
                  //  sw.WriteLine();
                    sw.Close();

                    countDebug = countDebug + 1;

                }
            }
            catch (Exception ex)
            {
                if (_log != null)
                {

                    _log.WriteEntry("(" + contadorInteracion + ")" + " Se produjo un error (5), causa: " + ex.Message + "\n Detalle: " + ex.StackTrace, EventLogEntryType.Error);
                }
            }
            finally
            {
                sw = null;

            }
        }

        //private void ServiceWorkerThread(object state)//CAMBIO TIMER A WHILE
        //{
        //    try
        //    {
               
        //        int periodo = SynTime();

        //        if (periodo != 0)
        //        {

        //            periodo = periodo * 60 *   1000;

                                       
        //            while (!this.stopping)
        //            {
                        
        //                SyncExchangeRate();

                        
                        
        //                Thread.Sleep(periodo);  

                        
                        
        //            }
                 
        //            this.stoppedEvent.Set();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        if (_log != null)
        //        {
        //            _log.WriteEntry("(" + contadorInteracion + ")" + "  Se produjo un error(6), causa: " + ex.Message + "\n Detalle: " + ex.StackTrace, EventLogEntryType.Error);
        //        }
        //    }

        //}

        /// <summary>
        /// Consulta tiempo de sincrionizacion
        /// </summary>
        /// <returns>tiempo</returns>
        private int SynTime()
        {


            int time = GetSynTime();

            Debuguer("Tiempo:  " + time + "minutos");

            return time;
        }

      

        /// <summary>
        /// se encarga de verificar si existen nuevos datos creados en sap
        /// </summary>
        private void SyncExchangeRate(Object eventState)
        {
            Sync oSync;
            try
            {

                Debuguer("Inicio Tipo de cambio " + System.DateTime.Now);

                oSync = new Sync();
                oSync.SyncExchangeRate();
                oSync = null;

                Debuguer("Fin Tipo de cambio " + System.DateTime.Now);
                        }
            catch (Exception ex)
            {
                Debuguer("SyncExchangeRate error: " + ex.Message);
                if (_log != null)
                {
                    _log.WriteEntry("(" + contadorInteracion + ")" + " Se produjo un error (3) , causa: " + ex.Message + "\n Detalle: " + ex.StackTrace, EventLogEntryType.Error);

                }

            }
            finally
            {
                oSync = null;
            }

        }

        public int  GetSynTime()
        { 
            int response = 0;

            try 
            {
            Configuration config = null;
            config = GetXMLConfig();

            response = Convert.ToInt32( config.AppSettings.Settings["SyncTime"].Value);
            }
            catch(Exception)
            {
                throw;
            }
            return response;
        }

        /// <summary>
        /// obtiene el xml de config 
        /// </summary>
        /// <returns></returns>
        public static Configuration GetXMLConfig()
        {
            ExeConfigurationFileMap configFileMap = null;
            Configuration config = null;
            string path = string.Empty;
            string configFile = string.Empty;
            try
            {

                path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                path = path.Replace(@"file:\", "");


                configFile = Path.Combine(path, "SCG.SyncBCCR.ConfigurationHost.exe.config");
              

                configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = configFile;
                config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            }
            catch (Exception)
            {
                throw;
            }
              return config;
        }

        #endregion

    }
}
