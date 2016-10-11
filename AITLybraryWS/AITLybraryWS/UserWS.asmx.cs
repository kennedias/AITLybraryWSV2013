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
    /// Summary description for UserWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserWS : WebService
    {

        [WebMethod]
        public DataTable GetAllUser()
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.GetAllUser().ToDataTable();
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "UserList",
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
                                                                            "UserList",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }


        [WebMethod]
        public DataTable GetUsersByName(String userName)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.GetUsersByName(userName).ToDataTable();

            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "GetUsersByName",
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
                                                                            "GetUsersByName",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public DataTable UserLogin(string username, string password)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.PerformLogin(username, password).ToDataTable();
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "UserLogin",
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
                                                                            "UserLogin",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        
        [WebMethod]
        public int updateUser(string userName, string password, string userLevelDescription, int userID)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.updateUser(userName, password, userLevelDescription, userID);
             }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "updateUser",
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
                                                                            "updateUser",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }



        [WebMethod]
        public int InsertUser(string userName, string userLevelDescription)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.insertUser(userName, userLevelDescription);
             }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "InsertUser",
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
                                                                            "InsertUser",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int updateUserWithoutPassword(string userName, string userLevelDescription, int userID)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.updateUserWithoutPassword(userName, userLevelDescription, userID);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "updateUserWithoutPassword",
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
                                                                            "updateUserWithoutPassword",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int deleteUser(int userID)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.deleteUser(userID);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "deleteUser",
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
                                                                            "deleteUser",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public String getUserLevelDescriptionByLevelCode(int userLevelCode)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.getUserLevelDescriptionByLevelCode(userLevelCode);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "getUserLevelDescriptionByLevelCode",
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
                                                                            "getUserLevelDescriptionByLevelCode",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int getUserLevelCodeByLevelDescription(string userLevelDescription)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.getUserLevelCodeByLevelDescription(userLevelDescription);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "getUserLevelDescriptionByLevelCode",
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
                                                                            "getUserLevelDescriptionByLevelCode",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }
    }
}
