<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtas_q = New System.Windows.Forms.TextBox()
        Me.cmbhl = New System.Windows.Forms.ComboBox()
        Me.txtas_epq = New System.Windows.Forms.TextBox()
        Me.txtas_oq = New System.Windows.Forms.TextBox()
        Me.txtas_eq = New System.Windows.Forms.TextBox()
        Me.cmbimgtype = New System.Windows.Forms.ComboBox()
        Me.cmbimgsz = New System.Windows.Forms.ComboBox()
        Me.cmbimgc = New System.Windows.Forms.ComboBox()
        Me.cmbas_filetype = New System.Windows.Forms.ComboBox()
        Me.txtas_sitesearch = New System.Windows.Forms.TextBox()
        Me.chksafe = New System.Windows.Forms.CheckBox()
        Me.chkfilter = New System.Windows.Forms.CheckBox()
        Me.txtFullURL = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lstURLS = New System.Windows.Forms.ListBox()
        Me.ButGO = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Term"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Language"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Complete Phrase"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "At Least One"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Excluding"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Image Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Image Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Image Color"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(331, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "File Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(331, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Site"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(331, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Safe Search"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(331, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Show Similar Results"
        '
        'txtas_q
        '
        Me.txtas_q.Location = New System.Drawing.Point(136, 40)
        Me.txtas_q.Name = "txtas_q"
        Me.txtas_q.Size = New System.Drawing.Size(144, 20)
        Me.txtas_q.TabIndex = 12
        '
        'cmbhl
        '
        Me.cmbhl.FormattingEnabled = True
        Me.cmbhl.Items.AddRange(New Object() {"en", "ar", "fr"})
        Me.cmbhl.Location = New System.Drawing.Point(136, 72)
        Me.cmbhl.Name = "cmbhl"
        Me.cmbhl.Size = New System.Drawing.Size(144, 21)
        Me.cmbhl.TabIndex = 13
        '
        'txtas_epq
        '
        Me.txtas_epq.Location = New System.Drawing.Point(136, 105)
        Me.txtas_epq.Name = "txtas_epq"
        Me.txtas_epq.Size = New System.Drawing.Size(144, 20)
        Me.txtas_epq.TabIndex = 14
        '
        'txtas_oq
        '
        Me.txtas_oq.Location = New System.Drawing.Point(136, 137)
        Me.txtas_oq.Name = "txtas_oq"
        Me.txtas_oq.Size = New System.Drawing.Size(144, 20)
        Me.txtas_oq.TabIndex = 15
        '
        'txtas_eq
        '
        Me.txtas_eq.Location = New System.Drawing.Point(136, 169)
        Me.txtas_eq.Name = "txtas_eq"
        Me.txtas_eq.Size = New System.Drawing.Size(144, 20)
        Me.txtas_eq.TabIndex = 16
        '
        'cmbimgtype
        '
        Me.cmbimgtype.FormattingEnabled = True
        Me.cmbimgtype.Items.AddRange(New Object() {"news", "face", "photo", "clipart", "lineart", "animated"})
        Me.cmbimgtype.Location = New System.Drawing.Point(136, 201)
        Me.cmbimgtype.Name = "cmbimgtype"
        Me.cmbimgtype.Size = New System.Drawing.Size(144, 21)
        Me.cmbimgtype.TabIndex = 17
        '
        'cmbimgsz
        '
        Me.cmbimgsz.FormattingEnabled = True
        Me.cmbimgsz.Items.AddRange(New Object() {"huge", "xxlarge", "xlarge", "large", "medium", "small", "icon"})
        Me.cmbimgsz.Location = New System.Drawing.Point(447, 40)
        Me.cmbimgsz.Name = "cmbimgsz"
        Me.cmbimgsz.Size = New System.Drawing.Size(144, 21)
        Me.cmbimgsz.TabIndex = 18
        '
        'cmbimgc
        '
        Me.cmbimgc.FormattingEnabled = True
        Me.cmbimgc.Items.AddRange(New Object() {"color", "gray", "mono", "trans"})
        Me.cmbimgc.Location = New System.Drawing.Point(447, 73)
        Me.cmbimgc.Name = "cmbimgc"
        Me.cmbimgc.Size = New System.Drawing.Size(144, 21)
        Me.cmbimgc.TabIndex = 19
        '
        'cmbas_filetype
        '
        Me.cmbas_filetype.FormattingEnabled = True
        Me.cmbas_filetype.Items.AddRange(New Object() {"jpg", "gif", "png", "bmp"})
        Me.cmbas_filetype.Location = New System.Drawing.Point(447, 106)
        Me.cmbas_filetype.Name = "cmbas_filetype"
        Me.cmbas_filetype.Size = New System.Drawing.Size(144, 21)
        Me.cmbas_filetype.TabIndex = 20
        '
        'txtas_sitesearch
        '
        Me.txtas_sitesearch.Location = New System.Drawing.Point(447, 139)
        Me.txtas_sitesearch.Name = "txtas_sitesearch"
        Me.txtas_sitesearch.Size = New System.Drawing.Size(144, 20)
        Me.txtas_sitesearch.TabIndex = 21
        '
        'chksafe
        '
        Me.chksafe.AutoSize = True
        Me.chksafe.Location = New System.Drawing.Point(450, 173)
        Me.chksafe.Name = "chksafe"
        Me.chksafe.Size = New System.Drawing.Size(15, 14)
        Me.chksafe.TabIndex = 22
        Me.chksafe.UseVisualStyleBackColor = True
        '
        'chkfilter
        '
        Me.chkfilter.AutoSize = True
        Me.chkfilter.Location = New System.Drawing.Point(450, 206)
        Me.chkfilter.Name = "chkfilter"
        Me.chkfilter.Size = New System.Drawing.Size(15, 14)
        Me.chkfilter.TabIndex = 22
        Me.chkfilter.UseVisualStyleBackColor = True
        '
        'txtFullURL
        '
        Me.txtFullURL.Location = New System.Drawing.Point(136, 12)
        Me.txtFullURL.Name = "txtFullURL"
        Me.txtFullURL.ReadOnly = True
        Me.txtFullURL.Size = New System.Drawing.Size(389, 20)
        Me.txtFullURL.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Full URL"
        '
        'lstURLS
        '
        Me.lstURLS.FormattingEnabled = True
        Me.lstURLS.Location = New System.Drawing.Point(12, 244)
        Me.lstURLS.Name = "lstURLS"
        Me.lstURLS.Size = New System.Drawing.Size(120, 95)
        Me.lstURLS.TabIndex = 24
        '
        'ButGO
        '
        Me.ButGO.Location = New System.Drawing.Point(532, 8)
        Me.ButGO.Name = "ButGO"
        Me.ButGO.Size = New System.Drawing.Size(59, 23)
        Me.ButGO.TabIndex = 25
        Me.ButGO.Text = "GO"
        Me.ButGO.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(140, 228)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(463, 250)
        Me.WebBrowser1.TabIndex = 26
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 384)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 56)
        Me.TextBox1.TabIndex = 27
        '
        'Form1
        '
        Me.AcceptButton = Me.ButGO
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 482)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ButGO)
        Me.Controls.Add(Me.lstURLS)
        Me.Controls.Add(Me.txtFullURL)
        Me.Controls.Add(Me.chkfilter)
        Me.Controls.Add(Me.chksafe)
        Me.Controls.Add(Me.txtas_sitesearch)
        Me.Controls.Add(Me.cmbas_filetype)
        Me.Controls.Add(Me.cmbimgc)
        Me.Controls.Add(Me.cmbimgsz)
        Me.Controls.Add(Me.cmbimgtype)
        Me.Controls.Add(Me.txtas_eq)
        Me.Controls.Add(Me.txtas_oq)
        Me.Controls.Add(Me.txtas_epq)
        Me.Controls.Add(Me.cmbhl)
        Me.Controls.Add(Me.txtas_q)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtas_q As System.Windows.Forms.TextBox
    Friend WithEvents cmbhl As System.Windows.Forms.ComboBox
    Friend WithEvents txtas_epq As System.Windows.Forms.TextBox
    Friend WithEvents txtas_oq As System.Windows.Forms.TextBox
    Friend WithEvents txtas_eq As System.Windows.Forms.TextBox
    Friend WithEvents cmbimgtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbimgsz As System.Windows.Forms.ComboBox
    Friend WithEvents cmbimgc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbas_filetype As System.Windows.Forms.ComboBox
    Friend WithEvents txtas_sitesearch As System.Windows.Forms.TextBox
    Friend WithEvents chksafe As System.Windows.Forms.CheckBox
    Friend WithEvents chkfilter As System.Windows.Forms.CheckBox
    Friend WithEvents txtFullURL As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lstURLS As System.Windows.Forms.ListBox
    Friend WithEvents ButGO As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
