Public Class AboutSedge
    Private Sub AboutSedge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Version " + CefSharp.Cef.ChromiumVersion
        Label4.Text = "Copyright Sipa Env 2020-" + DateTime.Now.ToString("yyyy")
    End Sub
End Class