Imports System.Data
Imports System.Data.SqlClient

Public Class Cancellation
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim reser As Object


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
            con.Open()
            str = "DELETE FROM reservation WHERE id = '" & TextBox1.Text & "'"

            com = New SqlCommand(Str, con)
            com.ExecuteNonQuery()
            con.Close()
            MsgBox(" Reservation Record Delete Successfully")
            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Immayuresh1\Desktop\kashipara.com_railwayreservationsystem-zip\RailwayReservationSystem\RailwayReservationSystem\railway.mdf;Integrated Security=True")
                str = "SELECT * FROM reservation"
                com = New SqlCommand(str, con)
                da = New SqlDataAdapter(com)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)

                DataGridView1.DataSource = New BindingSource(dt, reser)
                Hide()
                TextBox1.Text = ""

            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Cancellation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RailwayDataSet.reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.RailwayDataSet.reservation)

    End Sub
End Class