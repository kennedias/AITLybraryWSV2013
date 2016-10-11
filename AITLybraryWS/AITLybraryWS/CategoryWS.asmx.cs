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
    /// Summary description for Category
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CategoryWS : WebService
    {

        [WebMethod]
        public int insertCategory(string categoryName)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.insertCategory(categoryName);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "insertCategory",
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
                                                                            "insertCategory",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int SelectCountCategoryByName(string categoryName)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.SelectCountCategoryByName(categoryName);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "SelectCountCategoryByName",
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
                                                                            "SelectCountCategoryByName",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }


        [WebMethod]
        public int DeleteCategory(int categoryId)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.DeleteCategory(categoryId);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "DeleteCategory",
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
                                                                            "DeleteCategory",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public int updateCategory(string categoryName, int categoryId)
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.updateCategory(categoryName, categoryId);
            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "updateCategory",
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
                                                                            "updateCategory",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        }

        [WebMethod]
        public DataTable GetAllCategories()
        {
            try
            {
                MasterLogic masterLogic = new MasterLogic();
                return masterLogic.GetAllCategories().ToDataTable();

            }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();
                soapException = handleSoapExceptionnew.CreateSoapException(Constants.faultUri,
                                                                           "GetAllCategories",
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
                                                                            "GetAllCategories",
                                                                            ex.Message,
                                                                            AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                            Constants.faultAplicationError,
                                                                            AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
            }
        } 
    }
}
