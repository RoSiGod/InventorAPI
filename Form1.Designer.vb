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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.InSpan = New System.Windows.Forms.TextBox()
        Me.InLength = New System.Windows.Forms.TextBox()
        Me.InHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InPitch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Export_BOM = New System.Windows.Forms.Button()
        Me.Export_Drawing = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FilepathDisplay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Select_Folder = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InSpan
        '
        Me.InSpan.Location = New System.Drawing.Point(107, 362)
        Me.InSpan.Name = "InSpan"
        Me.InSpan.Size = New System.Drawing.Size(100, 20)
        Me.InSpan.TabIndex = 0
        '
        'InLength
        '
        Me.InLength.Location = New System.Drawing.Point(107, 397)
        Me.InLength.Name = "InLength"
        Me.InLength.Size = New System.Drawing.Size(100, 20)
        Me.InLength.TabIndex = 1
        '
        'InHeight
        '
        Me.InHeight.Location = New System.Drawing.Point(107, 432)
        Me.InHeight.Name = "InHeight"
        Me.InHeight.Size = New System.Drawing.Size(100, 20)
        Me.InHeight.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Span"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Length"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Height"
        '
        'InPitch
        '
        Me.InPitch.Location = New System.Drawing.Point(107, 470)
        Me.InPitch.Name = "InPitch"
        Me.InPitch.Size = New System.Drawing.Size(100, 20)
        Me.InPitch.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 470)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pitch"
        '
        'mm
        '
        Me.mm.AutoSize = True
        Me.mm.Location = New System.Drawing.Point(213, 369)
        Me.mm.Name = "mm"
        Me.mm.Size = New System.Drawing.Size(23, 13)
        Me.mm.TabIndex = 8
        Me.mm.Text = "mm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(213, 404)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "mm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "mm"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 473)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Degrees"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(397, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 303)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(70, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(670, 124)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Export_BOM
        '
        Me.Export_BOM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Export_BOM.Location = New System.Drawing.Point(346, 556)
        Me.Export_BOM.Name = "Export_BOM"
        Me.Export_BOM.Size = New System.Drawing.Size(99, 23)
        Me.Export_BOM.TabIndex = 15
        Me.Export_BOM.Text = "Export BOM"
        Me.Export_BOM.UseVisualStyleBackColor = True
        '
        'Export_Drawing
        '
        Me.Export_Drawing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Export_Drawing.Location = New System.Drawing.Point(216, 556)
        Me.Export_Drawing.Name = "Export_Drawing"
        Me.Export_Drawing.Size = New System.Drawing.Size(98, 23)
        Me.Export_Drawing.TabIndex = 16
        Me.Export_Drawing.Text = "Export Drawing"
        Me.Export_Drawing.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Simple Portal Frame Design with Inventor API"
        '
        'FilepathDisplay
        '
        Me.FilepathDisplay.Location = New System.Drawing.Point(107, 310)
        Me.FilepathDisplay.Multiline = True
        Me.FilepathDisplay.Name = "FilepathDisplay"
        Me.FilepathDisplay.Size = New System.Drawing.Size(271, 20)
        Me.FilepathDisplay.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(649, 556)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 58)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Click to End"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(70, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 40)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Create Structure"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Select_Folder
        '
        Me.Select_Folder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Select_Folder.Location = New System.Drawing.Point(12, 308)
        Me.Select_Folder.Name = "Select_Folder"
        Me.Select_Folder.Size = New System.Drawing.Size(94, 23)
        Me.Select_Folder.TabIndex = 23
        Me.Select_Folder.Text = "Select Folder"
        Me.Select_Folder.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(786, 635)
        Me.Controls.Add(Me.Select_Folder)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FilepathDisplay)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Export_Drawing)
        Me.Controls.Add(Me.Export_BOM)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.mm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InPitch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InHeight)
        Me.Controls.Add(Me.InLength)
        Me.Controls.Add(Me.InSpan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InSpan As TextBox
    Friend WithEvents InLength As TextBox
    Friend WithEvents InHeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents InPitch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Export_BOM As Button
    Friend WithEvents Export_Drawing As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents FilepathDisplay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Select_Folder As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
