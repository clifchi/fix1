Imports System
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Owin

Partial Public Class Register
    Inherits Page
    Protected Sub CreateUser_Click(sender As Object, e As EventArgs)
        Dim userName As String = Email.Text
        Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
        Dim signInManager = Context.GetOwinContext().Get(Of ApplicationSignInManager)()
        Dim user = New ApplicationUser() With {.UserName = userName, .Email = userName}
        Dim result = manager.Create(user, Password.Text)
        If result.Succeeded Then
            ' 如需如何啟用帳戶確認和密碼重設的詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkID=320771
            ' Dim code = manager.GenerateEmailConfirmationToken(user.Id)
            ' Dim callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request)
            ' manager.SendEmail(user.Id, "確認您的帳戶", "請按一下此連結確認您的帳戶 <a href=""" & callbackUrl & """>這裏</a>.")

            signInManager.SignIn(user, isPersistent := False, rememberBrowser := False)
            IdentityHelper.RedirectToReturnUrl(Request.QueryString("ReturnUrl"), Response)
        Else
            ErrorMessage.Text = result.Errors.FirstOrDefault()
        End If
    End Sub
End Class

