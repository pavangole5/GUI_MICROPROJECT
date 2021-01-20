Public Class Welcome
    Private Sub btnAddanother_Click(sender As Object, e As EventArgs) Handles btnAddanother.Click
        Dim frm As Form = New NewCustomer()
        frm.Show()
    End Sub

    Private Sub btnfillorcancel_Click(sender As Object, e As EventArgs) Handles btnfillorcancel.Click
        Dim frm As Form = New FillOrCancel()
        frm.ShowDialog()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class