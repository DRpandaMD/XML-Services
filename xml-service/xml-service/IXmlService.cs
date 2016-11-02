using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace xml_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IXmlService" in both code and config file together.
    [ServiceContract]
    public interface IXmlService
    {
        [OperationContract]
        string generateHtml(string xmlURL, string xslURL);

        [OperationContract]
        string validateXML(string xmlURL, string xsdURL);
    }

}
