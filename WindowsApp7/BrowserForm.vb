Imports CefSharp
Imports CefSharp.WinForms
Public Class BrowserForm
    Friend WithEvents browser As ChromiumWebBrowser
    Dim settings As CefSettings
    Dim appdata As String = Environment.GetEnvironmentVariable(Environment.SpecialFolder.LocalApplicationData)
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("User Local AppData folder : " + appdata)
        settings = New CefSettings
        settings.CachePath = Environment.GetEnvironmentVariable(Environment.SpecialFolder.LocalApplicationData) + "\SipaaOS\Sedge\Cache"
        settings.Locale = "en-us"
        browser = New ChromiumWebBrowser(My.Settings.DefaultHomePage)
        browser.Dock = DockStyle.Fill
        CefPanel.Controls.Add(browser)
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        browser.Back()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        browser.Forward()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        browser.Load(My.Settings.DefaultHomePage)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click

    End Sub
End Class