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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.title_heading = New System.Windows.Forms.Label()
        Me.input_label = New System.Windows.Forms.Label()
        Me.output_label = New System.Windows.Forms.Label()
        Me.text_input = New System.Windows.Forms.TextBox()
        Me.text_output = New System.Windows.Forms.TextBox()
        Me.btn_c2f = New System.Windows.Forms.Button()
        Me.btn_f2c = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_korean = New System.Windows.Forms.Button()
        Me.btn_english = New System.Windows.Forms.Button()
        Me.btn_usd_krw = New System.Windows.Forms.Button()
        Me.btn_krw_usd = New System.Windows.Forms.Button()
        Me.btn_lbs_kilo = New System.Windows.Forms.Button()
        Me.btn_km_mile = New System.Windows.Forms.Button()
        Me.btn_kilo_lbs = New System.Windows.Forms.Button()
        Me.btn_mile_km = New System.Windows.Forms.Button()
        Me.t_t = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'title_heading
        '
        Me.title_heading.AutoSize = True
        Me.title_heading.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.title_heading.Location = New System.Drawing.Point(397, 9)
        Me.title_heading.Name = "title_heading"
        Me.title_heading.Size = New System.Drawing.Size(74, 19)
        Me.title_heading.TabIndex = 0
        Me.title_heading.Text = "공학계산기"
        '
        'input_label
        '
        Me.input_label.AutoSize = True
        Me.input_label.BackColor = System.Drawing.Color.DarkGray
        Me.input_label.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.input_label.Location = New System.Drawing.Point(352, 117)
        Me.input_label.Name = "input_label"
        Me.input_label.Size = New System.Drawing.Size(35, 19)
        Me.input_label.TabIndex = 2
        Me.input_label.Text = "입력"
        '
        'output_label
        '
        Me.output_label.AutoSize = True
        Me.output_label.BackColor = System.Drawing.Color.DarkGray
        Me.output_label.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.output_label.Location = New System.Drawing.Point(463, 154)
        Me.output_label.Name = "output_label"
        Me.output_label.Size = New System.Drawing.Size(61, 19)
        Me.output_label.TabIndex = 1
        Me.output_label.Text = "산출하다"
        '
        'text_input
        '
        Me.text_input.BackColor = System.Drawing.Color.LightSkyBlue
        Me.text_input.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.text_input.Location = New System.Drawing.Point(402, 114)
        Me.text_input.Name = "text_input"
        Me.text_input.Size = New System.Drawing.Size(137, 26)
        Me.text_input.TabIndex = 3
        '
        'text_output
        '
        Me.text_output.BackColor = System.Drawing.Color.Wheat
        Me.text_output.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.text_output.Location = New System.Drawing.Point(357, 151)
        Me.text_output.Name = "text_output"
        Me.text_output.Size = New System.Drawing.Size(100, 26)
        Me.text_output.TabIndex = 4
        '
        'btn_c2f
        '
        Me.btn_c2f.BackColor = System.Drawing.Color.Firebrick
        Me.btn_c2f.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_c2f.ForeColor = System.Drawing.Color.Silver
        Me.btn_c2f.Location = New System.Drawing.Point(62, 211)
        Me.btn_c2f.Name = "btn_c2f"
        Me.btn_c2f.Size = New System.Drawing.Size(155, 60)
        Me.btn_c2f.TabIndex = 5
        Me.btn_c2f.Text = "섭씨->화씨"
        Me.t_t.SetToolTip(Me.btn_c2f, "°C => °F")
        Me.btn_c2f.UseVisualStyleBackColor = False
        '
        'btn_f2c
        '
        Me.btn_f2c.BackColor = System.Drawing.Color.Navy
        Me.btn_f2c.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_f2c.ForeColor = System.Drawing.Color.Silver
        Me.btn_f2c.Location = New System.Drawing.Point(31, 304)
        Me.btn_f2c.Name = "btn_f2c"
        Me.btn_f2c.Size = New System.Drawing.Size(155, 60)
        Me.btn_f2c.TabIndex = 6
        Me.btn_f2c.Text = "화씨->섭씨"
        Me.t_t.SetToolTip(Me.btn_f2c, "°F => °C ")
        Me.btn_f2c.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.DarkGray
        Me.btn_clear.Font = New System.Drawing.Font("Papyrus", 6.0!, System.Drawing.FontStyle.Bold)
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_clear.Location = New System.Drawing.Point(543, 116)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(60, 20)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Text = "삭제하다"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Black
        Me.btn_exit.Font = New System.Drawing.Font("Papyrus", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.MintCream
        Me.btn_exit.Location = New System.Drawing.Point(730, 429)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(116, 50)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_korean
        '
        Me.btn_korean.BackgroundImage = CType(resources.GetObject("btn_korean.BackgroundImage"), System.Drawing.Image)
        Me.btn_korean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_korean.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_korean.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_korean.Location = New System.Drawing.Point(617, 9)
        Me.btn_korean.Name = "btn_korean"
        Me.btn_korean.Size = New System.Drawing.Size(90, 55)
        Me.btn_korean.TabIndex = 9
        Me.btn_korean.UseVisualStyleBackColor = True
        '
        'btn_english
        '
        Me.btn_english.BackColor = System.Drawing.Color.Transparent
        Me.btn_english.BackgroundImage = CType(resources.GetObject("btn_english.BackgroundImage"), System.Drawing.Image)
        Me.btn_english.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_english.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_english.Font = New System.Drawing.Font("Papyrus", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_english.Location = New System.Drawing.Point(191, 9)
        Me.btn_english.Name = "btn_english"
        Me.btn_english.Size = New System.Drawing.Size(90, 55)
        Me.btn_english.TabIndex = 10
        Me.btn_english.UseVisualStyleBackColor = False
        '
        'btn_usd_krw
        '
        Me.btn_usd_krw.BackColor = System.Drawing.Color.Navy
        Me.btn_usd_krw.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_usd_krw.ForeColor = System.Drawing.Color.Silver
        Me.btn_usd_krw.Location = New System.Drawing.Point(251, 304)
        Me.btn_usd_krw.Name = "btn_usd_krw"
        Me.btn_usd_krw.Size = New System.Drawing.Size(155, 60)
        Me.btn_usd_krw.TabIndex = 11
        Me.btn_usd_krw.Text = "미국USD=>   원KRW"
        Me.btn_usd_krw.UseVisualStyleBackColor = False
        '
        'btn_krw_usd
        '
        Me.btn_krw_usd.BackColor = System.Drawing.Color.Firebrick
        Me.btn_krw_usd.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_krw_usd.ForeColor = System.Drawing.Color.Silver
        Me.btn_krw_usd.Location = New System.Drawing.Point(270, 211)
        Me.btn_krw_usd.Name = "btn_krw_usd"
        Me.btn_krw_usd.Size = New System.Drawing.Size(155, 60)
        Me.btn_krw_usd.TabIndex = 12
        Me.btn_krw_usd.Text = "원KRW=>     미국USD"
        Me.btn_krw_usd.UseVisualStyleBackColor = False
        '
        'btn_lbs_kilo
        '
        Me.btn_lbs_kilo.BackColor = System.Drawing.Color.Navy
        Me.btn_lbs_kilo.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_lbs_kilo.ForeColor = System.Drawing.Color.Silver
        Me.btn_lbs_kilo.Location = New System.Drawing.Point(667, 304)
        Me.btn_lbs_kilo.Name = "btn_lbs_kilo"
        Me.btn_lbs_kilo.Size = New System.Drawing.Size(155, 60)
        Me.btn_lbs_kilo.TabIndex = 13
        Me.btn_lbs_kilo.Text = "파운드=>       킬로그램"
        Me.btn_lbs_kilo.UseVisualStyleBackColor = False
        '
        'btn_km_mile
        '
        Me.btn_km_mile.BackColor = System.Drawing.Color.Firebrick
        Me.btn_km_mile.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_km_mile.ForeColor = System.Drawing.Color.Silver
        Me.btn_km_mile.Location = New System.Drawing.Point(485, 211)
        Me.btn_km_mile.Name = "btn_km_mile"
        Me.btn_km_mile.Size = New System.Drawing.Size(155, 60)
        Me.btn_km_mile.TabIndex = 16
        Me.btn_km_mile.Text = "  킬로미터=>  먼 거리"
        Me.btn_km_mile.UseVisualStyleBackColor = False
        '
        'btn_kilo_lbs
        '
        Me.btn_kilo_lbs.BackColor = System.Drawing.Color.Firebrick
        Me.btn_kilo_lbs.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_kilo_lbs.ForeColor = System.Drawing.Color.Silver
        Me.btn_kilo_lbs.Location = New System.Drawing.Point(692, 211)
        Me.btn_kilo_lbs.Name = "btn_kilo_lbs"
        Me.btn_kilo_lbs.Size = New System.Drawing.Size(155, 60)
        Me.btn_kilo_lbs.TabIndex = 17
        Me.btn_kilo_lbs.Text = "킬로그램=>    파운드"
        Me.btn_kilo_lbs.UseVisualStyleBackColor = False
        '
        'btn_mile_km
        '
        Me.btn_mile_km.BackColor = System.Drawing.Color.Navy
        Me.btn_mile_km.Font = New System.Drawing.Font("Papyrus", 9.0!)
        Me.btn_mile_km.ForeColor = System.Drawing.Color.Silver
        Me.btn_mile_km.Location = New System.Drawing.Point(463, 304)
        Me.btn_mile_km.Name = "btn_mile_km"
        Me.btn_mile_km.Size = New System.Drawing.Size(155, 60)
        Me.btn_mile_km.TabIndex = 18
        Me.btn_mile_km.Text = "먼 거리=>      킬로미터"
        Me.btn_mile_km.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(884, 491)
        Me.Controls.Add(Me.btn_english)
        Me.Controls.Add(Me.btn_mile_km)
        Me.Controls.Add(Me.btn_kilo_lbs)
        Me.Controls.Add(Me.btn_km_mile)
        Me.Controls.Add(Me.btn_lbs_kilo)
        Me.Controls.Add(Me.btn_krw_usd)
        Me.Controls.Add(Me.btn_usd_krw)
        Me.Controls.Add(Me.btn_korean)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_f2c)
        Me.Controls.Add(Me.btn_c2f)
        Me.Controls.Add(Me.text_output)
        Me.Controls.Add(Me.text_input)
        Me.Controls.Add(Me.input_label)
        Me.Controls.Add(Me.output_label)
        Me.Controls.Add(Me.title_heading)
        Me.Name = "Form1"
        Me.Text = "US-Korean Travel Conversion Calculator © Dr. Azuaje 2017—  Trevor Fields 2017"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title_heading As Label
    Friend WithEvents output_label As Label
    Friend WithEvents input_label As Label
    Friend WithEvents text_input As TextBox
    Friend WithEvents text_output As TextBox
    Friend WithEvents btn_c2f As Button
    Friend WithEvents btn_f2c As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_korean As Button
    Friend WithEvents btn_english As Button
    Friend WithEvents btn_usd_krw As Button
    Friend WithEvents btn_krw_usd As Button
    Friend WithEvents btn_lbs_kilo As Button
    Friend WithEvents btn_km_mile As Button
    Friend WithEvents btn_kilo_lbs As Button
    Friend WithEvents btn_mile_km As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
    Friend WithEvents ToolTip4 As ToolTip
    Friend WithEvents ToolTip5 As ToolTip
    Friend WithEvents ToolTip6 As ToolTip
    Friend WithEvents ToolTip7 As ToolTip
    Friend WithEvents ToolTip8 As ToolTip
    Friend WithEvents ToolTip9 As ToolTip
    Friend WithEvents ToolTip10 As ToolTip
    Friend WithEvents ToolTip11 As ToolTip
    Friend WithEvents USA As ToolTip
    Friend WithEvents Korea As ToolTip
    Friend WithEvents t_t As ToolTip
End Class