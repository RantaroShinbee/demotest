Public Class Form1
    Private dbaccess As New DataBaseAccess
    Private isloading As Boolean = False

    Function LoadCategory()
        Dim category As String = "select category_id, category_name from categories_product"
        Dim datatable As DataTable = dbaccess.GetDataTable(category)
        Me.selectcategory.DataSource = datatable
        Me.selectcategory.ValueMember = "category_id"
        Me.selectcategory.DisplayMember = "category_name"
    End Function

    Function LoadProduct(category_id As String)
        Dim product As String = String.Format("select product_id, product_name, price, amount, description from products where category_id = '{0}'", category_id)
        Dim datatable As DataTable = dbaccess.GetDataTable(product)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Product Id"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Price"
            .Columns(3).HeaderText = "Amount"
            .Columns(4).HeaderText = "Description"
        End With
    End Function

    Function Search(category_id As String, inputvalue As String)
        Dim querysearch As String = String.Format("select product_id, product_name, price, amount, description from products where category_id = '{0}'", category_id)
        If Me.selectsearch.SelectedIndex = 0 Then
            querysearch += String.Format("and product_id like '{0}%'", inputvalue)
        ElseIf Me.selectsearch.SelectedIndex = 1 Then
            querysearch += String.Format("and product_name like '{0}%'", inputvalue)
        End If
        Dim datatable As DataTable = dbaccess.GetDataTable(querysearch)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Product Id"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Price"
            .Columns(3).HeaderText = "Amount"
            .Columns(4).HeaderText = "Description"
        End With
    End Function

    Function DeleteProduct()
        Dim product_id As String = Me.listviewproduct.Rows(Me.listviewproduct.CurrentCell.RowIndex).Cells("product_id").Value
        Dim delete As String = String.Format("delete products where product_id = '{0}'", product_id)
        If dbaccess.ExecuteNoneQuery(delete) Then
            MessageBox.Show("A Record Has Been Deleted Successfully", "Confirm", MessageBoxButtons.OK)
            LoadProduct(Me.selectcategory.SelectedValue)
        Else
            MessageBox.Show("Error When Deleting Data From Database !", "Failure", MessageBoxButtons.OK)
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isloading = True
        LoadCategory()
        LoadProduct(Me.selectcategory.SelectedValue)
        isloading = False
    End Sub

    Private Sub selectcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectcategory.SelectedIndexChanged
        If Not isloading Then
            LoadProduct(Me.selectcategory.SelectedValue)
        End If
    End Sub

    Private Sub searchfield_TextChanged(sender As Object, e As EventArgs) Handles searchfield.TextChanged
        Search(Me.selectcategory.SelectedValue, searchfield.Text)
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        DeleteProduct()
    End Sub

    Private Sub insertbtn_Click(sender As Object, e As EventArgs) Handles insertbtn.Click
        Dim form2 As New Form2
        form2.ShowDialog()
        If form2.DialogResult = DialogResult.OK Then
            LoadProduct(form2.selectcategory.SelectedValue)
        End If
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim form3 As New Form3
        form3.productidfield.ReadOnly = True
        form3.categoryidfield.Text = Me.selectcategory.SelectedValue
        form3.categoryidfield.ReadOnly = True
        With Me.listviewproduct
            form3.productidfield.Text = .Rows(.CurrentCell.RowIndex).Cells("product_id").Value
            form3.productnamefield.Text = .Rows(.CurrentCell.RowIndex).Cells("product_name").Value
            form3.pricefield.Text = .Rows(.CurrentCell.RowIndex).Cells("price").Value
            form3.amountfield.Text = .Rows(.CurrentCell.RowIndex).Cells("amount").Value
            form3.descriptionfield.Text = .Rows(.CurrentCell.RowIndex).Cells("description").Value
        End With
        form3.ShowDialog()
        If form3.DialogResult = DialogResult.OK Then
            LoadProduct(form3.categoryidfield.Text)
        End If
    End Sub
End Class
