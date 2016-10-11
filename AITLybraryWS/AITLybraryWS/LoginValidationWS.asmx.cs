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
    /// Summary description for LoginValidation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginValidationWS : WebService
    {

        [WebMethod]
        public Boolean passwordFormatValidation(string password)
        {
            try
            {
                LoginLogic loginLogic = new LoginLogic();
                return loginLogic.passwordFormatValidation(password);

            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "passwordFormatValidation",
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
                                                                            "passwordFormatValidation",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }
    }
}
