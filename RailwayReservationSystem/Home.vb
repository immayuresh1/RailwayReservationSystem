Public Class Home
    Private Sub TrainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrainToolStripMenuItem.Click
        NewTrain.ShowDialog()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        Reservation.ShowDialog()
    End Sub

    Private Sub CancellationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancellationToolStripMenuItem.Click
        Cancellation.ShowDialog()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        Reports.ShowDialog()
    End Sub

    Private Sub CustomerCareToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CustomerCareToolStripMenuItem1.Click
        CustomerCare.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

    End Sub
End Class