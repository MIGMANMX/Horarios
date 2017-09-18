Imports System.Data.Odbc
Imports System.Data.OleDb

Public Class Globales
    Public sucursal As String
    Public idSucursal As String

    'BD Pixel POS
    'Public StarConnStr As String = "DSN=PixelSqlBase;UID=reportuser;PWD=pixel1047;"

    'CTI
    'Star San Luis
    'Public connStr As String = "Data Source=ACLCTI8\SQLEXPRESS;Initial Catalog=StarT;User ID=sa;Password=cti;"
    Public connStr As String = "Data Source=SISTEMAS3-PC\STAR;Network Library=DBMSSOCN;Initial Catalog=dbo;User ID=sa;Password=star;"
    Public AttConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Att2000.mdb;Persist Security Info=True;Jet OLEDBTongue;"
End Class
