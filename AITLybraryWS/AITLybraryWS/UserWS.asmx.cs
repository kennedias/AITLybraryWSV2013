using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogic;
using System.Data;
using SystemFramework;
using System.Web.Services.Protocols;

using System.Xml;

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
        public void myThrow()
        {

            // Build the detail element of the SOAP fault.
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            System.Xml.XmlNode node = doc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);


            // Build specific details for the SoapException. 
            // Add first child of detail XML element.
            System.Xml.XmlNode details = doc.CreateNode(XmlNodeType.Element, "mySpecialInfo1", "http://tempuri.org/");
            System.Xml.XmlNode detailsChild = doc.CreateNode(XmlNodeType.Element, "childOfSpecialInfo", "http://tempuri.org/");
            details.AppendChild(detailsChild);


            // Add second child of detail XML element with an attribute.
            System.Xml.XmlNode details2 = doc.CreateNode(XmlNodeType.Element, "mySpecialInfo2", "http://tempuri.org/");
            XmlAttribute attr = doc.CreateAttribute("t", "attrName", "http://tempuri.org/");
            attr.Value = "attrValue";
            details2.Attributes.Append(attr);

            // Append the two child elements to the detail node.
            node.AppendChild(details);
            node.AppendChild(details2);


            //Throw the exception.    
            SoapException se = new SoapException("Fault occurred", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, node);

            throw se;
            return;
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
             //   return AppUtil.ThrowExceptionTable(ex, Constants.faultBusinessError);

                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException("http://tempuri.org/CategoriesService",
                                                                                         "PerformLogin",
                                                                                         ex.Message,
                                                                                         AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                                         "Business",
                                                                                         AppEnum.FaultSourceWS.BusinessError);
                throw soapException;

                throw;
            }
            catch (Exception ex)
            {
              //  return AppUtil.ThrowExceptionTable(ex, Constants.faultAplicationError);
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException("http://tempuri.org/CategoriesService",
                                                                                         "PerformLogin",
                                                                                         ex.Message,
                                                                                         AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                                         "Business",
                                                                                         AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
                throw;
            }
        }

        [WebMethod]
        public DataTable UserList()
        {
            UserLogic userLogic = new UserLogic();

            return userLogic.GetAllUser().ToDataTable();
        }

        /*
        [WebMethod]
        public DataTable InsertUser(string userName, string userLevelDescription)
        {
            try
            {
                UserLogic userLogic = new UserLogic();
                return userLogic.insertUser(userName, userLevelDescription);
             }
            catch (BusinessLogicException ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();

                    CreateSoapException(string uri,
                                        string webServiceNamespace,
                                        string errorMessage,
                                        string errorNumber,
                                        string errorSource,
                                        AppEnum.FaultSourceWS faultSource)
                
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException("http://tempuri.org/CategoriesService",
                                                                                         "PerformLogin",
                                                                                         ex.Message,
                                                                                         AppEnum.FaultSourceWS.BusinessError.ToString(),
                                                                                         "Business",
                                                                                         AppEnum.FaultSourceWS.BusinessError);
                throw SoapException;
                // return AppUtil.ThrowExceptionTable(ex);
            }
            catch (Exception ex)
            {
                HandleSoapException handleSoapExceptionnew = new HandleSoapException();
                SoapException soapException = new SoapException();

                soapException = handleSoapExceptionnew.CreateSoapException("http://tempuri.org/CategoriesService",
                                                                                         "PerformLogin",
                                                                                         ex.Message,
                                                                                         AppEnum.FaultSourceWS.AplicationError.ToString(),
                                                                                         "Business",
                                                                                         AppEnum.FaultSourceWS.AplicationError);
                throw soapException;
                //return AppUtil.ThrowExceptionTable(ex);
            }
        }
*/
 
    } 
}
