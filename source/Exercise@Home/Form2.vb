Imports System.IO

Public Class Form2

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fileDlg As New FolderBrowserDialog
        fileDlg.Description = "Choose directory to save/add workout animations"
        If (fileDlg.ShowDialog() = DialogResult.OK) Then
            TextBox1.Text = fileDlg.SelectedPath
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Maximum = 200
        ProgressBar1.Minimum = 0
        ProgressBar1.Value = 0

        Dim workoutdb As New IO.DirectoryInfo(TextBox1.Text)

        If Directory.Exists(workoutdb.FullName & "/abs") Then

        Else
            Dim di As DirectoryInfo = Directory.CreateDirectory(workoutdb.FullName & "/abs")
            Dim sourcefilesdir = Directory.GetCurrentDirectory() & "/abs"

            Dim dir As New IO.DirectoryInfo(sourcefilesdir)
            Dim files As IO.FileInfo() = dir.GetFiles()
            For Each file In files
                file.CopyTo(di.FullName & "/" & file.Name)
                ProgressBar1.Value = ProgressBar1.Value + 1
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
                ProgressBar1.Value = ProgressBar1.Value + 1
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
                ProgressBar1.Value = ProgressBar1.Value + 1
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
                ProgressBar1.Value = ProgressBar1.Value + 1
            Next

        End If

        ProgressBar1.Value = ProgressBar1.Maximum
        Dim objWriter As New System.IO.StreamWriter(Form1.preferencefi.FullName, False)

        objWriter.WriteLine(TextBox1.Text)
        objWriter.Close()
        Form1.workoutdbdir = TextBox1.Text
        ' Me.Close()
        '  Form1.Show()
    End Sub

End Class