<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentAdvisorDetails.aspx.cs" Inherits="StudentInstructor_University_Assignment.StudentAdvisorDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnDisplayDetails" runat="server" OnClick="btnDisplayDetails_Click" />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
