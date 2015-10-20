<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchfield = New System.Windows.Forms.TextBox()
        Me.listviewproduct = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.insertbtn = New System.Windows.Forms.Button()
        Me.selectsearch = New System.Windows.Forms.ComboBox()
        Me.selectcategory = New System.Windows.Forms.ComboBox()
        CType(Me.listviewproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'searchfield
        '
        Me.searchfield.Location = New System.Drawing.Point(90, 23)
        Me.searchfield.Name = "searchfield"
        Me.searchfield.Size = New System.Drawing.Size(308, 20)
        Me.searchfield.TabIndex = 1
        '
        'listviewproduct
        '
        Me.listviewproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listviewproduct.Location = New System.Drawing.Point(27, 59)
        Me.listviewproduct.Name = "listviewproduct"
        Me.listviewproduct.Size = New System.Drawing.Size(371, 187)
        Me.listviewproduct.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Classify By"
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(427, 190)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(159, 41)
        Me.deletebtn.TabIndex = 8
        Me.deletebtn.Text = "Delete"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(427, 143)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(159, 41)
        Me.updatebtn.TabIndex = 10
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'insertbtn
        '
        Me.insertbtn.Location = New System.Drawing.Point(427, 96)
        Me.insertbtn.Name = "insertbtn"
        Me.insertbtn.Size = New System.Drawing.Size(159, 41)
        Me.insertbtn.TabIndex = 11
        Me.insertbtn.Text = "Insert"
        Me.insertbtn.UseVisualStyleBackColor = True
        '
        'selectsearch
        '
        Me.selectsearch.FormattingEnabled = True
        Me.selectsearch.Items.AddRange(New Object() {"Product Id", "Product Name"})
        Me.selectsearch.Location = New System.Drawing.Point(497, 23)
        Me.selectsearch.Name = "selectsearch"
        Me.selectsearch.Size = New System.Drawing.Size(112, 21)
        Me.selectsearch.TabIndex = 12
        '
        'selectcategory
        '
        Me.selectcategory.FormattingEnabled = True
        Me.selectcategory.Location = New System.Drawing.Point(497, 56)
        Me.selectcategory.Name = "selectcategory"
        Me.selectcategory.Size = New System.Drawing.Size(112, 21)
        Me.selectcategory.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 270)
        Me.Controls.Add(Me.selectcategory)
        Me.Controls.Add(Me.selectsearch)
        Me.Controls.Add(Me.insertbtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listviewproduct)
        Me.Controls.Add(Me.searchfield)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Product"
        CType(Me.listviewproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents searchfield As TextBox
    Friend WithEvents listviewproduct As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents deletebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents insertbtn As Button
    Friend WithEvents selectsearch As ComboBox
    Friend WithEvents selectcategory As ComboBox
End Class
