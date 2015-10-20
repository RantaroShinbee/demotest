Public Class Form2
    Private dbaccess As New DataBaseAccess

    Public Function LoadCategory()
        Dim category As String = "select category_id, category_name from categories_product"
        Dim datatable As DataTable = dbaccess.GetDataTable(category)
        Me.selectcategory.DataSource = datatable
        Me.selectcategory.ValueMember = "category_id"
        Me.selectcategory.DisplayMember = "category_name"
    End Function

    Private Function Insert() As Boolean
        Dim insertproduct As String = "insert into products (product_id, product_name, price, amount, category_id, description)"
        insertproduct += String.Format("values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", Me.productidfield.Text, Me.productnamefield.Text, Me.pricefield.Text, Me.amountfield.Text, Me.selectcategory.SelectedValue, Me.descriptionfield.Text)
        Return dbaccess.ExecuteNoneQuery(insertproduct)
    End Function

    Private Function Update() As Boolean
        Dim updateproduct As String = String.Format("update products set product_name ='{0}', price ='{1}', amount ='{2}', description ='{3}' where product_id ='{4}' ", Me.productnamefield.Text, Me.pricefield.Text, Me.amountfield.Text, Me.descriptionfield.Text, Me.productidfield.Text)
        Return dbaccess.ExecuteNoneQuery(updateproduct)
    End Function

    Private Function ValidationForm()
        Return (String.IsNullOrEmpty(Me.productidfield.Text) OrElse String.IsNullOrEmpty(Me.productnamefield.Text) OrElse String.IsNullOrEmpty(Me.pricefield.Text) OrElse String.IsNullOrEmpty(Me.amountfield.Text) OrElse String.IsNullOrEmpty(Me.descriptionfield.Text))
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategory()
    End Sub

    Private Sub okbtn_Click(sender As Object, e As EventArgs) Handles okbtn.Click
        If ValidationForm() Then
            MessageBox.Show("Require: One Of Your Fields Is Empty. Please Complete Your Fields !", "Requirement", MessageBoxButtons.OK)
        Else
            If Insert() Then
            MessageBox.Show("A Record Has Been Added Successfully", "Confirm", MessageBoxButtons.OK)
            Me.DialogResult = DialogResult.OK
        Else
            MessageBox.Show("Error When Inserting Data Into Database !", "Error", MessageBoxButtons.OK)
        Me.DialogResult = DialogResult.No
        End If
        Me.Close()
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub
End Class