Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        Me.BackColor = Color.LightBlue
        btnAdd.BackColor = Color.Blue

    End Sub

    Private Sub rbtnPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPurple.CheckedChanged
        lbGrouBox.ForeColor = Color.Purple

    End Sub

    Private Sub rbtnBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBlue.CheckedChanged
        lbGrouBox.ForeColor = Color.Blue
    End Sub

    Private Sub rbtnLCase_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLCase.CheckedChanged
        lbGrouBox.Text = Microsoft.VisualBasic.LCase(lbGrouBox.Text)
    End Sub

    Private Sub rbtnUCase_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnUCase.CheckedChanged
        lbGrouBox.Text = Microsoft.VisualBasic.UCase(lbGrouBox.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim enterText As String
        enterText = txtEnterWord.Text
        'ListBox1.Items.Add(enterText)

        enterText = txtEnterWord.Text.Trim()


        If Not ListBox1.Items.Contains(enterText) Then

            ListBox1.Items.Add(enterText)  '& "                           " & Label1.Text)
            MsgBox("You have add new word")
            'txtEnterWord.Clear()
        Else

            MsgBox("The word does already exist in the list." & " " & "You can not Duplicate Entry!!")

        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            lbGrouBox.Text = ListBox1.SelectedItem.ToString()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "MM/dd/yyyy h:mm:ss tt")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Close()
    End Sub
End Class
