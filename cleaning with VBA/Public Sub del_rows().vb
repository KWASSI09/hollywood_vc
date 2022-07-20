Public Sub del_rows()

a = Worksheets("IMDB_Movies2").Cells(Rows.Count, 1).End(xlUp).Row
For i = 2 To a
If Worksheets("IMDB_Movies2").Cells(i, 6).Value <> "USA" Then
Rows(i).Delete
End If
Next




End Sub
