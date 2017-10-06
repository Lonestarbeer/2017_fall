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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.TextBoxOutput = New System.Windows.Forms.TextBox()
        Me.btnC2F = New System.Windows.Forms.Button()
        Me.btnF2C = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(290, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conversion Calculator Ver 1.0"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(500, 117)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(76, 25)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(149, 117)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(59, 25)
        Me.lblInput.TabIndex = 2
        Me.lblInput.Text = "Input"
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInput.Location = New System.Drawing.Point(251, 117)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(100, 31)
        Me.TextBoxInput.TabIndex = 3
        '
        'TextBoxOutput
        '
        Me.TextBoxOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOutput.Location = New System.Drawing.Point(607, 117)
        Me.TextBoxOutput.Name = "TextBoxOutput"
        Me.TextBoxOutput.Size = New System.Drawing.Size(100, 31)
        Me.TextBoxOutput.TabIndex = 4
        '
        'btnC2F
        '
        Me.btnC2F.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2F.Location = New System.Drawing.Point(154, 248)
        Me.btnC2F.Name = "btnC2F"
        Me.btnC2F.Size = New System.Drawing.Size(116, 50)
        Me.btnC2F.TabIndex = 5
        Me.btnC2F.Text = "C==>F"
        Me.btnC2F.UseVisualStyleBackColor = True
        '
        'btnF2C
        '
        Me.btnF2C.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF2C.Location = New System.Drawing.Point(295, 200)
        Me.btnF2C.Name = "btnF2C"
        Me.btnF2C.Size = New System.Drawing.Size(116, 50)
        Me.btnF2C.TabIndex = 6
        Me.btnF2C.Text = "F==>C"
        Me.btnF2C.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(12, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 50)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(801, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSpanish
        '
        Me.btnSpanish.BackgroundImage = Global.ConversionCalculator1.My.Resources.Resources.spain
        Me.btnSpanish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSpanish.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpanish.Location = New System.Drawing.Point(724, 12)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(93, 43)
        Me.btnSpanish.TabIndex = 9
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'btnEnglish
        '
        Me.btnEnglish.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnglish.Location = New System.Drawing.Point(614, 15)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(93, 40)
        Me.btnEnglish.TabIndex = 10
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(438, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "F==>C"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(781, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 50)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "F==>C"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(295, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 50)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "F==>C"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(282, 352)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(405, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(201, 26)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 250)
        Me.WebBrowser1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 443)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEnglish)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnF2C)
        Me.Controls.Add(Me.btnC2F)
        Me.Controls.Add(Me.TextBoxOutput)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Conversion Calculator (c) Dr. Azuaje 2017"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents btnC2F As Button
    Friend WithEvents btnF2C As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSpanish As Button
    Friend WithEvents btnEnglish As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
