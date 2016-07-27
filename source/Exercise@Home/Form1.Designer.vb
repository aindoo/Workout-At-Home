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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.abs = New System.Windows.Forms.ImageList(Me.components)
        Me.arms = New System.Windows.Forms.ImageList(Me.components)
        Me.back = New System.Windows.Forms.ImageList(Me.components)
        Me.legs = New System.Windows.Forms.ImageList(Me.components)
        Me.setlist = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkoutDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeDirectoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecentWorkoutsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(793, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 71)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Begin Workout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 91)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(164, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 91)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 91)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = ":"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'abs
        '
        Me.abs.ImageStream = CType(resources.GetObject("abs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.abs.TransparentColor = System.Drawing.Color.Transparent
        Me.abs.Images.SetKeyName(0, "alternating knee check.gif")
        Me.abs.Images.SetKeyName(1, "alternating v ups.gif")
        Me.abs.Images.SetKeyName(2, "bench abs in and outs.gif")
        Me.abs.Images.SetKeyName(3, "bicycle crunches.gif")
        Me.abs.Images.SetKeyName(4, "body weight side to side.gif")
        Me.abs.Images.SetKeyName(5, "cross legged seated raise.gif")
        Me.abs.Images.SetKeyName(6, "crunch and punch.gif")
        Me.abs.Images.SetKeyName(7, "full leg raises.gif")
        Me.abs.Images.SetKeyName(8, "high knees.gif")
        Me.abs.Images.SetKeyName(9, "L crunches.gif")
        Me.abs.Images.SetKeyName(10, "Left and right oblique twists.gif")
        Me.abs.Images.SetKeyName(11, "left and right side isolated crunches.gif")
        Me.abs.Images.SetKeyName(12, "left in and outs.gif")
        Me.abs.Images.SetKeyName(13, "lower leg raises.gif")
        Me.abs.Images.SetKeyName(14, "mountain climbers.gif")
        Me.abs.Images.SetKeyName(15, "renegade pushups.gif")
        Me.abs.Images.SetKeyName(16, "seated circle crunches.gif")
        Me.abs.Images.SetKeyName(17, "seated leg scissors.gif")
        Me.abs.Images.SetKeyName(18, "seated twists.gif")
        Me.abs.Images.SetKeyName(19, "side plank.gif")
        Me.abs.Images.SetKeyName(20, "single leg crunches.gif")
        Me.abs.Images.SetKeyName(21, "sit thrusts.gif")
        Me.abs.Images.SetKeyName(22, "spring ups.gif")
        Me.abs.Images.SetKeyName(23, "stacked feet crunches.gif")
        Me.abs.Images.SetKeyName(24, "superman walkouts.gif")
        Me.abs.Images.SetKeyName(25, "toe touches.gif")
        Me.abs.Images.SetKeyName(26, "twisters.gif")
        Me.abs.Images.SetKeyName(27, "unilateral side oblique twists.gif")
        '
        'arms
        '
        Me.arms.ImageStream = CType(resources.GetObject("arms.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.arms.TransparentColor = System.Drawing.Color.Transparent
        Me.arms.Images.SetKeyName(0, "air sit front raise.gif")
        Me.arms.Images.SetKeyName(1, "alternating bicep curls.gif")
        Me.arms.Images.SetKeyName(2, "alternating hammer curls.gif")
        Me.arms.Images.SetKeyName(3, "bear huges.gif")
        Me.arms.Images.SetKeyName(4, "biceps 90 hold.gif")
        Me.arms.Images.SetKeyName(5, "clapping push ups.gif")
        Me.arms.Images.SetKeyName(6, "close push ups.gif")
        Me.arms.Images.SetKeyName(7, "dips.gif")
        Me.arms.Images.SetKeyName(8, "dive bombers.gif")
        Me.arms.Images.SetKeyName(9, "double dumbbell.gif")
        Me.arms.Images.SetKeyName(10, "dumbbell biceps curls.gif")
        Me.arms.Images.SetKeyName(11, "dumbbell front raise.gif")
        Me.arms.Images.SetKeyName(12, "explosive rows.gif")
        Me.arms.Images.SetKeyName(13, "inverted rows.gif")
        Me.arms.Images.SetKeyName(14, "knee push ups.gif")
        Me.arms.Images.SetKeyName(15, "lateral raise.gif")
        Me.arms.Images.SetKeyName(16, "nejma.gif")
        Me.arms.Images.SetKeyName(17, "pike pushups.gif")
        Me.arms.Images.SetKeyName(18, "plank to tricep extend.gif")
        Me.arms.Images.SetKeyName(19, "pullups.gif")
        Me.arms.Images.SetKeyName(20, "pushouts.gif")
        Me.arms.Images.SetKeyName(21, "pushups.gif")
        Me.arms.Images.SetKeyName(22, "rear deltoids.gif")
        Me.arms.Images.SetKeyName(23, "renegade rows dumbbells.gif")
        Me.arms.Images.SetKeyName(24, "shadowboxing.gif")
        Me.arms.Images.SetKeyName(25, "shoulder explode.gif")
        Me.arms.Images.SetKeyName(26, "spiderman plank.gif")
        Me.arms.Images.SetKeyName(27, "spiderman walking pushups.gif")
        Me.arms.Images.SetKeyName(28, "squat and press with dumbbells.gif")
        Me.arms.Images.SetKeyName(29, "straight punching.gif")
        Me.arms.Images.SetKeyName(30, "superman walkouts.gif")
        Me.arms.Images.SetKeyName(31, "triceps press.gif")
        Me.arms.Images.SetKeyName(32, "tuck arms.gif")
        Me.arms.Images.SetKeyName(33, "upright row.gif")
        Me.arms.Images.SetKeyName(34, "wide pushups.gif")
        '
        'back
        '
        Me.back.ImageStream = CType(resources.GetObject("back.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.back.TransparentColor = System.Drawing.Color.Transparent
        Me.back.Images.SetKeyName(0, "back extension.gif")
        Me.back.Images.SetKeyName(1, "burpee clean pushup press.gif")
        Me.back.Images.SetKeyName(2, "burpees with dumbbells.gif")
        Me.back.Images.SetKeyName(3, "burpees.gif")
        Me.back.Images.SetKeyName(4, "sprawls.gif")
        Me.back.Images.SetKeyName(5, "stiff leg deadlift.gif")
        '
        'legs
        '
        Me.legs.ImageStream = CType(resources.GetObject("legs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.legs.TransparentColor = System.Drawing.Color.Transparent
        Me.legs.Images.SetKeyName(0, "burpee clean pushup press.gif")
        Me.legs.Images.SetKeyName(1, "burpees with dumbbells.gif")
        Me.legs.Images.SetKeyName(2, "burpees.gif")
        Me.legs.Images.SetKeyName(3, "calf raise.gif")
        Me.legs.Images.SetKeyName(4, "farmer squat.gif")
        Me.legs.Images.SetKeyName(5, "hip thrusts.gif")
        Me.legs.Images.SetKeyName(6, "jump jacks.gif")
        Me.legs.Images.SetKeyName(7, "jump squat.gif")
        Me.legs.Images.SetKeyName(8, "jumping lunges.gif")
        Me.legs.Images.SetKeyName(9, "lunges.gif")
        Me.legs.Images.SetKeyName(10, "prisoner squat.gif")
        Me.legs.Images.SetKeyName(11, "side to side skater jumps.gif")
        Me.legs.Images.SetKeyName(12, "sit thrusts.gif")
        Me.legs.Images.SetKeyName(13, "skipping rope.gif")
        Me.legs.Images.SetKeyName(14, "split squat.gif")
        Me.legs.Images.SetKeyName(15, "squat and press with dumbbells.gif")
        Me.legs.Images.SetKeyName(16, "squat.gif")
        Me.legs.Images.SetKeyName(17, "step ups.gif")
        Me.legs.Images.SetKeyName(18, "stiff leg deadlift.gif")
        Me.legs.Images.SetKeyName(19, "tuck jumps.gif")
        Me.legs.Images.SetKeyName(20, "twist lunges.gif")
        '
        'setlist
        '
        Me.setlist.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.setlist.ImageSize = New System.Drawing.Size(16, 16)
        Me.setlist.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Exercise_Home.My.Resources.Resources.burpee_clean_pushup_press
        Me.PictureBox1.Location = New System.Drawing.Point(0, -166)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(961, 634)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(395, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 468)
        Me.Panel1.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 73)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Rest"
        Me.Label12.Visible = False
        '
        'ListBox5
        '
        Me.ListBox5.AllowDrop = True
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(207, 49)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(148, 420)
        Me.ListBox5.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 491)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Set Interval:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(206, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Workout List:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Rest Interval:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 484)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(53, 20)
        Me.TextBox1.TabIndex = 39
        Me.TextBox1.Text = "mm"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(9, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(191, 442)
        Me.TabControl1.TabIndex = 49
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(183, 416)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Arms"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(183, 420)
        Me.ListBox1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(183, 416)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Legs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(0, 0)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(185, 420)
        Me.ListBox2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ListBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(183, 416)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Abs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(0, 0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(183, 420)
        Me.ListBox3.TabIndex = 16
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.ListBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(183, 416)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "Back"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(0, 0)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(185, 420)
        Me.ListBox4.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(224, 484)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(53, 20)
        Me.TextBox2.TabIndex = 40
        Me.TextBox2.Text = "ss"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "sec"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "min"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(211, 578)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 24)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Save Workout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "sec"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 516)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "min"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(224, 516)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(53, 20)
        Me.TextBox4.TabIndex = 43
        Me.TextBox4.Text = "ss"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 516)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(53, 20)
        Me.TextBox3.TabIndex = 44
        Me.TextBox3.Text = "mm"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(19, 578)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 24)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Load Workout"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(395, 114)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(479, 23)
        Me.ProgressBar1.TabIndex = 54
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(395, 33)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 71)
        Me.Button4.TabIndex = 55
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(119, 549)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(157, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Total Workout Duration=  00:00"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(879, 24)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkoutDatabaseToolStripMenuItem, Me.RecentWorkoutsToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'WorkoutDatabaseToolStripMenuItem
        '
        Me.WorkoutDatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeDirectoryToolStripMenuItem})
        Me.WorkoutDatabaseToolStripMenuItem.Name = "WorkoutDatabaseToolStripMenuItem"
        Me.WorkoutDatabaseToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.WorkoutDatabaseToolStripMenuItem.Text = "Exercise Database"
        '
        'ChangeDirectoryToolStripMenuItem
        '
        Me.ChangeDirectoryToolStripMenuItem.Name = "ChangeDirectoryToolStripMenuItem"
        Me.ChangeDirectoryToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ChangeDirectoryToolStripMenuItem.Text = "* Change directory *"
        '
        'RecentWorkoutsToolStripMenuItem
        '
        Me.RecentWorkoutsToolStripMenuItem.Name = "RecentWorkoutsToolStripMenuItem"
        Me.RecentWorkoutsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RecentWorkoutsToolStripMenuItem.Text = "Recent Workouts"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(361, 213)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(28, 27)
        Me.Button5.TabIndex = 58
        Me.Button5.Text = "↑"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(361, 246)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(28, 27)
        Me.Button6.TabIndex = 59
        Me.Button6.Text = "↓"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProgressBar2)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(36, 635)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 168)
        Me.Panel2.TabIndex = 60
        Me.Panel2.Visible = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(16, 121)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(408, 28)
        Me.ProgressBar2.TabIndex = 64
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(430, 121)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(106, 28)
        Me.Button7.TabIndex = 63
        Me.Button7.Text = "OK"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(16, 81)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(408, 20)
        Me.TextBox5.TabIndex = 62
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(430, 77)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(106, 24)
        Me.Button8.TabIndex = 61
        Me.Button8.Text = "Browse"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(289, 16)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Choose a folder to store/edit workout exercises:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(525, 25)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Looks like you're new, so let's set things up real quick"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(466, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(305, 119)
        Me.Panel3.TabIndex = 61
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 613)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(895, 652)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents abs As System.Windows.Forms.ImageList
    Friend WithEvents arms As System.Windows.Forms.ImageList
    Friend WithEvents back As System.Windows.Forms.ImageList
    Friend WithEvents legs As System.Windows.Forms.ImageList
    Friend WithEvents setlist As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkoutDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChangeDirectoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecentWorkoutsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel

End Class
