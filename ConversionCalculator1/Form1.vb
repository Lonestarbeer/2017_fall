Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBoxInput.Text = "" 'this is to clear my textboxInput
        TextBoxOutput.Clear()
    End Sub

    Private Sub btnC2F_Click(sender As Object, e As EventArgs) Handles btnC2F.Click
        TextBoxOutput.Text = (TextBoxInput.Text * 1.8) + 32
    End Sub

    Private Sub btnKorean_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblInput.Text = "Entrada"
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        lblInput.Text = "Input"
    End Sub

    Private Sub lblInput_Click(sender As Object, e As EventArgs) Handles lblInput.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DateTimePicker1_VisibleChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.VisibleChanged

    End Sub
End Class
