Namespace Printing
    Public Class ReceipParams
        Public PointId As String
        Public PointName As String
        Public TableName As String
        Public ServeurName As String
        Public PrinterName As String
        Public ItemsTopPrint As String


        Sub New(pvId As String, pName As String, tName As String, sName As String, printerName As String, itemsToPrint As String)

            Me.PointId = pvId
            Me.PointName = pName
            Me.TableName = tName
            Me.ServeurName = sName
            Me.PrinterName = printerName
            Me.ItemsTopPrint = itemsToPrint

        End Sub


    End Class

End Namespace