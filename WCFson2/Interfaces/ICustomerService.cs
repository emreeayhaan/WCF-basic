using Data.Database;
using DataAccess.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFson2.Dto;

namespace WCFson2.Interfaces
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]//metotları bu sözleşmede belirtyoruz.
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "AddCustomerService")]
        void AddCustomerService(CustomerDto customerService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "DeleteCustomerService")]
        void DelCustomerService(CustomerDto deleteCustomerService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "UpdateCustomerService")]
        void UpCustomerService(CustomerDto updateCutomerService);
        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetCustomerService")]
        //auth key verilip tüm customerlar çekilmelidir
        void GetCustomerService(int CustomerDto);
    }
}
