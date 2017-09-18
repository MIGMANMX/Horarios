<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportH
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.lblFechaIni = New System.Windows.Forms.Label()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.mcFechaFin = New System.Windows.Forms.MonthCalendar()
        Me.tbFechaFin = New System.Windows.Forms.TextBox()
        Me.mcFechaIni = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFechaIni = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(416, 230)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(140, 56)
        Me.ListBox1.TabIndex = 44
        Me.ListBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(231, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ForeColor = System.Drawing.Color.White
        Me.btnImportar.Location = New System.Drawing.Point(74, 230)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(114, 56)
        Me.btnImportar.TabIndex = 0
        Me.btnImportar.Text = "Importar Horarios"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'lblFechaIni
        '
        Me.lblFechaIni.AutoSize = True
        Me.lblFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIni.Location = New System.Drawing.Point(48, 21)
        Me.lblFechaIni.Name = "lblFechaIni"
        Me.lblFechaIni.Size = New System.Drawing.Size(87, 17)
        Me.lblFechaIni.TabIndex = 32
        Me.lblFechaIni.Text = "Fecha Inicio:"
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaFin.Location = New System.Drawing.Point(358, 20)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(74, 17)
        Me.lblFechaFin.TabIndex = 35
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'mcFechaFin
        '
        Me.mcFechaFin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcFechaFin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcFechaFin.Location = New System.Drawing.Point(308, 51)
        Me.mcFechaFin.MaxSelectionCount = 1
        Me.mcFechaFin.Name = "mcFechaFin"
        Me.mcFechaFin.ShowToday = False
        Me.mcFechaFin.TabIndex = 42
        Me.mcFechaFin.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcFechaFin.TitleForeColor = System.Drawing.Color.White
        '
        'tbFechaFin
        '
        Me.tbFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaFin.Location = New System.Drawing.Point(438, 15)
        Me.tbFechaFin.Name = "tbFechaFin"
        Me.tbFechaFin.Size = New System.Drawing.Size(80, 23)
        Me.tbFechaFin.TabIndex = 36
        '
        'mcFechaIni
        '
        Me.mcFechaIni.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcFechaIni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcFechaIni.Location = New System.Drawing.Point(18, 51)
        Me.mcFechaIni.MaxSelectionCount = 1
        Me.mcFechaIni.Name = "mcFechaIni"
        Me.mcFechaIni.ShowToday = False
        Me.mcFechaIni.TabIndex = 41
        Me.mcFechaIni.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mcFechaIni.TitleForeColor = System.Drawing.Color.White
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Fecha Inicio:"
        '
        'tbFechaIni
        '
        Me.tbFechaIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaIni.Location = New System.Drawing.Point(145, 19)
        Me.tbFechaIni.Name = "tbFechaIni"
        Me.tbFechaIni.Size = New System.Drawing.Size(80, 23)
        Me.tbFechaIni.TabIndex = 33
        '
        'ImportH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 307)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mcFechaFin)
        Me.Controls.Add(Me.mcFechaIni)
        Me.Controls.Add(Me.tbFechaFin)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbFechaIni)
        Me.Controls.Add(Me.lblFechaIni)
        Me.Controls.Add(Me.btnImportar)
        Me.Name = "ImportH"
        Me.Text = "Importar Horarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnImportar As Button
    Friend WithEvents lblFechaIni As Label
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents mcFechaFin As MonthCalendar
    Friend WithEvents tbFechaFin As TextBox
    Friend WithEvents mcFechaIni As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents tbFechaIni As TextBox
End Class
