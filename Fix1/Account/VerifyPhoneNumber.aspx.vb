﻿Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin

Partial Public Class VerifyPhoneNumber
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
        Dim phonenum = Request.QueryString("PhoneNumber")
        Dim code = manager.GenerateChangePhoneNumberToken(User.Identity.GetUserId(), phonenum)
        PhoneNumber.Value = phonenum
    End Sub

    Protected Sub Code_Click(sender As Object, e As EventArgs)
        If Not ModelState.IsValid Then
            ModelState.AddModelError("", "無效的密碼")
            Return
        End If

        Dim manager = Context.GetOwinContext().GetUserManager(Of ApplicationUserManager)()
        Dim signInManager = Context.GetOwinContext().Get(Of ApplicationSignInManager)()

        Dim result = manager.ChangePhoneNumber(User.Identity.GetUserId(), PhoneNumber.Value, Code.Text)

        If result.Succeeded Then
            Dim userInfo = manager.FindById(User.Identity.GetUserId())

            If userInfo IsNot Nothing Then
                signInManager.SignIn(userInfo, isPersistent := False, rememberBrowser := False)
                Response.Redirect("/Account/Manage?m=AddPhoneNumberSuccess")
            End If
        End If

        ' 如果到了這個階段出現了錯誤，請於以下位置重新顯示
        ModelState.AddModelError("", "無法驗證電話")
    End Sub
End Class
