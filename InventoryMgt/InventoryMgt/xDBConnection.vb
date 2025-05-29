Imports System.Data.OleDb

Module xDBConnection

    Public xConn As New OleDbConnection
    Dim DBProvider As String
    Dim DBSource As String


    Friend Sub xConnopen()

        'xConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Tharusha Dilshan\OneDrive\Documents\Invent_Mgt_old.mdb"
        xConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Invent_Mgt_old.mdb"

        xConn.Open()

    End Sub

    Friend Sub xConnClose()
        xConn.Close()
    End Sub

End Module