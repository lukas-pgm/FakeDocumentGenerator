Public Class Main
    Private Sub label_ad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles label_ad.LinkClicked
        Process.Start("https://github.com/lukas-pgm/FakeDocumentGenerator")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/lukas-pgm/FakeDocumentGenerator/blob/main/Known%20file%20extensions")
    End Sub
    Private Sub triggerfileLocation_Click(sender As Object, e As EventArgs) Handles triggerfileLocation.Click
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            optionfileLocation.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub
    Private Sub optionfileLocation_TextChanged(sender As Object, e As EventArgs) Handles optionfileLocation.TextChanged
        If Not optionfileLocation.TextLength >= 1 Then
            MsgBox("Error: The save location is not valid!")
        End If
    End Sub
    Private Sub optionfileName_TextChanged(sender As Object, e As EventArgs) Handles optionfileName.TextChanged
        If Not optionfileLocation.TextLength >= 1 Then
            MsgBox("Error: The save location is not valid!")
        End If
    End Sub
    Private Sub triggerCreate_Click(sender As Object, e As EventArgs) Handles triggerCreate.Click
        MsgBox("The program may hang up during the process (No respond). Leave the program open: the program will keep working!")

        Dim fileLocation As String = ""
        Dim fileExtension As String = "fdg"
        Dim fileName As String = "generatedFile"
        Dim fileSize As String = "0"

        ProgressBar.Value = 10

        Try
            If optionfileLocation.Text = "" Or optionfileLocation.TextLength <= 0 Then
                MsgBox("Error: The save location is not valid!")
                Return
            Else
                If optionfileLocation.Text.EndsWith("\") Or optionfileLocation.Text.EndsWith("/") Then
                    MsgBox("Error: Remove the slash in the file path!")
                    Return
                Else
                    fileLocation = optionfileLocation.Text
                    ProgressBar.Value = 20
                End If
            End If

            If Not optionfileExtension1.Text = "" Or optionfileExtension1.TextLength <= 0 Then
                If Not optionfileExtension1.Text.Contains(".") Then
                    fileExtension = optionfileExtension1.Text
                    ProgressBar.Value = 30
                Else
                    MsgBox("Error: Remove the dot in the file extension!")
                    Return
                End If
            Else
                MsgBox("Error: The file extension is not valid!")
                Return
            End If

            If optionfileName.Text = "" Or optionfileName.TextLength <= 0 Then
                MsgBox("Error: The save name is not valid!")
                Return
            Else
                If optionfileName.Text.Contains(".") Then
                    MsgBox("Error: Remove the dot in the file extension!")
                    Return
                Else
                    fileName = optionfileName.Text
                    ProgressBar.Value = 40
                End If
            End If


            fileSize = optionfileSize.Text
            ProgressBar.Value = 60
            If fileSize > 50000 Then
                MsgBox("Warning: The file size seems to be unrealistic and takes longer to create!")
            End If

            If Not IO.File.Exists(fileLocation + "\" + fileName + "." + fileExtension) Then
                ProgressBar.Value = 70
                Dim enc As New System.Text.ASCIIEncoding
                Dim content = New String(Chr(0), (fileSize * 1000))
                ProgressBar.Value = 80
                IO.File.WriteAllBytes(fileLocation + "\" + fileName + "." + fileExtension, enc.GetBytes(content))
                ProgressBar.Value = 100
                MsgBox("The file was created successfully!")
                ProgressBar.Value = 0
                Return
            Else
                MsgBox("The file already exists. Choose another file name or change the file location!")
                Return
            End If
        Catch ex As Exception
            MsgBox("Error: An error occured while creating the file. Please contact the author of this software!")
            Application.Restart()
        End Try
    End Sub
End Class
