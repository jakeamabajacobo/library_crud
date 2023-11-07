Imports System.Data.OleDb
Public Class Form1

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\git\libapp\LibApp\DB\Books97.accdb")
    Dim com As New OleDbCommand
    Dim adpt As New OleDbDataAdapter
    Dim dr As OleDbDataReader
    Dim dt As New DataTable
    Dim qry As String
    Dim selected_id As Integer
    Dim bitmap As Bitmap


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        qry = "SELECT * FROM Books"
        Try
            con.Open()
            com.Connection = con
            com.CommandText = qry
            adpt.SelectCommand = com
            dt.Clear()

            adpt.Fill(dt)

            dt_grid.DataSource = dt


            com.Dispose()
            adpt.Dispose()
            com.Connection = con
            com.CommandText = "SELECT * FROM CategoryID"
            adpt.SelectCommand = com
            Dim cat_dt As New DataTable
            cat_dt.Clear()
            adpt.Fill(cat_dt)


            category_cb.DataSource = cat_dt
            category_cb.DisplayMember = "CategoryName"
            category_cb.ValueMember = "CategoryID"


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try











    End Sub

    Private Sub dt_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_grid.CellClick


        Dim row As DataGridViewRow = dt_grid.Rows(e.RowIndex)


        title_txt.Text = row.Cells(1).Value.ToString
        isbn_txt.Text = row.Cells(2).Value.ToString
        description_txt.Text = row.Cells(3).Value.ToString
        author_txt.Text = row.Cells(5).Value.ToString
        category_cb.SelectedIndex = Convert.ToInt32(row.Cells(4).Value)
        selected_id = Convert.ToInt32(row.Cells(0).Value)
        Console.WriteLine(selected_id)
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click

        Try
            con.Open()
            com.Connection = con
            com.CommandText = "INSERT INTO Books(Title,ISBN,Description,CategoryID,Author,Quantity) VALUES('" & title_txt.Text & "','" & isbn_txt.Text & "','" & description_txt.Text & "'," & category_cb.SelectedIndex & ",'" & author_txt.Text & "'," & qty_txt.Text & ")"

            If com.ExecuteNonQuery > 0 Then
                MsgBox("Data Saved!")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
            com.Dispose()

        End Try

    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click

        Try
            con.Open()
            com.Connection = con
            com.CommandText = "SELECT * FROM Books"
            adpt.SelectCommand = com
            dt.Clear()
            adpt.Fill(dt)


            dt_grid.DataSource = Nothing
            dt_grid.DataSource = dt
            dt_grid.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            com.Dispose()

        End Try

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "UPDATE  Books SET Title='" & title_txt.Text & "',ISBN=" & isbn_txt.Text & ",Description='" & description_txt.Text & "',CategoryID='" & category_cb.SelectedIndex & "',Author='" & author_txt.Text & "',Quantity='" & qty_txt.Text & "'  WHERE ID= " & selected_id & ""

            If com.ExecuteNonQuery > 0 Then
                MsgBox("Data Updated!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            com.Dispose()
        End Try
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "DELETE FROM Books WHERE ID=" & selected_id & ""

            If com.ExecuteNonQuery > 0 Then
                MsgBox("Data Deleted!")


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            com.Dispose()

        End Try
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Try
            con.Open()
            com.Connection = con
            com.CommandText = "SELECT * FROM  Books WHERE Title= '%" & search_txtbox.Text & "%' "



            If com.ExecuteNonQuery > 0 Then
                dr = com.ExecuteReader()
                Do While dr.Read
                    MsgBox(dr("Title"))
                Loop
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            com.Dispose()


        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintDocument.DefaultPageSettings.Landscape = True


        'Resize DataGridView to full height.
        Dim height As Integer = dt_grid.Height
        dt_grid.Height = dt_grid.RowCount * dt_grid.RowTemplate.Height

        'Create a Bitmap and draw the DataGridView on it.
        bitmap = New Bitmap(Me.dt_grid.Width, Me.dt_grid.Height)
        dt_grid.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.dt_grid.Width, Me.dt_grid.Height))

        'Resize DataGridView back to original height.
        dt_grid.Height = height

        'Show the Print Preview Dialog.
        PrintPreviewDialog.Document = PrintDocument

        PrintPreviewDialog.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog.ShowDialog()


    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
    End Sub
End Class
