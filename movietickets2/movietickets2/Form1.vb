Public Class MovieTicketPreorder
    Dim TaxRate As Decimal = 0.0825
    Dim discount As Decimal
    Dim Tax As Decimal
    Dim Pretaxtotal As Decimal

    Private Sub Btn_Calc_Click(sender As Object, e As EventArgs) Handles Btn_Calc.Click

        Textbox_subtotal.Text = (Textbox_ticketinput.Text * 10)

        If (Checkbox_vet.Checked) = True Then
            discount = (Textbox_subtotal.Text * 0.2)
            Pretaxtotal = (Textbox_subtotal.Text - discount)
            Tax = (Textbox_subtotal.Text - discount) * TaxRate

            Textbox_total.Text = (Pretaxtotal + Tax)
        End If

        If (Checkbox_vet.Checked) = False Then
            Textbox_subtotal.Text = (Textbox_ticketinput.Text * 10)
            Pretaxtotal = (Textbox_subtotal.Text)
            Tax = (Textbox_subtotal.Text) * TaxRate
            Textbox_total.Text = (Pretaxtotal + Tax)
        End If

    End Sub

    Private Sub Btn_exit_Click(sender As Object, e As EventArgs) Handles Btn_exit.Click

    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click

    End Sub

    Private Sub Checkbox_vet_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_vet.CheckedChanged

    End Sub

    Private Sub Textbox_ticketinput_TextChanged(sender As Object, e As EventArgs) Handles Textbox_ticketinput.TextChanged

    End Sub

    Private Sub Textbox_tax_TextChanged(sender As Object, e As EventArgs) Handles Textbox_tax.TextChanged

    End Sub

    Private Sub Textbox_total_TextChanged(sender As Object, e As EventArgs) Handles Textbox_total.TextChanged

    End Sub

    Private Sub Textbox_subtotal_TextChanged(sender As Object, e As EventArgs) Handles Textbox_subtotal.TextChanged

    End Sub

    Private Sub Lbl_title_Click(sender As Object, e As EventArgs) Handles Lbl_title.Click

    End Sub

    Private Sub Lbl_tickets_Click(sender As Object, e As EventArgs) Handles Lbl_tickets.Click

    End Sub

    Private Sub Lbl_subtotal_Click(sender As Object, e As EventArgs) Handles Lbl_subtotal.Click

    End Sub

    Private Sub Lbl_total_Click(sender As Object, e As EventArgs) Handles Lbl_total.Click

    End Sub

    Private Sub Lbl_taxrate_Click(sender As Object, e As EventArgs) Handles Lbl_taxrate.Click

    End Sub
End Class
