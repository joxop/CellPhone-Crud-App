
Imports System.Data.SqlClient
Public Class Form1
    Private r As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jay\Downloads\file\agile\PRoject\Project\demo.mdf;Integrated Security=True")
        Dim objcon As SqlConnection = Nothing
        Dim objcmd As SqlCommand = Nothing

        Try
            objcon = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jay\Downloads\file\agile\PRoject\Project\demo.mdf;Integrated Security=True")
            objcon.Open()
            Dim stmt As String = "select * from register where email ='" & Email.Text & "' AND password ='" & password.Text & "' "
            objcmd = New SqlCommand(stmt, objcon)
            Dim reader As SqlDataReader = objcmd.ExecuteReader
            If reader.Read Then
                MessageBox.Show("Login successfully")
                Me.Hide()
                Form2.Show()
            Else
                MessageBox.Show("Invalid Login Please Check!")
                Email.Clear()
                password.Clear()
            End If
        Catch ex As Exception
            MsgBox("MSSQL ERROR")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub
    Private Sub ShowPass_Click(sender As Object, e As EventArgs) Handles ShowPassword.Click

        If password.UseSystemPasswordChar = True Then

            password.UseSystemPasswordChar = False
            ShowPassword.Text = "Hide"

        Else

            password.UseSystemPasswordChar = True
            ShowPassword.Text = "Show"

        End If

    End Sub

    ' Form Load
    Private Sub PassShow_Hide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        password.UseSystemPasswordChar = True


    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = +1

        PictureBox2.Image = My.Resources.ResourceManager.GetObject("ph" & r.Next(i, 3))


    End Sub

    Private Sub OnButton_Click(sender As Object, e As EventArgs) Handles Onbutton.Click
        Timer1.Start()

    End Sub

    Private Sub Speed_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Speed.Text = "Slow" Then
            Timer1.Interval = 2000
            '2 secs
        ElseIf Speed.Text = "Medium" Then
            Timer1.Interval = 1000
            '1 Sec
        ElseIf Speed.Text = "Fast" Then
            Timer1.Interval = 500
            '1/2 sec

        End If
    End Sub

    Private Sub OffButton_Click(sender As Object, e As EventArgs) Handles Offbutton.Click
        Timer1.Stop()

    End Sub
End Class