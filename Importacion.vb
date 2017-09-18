Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.SqlTypes
Public Class Importacion
    Public cont As Integer
    Dim CHECKTIME As String
    Dim CHECKTYPE As String
    Dim Catt As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Program Files (x86)\Att\ATT2000.mdb;Persist Security Info=False;"
    Private Sub Importacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Etiqueta.Text = "Importacion de chequeos"
        Try
            Dim conexion As OleDbConnection
            conexion = New OleDbConnection(Catt)
            conexion.Open()
            MsgBox("La conexion con Att fue exitosa", MsgBoxStyle.Information, "Importacion")
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al conectar " & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Close()
        End Try
    End Sub
    Public Sub Importar()
        Dim CHEQUEO As String

        Dim dbC As New SqlConnection(connStrRH)
        Dim cmd As New SqlCommand("", dbC)
        Dim rdr As SqlDataReader
        dbC.Open()


        cmd.CommandText = "SELECT clave_att, id_att, inicio, fin, fecha FROM vm_ReporteHorario ORDER BY clave_att"
        rdr = cmd.ExecuteReader


        Dim dbA As New OleDbConnection(AttConnStr)
        dbA.Open()
        Dim rda As OleDbDataReader
        Dim cmda As New OleDbCommand("", dbA)
        'Dim dbA2 As New OleDbConnection(connStrRH)
        'dbA2.Open()
        'Dim rda2 As OleDbDataReader
        'Dim cmda2 As New OleDbCommand("", dbA2)


        While rdr.Read()
            Etiqueta.Text = "Leyendo registros"
            ProgressBar1.Value = 40
            Threading.Thread.Sleep(1000)

            'cmda = New OleDbCommand("SELECT * FROM Consulta1 WHERE SSN ='" & rdr("clave_att").ToString & "'", dbA)
            '  rda = cmda.ExecuteReader
            'CHEQUEO = rda("CHECKTIME").ToString


            'Arreglo de fechas 


            ''''''''''


            Etiqueta.Text = "Insertando registros"
            ProgressBar1.Value = 70
            Threading.Thread.Sleep(1000)
            'If rda.Read Then
            'cmda2.CommandText = ("INSERT INTO Chequeo (userid, cometime, leavetime, type, flag, schclassid, overtime) VALUES (1, '" & cometime & "', '" & leavetime & "', 0, 1, '" & rdr("id_att").ToString & "',0)", dbA2)


            ' cmda2.ExecuteNonQuery()
            'cmda2.Dispose()

            'End If

        End While
        rdr.Close()
        Etiqueta.Text = "Proceso finalizado con éxito."
        ProgressBar1.Value = 100
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Iniciar.Click
        Etiqueta.Text = "Conectando la base de datos"
        Importacion()
    End Sub
    Public Sub Importacion()
        'Conexion con SQL
        ProgressBar1.Value = 45
        Dim dbC As New SqlConnection(connStrdbo)

        Dim cmdS As New SqlCommand("", dbC)
        Dim rdr As SqlDataReader

        Dim dbC2 As New SqlConnection(connStrRH)
        Dim cmdS2 As New SqlCommand("", dbC2)

        dbC.Open()
        'Sacar las claves_att de la BD SQL
        cmdS.CommandText = "SELECT clave_att FROM Empleados ORDER BY clave_att desc"
        rdr = cmdS.ExecuteReader
        'Ciclo de lectura de claves
        While rdr.Read()
            Dim claveatt As String
            claveatt = rdr("clave_att").ToString
            If claveatt <> "" Then
                'Conexion con BD Access
                Dim conexion As OleDbConnection
                conexion = New OleDbConnection(Catt)
                conexion.Open()
                'Comando para buscar el ID con la claveatt
                Dim cmdID As OleDbCommand
                cmdID = conexion.CreateCommand
                cmdID.CommandText = ("SELECT USERINFO.USERID FROM USERINFO WHERE (((USERINFO.SSN) ='" & claveatt & "'))")
                Dim leer As OleDbDataReader
                leer = cmdID.ExecuteReader()
                Dim id As Integer
                While leer.Read()
                    'Asignar el usuario segun la clave
                    id = Convert.ToInt32(leer("USERID").ToString())
                End While
                'Comando para buscar las checadas por el ID
                Dim cmd As OleDbCommand
                cmd = conexion.CreateCommand
                cmd.CommandText = "SELECT CHECKTIME, CHECKTYPE  FROM CHECKINOUT WHERE USERID=" & id & ""
                Dim check As OleDbDataReader
                check = cmd.ExecuteReader()

                'Ciclo de leer los cheks segun el id
                While check.Read()
                    'Variable de fecha
                    CHECKTIME = check("CHECKTIME").ToString
                    'Variable de tipo de chequeo
                    CHECKTYPE = check("CHECKTYPE").ToString



                    dbC2.Open()
                    'Comparando si es la misma fecha al anterior
                    cmdS2.CommandText = "select top (1) * from View_1 where chec = '" & Format(CDate(CHECKTIME), "yyyy-dd-MMThh:mm:ss") & "'"
                    'rdr2 = cmdS2.ExecuteReader
                    Dim rdr2 As SqlDataReader = cmdS2.ExecuteReader
                    'Ciclo de lectura de claves
                    If rdr2.HasRows Then
                        'Dim idchek As Integer
                        'idchek = rdr2("idchequeo").ToString()
                        rdr2.Close()

                    Else
                        rdr2.Close()

                        Select Case CHECKTYPE
                            'INSERTAR REGISTROS
                            Case "I"
                                cmdS2.CommandText = "INSERT INTO Chequeo (idempleado,chec,tipo) values('" & id & "','" & Format(CDate(CHECKTIME), "yyyy-MM-ddThh:mm:ss") & "',1)"
                                cmdS2.ExecuteNonQuery()
                                rdr2 = cmdS2.ExecuteReader

                            Case "0"
                                cmdS2.CommandText = "INSERT INTO Chequeo (idempleado,chec,tipo) values('" & id & "','" & Format(CDate(CHECKTIME), "yyyy-MM-ddThh:mm:ss") & "',2)"
                                cmdS2.ExecuteNonQuery()
                                rdr2 = cmdS2.ExecuteReader

                            Case "1"
                                cmdS2.CommandText = "INSERT INTO Chequeo (idempleado,chec,tipo) values('" & id & "','" & Format(CDate(CHECKTIME), "yyyy-MM-ddThh:mm:ss") & "',3)"
                                cmdS2.ExecuteNonQuery()
                                rdr2 = cmdS2.ExecuteReader

                            Case "O"
                                cmdS2.CommandText = "INSERT INTO Chequeo (idempleado,chec,tipo) values('" & id & "','" & Format(CDate(CHECKTIME), "yyyy-MM-ddThh:mm:ss") & "',4)"
                                cmdS2.ExecuteNonQuery()
                                rdr2 = cmdS2.ExecuteReader

                        End Select

                    End If




                    'Cerrar conexion
                    dbC2.Close()
                End While

                'Cerrar conexion att
                conexion.Close()
            End If
        End While
        'Cerrar SQL
        dbC.Close()
        Etiqueta.Text = "Proceso finalizado con éxito."
        ProgressBar1.Value = 100
        Iniciar.Enabled = False
    End Sub
End Class