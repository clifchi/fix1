Imports System
Imports System.Web
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Owin

Partial Public Class ForgotPassword
    Inherits System.Web.UI.Page

    Protected Property StatusMessage() As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Protected Sub Forgot(sender As Object, e As EventArgs)
        If IsValid Then
            ' 驗證使用者的電子郵件地址
            Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
            Dim user As ApplicationUser = manager.FindByName(Email.Text)
            If user Is Nothing OrElse Not manager.IsEmailConfirmed(user.Id) Then
                FailureText.Text = "使用者不存在或未確認。"
                ErrorMessage.Visible = True
                Return
            End If
            ' 如需如何啟用帳戶確認和密碼重設的詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkID=320771
            ' 傳送包含驗證碼的電子郵件並重新導向至重設密碼頁面
            ' Dim code = manager.GeneratePasswordResetToken(user.Id)
            ' Dim callbackUrl = IdentityHelper.GetResetPasswordRedirectUrl(code, Request)
            ' manager.SendEmail(user.Id, "重設密碼", "Please reset your password by clicking <a href=""" & callbackUrl & """>這裏</a>.")
            loginForm.Visible = False
            DisplayEmail.Visible = True
        End If
    End Sub
End Class