Public Class Main
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Session("Account") Is Nothing Then
            AddCase.Visible = True
            PersonalCase.Visible = True
            GetHW.Visible = True
            login.Visible = False
            username.Visible = True
            If Not Session("Worker") Is Nothing Then
                ManageCase.Visible = True
            End If
            If Not Session("Admin") Is Nothing Then
                ManageCase.Visible = True
                Adminsetup.Visible = True
            End If
        Else
            AddCase.Visible = False
            PersonalCase.Visible = False
            GetHW.Visible = False
            login.Visible = True
            username.Visible = False
            ManageCase.Visible = False
            Adminsetup.Visible = False
        End If

    End Sub

End Class