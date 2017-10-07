Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        text_input.Text = "" 'this is to clear my textboxInput
        text_output.Clear()
    End Sub
    Private Sub btnC2F_Click(sender As Object, e As EventArgs) Handles btn_c2f.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * 1.8) + 32
        End If
    End Sub

    Private Sub btnF2C_Click(sender As Object, e As EventArgs) Handles btn_f2c.Click
        If correct_input(text_input.Text) Then
            text_output.Text = ((text_input.Text - 32) * (5 / 9))
        End If
    End Sub

    Private Sub btnKRWusd(sender As Object, e As EventArgs) Handles btn_krw_usd.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * 0.000877)
        End If
    End Sub

    Private Sub btnUSDkrw(sender As Object, e As EventArgs) Handles btn_usd_krw.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * 1141.98)
        End If
    End Sub

    Private Sub kmMiles_Click(sender As Object, e As EventArgs) Handles btn_km_mile.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * (0.62))
        End If
    End Sub

    Private Sub milesKm_Click(sender As Object, e As EventArgs) Handles btn_mile_km.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * (1.609 / 1))
        End If
    End Sub

    Private Sub btnKGlbs(sender As Object, e As EventArgs) Handles btn_kilo_lbs.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * 2.2046226218)
        End If
    End Sub

    Private Sub btnLBSkg(sender As Object, e As EventArgs) Handles btn_lbs_kilo.Click
        If correct_input(text_input.Text) Then
            text_output.Text = (text_input.Text * 0.45359237)
        End If
    End Sub

    Private Sub btnKorean_Click(sender As Object, e As EventArgs) Handles btn_korean.Click
        lang_korean()

    End Sub
    Private Sub lang_korean()

        'lang_shown
        title_heading.Text = "US—Korean Travel Conversions"
        output_label.Text = "산출하다"
        input_label.Text = "입력"
        btn_c2f.Text = "섭씨->화씨"
        btn_f2c.Text = "화씨->섭씨"
        btn_usd_krw.Text = "미국USD=>   원KRW"
        btn_krw_usd.Text = "원KRW=>     미국USD"
        btn_mile_km.Text = "먼 거리=>      킬로미터"
        btn_km_mile.Text = "  킬로미터=>  먼 거리"
        btn_kilo_lbs.Text = "킬로그램=>    파운드"
        btn_lbs_kilo.Text = "파운드=>       킬로그램"
        btn_clear.Text = "삭제하다"
        btn_exit.Text = "출구"
        'tooltips
        t_t.SetToolTip(Me.output_label, "Output Field")
        t_t.SetToolTip(Me.input_label, "Input Field")
        t_t.SetToolTip(Me.btn_c2f, "°C => °F")
        t_t.SetToolTip(Me.btn_f2c, "°F => °C")
        t_t.SetToolTip(Me.btn_usd_krw, "USD => KRW")
        t_t.SetToolTip(Me.btn_krw_usd, "KRW => USD")
        t_t.SetToolTip(Me.btn_mile_km, "Miles => Kilometers")
        t_t.SetToolTip(Me.btn_km_mile, "Kilometers => Miles")
        t_t.SetToolTip(Me.btn_kilo_lbs, "Kilograms => Pounds")
        t_t.SetToolTip(Me.btn_lbs_kilo, "Pounds => Kilograms")

        t_t.SetToolTip(Me.btn_clear, "Clear Entries")
        t_t.SetToolTip(Me.btn_exit, "Exit the Program")
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btn_english.Click

        'lang_shown
        title_heading.Text = "민국—한국 공학계산기"
        input_label.Text = "Input"
        output_label.Text = "Output"
        btn_c2f.Text = "°C => °F"
        btn_f2c.Text = "°F => °C"
        btn_usd_krw.Text = "USD=>KRW"
        btn_krw_usd.Text = "KRW=>USD"
        btn_mile_km.Text = "Miles=>  Kilometers"
        btn_km_mile.Text = "Kilometers=>Miles"
        btn_kilo_lbs.Text = "Kilograms=>Pounds"
        btn_lbs_kilo.Text = "Pounds=>  Kilograms"
        btn_clear.Text = "Clear"
        btn_exit.Text = "Exit"
        'tooltips

        t_t.SetToolTip(Me.output_label, "산출하다")
        t_t.SetToolTip(Me.input_label, "입력")
        t_t.SetToolTip(Me.btn_c2f, "섭씨 => 화씨")
        t_t.SetToolTip(Me.btn_f2c, "화씨 => 섭씨")
        t_t.SetToolTip(Me.btn_usd_krw, "미국USD => 원KRW")
        t_t.SetToolTip(Me.btn_krw_usd, "원KRW => 미국USD")
        t_t.SetToolTip(Me.btn_mile_km, "먼 거리 => 킬로미터")
        t_t.SetToolTip(Me.btn_km_mile, "킬로미터 => 먼 거리")
        t_t.SetToolTip(Me.btn_kilo_lbs, "킬로그램 => 파운드")
        t_t.SetToolTip(Me.btn_lbs_kilo, "파운드 => 킬로그램")
        t_t.SetToolTip(Me.btn_clear, "삭제하다")
        t_t.SetToolTip(Me.btn_exit, "출구")


    End Sub

    Private Sub lblInput_Click(sender As Object, e As EventArgs) Handles input_label.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, text_output.TextChanged, text_input.TextChanged
        lang_korean()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles title_heading.Click

    End Sub

    Private Sub DateTimePicker1_VisibleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles output_label.Click

    End Sub

    Private Function correct_input(value As String) As Boolean
        Dim checked_value As Double
        If Not Double.TryParse(value, checked_value) Then
            Return False
        End If
        Return True
    End Function

End Class