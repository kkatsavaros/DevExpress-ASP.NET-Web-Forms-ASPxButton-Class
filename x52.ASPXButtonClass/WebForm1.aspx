<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="x52.ASPXButtonClass.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>


            <dx:ASPxButton ID="MyButton" runat="server" Text="Show Alert" AutoPostBack="False">
                <ClientSideEvents Click="function(s, e) {alert('Hello, world');}" />
            </dx:ASPxButton>

            <br /><br /><br />



            <dx:ASPxButton ID="btnNewItem" runat="server" RenderMode="Link" Text="New Item" AutoPostBack="false"
                ImagePosition="Right" Image-IconID="actions_additem_16x16gray" />

            <dx:ASPxButton ID="btnDelete" runat="server" RenderMode="Danger" Text="Delete" Width="164px" AutoPostBack="false" />

            <dx:ASPxButton ID="btnNative" runat="server" Native="True" Text="Native" Width="164px" AutoPostBack="false" />

            <br /><br /><br />


        </div>
    </form>
</body>
</html>
