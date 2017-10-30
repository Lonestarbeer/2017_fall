<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MovieTicketPreorder
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
        Me.Checkbox_vet = New System.Windows.Forms.CheckBox()
        Me.Btn_Calc = New System.Windows.Forms.Button()
        Me.Btn_clear = New System.Windows.Forms.Button()
        Me.Btn_exit = New System.Windows.Forms.Button()
        Me.Lbl_title = New System.Windows.Forms.Label()
        Me.Lbl_tickets = New System.Windows.Forms.Label()
        Me.Lbl_taxrate = New System.Windows.Forms.Label()
        Me.Lbl_total = New System.Windows.Forms.Label()
        Me.Lbl_subtotal = New System.Windows.Forms.Label()
        Me.Textbox_ticketinput = New System.Windows.Forms.TextBox()
        Me.Textbox_subtotal = New System.Windows.Forms.TextBox()
        Me.Textbox_tax = New System.Windows.Forms.TextBox()
        Me.Textbox_total = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Checkbox_vet
        '
        Me.Checkbox_vet.AutoSize = True
        Me.Checkbox_vet.Location = New System.Drawing.Point(136, 125)
        Me.Checkbox_vet.Name = "Checkbox_vet"
        Me.Checkbox_vet.Size = New System.Drawing.Size(129, 17)
        Me.Checkbox_vet.TabIndex = 0
        Me.Checkbox_vet.Text = "Veteran/Active Duty?"
        Me.Checkbox_vet.UseVisualStyleBackColor = True
        '
        'Btn_Calc
        '
        Me.Btn_Calc.Location = New System.Drawing.Point(225, 182)
        Me.Btn_Calc.Name = "Btn_Calc"
        Me.Btn_Calc.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Calc.TabIndex = 1
        Me.Btn_Calc.Text = "Calc"
        Me.Btn_Calc.UseVisualStyleBackColor = True
        '
        'Btn_clear
        '
        Me.Btn_clear.Location = New System.Drawing.Point(103, 182)
        Me.Btn_clear.Name = "Btn_clear"
        Me.Btn_clear.Size = New System.Drawing.Size(44, 23)
        Me.Btn_clear.TabIndex = 2
        Me.Btn_clear.Text = "CLR"
        Me.Btn_clear.UseVisualStyleBackColor = True
        '
        'Btn_exit
        '
        Me.Btn_exit.Location = New System.Drawing.Point(72, 353)
        Me.Btn_exit.Name = "Btn_exit"
        Me.Btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_exit.TabIndex = 3
        Me.Btn_exit.Text = "EXIT"
        Me.Btn_exit.UseVisualStyleBackColor = True
        '
        'Lbl_title
        '
        Me.Lbl_title.AutoSize = True
        Me.Lbl_title.Location = New System.Drawing.Point(142, 9)
        Me.Lbl_title.Name = "Lbl_title"
        Me.Lbl_title.Size = New System.Drawing.Size(112, 13)
        Me.Lbl_title.TabIndex = 4
        Me.Lbl_title.Text = "Movie Ticket Preorder"
        '
        'Lbl_tickets
        '
        Me.Lbl_tickets.AutoSize = True
        Me.Lbl_tickets.Location = New System.Drawing.Point(45, 71)
        Me.Lbl_tickets.Name = "Lbl_tickets"
        Me.Lbl_tickets.Size = New System.Drawing.Size(94, 13)
        Me.Lbl_tickets.TabIndex = 5
        Me.Lbl_tickets.Text = "Number of Tickets"
        '
        'Lbl_taxrate
        '
        Me.Lbl_taxrate.AutoSize = True
        Me.Lbl_taxrate.Location = New System.Drawing.Point(254, 278)
        Me.Lbl_taxrate.Name = "Lbl_taxrate"
        Me.Lbl_taxrate.Size = New System.Drawing.Size(25, 13)
        Me.Lbl_taxrate.TabIndex = 6
        Me.Lbl_taxrate.Text = "Tax"
        '
        'Lbl_total
        '
        Me.Lbl_total.AutoSize = True
        Me.Lbl_total.Location = New System.Drawing.Point(254, 314)
        Me.Lbl_total.Name = "Lbl_total"
        Me.Lbl_total.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_total.TabIndex = 7
        Me.Lbl_total.Text = "Total"
        '
        'Lbl_subtotal
        '
        Me.Lbl_subtotal.AutoSize = True
        Me.Lbl_subtotal.Location = New System.Drawing.Point(254, 248)
        Me.Lbl_subtotal.Name = "Lbl_subtotal"
        Me.Lbl_subtotal.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_subtotal.TabIndex = 8
        Me.Lbl_subtotal.Text = "Subtotal"
        '
        'Textbox_ticketinput
        '
        Me.Textbox_ticketinput.Location = New System.Drawing.Point(145, 68)
        Me.Textbox_ticketinput.Name = "Textbox_ticketinput"
        Me.Textbox_ticketinput.Size = New System.Drawing.Size(100, 20)
        Me.Textbox_ticketinput.TabIndex = 9
        '
        'Textbox_subtotal
        '
        Me.Textbox_subtotal.Location = New System.Drawing.Point(181, 241)
        Me.Textbox_subtotal.Name = "Textbox_subtotal"
        Me.Textbox_subtotal.Size = New System.Drawing.Size(55, 20)
        Me.Textbox_subtotal.TabIndex = 10
        '
        'Textbox_tax
        '
        Me.Textbox_tax.Location = New System.Drawing.Point(195, 275)
        Me.Textbox_tax.Name = "Textbox_tax"
        Me.Textbox_tax.Size = New System.Drawing.Size(41, 20)
        Me.Textbox_tax.TabIndex = 11
        Me.Textbox_tax.Text = "8.25%"
        '
        'Textbox_total
        '
        Me.Textbox_total.Location = New System.Drawing.Point(181, 311)
        Me.Textbox_total.Name = "Textbox_total"
        Me.Textbox_total.Size = New System.Drawing.Size(55, 20)
        Me.Textbox_total.TabIndex = 12
        '
        'MovieTicketPreorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(455, 415)
        Me.Controls.Add(Me.Textbox_total)
        Me.Controls.Add(Me.Textbox_tax)
        Me.Controls.Add(Me.Textbox_subtotal)
        Me.Controls.Add(Me.Textbox_ticketinput)
        Me.Controls.Add(Me.Lbl_subtotal)
        Me.Controls.Add(Me.Lbl_total)
        Me.Controls.Add(Me.Lbl_taxrate)
        Me.Controls.Add(Me.Lbl_tickets)
        Me.Controls.Add(Me.Lbl_title)
        Me.Controls.Add(Me.Btn_exit)
        Me.Controls.Add(Me.Btn_clear)
        Me.Controls.Add(Me.Btn_Calc)
        Me.Controls.Add(Me.Checkbox_vet)
        Me.Name = "MovieTicketPreorder"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Checkbox_vet As CheckBox
    Friend WithEvents Btn_Calc As Button
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Btn_exit As Button
    Friend WithEvents Lbl_title As Label
    Friend WithEvents Lbl_tickets As Label
    Friend WithEvents Lbl_taxrate As Label
    Friend WithEvents Lbl_total As Label
    Friend WithEvents Lbl_subtotal As Label
    Friend WithEvents Textbox_ticketinput As TextBox
    Friend WithEvents Textbox_subtotal As TextBox
    Friend WithEvents Textbox_tax As TextBox
    Friend WithEvents Textbox_total As TextBox
End Class
