<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Registro_Eventos
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
        Me.CB_Nombre = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBTotal_Asistencias = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimeAsistencia = New System.Windows.Forms.DateTimePicker()
        Me.ListViewAsistencia = New System.Windows.Forms.ListView()
        Me.Matricula = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Carrera = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Area = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fecha_Asistencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GBDatos = New System.Windows.Forms.GroupBox()
        Me.TBSemestre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCarrera = New System.Windows.Forms.TextBox()
        Me.LblCarrera = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CB_Area = New System.Windows.Forms.ComboBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GBClave = New System.Windows.Forms.GroupBox()
        Me.LblMatricula = New System.Windows.Forms.Label()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.EventosDataSet = New VS_FACDYC_Eventos.EventosDataSet()
        Me.AreasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AreasTableAdapter = New VS_FACDYC_Eventos.EventosDataSetTableAdapters.AreasTableAdapter()
        Me.GroupBox3.SuspendLayout()
        Me.GBDatos.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBClave.SuspendLayout()
        CType(Me.EventosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_Nombre
        '
        Me.CB_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Nombre.FormattingEnabled = True
        Me.CB_Nombre.Location = New System.Drawing.Point(360, 37)
        Me.CB_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Nombre.Name = "CB_Nombre"
        Me.CB_Nombre.Size = New System.Drawing.Size(506, 24)
        Me.CB_Nombre.TabIndex = 77
        Me.CB_Nombre.Text = "Teclear primer apellido"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(717, 384)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 37)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 472)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 31)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Total de Asistencias a Eventos:"
        '
        'TBTotal_Asistencias
        '
        Me.TBTotal_Asistencias.Enabled = False
        Me.TBTotal_Asistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBTotal_Asistencias.Location = New System.Drawing.Point(344, 468)
        Me.TBTotal_Asistencias.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTotal_Asistencias.Multiline = True
        Me.TBTotal_Asistencias.Name = "TBTotal_Asistencias"
        Me.TBTotal_Asistencias.Size = New System.Drawing.Size(107, 30)
        Me.TBTotal_Asistencias.TabIndex = 74
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.Location = New System.Drawing.Point(1137, 381)
        Me.Btn_Guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(149, 40)
        Me.Btn_Guardar.TabIndex = 73
        Me.Btn_Guardar.Text = "Registrar Asistencia"
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimeAsistencia)
        Me.GroupBox3.Location = New System.Drawing.Point(890, 12)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(436, 62)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Asistencia:"
        '
        'DateTimeAsistencia
        '
        Me.DateTimeAsistencia.Enabled = False
        Me.DateTimeAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeAsistencia.Location = New System.Drawing.Point(11, 20)
        Me.DateTimeAsistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimeAsistencia.Name = "DateTimeAsistencia"
        Me.DateTimeAsistencia.Size = New System.Drawing.Size(409, 26)
        Me.DateTimeAsistencia.TabIndex = 20
        '
        'ListViewAsistencia
        '
        Me.ListViewAsistencia.AllowColumnReorder = True
        Me.ListViewAsistencia.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Matricula, Me.Carrera, Me.Area, Me.Fecha_Asistencia})
        Me.ListViewAsistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewAsistencia.FullRowSelect = True
        Me.ListViewAsistencia.GridLines = True
        Me.ListViewAsistencia.HideSelection = False
        Me.ListViewAsistencia.Location = New System.Drawing.Point(13, 91)
        Me.ListViewAsistencia.Margin = New System.Windows.Forms.Padding(4)
        Me.ListViewAsistencia.Name = "ListViewAsistencia"
        Me.ListViewAsistencia.Size = New System.Drawing.Size(633, 357)
        Me.ListViewAsistencia.TabIndex = 71
        Me.ListViewAsistencia.UseCompatibleStateImageBehavior = False
        Me.ListViewAsistencia.View = System.Windows.Forms.View.Details
        '
        'Matricula
        '
        Me.Matricula.Text = "MATRICULA"
        Me.Matricula.Width = 100
        '
        'Carrera
        '
        Me.Carrera.Text = "CARRERA"
        Me.Carrera.Width = 100
        '
        'Area
        '
        Me.Area.Text = "AREA"
        Me.Area.Width = 160
        '
        'Fecha_Asistencia
        '
        Me.Fecha_Asistencia.Text = "FECHA_ASISTENCIA"
        Me.Fecha_Asistencia.Width = 180
        '
        'GBDatos
        '
        Me.GBDatos.Controls.Add(Me.TBSemestre)
        Me.GBDatos.Controls.Add(Me.Label1)
        Me.GBDatos.Controls.Add(Me.TBCarrera)
        Me.GBDatos.Controls.Add(Me.LblCarrera)
        Me.GBDatos.Controls.Add(Me.GroupBox4)
        Me.GBDatos.Controls.Add(Me.TBNombre)
        Me.GBDatos.Controls.Add(Me.LblNombre)
        Me.GBDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBDatos.Location = New System.Drawing.Point(654, 91)
        Me.GBDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.GBDatos.Name = "GBDatos"
        Me.GBDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.GBDatos.Size = New System.Drawing.Size(672, 268)
        Me.GBDatos.TabIndex = 70
        Me.GBDatos.TabStop = False
        Me.GBDatos.Text = "Datos del Alumno:"
        '
        'TBSemestre
        '
        Me.TBSemestre.Enabled = False
        Me.TBSemestre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBSemestre.Location = New System.Drawing.Point(86, 150)
        Me.TBSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.TBSemestre.Name = "TBSemestre"
        Me.TBSemestre.Size = New System.Drawing.Size(63, 29)
        Me.TBSemestre.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Semestre:"
        '
        'TBCarrera
        '
        Me.TBCarrera.Enabled = False
        Me.TBCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCarrera.Location = New System.Drawing.Point(86, 96)
        Me.TBCarrera.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCarrera.Name = "TBCarrera"
        Me.TBCarrera.Size = New System.Drawing.Size(63, 29)
        Me.TBCarrera.TabIndex = 3
        '
        'LblCarrera
        '
        Me.LblCarrera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCarrera.Location = New System.Drawing.Point(11, 105)
        Me.LblCarrera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCarrera.Name = "LblCarrera"
        Me.LblCarrera.Size = New System.Drawing.Size(59, 20)
        Me.LblCarrera.TabIndex = 2
        Me.LblCarrera.Text = "Carrera:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CB_Area)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox4.Location = New System.Drawing.Point(257, 96)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(344, 94)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Area:"
        '
        'CB_Area
        '
        Me.CB_Area.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AreasBindingSource, "Area", True))
        Me.CB_Area.DataSource = Me.AreasBindingSource
        Me.CB_Area.DisplayMember = "Area"
        Me.CB_Area.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Area.FormattingEnabled = True
        Me.CB_Area.Location = New System.Drawing.Point(12, 27)
        Me.CB_Area.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_Area.Name = "CB_Area"
        Me.CB_Area.Size = New System.Drawing.Size(324, 24)
        Me.CB_Area.TabIndex = 78
        Me.CB_Area.ValueMember = "Area"
        '
        'TBNombre
        '
        Me.TBNombre.Enabled = False
        Me.TBNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombre.Location = New System.Drawing.Point(63, 40)
        Me.TBNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(593, 26)
        Me.TBNombre.TabIndex = 1
        '
        'LblNombre
        '
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(11, 49)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(85, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'GBClave
        '
        Me.GBClave.Controls.Add(Me.LblMatricula)
        Me.GBClave.Controls.Add(Me.TBMatricula)
        Me.GBClave.Location = New System.Drawing.Point(-7, 12)
        Me.GBClave.Margin = New System.Windows.Forms.Padding(4)
        Me.GBClave.Name = "GBClave"
        Me.GBClave.Padding = New System.Windows.Forms.Padding(4)
        Me.GBClave.Size = New System.Drawing.Size(341, 59)
        Me.GBClave.TabIndex = 69
        Me.GBClave.TabStop = False
        Me.GBClave.Text = "Clave:"
        '
        'LblMatricula
        '
        Me.LblMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMatricula.Location = New System.Drawing.Point(21, 20)
        Me.LblMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMatricula.Name = "LblMatricula"
        Me.LblMatricula.Size = New System.Drawing.Size(96, 20)
        Me.LblMatricula.TabIndex = 0
        Me.LblMatricula.Text = "Matricula:"
        '
        'TBMatricula
        '
        Me.TBMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMatricula.Location = New System.Drawing.Point(127, 14)
        Me.TBMatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.TBMatricula.MaxLength = 7
        Me.TBMatricula.Name = "TBMatricula"
        Me.TBMatricula.Size = New System.Drawing.Size(205, 26)
        Me.TBMatricula.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(345, 12)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(537, 61)
        Me.GroupBox5.TabIndex = 78
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Busqueda por Apellido:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Eventos;Persist Security Info=True;Use" &
    "r ID=sa;Password=Facdyc2020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'EventosDataSet
        '
        Me.EventosDataSet.DataSetName = "EventosDataSet"
        Me.EventosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AreasBindingSource
        '
        Me.AreasBindingSource.DataMember = "Areas"
        Me.AreasBindingSource.DataSource = Me.EventosDataSet
        '
        'AreasTableAdapter
        '
        Me.AreasTableAdapter.ClearBeforeFill = True
        '
        'Frm_Registro_Eventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1361, 578)
        Me.Controls.Add(Me.CB_Nombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBTotal_Asistencias)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ListViewAsistencia)
        Me.Controls.Add(Me.GBDatos)
        Me.Controls.Add(Me.GBClave)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "Frm_Registro_Eventos"
        Me.Text = "Frm_Registro_Eventos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GBDatos.ResumeLayout(False)
        Me.GBDatos.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GBClave.ResumeLayout(False)
        Me.GBClave.PerformLayout()
        CType(Me.EventosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AreasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB_Nombre As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TBTotal_Asistencias As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimeAsistencia As DateTimePicker
    Friend WithEvents ListViewAsistencia As ListView
    Friend WithEvents Matricula As ColumnHeader
    Friend WithEvents Carrera As ColumnHeader
    Friend WithEvents Area As ColumnHeader
    Friend WithEvents Fecha_Asistencia As ColumnHeader
    Friend WithEvents GBDatos As GroupBox
    Friend WithEvents TBCarrera As TextBox
    Friend WithEvents LblCarrera As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents GBClave As GroupBox
    Friend WithEvents LblMatricula As Label
    Friend WithEvents TBMatricula As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents TBSemestre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_Area As ComboBox
    Friend WithEvents EventosDataSet As EventosDataSet
    Friend WithEvents AreasBindingSource As BindingSource
    Friend WithEvents AreasTableAdapter As EventosDataSetTableAdapters.AreasTableAdapter
End Class
