Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub txtas_q_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtas_q.TextChanged, txtas_epq.TextChanged, txtas_eq.TextChanged, txtas_oq.TextChanged, txtas_sitesearch.TextChanged
        GenerateURL()
    End Sub
    Private Sub GenerateURL()
        Dim FULLURL As String = ""
        If txtas_epq.Text.Trim <> "" Then FULLURL = FULLURL & "&as_epq=" & txtas_epq.Text.Trim
        If txtas_eq.Text.Trim <> "" Then FULLURL = FULLURL & "&as_eq=" & txtas_eq.Text.Trim
        If txtas_oq.Text.Trim <> "" Then FULLURL = FULLURL & "&as_oq=" & txtas_oq.Text.Trim
        If txtas_q.Text.Trim <> "" Then FULLURL = FULLURL & "&as_q=" & txtas_q.Text.Trim
        If txtas_sitesearch.Text.Trim <> "" Then FULLURL = FULLURL & "&as_sitesearch=" & txtas_sitesearch.Text.Trim
        If cmbhl.Text.Trim <> "" Then FULLURL = FULLURL & "&hl=" & cmbhl.Text.Trim
        If cmbas_filetype.Text.Trim <> "" Then FULLURL = FULLURL & "&as_filetype=" & cmbas_filetype.Text.Trim
        If cmbimgc.Text.Trim <> "" Then FULLURL = FULLURL & "&imgc=" & cmbimgc.Text.Trim
        If cmbimgsz.Text.Trim <> "" Then FULLURL = FULLURL & "&imgsz=" & cmbimgsz.Text.Trim
        If cmbimgtype.Text.Trim <> "" Then FULLURL = FULLURL & "&imgtype=" & cmbimgtype.Text.Trim
        If chkfilter.Checked Then FULLURL = FULLURL & "&filter=0"
        If chksafe.Checked Then FULLURL = FULLURL & "&safe=on" Else FULLURL = FULLURL & "&safe=off"

        FULLURL = "https://www.google.com/search?btnG=Search+by+image&tbm=isch&site=imghp&source=hp&sout=0&as_st=y&sa=N&start=20" & FULLURL
        txtFullURL.Text = FULLURL
    End Sub

    Private Sub cmbhl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbhl.SelectedIndexChanged, cmbas_filetype.SelectedIndexChanged, cmbimgc.SelectedIndexChanged, cmbimgsz.SelectedIndexChanged, cmbimgtype.SelectedIndexChanged
        GenerateURL()
    End Sub

    Private Sub cmbas_filetype_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbhl.TextChanged, cmbas_filetype.TextChanged, cmbimgc.TextChanged, cmbimgsz.TextChanged, cmbimgtype.TextChanged
        GenerateURL()
    End Sub

    Private Sub chksafe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksafe.CheckedChanged, chkfilter.CheckedChanged
        GenerateURL()
    End Sub

    Private Sub ButGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGO.Click
        WebBrowser1.ObjectForScripting = True
        WebBrowser1.Navigate(txtFullURL.Text)
        'GeckoWebBrowser1.Navigate(txtFullURL.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim curT As String = ""
    Dim stp As Integer
    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        stp = 0
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If stp < 3 Then
            WebBrowser1.Navigate("javascript:window.scroll(0,document.body.scrollHeight);")
            stp = stp + 1
        Else
            Timer1.Enabled = False
            Dim match As Match = Regex.Match(WebBrowser1.DocumentText, "imgurl=([^"" >]+)&amp;imgrefurl=", RegexOptions.IgnoreCase)


            While match.Success
                Dim lvi As New ListViewItem()
                lvi.Text = match.Groups(1).Value
                TextBox1.Text = TextBox1.Text & vbCrLf & lvi.Text
                lstURLS.Items.Add(lvi)
                match = match.NextMatch()
            End While
           

            MsgBox("fin")
        End If

        'If curT <> WebBrowser1.DocumentText And stp < 4 Then
        '    curT = WebBrowser1.DocumentText
        '    WebBrowser1.Navigate("javascript:window.scroll(0,document.body.scrollHeight);")
        'ElseIf stp < 4 Then
        '    stp = stp + 1
        '    Timer1.Interval = Timer1.Interval * 2
        '    WebBrowser1.Navigate("javascript:window.scroll(0,document.body.scrollHeight);")
        'Else
        '    Timer1.Enabled = False
        '    MsgBox("fin")
        'End If
    End Sub
End Class
