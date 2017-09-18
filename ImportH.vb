Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class ImportH

    Private Sub ImportH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbFechaIni.Text = Format(Date.Today.Subtract(New TimeSpan(7, 0, 0, 0)), "short date")
        tbFechaFin.Text = Format(Date.Today.Subtract(New TimeSpan(1, 0, 0, 0)), "short date")
    End Sub
    Private Sub mcFechaIni_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaIni.DateSelected
        tbFechaIni.Text = mcFechaIni.SelectionStart.ToString.Substring(0, 10)
        tbFechaIni.Focus()
    End Sub

    Private Sub mcFechaFin_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcFechaFin.DateSelected
        tbFechaFin.Text = mcFechaFin.SelectionStart.ToString.Substring(0, 10)
        tbFechaFin.Focus()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        'Const bitacora As String = "F:\bitacora.txt"
        'Dim sw As New System.IO.StreamWriter(bitacora, True)
        Dim fini, ffin As String
        Dim hrini, hrfin As String
        Dim fecha As String
        Dim hora As Integer
        Dim cometime, leavetime As String
        Dim dbC As New SqlConnection(connStrRH)
        Dim cmd As New SqlCommand("", dbC)
        Dim rdr As SqlDataReader
        Dim userid As String
        dbC.Open()
        Label1.Visible = True

        If tbFechaIni.Text <> "" And tbFechaFin.Text <> "" Then
            fini = Format(CDate(tbFechaIni.Text), "yyyy/MM/dd")
            ffin = Format(CDate(tbFechaFin.Text), "yyyy/MM/dd")
            cmd.CommandText = "SELECT clave_att, id_att, inicio, fin, fecha FROM vm_ReporteHorario WHERE FECHA BETWEEN (" & "'" & fini & "'" & ")" & " AND (" & "'" & ffin & "'" & ") ORDER BY clave_att"
            rdr = cmd.ExecuteReader

            Dim dbA As New OleDbConnection(AttConnStr)
            dbA.Open()
            Dim rda As OleDbDataReader
            Dim cmda As New OleDbCommand("", dbA)
            Dim dbA2 As New OleDbConnection(AttConnStr)
            dbA2.Open()
            Dim rda2 As OleDbDataReader
            Dim cmda2 As New OleDbCommand("", dbA2)

            While rdr.Read()
                Label1.Text = "Importando horarios..."
                userid = ""
                hrini = rdr("inicio").ToString
                hrfin = rdr("fin").ToString
                'validar si la hora es después de las 00:00 hrs y antes de las 5 am
                'Se extrae solamente la hora, para validar.
                hora = hrfin.Substring(0, 2)
                'La fecha inicial se deja igual
                fecha = Format(CDate(rdr("fecha").ToString), "short date")
                cometime = fecha + " " + hrini
                cometime = Format(CDate(cometime), "dd/MM/yyyy hh:mm:ss tt")

                'En la fecha final, si la hora es de la madrugada, incrementar fecha + 1
                If hora < 5 Then
                    fecha = Format(CDate(rdr("fecha").ToString).Add(New TimeSpan(1, 0, 0, 0)), "short date")
                Else
                    fecha = Format(CDate(rdr("fecha").ToString), "short date")
                End If

                'Si hora es igual a 00:00 hrs, solo insertar la fecha
                If hora = 0 Then
                    leavetime = fecha
                Else
                    leavetime = fecha + " " + hrfin
                    leavetime = Format(CDate(leavetime), "dd/MM/yyyy hh:mm:ss tt")
                End If

                'Label1.Text = hora
                'Label2.Text = hrini

                'Buscar el Userid de la tabla USERINFO DE ATTendance donde coincida SSN que es la clave única para empleados
                'If rdr("clave_att").ToString <> "" Then
                cmda = New OleDbCommand("SELECT userid FROM USERINFO WHERE SSN ='" & rdr("clave_att").ToString & "'", dbA)
                rda = cmda.ExecuteReader
                'userid = rda("userid").ToString

                'If userid <> "" Then
                If rda.Read Then
                    cmda2 = New OleDbCommand("INSERT INTO USER_TEMP_SCH (userid, cometime, leavetime, type, flag, schclassid, overtime) VALUES (1, '" & cometime & "', '" & leavetime & "', 0, 1, '" & rdr("id_att").ToString & "',0)", dbA2)
                    cmda2.ExecuteNonQuery()
                    'sw.WriteLine(rdr("clave_att").ToString + " " + rda("userid").ToString + " " + cometime + " " + leavetime + " " + rdr("id_att").ToString)

                    cmda2.Dispose()

                End If


                'End If

                ListBox1.Items.Add(rdr("fecha")).ToString()
            End While
            'sw.Close()
            rdr.Close()
            Label1.Text = "Proceso finalizado con éxito."
        Else
            MsgBox("Selecciona el rango de fechas", vbExclamation)
        End If
    End Sub

    Private Sub btnFechaIni_Click(sender As Object, e As EventArgs)
        mcFechaIni.Visible = True
    End Sub

End Class