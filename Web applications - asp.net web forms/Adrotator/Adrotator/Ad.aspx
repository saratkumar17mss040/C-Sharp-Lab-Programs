<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ad.aspx.cs" Inherits="Ad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/XMLFile.xml" />
        </div>
    </form>
</body>
</html>
