Imports System.Data
Imports System.Data.SqlClient

Public Class Reservation
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim getres As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")


        com = New SqlCommand("insert into reservation(s_place,e_place,t_no,t_name,price,doj,not1,t_price,c_name,addr,mob,email)values('" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "')", con)
        con.Open()
        com.ExecuteNonQuery()
        MsgBox("Reservation Infromation Inserted Successfullyy..")
        Hide()
        con.Close()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"

    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
        con.Open()

        Try
            getres = "SELECT nextID=MAX(Id)+1 FROM reservation"
            com = New SqlCommand(getres, con)
            dr = com.ExecuteReader()
            If dr.Read() Then

                TextBox1.Text = dr.GetValue(0).ToString()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        ComboBox1.Text = "--Select--"
        ComboBox2.Text = "--Select--"

    End Sub
End Class