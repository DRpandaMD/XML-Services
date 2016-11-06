using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryItWebPage
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PushMeButton_Click(object sender, EventArgs e)
        {
            //make a service proxy to connect to
            XMLService.XmlServiceClient xmlService = new XMLService.XmlServiceClient();

            //now we need to get our inputs from the website
            string xmlURL = XMLTextBox.Text;
            string xsltUrl = XSLTextBox.Text;
            //now we can use those urls to get us an HTML file
            string htmlFile = xmlService.generateHtml(xmlURL, xsltUrl);
            ResultLabel.Text = htmlFile;
            HtmlLabel.Text = "<b> Here is the HTML code for the tabel!: </b>";
            HtmlTextBox.Text = htmlFile;
            HtmlTextBox.Enabled = false;
            HtmlTextBox.Visible = true;
        }

        protected void ValidateButton_Click(object sender, EventArgs e)
        {
            //MOAR PROXY
            XMLService.XmlServiceClient xmlService = new XMLService.XmlServiceClient();
            string xmlURL = SecondXMLTextBox.Text;
            string xsdURL = XSDTextBox.Text;

            string validResults = xmlService.validateXML(xmlURL, xsdURL);
            ValidationResultLabel.Text = validResults;
        }
    }
}