@Code
    ViewData("Title") = "UploadFile"
End Code
<head runat="server">
</head>

<h2>UploadFile</h2>

<h3>@ViewData("Message")</h3>
<div>
    <form id="form1" runat="server">
        <asp:FileUpload ID="FileUpload1" CssClass="button" runat="server" />
        <asp:Button ID="btnImport" CssClass="button" runat="server" Text="Import" OnClick="ImportCSV" />
        <hr />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</div>