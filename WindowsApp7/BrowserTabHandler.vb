Public Class BrowserTabHandler
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim bf As New BrowserForm
        Dim mtp As New TabPage
        bf.TopLevel = False
        bf.Dock = DockStyle.Fill
        bf.FormBorderStyle = FormBorderStyle.None
        mtp.Controls.Add(bf)
        MetroTabControl1.TabPages.Add(mtp)
        mtp.Text = "Tab " + MetroTabControl1.TabCount.ToString
        bf.Show()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        If MetroTabControl1.TabCount = 1 Then
            Me.Close()
        Else
            MetroTabControl1.TabPages.Remove(MetroTabControl1.SelectedTab)
        End If
    End Sub

    Private Sub AboutSedgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSedgeToolStripMenuItem.Click
        Dim bf As New AboutSedge
        Dim mtp As New TabPage
        bf.TopLevel = False
        bf.Dock = DockStyle.Fill
        bf.FormBorderStyle = FormBorderStyle.None
        mtp.Controls.Add(bf)
        MetroTabControl1.TabPages.Add(mtp)
        mtp.Text = "About Sedge"
        bf.Show()
    End Sub

    Private Sub BrowserTabHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MetroTabControl1.TabCount = 0 Then
            Dim bf As New BrowserForm
            Dim mtp As New TabPage
            bf.TopLevel = False
            bf.Dock = DockStyle.Fill
            bf.FormBorderStyle = FormBorderStyle.None
            mtp.Controls.Add(bf)
            MetroTabControl1.TabPages.Add(mtp)
            mtp.Text = "Tab " + MetroTabControl1.TabCount.ToString
            bf.Show()
        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        MetroContextMenu1.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim bf As New Settings
        Dim mtp As New TabPage
        bf.TopLevel = False
        bf.Dock = DockStyle.Fill
        bf.FormBorderStyle = FormBorderStyle.None
        mtp.Controls.Add(bf)
        MetroTabControl1.TabPages.Add(mtp)
        mtp.Text = "Tab " + MetroTabControl1.TabCount.ToString
        bf.Show()
    End Sub
End Class
