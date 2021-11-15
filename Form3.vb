Imports System.Data.SqlClient
Public Class Form3

    Private Sub Register_click(sender As Object, e As EventArgs) Handles Register.Click

        Try
            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dr As SqlDataReader

            con.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jay\Downloads\file\agile\PRoject\Project\demo.mdf;Integrated Security=True")
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from register where email='" & email.Text & "' "
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Email Id Already Registered", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                cmd = New SqlCommand("INSERT INTO register values('" & fname.Text & "','" & lname.Text & "','" & gender.Text & "','" & phone.Text & "','" & email.Text & "','" & password.Text & "')", con)
                If (fname.Text = "" And lname.Text = "" And gender.Text = "" And phone.Text = "" And email.Text = "" And password.Text = "") Then
                    MessageBox.Show("Please enter the details")
                Else
                    cmd.ExecuteNonQuery()
                    MsgBox("Succerssfully Registered.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Form1.Show()
                    fname.Clear()
                    lname.Clear()
                    gender.Text = " "
                    phone.Clear()
                    email.Clear()
                    password.Clear()
                End If
                con.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error")
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gender.SelectedIndexChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowPass.Click

        If password.UseSystemPasswordChar = True Then

            password.UseSystemPasswordChar = False
            ShowPass.Text = "Hide"

        Else

            password.UseSystemPasswordChar = True
            ShowPass.Text = "Show"

        End If

    End Sub

    ' Form Load
    Private Sub PassShow_Hide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        password.UseSystemPasswordChar = True


    End Sub


End Class