<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageInfoDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageInfoDialog))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.url = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.favicon = New System.Windows.Forms.PictureBox()
        Me.securitystat = New System.Windows.Forms.Label()
        Me.contentstat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.contimg = New System.Windows.Forms.PictureBox()
        Me.secimg = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.contimg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.secimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.url)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Controls.Add(Me.favicon)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 86)
        Me.Panel1.TabIndex = 0
        '
        'url
        '
        Me.url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.url.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.url.Location = New System.Drawing.Point(71, 48)
        Me.url.Name = "url"
        Me.url.Size = New System.Drawing.Size(385, 30)
        Me.url.TabIndex = 2
        Me.url.Text = "Page URL"
        Me.url.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'title
        '
        Me.title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.title.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.title.Location = New System.Drawing.Point(68, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(390, 48)
        Me.title.TabIndex = 1
        Me.title.Text = "Page Title"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'favicon
        '
        Me.favicon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.favicon.Image = Global.GreenDragonLightning.My.Resources.Resources.globe
        Me.favicon.Location = New System.Drawing.Point(7, 3)
        Me.favicon.Name = "favicon"
        Me.favicon.Size = New System.Drawing.Size(59, 78)
        Me.favicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.favicon.TabIndex = 0
        Me.favicon.TabStop = False
        '
        'securitystat
        '
        Me.securitystat.BackColor = System.Drawing.Color.White
        Me.securitystat.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.securitystat.Location = New System.Drawing.Point(65, 127)
        Me.securitystat.Name = "securitystat"
        Me.securitystat.Size = New System.Drawing.Size(377, 50)
        Me.securitystat.TabIndex = 1
        Me.securitystat.Text = "This page is secure, etc."
        '
        'contentstat
        '
        Me.contentstat.BackColor = System.Drawing.Color.White
        Me.contentstat.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.contentstat.Location = New System.Drawing.Point(69, 245)
        Me.contentstat.Name = "contentstat"
        Me.contentstat.Size = New System.Drawing.Size(374, 50)
        Me.contentstat.TabIndex = 2
        Me.contentstat.Text = "There is no insecure content in this page"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(0, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(454, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Page Security"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(1, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(454, 41)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Page Content"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(355, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Okay, thanks!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'contimg
        '
        Me.contimg.BackColor = System.Drawing.Color.White
        Me.contimg.Image = CType(resources.GetObject("contimg.Image"), System.Drawing.Image)
        Me.contimg.Location = New System.Drawing.Point(6, 245)
        Me.contimg.Name = "contimg"
        Me.contimg.Size = New System.Drawing.Size(59, 50)
        Me.contimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.contimg.TabIndex = 5
        Me.contimg.TabStop = False
        '
        'secimg
        '
        Me.secimg.BackColor = System.Drawing.Color.White
        Me.secimg.Image = CType(resources.GetObject("secimg.Image"), System.Drawing.Image)
        Me.secimg.Location = New System.Drawing.Point(6, 127)
        Me.secimg.Name = "secimg"
        Me.secimg.Size = New System.Drawing.Size(59, 50)
        Me.secimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.secimg.TabIndex = 3
        Me.secimg.TabStop = False
        '
        'PageInfoDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 343)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.contimg)
        Me.Controls.Add(Me.secimg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.contentstat)
        Me.Controls.Add(Me.securitystat)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PageInfoDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Page Security"
        Me.Panel1.ResumeLayout(False)
        CType(Me.favicon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.contimg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.secimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents favicon As System.Windows.Forms.PictureBox
    Friend WithEvents url As System.Windows.Forms.Label
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents securitystat As System.Windows.Forms.Label
    Friend WithEvents contentstat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents secimg As System.Windows.Forms.PictureBox
    Friend WithEvents contimg As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
