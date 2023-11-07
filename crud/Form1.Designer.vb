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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dt_grid = New System.Windows.Forms.DataGridView()
        Me.title_txt = New System.Windows.Forms.TextBox()
        Me.description_txt = New System.Windows.Forms.TextBox()
        Me.author_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.category_cb = New System.Windows.Forms.ComboBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.isbn_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qty_txt = New System.Windows.Forms.TextBox()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.search_txtbox = New System.Windows.Forms.TextBox()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_grid
        '
        Me.dt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid.Location = New System.Drawing.Point(534, 44)
        Me.dt_grid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dt_grid.Name = "dt_grid"
        Me.dt_grid.Size = New System.Drawing.Size(1114, 872)
        Me.dt_grid.TabIndex = 0
        '
        'title_txt
        '
        Me.title_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.title_txt.Location = New System.Drawing.Point(75, 375)
        Me.title_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.title_txt.Name = "title_txt"
        Me.title_txt.Size = New System.Drawing.Size(404, 26)
        Me.title_txt.TabIndex = 1
        '
        'description_txt
        '
        Me.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.description_txt.Location = New System.Drawing.Point(75, 512)
        Me.description_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.description_txt.Name = "description_txt"
        Me.description_txt.Size = New System.Drawing.Size(404, 26)
        Me.description_txt.TabIndex = 2
        '
        'author_txt
        '
        Me.author_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.author_txt.Location = New System.Drawing.Point(75, 604)
        Me.author_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.author_txt.Name = "author_txt"
        Me.author_txt.Size = New System.Drawing.Size(404, 26)
        Me.author_txt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 658)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 579)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Author"
        '
        'category_cb
        '
        Me.category_cb.FormattingEnabled = True
        Me.category_cb.Location = New System.Drawing.Point(75, 681)
        Me.category_cb.Name = "category_cb"
        Me.category_cb.Size = New System.Drawing.Size(404, 28)
        Me.category_cb.TabIndex = 9
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(68, 298)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 32)
        Me.save_btn.TabIndex = 10
        Me.save_btn.Text = "Add"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Location = New System.Drawing.Point(164, 298)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(75, 32)
        Me.delete_btn.TabIndex = 11
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Location = New System.Drawing.Point(255, 298)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(75, 32)
        Me.update_btn.TabIndex = 12
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(71, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ISBN"
        '
        'isbn_txt
        '
        Me.isbn_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isbn_txt.Location = New System.Drawing.Point(75, 443)
        Me.isbn_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.isbn_txt.Name = "isbn_txt"
        Me.isbn_txt.Size = New System.Drawing.Size(404, 26)
        Me.isbn_txt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(71, 733)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "QTY"
        '
        'qty_txt
        '
        Me.qty_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qty_txt.Location = New System.Drawing.Point(75, 758)
        Me.qty_txt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.qty_txt.Name = "qty_txt"
        Me.qty_txt.Size = New System.Drawing.Size(404, 26)
        Me.qty_txt.TabIndex = 15
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(346, 298)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 32)
        Me.refresh_btn.TabIndex = 17
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'search_txtbox
        '
        Me.search_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.search_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_txtbox.Location = New System.Drawing.Point(52, 57)
        Me.search_txtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.search_txtbox.Multiline = True
        Me.search_txtbox.Name = "search_txtbox"
        Me.search_txtbox.Size = New System.Drawing.Size(404, 47)
        Me.search_txtbox.TabIndex = 18
        '
        'search_btn
        '
        Me.search_btn.Location = New System.Drawing.Point(204, 123)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(75, 32)
        Me.search_btn.TabIndex = 19
        Me.search_btn.Text = "Search"
        Me.search_btn.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Document = Me.PrintDocument
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDocument
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(296, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1700, 975)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.search_btn)
        Me.Controls.Add(Me.search_txtbox)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.qty_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.isbn_txt)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.category_cb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.author_txt)
        Me.Controls.Add(Me.description_txt)
        Me.Controls.Add(Me.title_txt)
        Me.Controls.Add(Me.dt_grid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dt_grid As DataGridView
    Friend WithEvents title_txt As TextBox
    Friend WithEvents description_txt As TextBox
    Friend WithEvents author_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents category_cb As ComboBox
    Friend WithEvents save_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents isbn_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents qty_txt As TextBox
    Friend WithEvents refresh_btn As Button
    Friend WithEvents search_txtbox As TextBox
    Friend WithEvents search_btn As Button
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents Button1 As Button
End Class
