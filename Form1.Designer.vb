<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lbEnterWord = New Label()
        ListBox1 = New ListBox()
        btnAdd = New Button()
        rbtnLCase = New RadioButton()
        rbtnUCase = New RadioButton()
        rbtnPurple = New RadioButton()
        rbtnBlue = New RadioButton()
        txtEnterWord = New TextBox()
        lbGrouBox = New Label()
        gbCase = New GroupBox()
        gbColor = New GroupBox()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Button1 = New Button()
        gbCase.SuspendLayout()
        gbColor.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbEnterWord
        ' 
        lbEnterWord.AutoSize = True
        lbEnterWord.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lbEnterWord.Location = New Point(269, 46)
        lbEnterWord.Name = "lbEnterWord"
        lbEnterWord.Size = New Size(101, 20)
        lbEnterWord.TabIndex = 0
        lbEnterWord.Text = "Enter a Word"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Items.AddRange(New Object() {"Hi!", "Hello World!", "GoodMorning"})
        ListBox1.Location = New Point(241, 184)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(184, 104)
        ListBox1.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.ForeColor = SystemColors.Desktop
        btnAdd.Location = New Point(289, 119)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(91, 43)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add Word"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' rbtnLCase
        ' 
        rbtnLCase.AutoSize = True
        rbtnLCase.Location = New Point(6, 26)
        rbtnLCase.Name = "rbtnLCase"
        rbtnLCase.Size = New Size(67, 24)
        rbtnLCase.TabIndex = 5
        rbtnLCase.TabStop = True
        rbtnLCase.Text = "LCase"
        rbtnLCase.UseVisualStyleBackColor = True
        ' 
        ' rbtnUCase
        ' 
        rbtnUCase.AutoSize = True
        rbtnUCase.Location = New Point(6, 50)
        rbtnUCase.Name = "rbtnUCase"
        rbtnUCase.Size = New Size(71, 24)
        rbtnUCase.TabIndex = 6
        rbtnUCase.TabStop = True
        rbtnUCase.Text = "UCase"
        rbtnUCase.UseVisualStyleBackColor = True
        ' 
        ' rbtnPurple
        ' 
        rbtnPurple.AutoSize = True
        rbtnPurple.Location = New Point(6, 26)
        rbtnPurple.Name = "rbtnPurple"
        rbtnPurple.Size = New Size(72, 24)
        rbtnPurple.TabIndex = 7
        rbtnPurple.TabStop = True
        rbtnPurple.Text = "Purple"
        rbtnPurple.UseVisualStyleBackColor = True
        ' 
        ' rbtnBlue
        ' 
        rbtnBlue.AutoSize = True
        rbtnBlue.Location = New Point(6, 56)
        rbtnBlue.Name = "rbtnBlue"
        rbtnBlue.Size = New Size(59, 24)
        rbtnBlue.TabIndex = 8
        rbtnBlue.TabStop = True
        rbtnBlue.Text = "Blue"
        rbtnBlue.UseVisualStyleBackColor = True
        ' 
        ' txtEnterWord
        ' 
        txtEnterWord.Location = New Point(219, 86)
        txtEnterWord.Name = "txtEnterWord"
        txtEnterWord.Size = New Size(233, 27)
        txtEnterWord.TabIndex = 9
        ' 
        ' lbGrouBox
        ' 
        lbGrouBox.BackColor = Color.White
        lbGrouBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbGrouBox.LiveSetting = Automation.AutomationLiveSetting.Polite
        lbGrouBox.Location = New Point(241, 304)
        lbGrouBox.Name = "lbGrouBox"
        lbGrouBox.Size = New Size(184, 28)
        lbGrouBox.TabIndex = 10
        lbGrouBox.Text = "                                           i"
        ' 
        ' gbCase
        ' 
        gbCase.Controls.Add(rbtnLCase)
        gbCase.Controls.Add(rbtnUCase)
        gbCase.Location = New Point(139, 353)
        gbCase.Name = "gbCase"
        gbCase.Size = New Size(89, 85)
        gbCase.TabIndex = 11
        gbCase.TabStop = False
        gbCase.Text = "Case"
        ' 
        ' gbColor
        ' 
        gbColor.Controls.Add(rbtnPurple)
        gbColor.Controls.Add(rbtnBlue)
        gbColor.Location = New Point(387, 353)
        gbColor.Name = "gbColor"
        gbColor.Size = New Size(99, 85)
        gbColor.TabIndex = 12
        gbColor.TabStop = False
        gbColor.Text = "Color"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(23, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 13
        Label1.Text = "Date_Time"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(572, 379)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 45)
        Button1.TabIndex = 14
        Button1.Text = "Exit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(674, 483)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(gbColor)
        Controls.Add(gbCase)
        Controls.Add(lbGrouBox)
        Controls.Add(txtEnterWord)
        Controls.Add(btnAdd)
        Controls.Add(ListBox1)
        Controls.Add(lbEnterWord)
        Name = "Form1"
        Text = "Words"
        gbCase.ResumeLayout(False)
        gbCase.PerformLayout()
        gbColor.ResumeLayout(False)
        gbColor.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbEnterWord As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents rbtnLCase As RadioButton
    Friend WithEvents rbtnUCase As RadioButton
    Friend WithEvents rbtnPurple As RadioButton
    Friend WithEvents rbtnBlue As RadioButton
    Friend WithEvents txtEnterWord As TextBox
    Friend WithEvents lbGrouBox As Label
    Friend WithEvents gbCase As GroupBox
    Friend WithEvents gbColor As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
