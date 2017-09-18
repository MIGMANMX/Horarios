Imports System.Data.Odbc
Imports System.Data.OleDb

Module Conexiones
    Public connStrdbo As String = "Data Source=SISTEMAS3-PC\STAR;Initial Catalog=dbo;Persist Security Info=True;User ID=sa;Password=star;"
    Public connStrRH As String = "Data Source=SISTEMAS3-PC\STAR;Initial Catalog=nomRH;Persist Security Info=True;User ID=sa;Password=star;"
    Public AttConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;;Data Source=C:\Program Files (x86)\Att\ATT2000.mdb;Persist Security Info=False;"
End Module
