Public Class Form3
    Private dbaccess As New DataBaseAccess

    Function Update() As Boolean
        Dim updateproduct As String = String.Format("update products set product_name = '{0}', price = '{1}', amount = '{2}', description = '{4}' where product_id = '{4}'", Me.productnamefield.Text, Me.pricefield.Text, Me.amountfield.Text, Me.descriptionfield.Text, Me.productidfield.Text)
        Return dbaccess.ExecuteNoneQuery(updateproduct)
    End Function

    Function ValidataionForm()
        Return (String.IsNullOrEmpty(Me.productidfield.Text) OrElse String.IsNullOrEmpty(Me.productidfield.Text) OrElse String.IsNullOrEmpty(Me.productnamefield.Text) OrElse String.IsNullOrEmpty(Me.pricefield.Text) OrElse String.IsNullOrEmpty(Me.amountfield.Text) OrElse String.IsNullOrEmpty(Me.descriptionfield.Text))
    End Function

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        If ValidataionForm() Then
            MessageBox.Show("Require: One Of Your Fields Is Empty. Please Complete Your Fields !", "Requirement", MessageBoxButtons.OK)
        Else
            If Update() Then
                MessageBox.Show("A Record Has Been Added Successfully", "Confirm", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            Else
                MessageBox.Show("Error When Inserting Data Into Database !", "Failure", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.No
            End If
            Me.Close()
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub
End Class