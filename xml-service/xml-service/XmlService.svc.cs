using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace xml_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "XmlService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select XmlService.svc or XmlService.svc.cs at the Solution Explorer and start debugging.
    public class XmlService : IXmlService
    {
        //Trying 5.1 Web Operation "Verification"
        //we want to Verify our XML

        public string validateXML(string xmlURL, string xsdURL)
        {
            //we are going to get the xml file from the url and make an XML Document
            try
            {
                WebRequest xmlRequest = WebRequest.Create(xmlURL);
                Stream xmlStream = xmlRequest.GetResponse().GetResponseStream();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlStream);
                
            }
            catch(Exception ex) //for debugging we want to catch exceptions
            {
                return ex.Message;
            }
            XmlSchemaSet schema = new XmlSchemaSet();
            //now we need to get our schema to verify our XML vs our XSD 
            try
            {
                schema.Add(null, xsdURL);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
           
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = schema;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            try
            {
                XmlReader reader = XmlReader.Create(xmlURL, settings);
                while (reader.Read()) ;
                return "XML is Valid!!";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }


        //Try to do 5.2 Wep Operation "Transform"
        public string generateHtml(string xmlURL, string xslURL)
        {
            try
            {
                // we are going to get the xml file and make an XML Document
                WebRequest xmlRequest = WebRequest.Create(xmlURL);
                Stream xmlStream = xmlRequest.GetResponse().GetResponseStream();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlStream);

                //get the .xslt file from the url and load it to transform the document
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(xslURL);

                //now make a Streamwrite to write the finished .hmtl file to disk
                StreamWriter output = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("App_Data/transformed.html"));
                transform.Transform(xmlDoc, null, output);
                output.Close();
                //put the file back
                return File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("App_Data/transformed.html"));
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
           

           
        }

        //we need to make a call back function to interrupt and show errors
        private static void ValidationCallBack(object sender, ValidationEventArgs events)
        {
            throw new Exception("WARNING: VALIDATION FAILED\n" + events.Exception.Message);
        }
    }
}
