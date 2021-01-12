Imports System.Data
Imports System.Data.SqlClient

Public Class NewTrain
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")


        com = New SqlCommand("insert into train(name,s_place,dest,price)values('" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox3.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("New Train Information Inserted Successfullyy..")
        Hide()
        con.Close()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class