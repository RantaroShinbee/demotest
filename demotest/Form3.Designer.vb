<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.productidfield = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.categoryidfield = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.descriptionfield = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amountfield = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pricefield = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.productnamefield = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.okbtn = New System.Windows.Forms.Button()
        Me.cancelbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Id"
        '
        'productidfield
        '
        Me.productidfield.Location = New System.Drawing.Point(112, 28)
        Me.productidfield.Name = "productidfield"
        Me.productidfield.Size = New System.Drawing.Size(268, 20)
        Me.productidfield.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'categoryidfield
        '
        Me.categoryidfield.Location = New System.Drawing.Point(112, 132)
        Me.categoryidfield.Name = "categoryidfield"
        Me.categoryidfield.Size = New System.Drawing.Size(268, 20)
        Me.categoryidfield.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category Id"
        '
        'descriptionfield
        '
        Me.descriptionfield.Location = New System.Drawing.Point(112, 158)
        Me.descriptionfield.Name = "descriptionfield"
        Me.descriptionfield.Size = New System.Drawing.Size(268, 20)
        Me.descriptionfield.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Description"
        '
        'amountfield
        '
        Me.amountfield.Location = New System.Drawing.Point(112, 106)
        Me.amountfield.Name = "amountfield"
        Me.amountfield.Size = New System.Drawing.Size(268, 20)
        Me.amountfield.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount"
        '
        'pricefield
        '
        Me.pricefield.Location = New System.Drawing.Point(112, 80)
        Me.pricefield.Name = "pricefield"
        Me.pricefield.Size = New System.Drawing.Size(268, 20)
        Me.pricefield.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Price"
        '
        'productnamefield
        '
        Me.productnamefield.Location = New System.Drawing.Point(112, 54)
        Me.productnamefield.Name = "productnamefield"
        Me.productnamefield.Size = New System.Drawing.Size(268, 20)
        Me.productnamefield.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Product Name"
        '
        'okbtn
        '
        Me.okbtn.Location = New System.Drawing.Point(112, 218)
        Me.okbtn.Name = "okbtn"
        Me.okbtn.Size = New System.Drawing.Size(75, 36)
        Me.okbtn.TabIndex = 12
        Me.okbtn.Text = "OK"
        Me.okbtn.UseMnemonic = False
        Me.okbtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Location = New System.Drawing.Point(242, 218)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(75, 36)
        Me.cancelbtn.TabIndex = 13
        Me.cancelbtn.Text = "Cancel"
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 298)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.okbtn)
        Me.Controls.Add(Me.productnamefield)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pricefield)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.amountfield)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.descriptionfield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.categoryidfield)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.productidfield)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents productidfield As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents categoryidfield As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents descriptionfield As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents amountfield As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pricefield As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents productnamefield As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents okbtn As Button
    Friend WithEvents cancelbtn As Button
End Class
