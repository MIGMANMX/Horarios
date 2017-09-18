<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Importacion))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Etiqueta = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Iniciar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(30, 219)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(321, 23)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(60, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Etiqueta
        '
        Me.Etiqueta.AutoSize = True
        Me.Etiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Etiqueta.Location = New System.Drawing.Point(91, 188)
        Me.Etiqueta.Name = "Etiqueta"
        Me.Etiqueta.Size = New System.Drawing.Size(0, 20)
        Me.Etiqueta.TabIndex = 2
        Me.Etiqueta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Iniciar
        '
        Me.Iniciar.Location = New System.Drawing.Point(145, 262)
        Me.Iniciar.Name = "Iniciar"
        Me.Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.Iniciar.TabIndex = 3
        Me.Iniciar.Text = "Iniciar"
        Me.Iniciar.UseVisualStyleBackColor = True
        '
        'Importacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(382, 297)
        Me.Controls.Add(Me.Iniciar)
        Me.Controls.Add(Me.Etiqueta)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Importacion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Etiqueta As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Iniciar As Button
End Class
