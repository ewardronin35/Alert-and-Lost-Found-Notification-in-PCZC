<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUpDean
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUpDean))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Idno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.confirmpass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dnUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CheckBox2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.stuFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stuCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwords = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1187, 54)
        Me.Panel1.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1132, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 31)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1236, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(104, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 28)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Dean ID No."
        '
        'Guna2Button2
        '
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 27
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(128, 598)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(333, 57)
        Me.Guna2Button2.TabIndex = 28
        Me.Guna2Button2.Text = "Sign Up"
        '
        'Idno
        '
        Me.Idno.AutoRoundedCorners = True
        Me.Idno.BackColor = System.Drawing.Color.Transparent
        Me.Idno.BorderColor = System.Drawing.Color.Black
        Me.Idno.BorderRadius = 18
        Me.Idno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Idno.DefaultText = ""
        Me.Idno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Idno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Idno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Idno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Idno.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Idno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idno.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Idno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Idno.Location = New System.Drawing.Point(104, 42)
        Me.Idno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Idno.Name = "Idno"
        Me.Idno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Idno.PlaceholderText = ""
        Me.Idno.SelectedText = ""
        Me.Idno.Size = New System.Drawing.Size(395, 39)
        Me.Idno.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(104, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 28)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Dean Full Name"
        '
        'confirmpass
        '
        Me.confirmpass.AutoRoundedCorners = True
        Me.confirmpass.BackColor = System.Drawing.Color.Transparent
        Me.confirmpass.BorderColor = System.Drawing.Color.Black
        Me.confirmpass.BorderRadius = 20
        Me.confirmpass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpass.DefaultText = ""
        Me.confirmpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpass.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.confirmpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpass.Location = New System.Drawing.Point(104, 479)
        Me.confirmpass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.confirmpass.Name = "confirmpass"
        Me.confirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmpass.PlaceholderText = ""
        Me.confirmpass.SelectedText = ""
        Me.confirmpass.Size = New System.Drawing.Size(392, 43)
        Me.confirmpass.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 28)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(95, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 28)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(420, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(430, 54)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "College Dean Sign Up"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dnUsername)
        Me.Panel2.Controls.Add(Me.Guna2CheckBox2)
        Me.Panel2.Controls.Add(Me.Guna2CheckBox1)
        Me.Panel2.Controls.Add(Me.stuFirstName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.stuCourse)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Guna2Button2)
        Me.Panel2.Controls.Add(Me.Idno)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.confirmpass)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.passwords)
        Me.Panel2.Location = New System.Drawing.Point(329, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(561, 725)
        Me.Panel2.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 28)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Dean Department"
        '
        'dnUsername
        '
        Me.dnUsername.AutoRoundedCorners = True
        Me.dnUsername.BackColor = System.Drawing.Color.Transparent
        Me.dnUsername.BorderColor = System.Drawing.Color.Black
        Me.dnUsername.BorderRadius = 21
        Me.dnUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dnUsername.DefaultText = ""
        Me.dnUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.dnUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dnUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dnUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.dnUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dnUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dnUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dnUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dnUsername.Location = New System.Drawing.Point(104, 202)
        Me.dnUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dnUsername.Name = "dnUsername"
        Me.dnUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dnUsername.PlaceholderText = ""
        Me.dnUsername.SelectedText = ""
        Me.dnUsername.Size = New System.Drawing.Size(395, 45)
        Me.dnUsername.TabIndex = 40
        '
        'Guna2CheckBox2
        '
        Me.Guna2CheckBox2.AutoSize = True
        Me.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox2.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox2.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CheckBox2.Location = New System.Drawing.Point(315, 529)
        Me.Guna2CheckBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CheckBox2.Name = "Guna2CheckBox2"
        Me.Guna2CheckBox2.Size = New System.Drawing.Size(161, 26)
        Me.Guna2CheckBox2.TabIndex = 39
        Me.Guna2CheckBox2.Text = "Show Password"
        Me.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox2.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox2.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(316, 428)
        Me.Guna2CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(161, 26)
        Me.Guna2CheckBox1.TabIndex = 38
        Me.Guna2CheckBox1.Text = "Show Password"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'stuFirstName
        '
        Me.stuFirstName.AutoRoundedCorners = True
        Me.stuFirstName.BackColor = System.Drawing.Color.Transparent
        Me.stuFirstName.BorderColor = System.Drawing.Color.Black
        Me.stuFirstName.BorderRadius = 21
        Me.stuFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stuFirstName.DefaultText = ""
        Me.stuFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stuFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stuFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stuFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stuFirstName.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.stuFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stuFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.stuFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stuFirstName.Location = New System.Drawing.Point(104, 119)
        Me.stuFirstName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stuFirstName.Name = "stuFirstName"
        Me.stuFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stuFirstName.PlaceholderText = ""
        Me.stuFirstName.SelectedText = ""
        Me.stuFirstName.Size = New System.Drawing.Size(395, 45)
        Me.stuFirstName.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 28)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Dean Username"
        '
        'stuCourse
        '
        Me.stuCourse.AutoRoundedCorners = True
        Me.stuCourse.BackColor = System.Drawing.Color.Transparent
        Me.stuCourse.BorderColor = System.Drawing.Color.Black
        Me.stuCourse.BorderRadius = 19
        Me.stuCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.stuCourse.DefaultText = ""
        Me.stuCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.stuCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.stuCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stuCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.stuCourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.stuCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stuCourse.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.stuCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stuCourse.Location = New System.Drawing.Point(104, 295)
        Me.stuCourse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stuCourse.Name = "stuCourse"
        Me.stuCourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.stuCourse.PlaceholderText = ""
        Me.stuCourse.SelectedText = ""
        Me.stuCourse.Size = New System.Drawing.Size(392, 40)
        Me.stuCourse.TabIndex = 33
        '
        'passwords
        '
        Me.passwords.AutoRoundedCorners = True
        Me.passwords.BackColor = System.Drawing.Color.Transparent
        Me.passwords.BorderColor = System.Drawing.Color.Black
        Me.passwords.BorderRadius = 20
        Me.passwords.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwords.DefaultText = ""
        Me.passwords.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwords.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwords.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwords.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwords.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.passwords.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwords.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwords.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwords.Location = New System.Drawing.Point(104, 378)
        Me.passwords.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.passwords.Name = "passwords"
        Me.passwords.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwords.PlaceholderText = ""
        Me.passwords.SelectedText = ""
        Me.passwords.Size = New System.Drawing.Size(392, 43)
        Me.passwords.TabIndex = 25
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel1.Controls.Add(Me.Panel2)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(3, 1)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1173, 859)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'SignUpDean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 818)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SignUpDean"
        Me.Text = "SignUpDean"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Idno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents confirmpass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2CheckBox2 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents stuFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents stuCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents passwords As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dnUsername As Guna.UI2.WinForms.Guna2TextBox
End Class
