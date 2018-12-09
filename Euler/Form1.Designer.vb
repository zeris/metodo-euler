<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcular
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbX = New System.Windows.Forms.TextBox()
        Me.tbY = New System.Windows.Forms.TextBox()
        Me.tbH = New System.Windows.Forms.TextBox()
        Me.tbFuncion = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbValorAEvaluar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEulerMejorado = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCS = New System.Windows.Forms.TextBox()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dame el valor de X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dame el valor de Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dame el valor de h"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(374, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dame la función a evaluar"
        '
        'tbX
        '
        Me.tbX.Location = New System.Drawing.Point(9, 49)
        Me.tbX.Name = "tbX"
        Me.tbX.Size = New System.Drawing.Size(100, 20)
        Me.tbX.TabIndex = 4
        '
        'tbY
        '
        Me.tbY.Location = New System.Drawing.Point(132, 49)
        Me.tbY.Name = "tbY"
        Me.tbY.Size = New System.Drawing.Size(100, 20)
        Me.tbY.TabIndex = 5
        '
        'tbH
        '
        Me.tbH.Location = New System.Drawing.Point(257, 49)
        Me.tbH.Name = "tbH"
        Me.tbH.Size = New System.Drawing.Size(100, 20)
        Me.tbH.TabIndex = 6
        '
        'tbFuncion
        '
        Me.tbFuncion.Location = New System.Drawing.Point(377, 49)
        Me.tbFuncion.Name = "tbFuncion"
        Me.tbFuncion.Size = New System.Drawing.Size(103, 20)
        Me.tbFuncion.TabIndex = 7
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(550, 176)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(120, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular por Euler"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(508, 292)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(600, 292)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Salida
        '
        Me.Salida.AllowUserToAddRows = False
        Me.Salida.AllowUserToDeleteRows = False
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(32, 176)
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        Me.Salida.Size = New System.Drawing.Size(344, 270)
        Me.Salida.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Yi"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "X"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Y"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'tbValorAEvaluar
        '
        Me.tbValorAEvaluar.Location = New System.Drawing.Point(508, 49)
        Me.tbValorAEvaluar.Name = "tbValorAEvaluar"
        Me.tbValorAEvaluar.Size = New System.Drawing.Size(100, 20)
        Me.tbValorAEvaluar.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(514, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Dame el valor de x a calcular"
        '
        'btnEulerMejorado
        '
        Me.btnEulerMejorado.Location = New System.Drawing.Point(517, 237)
        Me.btnEulerMejorado.Name = "btnEulerMejorado"
        Me.btnEulerMejorado.Size = New System.Drawing.Size(153, 23)
        Me.btnEulerMejorado.TabIndex = 14
        Me.btnEulerMejorado.Text = "Calcular por Euler mejorado"
        Me.btnEulerMejorado.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Dame las cifras significativas"
        '
        'tbCS
        '
        Me.tbCS.Location = New System.Drawing.Point(9, 124)
        Me.tbCS.Name = "tbCS"
        Me.tbCS.Size = New System.Drawing.Size(100, 20)
        Me.tbCS.TabIndex = 15
        '
        'Calcular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 458)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCS)
        Me.Controls.Add(Me.btnEulerMejorado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbValorAEvaluar)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.tbFuncion)
        Me.Controls.Add(Me.tbH)
        Me.Controls.Add(Me.tbY)
        Me.Controls.Add(Me.tbX)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Calcular"
        Me.Text = "Euler"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbX As TextBox
    Friend WithEvents tbY As TextBox
    Friend WithEvents tbH As TextBox
    Friend WithEvents tbFuncion As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents tbValorAEvaluar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEulerMejorado As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCS As TextBox
End Class
