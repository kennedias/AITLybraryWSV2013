using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogic;
using System.Data;
using SystemFramework;
using System.Web.Services.Protocols;

namespace AITLybraryWS
{
    /// <summary>
    /// Summary description for LanguageWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LanguageWS : System.Web.Services.WebService
    {
        [WebMethod]
        public int insertLanguage(string languageName)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.insertLanguage(languageName);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "insertLanguage",
                                                                           ex.Message,
                                                                           AppEnum.FaultSourceWS.BusinessError.ToString(),
                                                                           Constants.faultBusinessError,
                                                                           AppEnum.FaultSourceWS.BusinessError);
                throw soapException;
            }
            catch (Exception ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                            "insertLanguage",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int SelectCountLanguageByName(string languageName)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.SelectCountLanguageByName(languageName);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "SelectCountLanguageByName",
                                                                           ex.Message,
                                                                           AppEnum.FaultSourceWS.BusinessError.ToString(),
                                                                           Constants.faultBusinessError,
                                                                           AppEnum.FaultSourceWS.BusinessError);
                throw soapException;
            }
            catch (Exception ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                            "SelectCountLanguageByName",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }


        [WebMethod]
        public int DeleteLanguage(int languageId)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.DeleteLanguage(languageId);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "DeleteLanguage",
                                                                           ex.Message,
                                                                           AppEnum.FaultSourceWS.BusinessError.ToString(),
                                                                           Constants.faultBusinessError,
                                                                           AppEnum.FaultSourceWS.BusinessError);
                throw soapException;
            }
            catch (Exception ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                            "DeleteLanguage",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int updateLanguage(string languageName, int languageId)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.updateLanguage(languageName, languageId);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "updateLanguage",
                                                                           ex.Message,
                                                                           AppEnum.FaultSourceWS.BusinessError.ToString(),
                                                                           Constants.faultBusinessError,
                                                                           AppEnum.FaultSourceWS.BusinessError);
                throw soapException;
            }
            catch (Exception ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                            "updateLanguage",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public DataTable GetAllLanguages()
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.GetAllLanguages().ToDataTable();

            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "GetAllLanguages",
                                                                           ex.Message,
                                                                           AppEnum.FaultSourceWS.BusinessError.ToString(),
                                                                           Constants.faultBusinessError,
                                                                           AppEnum.FaultSourceWS.BusinessError);
                throw soapException;
            }
            catch (Exception ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                            "GetAllLanguages",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }      
    }
}
