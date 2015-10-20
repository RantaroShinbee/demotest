Public Class Form1
    Private dbaccess As New DataBaseAccess
    Private isloading As Boolean = False

    'search
    Private Function Search(value1 As String, value2 As String)
        Dim querysearch As String = String.Format("select product_id, product_name, price, amount, description from products where category_id = '{0}' ", value1)
        If Me.selectsearch.SelectedIndex = 0 Then
            querysearch += String.Format("and product_id like '{0}%'", value2)
        ElseIf Me.selectsearch.SelectedIndex = 1 Then
            querysearch += String.Format("and product_name like '{0}%'", value2)
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

    'load data
    Private Function LoadCategory()
        Dim category As String = "select category_id, category_name from categories_product"
        Dim datatable As DataTable = dbaccess.GetDataTable(category)
        Me.selectcategory.DataSource = datatable
        Me.selectcategory.ValueMember = "category_id"
        Me.selectcategory.DisplayMember = "category_name"
    End Function

    Private Function LoadProduct(category_id As String)
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

    Private Sub searchfield_TextChanged(sender As Object, e As EventArgs) Handles searchfield.TextChanged
        Search(Me.selectcategory.SelectedValue, Me.searchfield.Text)
    End Sub

    Private Sub selectcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectcategory.SelectedIndexChanged
        If Not isloading Then
            LoadProduct(Me.selectcategory.SelectedValue)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isloading = True
        LoadCategory()
        LoadProduct(Me.selectcategory.SelectedValue)
        isloading = False
    End Sub

    Private Sub insertbtn_Click(sender As Object, e As EventArgs) Handles insertbtn.Click
        Dim form2 As New Form2(False)
        form2.Text = "Insert"
        form2.ShowDialog()
        If form2.DialogResult = DialogResult.OK Then
            LoadProduct(form2.selectcategory.SelectedValue)
        End If
    End Sub
End Class
