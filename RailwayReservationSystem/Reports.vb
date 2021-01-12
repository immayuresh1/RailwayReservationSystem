Imports System.Data
Imports System.Data.SqlClient

Public Class Reports
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim train As Object
    Dim reservation As Object
    Dim complain As Object
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
                str = "SELECT * FROM train WHERE id = '" + TextBox3.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, train)
            End Using
        ElseIf ComboBox1.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
                str = "SELECT * FROM reservation WHERE id = '" + TextBox3.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, reservation)
            End Using

        ElseIf ComboBox1.SelectedIndex = "2" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\HostelManagementSystem\HostelManagementSystem\hostel.mdf;Integrated Security=True")
                str = "SELECT * FROM complain WHERE id = '" + TextBox3.Text + "'"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, complain)
            End Using
            TextBox3.Text = ""
            ComboBox1.Text = "--Select--"
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = "0" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
                str = "SELECT * FROM train "
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, train)
            End Using
        ElseIf ComboBox1.SelectedIndex = "1" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
                str = "SELECT * FROM reservation"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, reservation)
            End Using

        ElseIf ComboBox1.SelectedIndex = "2" Then
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
                str = "SELECT * FROM complain"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, complain)
            End Using
            TextBox3.Text = ""
            ComboBox1.Text = "--Select--"

        End If
    End Sub
End Class