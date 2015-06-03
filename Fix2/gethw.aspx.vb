Public Class gethw
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strUser As String
        If Session("Account") <> "" Then
            strUser = Session("Account")
        Else
            Response.Redirect("login.aspx")
        End If
    End Sub


    Protected Sub getCaseID_Click(sender As Object, e As EventArgs) Handles btn_getCaseID.Click
        'GridView1.DataSource = SqlDataSource_gethw
        'GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To cblAttach.Items.Count - 1
            If cblAttach.Items(i).Selected Then
                lblAttach.Text &= cblAttach.Items(i).Text & ","
            End If
        Next

        If tbOtherAttach.Text <> "" Then
            lblAttach.Text &= tbOtherAttach.Text
        Else
            lblAttach.Text &= "無其它"
        End If

        Try
            SqlDataSource_gethw.Insert()
        Catch ex As ArgumentException
            Response.Write(ex.ToString)
        Finally
            Response.Redirect("testMain")
        End Try




    End Sub
End Class