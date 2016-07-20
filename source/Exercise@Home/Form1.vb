Imports System.IO


Public Class Form1
    Dim workoutdbdir
    Dim setduration
    Dim restduration
    Dim remainingduration
    Dim currentindex
    Dim status


    Private Function checknewuser()
        Dim preferencefi As New IO.FileInfo(Directory.GetCurrentDirectory() & "/pref.inf")
        If preferencefi.Exists Then

            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(preferencefi.FullName)
            workoutdbdir = fileReader.ReadLine

        Else
            MessageBox.Show("Looks like you're using this program for the first time. Let's set things up real quick.")
            Dim fileDlg As New FolderBrowserDialog
            fileDlg.Description = "Choose directory to save/add workout animations"
            If (fileDlg.ShowDialog() = DialogResult.OK) Then
                Dim workoutdb As New IO.DirectoryInfo(fileDlg.SelectedPath)

                If Directory.Exists(workoutdb.FullName & "/abs") Then

                Else
                    Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/abs")
                    Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/abs"

                    Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                    Dim files As IO.FileInfo() = dir.GetFiles()
                    For Each file In files
                        file.CopyTo(di.FullName & "/" & file.Name)
                    Next


                End If
                If Directory.Exists(workoutdb.FullName & "/arms") Then

                Else
                    Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/arms")
                    Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/arms"

                    Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                    Dim files As IO.FileInfo() = dir.GetFiles()
                    For Each file In files
                        file.CopyTo(di.FullName & "/" & file.Name)
                    Next

                End If
                If Directory.Exists(workoutdb.FullName & "/legs") Then

                Else
                    Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/legs")
                    Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/legs"

                    Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                    Dim files As IO.FileInfo() = dir.GetFiles()
                    For Each file In files
                        file.CopyTo(di.FullName & "/" & file.Name)
                    Next

                End If
                If Directory.Exists(workoutdb.FullName & "/back") Then

                Else
                    Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/back")
                    Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/backs"

                    Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                    Dim files As IO.FileInfo() = dir.GetFiles()
                    For Each file In files
                        file.CopyTo(di.FullName & "/" & file.Name)
                    Next

                End If


                Dim objWriter As New System.IO.StreamWriter(preferencefi.FullName, False)

                objWriter.WriteLine(fileDlg.SelectedPath)
                objWriter.Close()
                MessageBox.Show("Workout Database Populated @ " & fileDlg.SelectedPath)
                workoutdbdir = fileDlg.SelectedPath
            End If

        End If

    End Function

    Private Function initialize()

        Timer1.Interval = 1000
        Timer2.Interval = 1000
        Timer1.Enabled = False
        Timer2.Enabled = False

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()

        Dim dra As IO.FileInfo

        Dim abs As New IO.DirectoryInfo(workoutdbdir & "\abs")
        Dim arms As New IO.DirectoryInfo(workoutdbdir & "\arms")
        Dim legs As New IO.DirectoryInfo(workoutdbdir & "\legs")
        Dim back As New IO.DirectoryInfo(workoutdbdir & "\back")


        Dim arms1 As IO.FileInfo() = arms.GetFiles()
        For Each dra In arms1
            ListBox1.Items.Add(dra)
        Next
        Dim legs1 As IO.FileInfo() = legs.GetFiles()
        For Each dra In legs1
            ListBox2.Items.Add(dra)
        Next
        Dim abs1 As IO.FileInfo() = abs.GetFiles()
        For Each dra In abs1
            ListBox3.Items.Add(dra)
        Next
        Dim back1 As IO.FileInfo() = back.GetFiles()
        For Each dra In back1
            ListBox4.Items.Add(dra)
        Next

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checknewuser()
        initialize()


    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim pictureurl As IO.FileInfo = ListBox1.SelectedItem
        PictureBox1.ImageLocation = pictureurl.FullName
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim pictureurl As IO.FileInfo = ListBox2.SelectedItem
        PictureBox1.ImageLocation = pictureurl.FullName
    End Sub
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim pictureurl As IO.FileInfo = ListBox3.SelectedItem
        PictureBox1.ImageLocation = pictureurl.FullName
    End Sub
    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        Dim pictureurl As IO.FileInfo = ListBox4.SelectedItem
        PictureBox1.ImageLocation = pictureurl.FullName
    End Sub
    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        If ListBox5.SelectedIndex <> -1 Then
            Dim pictureurl As IO.FileInfo = ListBox5.SelectedItem
            PictureBox1.ImageLocation = pictureurl.FullName
        End If
    End Sub


    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        ListBox5.Items.Add(ListBox1.SelectedItem)
    End Sub
    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        ListBox5.Items.Add(ListBox2.SelectedItem)
    End Sub
    Private Sub ListBox3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox3.MouseDoubleClick
        ListBox5.Items.Add(ListBox3.SelectedItem)
    End Sub
    Private Sub ListBox4_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox4.MouseDoubleClick
        ListBox5.Items.Add(ListBox4.SelectedItem)
    End Sub
    Private Sub ListBox5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox5.MouseDoubleClick
        ListBox5.Items.Remove(ListBox5.SelectedItem)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Begin Workout") Then

            If (TextBox1.Text = "" Or TextBox1.Text = "mm") Then
                TextBox1.Text = "00"
            End If
            If (TextBox2.Text = "" Or TextBox2.Text = "ss") Then
                TextBox2.Text = "60"
            End If
            If (TextBox3.Text = "" Or TextBox3.Text = "mm") Then
                TextBox3.Text = "00"
            End If
            If (TextBox4.Text = "" Or TextBox4.Text = "ss") Then
                TextBox4.Text = "15"
            End If

            setduration = TextBox1.Text * 60 + TextBox2.Text
            restduration = TextBox3.Text * 60 + TextBox4.Text
            remainingduration = setduration
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = setduration
            currentindex = 0
            PictureBox1.ImageLocation = ListBox5.Items.Item(currentindex).FullName
            Timer1.Enabled = True
            Dim totalworkoutduration = setduration * ListBox5.Items.Count + restduration * (ListBox5.Items.Count - 1)
            Dim totalworkoutdurationmm = Math.Sign(totalworkoutduration / 60) * Math.Floor(Math.Abs(totalworkoutduration / 60))
            Dim totalworkoutdurationss = totalworkoutduration - totalworkoutdurationmm * 60
            Label11.Text = "Total Workout Duration= " & totalworkoutdurationmm & " min" & totalworkoutdurationss & " sec"
            Button1.Text = "Pause Workout"
        ElseIf (Button1.Text = "Pause Workout") Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Button1.Text = "Resume Workout"

        ElseIf (Button1.Text = "Resume Workout") Then
            If status = "rest" Then
                Timer2.Enabled = True
            Else
                Timer1.Enabled = True
            End If
            Beep()
            Button1.Text = "Pause Workout"
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        remainingduration = remainingduration - Timer1.Interval / 1000

        If (remainingduration >= 0) Then
            Dim remainingmin = Math.Sign(remainingduration / 60) * Math.Floor(Math.Abs(remainingduration / 60))
            Dim remainingsec = remainingduration - remainingmin * 60
            ProgressBar1.Value = setduration - remainingduration
            Label7.Text = remainingmin
            Label8.Text = remainingsec
            status = "active"
        Else
            Beep()
            Timer1.Enabled = False
            remainingduration = restduration
            status = "rest"
            If (currentindex + 1 < ListBox5.Items.Count) Then
                currentindex = currentindex + 1
                PictureBox1.ImageLocation = ListBox5.Items.Item(currentindex).FullName
                Timer2.Enabled = True
            Else
                MessageBox.Show("WORKOUT COMPLETE!!!")
                Button1.Text = "Begin Workout"
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        remainingduration = remainingduration - Timer2.Interval / 1000

        If (remainingduration >= 0) Then
            Dim remainingmin = Math.Sign(remainingduration / 60) * Math.Floor(Math.Abs(remainingduration / 60))
            Dim remainingsec = remainingduration - remainingmin * 60
            Label7.Text = remainingmin
            Label8.Text = remainingsec

        Else
            Timer2.Enabled = False
            remainingduration = setduration
            Timer1.Enabled = True
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        setduration = TextBox1.Text * 60 + TextBox2.Text
        restduration = TextBox3.Text * 60 + TextBox4.Text

        Dim fileDlg As New SaveFileDialog
        fileDlg.RestoreDirectory = True
        fileDlg.OverwritePrompt = True
        fileDlg.Filter = "MSL File | *.msl"
        fileDlg.DefaultExt = "msl"

        If (fileDlg.ShowDialog() = DialogResult.OK) Then
            Dim workoutfile = fileDlg.FileName
            Dim objWriter As New System.IO.StreamWriter(workoutfile, False)

            objWriter.WriteLine(setduration)
            objWriter.WriteLine(restduration)
            Dim downloadlist = ListBox5.Items
            For i = 0 To downloadlist.Count - 1
                Dim title As String = downloadlist(i).fullName
                objWriter.WriteLine(title)
            Next
            objWriter.Close()
            MessageBox.Show("Workout Saved")
        Else
            MessageBox.Show("Failed to save workout. Please try again.")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox5.Items.Clear()
        Dim fileDlg As New OpenFileDialog
        fileDlg.RestoreDirectory = True
        fileDlg.Filter = "MSL File | *.msl"
        fileDlg.DefaultExt = "msl"

        If (fileDlg.ShowDialog() = DialogResult.OK) Then
            Dim workoutfile = fileDlg.FileName

            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(workoutfile)
            Dim stringReader As String = fileReader.ReadToEnd
            Dim parts As String() = stringReader.Split(New String() {Environment.NewLine},
                                       StringSplitOptions.None)

            Dim setdurationmm = Math.Sign(parts(0) / 60) * Math.Floor(Math.Abs(parts(0) / 60))
            Dim setdurationss = parts(0) - setdurationmm * 60
            TextBox1.Text = setdurationmm
            TextBox2.Text = setdurationss

            Dim restdurationmm = Math.Sign(parts(1) / 60) * Math.Floor(Math.Abs(parts(1) / 60))
            Dim restdurationss = parts(1) - restdurationmm * 60
            TextBox3.Text = restdurationmm
            TextBox4.Text = restdurationss


            For i = 2 To parts.Count - 2
                Dim dd As New IO.FileInfo(parts(i))

                ListBox5.Items.Add(dd)
            Next
            ListBox5.DisplayMember = "Name"

            MessageBox.Show("Workout Loaded")
        Else
            MessageBox.Show("Failed to load workout. Please try again.")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button1.Text = "Begin Workout"
        Timer1.Enabled = False
        Timer2.Enabled = False
        ProgressBar1.Value = 0
        Label7.Text = "00"
        Label8.Text = "00"
    End Sub


    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox3.MouseClick
        TextBox3.Text = ""
    End Sub
    Private Sub TextBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseClick
        TextBox4.Text = ""
    End Sub

    Private Sub WorkoutDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkoutDatabaseToolStripMenuItem.Click
        Dim fileDlg As New FolderBrowserDialog
        If (fileDlg.ShowDialog() = DialogResult.OK) Then
            Dim workoutdb As New IO.DirectoryInfo(fileDlg.SelectedPath)

            If Directory.Exists(workoutdb.FullName & "/abs") Then

            Else
                Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/abs")
                Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/abs"

                Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                Dim files As IO.FileInfo() = dir.GetFiles()
                For Each file In files
                    file.CopyTo(di.FullName & "/" & file.Name)
                Next


            End If
            If Directory.Exists(workoutdb.FullName & "/arms") Then

            Else
                Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/arms")
                Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/arms"

                Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                Dim files As IO.FileInfo() = dir.GetFiles()
                For Each file In files
                    file.CopyTo(di.FullName & "/" & file.Name)
                Next

            End If
            If Directory.Exists(workoutdb.FullName & "/legs") Then

            Else
                Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/legs")
                Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/legs"

                Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                Dim files As IO.FileInfo() = dir.GetFiles()
                For Each file In files
                    file.CopyTo(di.FullName & "/" & file.Name)
                Next

            End If
            If Directory.Exists(workoutdb.FullName & "/back") Then

            Else
                Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/back")
                Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/back"

                Dim dir As New IO.DirectoryInfo(sourcefilesdir)
                Dim files As IO.FileInfo() = dir.GetFiles()
                For Each file In files
                    file.CopyTo(di.FullName & "/" & file.Name)
                Next

            End If


            Dim preferencefile = Directory.GetCurrentDirectory() & "/pref.inf"
            Dim objWriter As New System.IO.StreamWriter(preferencefile, False)

            objWriter.WriteLine(fileDlg.SelectedPath)
            objWriter.Close()
            workoutdbdir = fileDlg.SelectedPath
            initialize()
            MessageBox.Show("Workout Database Selected")

        End If
    End Sub
End Class

