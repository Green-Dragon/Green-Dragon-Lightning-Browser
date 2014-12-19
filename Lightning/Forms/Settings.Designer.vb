<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.segreendragon = New System.Windows.Forms.RadioButton()
        Me.seyoutube = New System.Windows.Forms.RadioButton()
        Me.sebing = New System.Windows.Forms.RadioButton()
        Me.seyahoo = New System.Windows.Forms.RadioButton()
        Me.segoogle = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.segreendragonbeta = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 26)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 25)
        Me.TextBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(364, 62)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Homepage"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.segreendragonbeta)
        Me.GroupBox2.Controls.Add(Me.segreendragon)
        Me.GroupBox2.Controls.Add(Me.seyoutube)
        Me.GroupBox2.Controls.Add(Me.sebing)
        Me.GroupBox2.Controls.Add(Me.seyahoo)
        Me.GroupBox2.Controls.Add(Me.segoogle)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(364, 108)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Engine"
        '
        'segreendragon
        '
        Me.segreendragon.AutoSize = True
        Me.segreendragon.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.segreendragon.Location = New System.Drawing.Point(200, 37)
        Me.segreendragon.Name = "segreendragon"
        Me.segreendragon.Size = New System.Drawing.Size(132, 19)
        Me.segreendragon.TabIndex = 4
        Me.segreendragon.TabStop = True
        Me.segreendragon.Text = "Green Dragon Search"
        Me.segreendragon.UseVisualStyleBackColor = True
        '
        'seyoutube
        '
        Me.seyoutube.AutoSize = True
        Me.seyoutube.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.seyoutube.Location = New System.Drawing.Point(112, 62)
        Me.seyoutube.Name = "seyoutube"
        Me.seyoutube.Size = New System.Drawing.Size(69, 19)
        Me.seyoutube.TabIndex = 3
        Me.seyoutube.TabStop = True
        Me.seyoutube.Text = "YouTube"
        Me.seyoutube.UseVisualStyleBackColor = True
        '
        'sebing
        '
        Me.sebing.AutoSize = True
        Me.sebing.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.sebing.Location = New System.Drawing.Point(112, 37)
        Me.sebing.Name = "sebing"
        Me.sebing.Size = New System.Drawing.Size(47, 19)
        Me.sebing.TabIndex = 2
        Me.sebing.TabStop = True
        Me.sebing.Text = "Bing"
        Me.sebing.UseVisualStyleBackColor = True
        '
        'seyahoo
        '
        Me.seyahoo.AutoSize = True
        Me.seyahoo.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.seyahoo.Location = New System.Drawing.Point(20, 62)
        Me.seyahoo.Name = "seyahoo"
        Me.seyahoo.Size = New System.Drawing.Size(60, 19)
        Me.seyahoo.TabIndex = 1
        Me.seyahoo.TabStop = True
        Me.seyahoo.Text = "Yahoo!"
        Me.seyahoo.UseVisualStyleBackColor = True
        '
        'segoogle
        '
        Me.segoogle.AutoSize = True
        Me.segoogle.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.segoogle.Location = New System.Drawing.Point(20, 37)
        Me.segoogle.Name = "segoogle"
        Me.segoogle.Size = New System.Drawing.Size(62, 19)
        Me.segoogle.TabIndex = 0
        Me.segoogle.TabStop = True
        Me.segoogle.Text = "Google"
        Me.segoogle.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(364, 97)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Download Path"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(20, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 23)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Ask for download path"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(283, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(20, 26)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(256, 25)
        Me.TextBox2.TabIndex = 0
        '
        'segreendragonbeta
        '
        Me.segreendragonbeta.AutoSize = True
        Me.segreendragonbeta.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.segreendragonbeta.Location = New System.Drawing.Point(200, 62)
        Me.segreendragonbeta.Name = "segreendragonbeta"
        Me.segreendragonbeta.Size = New System.Drawing.Size(158, 19)
        Me.segreendragonbeta.TabIndex = 5
        Me.segreendragonbeta.TabStop = True
        Me.segreendragonbeta.Text = "Green Dragon Search Beta"
        Me.segreendragonbeta.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 344)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents seyoutube As System.Windows.Forms.RadioButton
    Friend WithEvents sebing As System.Windows.Forms.RadioButton
    Friend WithEvents seyahoo As System.Windows.Forms.RadioButton
    Friend WithEvents segoogle As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents segreendragon As System.Windows.Forms.RadioButton
    Friend WithEvents segreendragonbeta As System.Windows.Forms.RadioButton
End Class
