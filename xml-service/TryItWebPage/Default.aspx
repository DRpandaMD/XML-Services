<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryItWebPage.Default" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <title>TryIt</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <asp:Label ID="TitleLabel" runat="server" Text="Assignment4-Part2-Step6" Font-Size="Large" Font-Bold="true"></asp:Label>
            <br />
            <asp:Label ID="XMLLabel" runat="server" Text="Enter in the XML URL:   "></asp:Label>
            <asp:TextBox ID="XMLTextBox" runat="server" Width="300px">http://www.public.asu.edu/~mczarate/Books.xml</asp:TextBox>
            <br />
            <asp:Label ID="XSLLabel" runat="server" Text="Enter in XSL URL:  "></asp:Label>
            <asp:TextBox ID="XSLTextBox" runat="server" Width="326px">http://www.public.asu.edu/~mczarate/Books.xslt</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="PushMeButton" runat="server" Text="PushMe!" />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="HtmlLabel" runat="server" Text=""></asp:Label>
            <br />
            <asp:TextBox ID="HtmlTextBox" runat="server" Font-Size="Smaller" TextMode="MultiLine" Visible="false" Columns="100" Rows="20"></asp:TextBox>
            
            <br />
            <br />
        </div>

       

        <div>
            <asp:Label ID="ValidationLabel" runat="server" Text="XML Validation Area" Font-Bold="true" Font-Size="Larger"></asp:Label>
            <br />
             <asp:Label ID="SecondXMLLabel" runat="server" Text="Enter in the XML URL:    "></asp:Label>
             <asp:TextBox ID="SecondXMLTextBox" runat="server" Width="300px">http://www.public.asu.edu/~mczarate/Books.xml</asp:TextBox>
            <br />
            <asp:Label ID="XSDLabel" runat="server" Text="Enter in XSD URL:  "></asp:Label>
            <asp:TextBox ID="XSDTextBox" runat="server" Width="326px">http://www.public.asu.edu/~mczarate/Books.xsd</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ValidateButton" runat="server" Text="ValidateXML" />
            <br />
            <asp:Label ID="ValidationResultLabel" runat="server" Text="" Font-Bold="true" Font-Size="Larger"></asp:Label>


        </div>

        


    </form>
        
</body>

</html>