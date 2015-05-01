<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="RegisterExternalLogin.aspx.vb" Inherits="Fix1.RegisterExternalLogin" Async="true" %>

<%@ Import Namespace="Fix1" %>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
<h3>以您的 <%: ProviderName %> 帳戶登入</h3>

    <asp:PlaceHolder runat="server">
        <div class="form-horizontal">
            <h4>關聯表單</h4>
            <hr />
            <asp:ValidationSummary runat="server" ShowModelStateErrors="true" CssClass="text-danger" />
            <p class="text-info">
                您已透過 <strong><%: ProviderName %></strong> 進行驗證。請在下方輸入目前網站的電子郵件並按一下 [登入] 按鈕。
            </p>

            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="email" CssClass="col-md-2 control-label">電子郵件</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="email" CssClass="form-control" TextMode="Email" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="email"
                        Display="Dynamic" CssClass="text-danger" ErrorMessage="電子郵件為必填" />
                    <asp:ModelErrorMessage runat="server" ModelStateKey="email" CssClass="text-error" />
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server" Text="登入" CssClass="btn btn-default" OnClick="LogIn_Click" />
                </div>
            </div>
        </div>
    </asp:PlaceHolder>
</asp:Content>
