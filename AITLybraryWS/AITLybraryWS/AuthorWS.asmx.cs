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
    /// Summary description for AuthorWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthorWS : WebService
    {

        [WebMethod]
        public int insertAuthor(string authorName)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.insertAuthor(authorName);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "insertAuthor",
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
                                                                            "insertAuthor",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int SelectCountAuthorByName(string authorName)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.SelectCountAuthorByName(authorName);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "SelectCountAuthorByName",
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
                                                                            "SelectCountAuthorByName",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }


        [WebMethod]
        public int DeleteAuthor(int authorId)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.DeleteAuthor(authorId);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "DeleteAuthor",
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
                                                                            "DeleteAuthor",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int updateAuthor(string authorName, int authorId)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.updateAuthor(authorName, authorId);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "updateAuthor",
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
                                                                            "updateAuthor",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public DataTable GetAllAuthors()
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.GetAllAuthors().ToDataTable();

            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "GetAllAuthors",
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
                                                                            "GetAllAuthors",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }        
    }
}
