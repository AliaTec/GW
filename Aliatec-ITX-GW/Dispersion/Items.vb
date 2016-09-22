Imports System.Data

Public Class Items
    Inherits DataTable

    Public Sub New()
        Me.Columns.Add("Label")
        Me.Columns.Add("Accion")
        Me.Columns.Add("Case")

        Dim newRow As DataRow

        newRow = Me.NewRow()
        newRow.Item("Label") = 100001
        newRow.Item("Accion") = 100001
        newRow.Item("Case") = 100001
        Me.Rows.Add(newRow)



        newRow = Me.NewRow()
        newRow.Item("Label") = 100002
        newRow.Item("Accion") = 100002
        newRow.Item("Case") = 100002
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100004
        newRow.Item("Accion") = 100004
        newRow.Item("Case") = 100004
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100005
        newRow.Item("Accion") = 100005
        newRow.Item("Case") = 100005
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100006
        newRow.Item("Accion") = 100006
        newRow.Item("Case") = 100006
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100007
        newRow.Item("Accion") = 100007
        newRow.Item("Case") = 100007
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100008
        newRow.Item("Accion") = 100008
        newRow.Item("Case") = 100008
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100009
        newRow.Item("Accion") = 100009
        newRow.Item("Case") = 100009
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100010
        newRow.Item("Accion") = 100010
        newRow.Item("Case") = 100010
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100011
        newRow.Item("Accion") = 100011
        newRow.Item("Case") = 100011
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100014
        newRow.Item("Accion") = 100014
        newRow.Item("Case") = 100014
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100024
        newRow.Item("Accion") = 100024
        newRow.Item("Case") = 100024
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100025
        newRow.Item("Accion") = 100025
        newRow.Item("Case") = 100025
        Me.Rows.Add(newRow)

        newRow = Me.NewRow()
        newRow.Item("Label") = 100100
        newRow.Item("Accion") = 100100
        newRow.Item("Case") = 100100
        Me.Rows.Add(newRow)
       
    End Sub
End Class
