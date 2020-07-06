Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Frm_Registro_Eventos
    Dim sqlmatricula As New SqlCommand
    Dim sqldrmatricula As SqlDataReader

    Dim sqlsd_buscar_Nombre As New SqlCommand
    Dim sqlda_buscar_nombre As SqlDataReader

    Dim sqlregistro_asistencia_listview As New SqlCommand
    Dim sqldr_registro_asistencia_listview As SqlDataReader

    Dim sqlregistro_asistencia As New SqlCommand
    Dim sqldr_registro_asistencia As SqlDataReader
    Dim sql_Inv_Hojas As New SqlCommand
    Dim sqldr_Inv_Hojas As SqlDataReader
    Dim H_CARTA As Integer = 0
    Dim H_OFICIO As Integer = 0
    Dim RESTO_HOJAS As Integer = 0
    Dim HOJAS_CAPTURADAS As Integer = 0
    Dim TOTAL_HOJAS As Integer = 0
    Dim SW_total_asistencia As Integer = 0

    Dim sw_incidencia As Integer = 0
    Dim SW_VALIDAR_MATRICULA As Integer = 0
    Dim Inventario_Existente_Carta As Integer = 0
    Dim Inventario_Existente_Oficio As Integer = 0
    Dim Inventario_Existente_Mermas As Integer = 0
    Dim SW_Asistencia As Integer = 0
    Dim SW_PagoS As Integer = 0
    Dim SW_PagoN As Integer = 0
    Dim SW_Si_Existe_Matricula As Integer = 0
    Dim drd As Integer = 0
    Dim sqlbuscar_matricula As New SqlCommand
    Dim sqldrbuscar_matricula As SqlDataReader

    Private Sub Frm_Registro_Eventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EventosDataSet.Areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.Fill(Me.EventosDataSet.Areas)
        Call cargar_nombre_alumnos()

    End Sub

    Sub cargar_nombre_alumnos()
        Try
            Me.SqlConnection1.Open()
            sqlsd_buscar_Nombre.CommandType = CommandType.Text
            sqlsd_buscar_Nombre.CommandText = ("select  Nombre,Matricula  from Alumnos order by Nombre asc")
            sqlsd_buscar_Nombre.Connection = Me.SqlConnection1
            sqlda_buscar_nombre = sqlsd_buscar_Nombre.ExecuteReader()
            While sqlda_buscar_nombre.Read = True
                CB_Nombre.Items.Add(sqlda_buscar_nombre.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqlsd_buscar_Nombre.CommandType = CommandType.StoredProcedure
        sqlsd_buscar_Nombre.Connection = Me.SqlConnection1
        sqlsd_buscar_Nombre.CommandText = ("Buscar_Nombre_Alumno_Eventos")
        sqlsd_buscar_Nombre.Parameters.Add("var_nombre_Alumno", SqlDbType.NVarChar, 50)
        sqlda_buscar_nombre.Close()
        Me.SqlConnection1.Close()
    End Sub

    Private Sub CB_Nombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Nombre.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            sqlsd_buscar_Nombre.Parameters("var_nombre_Alumno").Value = CB_Nombre.SelectedItem
            sqlda_buscar_nombre = sqlsd_buscar_Nombre.ExecuteReader()
            sqlda_buscar_nombre.Read()
            TBMatricula.Text = sqlda_buscar_nombre("Matricula").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'Return
        Me.SqlConnection1.Close()
        Me.TBMatricula.Focus()
    End Sub

    Sub Validar_existencia_matricula()
        'SW_Si_Existe_Matricula = 0
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandText = CommandType.Text
            sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula= '" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                'SW_PagoS = 1
                'Btn_Guardar.Enabled = True
                'Me.TBNombre.Text = sqldrmatricula("Nombre")
                'Me.TBCarrera.Text = sqldrmatricula("Carrera")
                'Me.TBPagoCurso.Text = sqldrmatricula("Pago_Curso")
                'Me.TBAula.Text = sqldrmatricula("Aula")
                'sqldrmatricula.Close()
                'Me.SqlConnection1.Close()
            Else
                ' SW_Si_Existe_Matricula = 2
                MsgBox("No existe registro de Alumno <<Favor de pedir comprobante>> ")
                sqldrmatricula.Close()
                Me.SqlConnection1.Close()
                Call LIMPIAR_CAMPOS()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()
    End Sub

    Sub validar_Asistencia()
        'Call validar_pago_matricula()
        SW_Asistencia = 0
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandText = CommandType.Text
            sqlmatricula.CommandText = ("Select * from Asistencias where Asistencias.matricula= '" & TBMatricula.Text & "'" & "AND  Fecha_Asistencia='" & Format(DateTimeAsistencia.Value.Date.ToString, "Short Date") & "'")
            'sqlmatricula.CommandText = ("Select * from Aspirantes where Aspirantes.matricula= '" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                SW_Asistencia = 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_matricula_Si()
        SW_PagoS = 0
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandText = CommandType.Text
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula= '" & TBMatricula.Text & "'" & "AND Pago_Curso='" & "S" & "'")
            sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula='" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                SW_PagoS = 1
                Btn_Guardar.Enabled = True
                Me.TBNombre.Text = sqldrmatricula("Nombre")
                Me.TBCarrera.Text = sqldrmatricula("Carrera")
                Me.TBSemestre.Text = sqldrmatricula("Semestre")
                ' Me.CB_Area.Text = sqldrmatricula("Area")
                'Me.TBTurno.Text = sqldrmatricula("Turno")

                sqldrmatricula.Close()
                Me.SqlConnection1.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()


    End Sub
    Sub buscar_matricula_NopagoCurso()
        SW_PagoN = 0

        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandText = CommandType.Text
            'sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula= '" & TBMatricula.Text & "'" & "AND Pago_Curso='" & "N" & "'")
            sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula= '" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                SW_PagoN = 1
                Btn_Guardar.Enabled = True
                Me.TBNombre.Text = sqldrmatricula("Nombre")
                Me.TBCarrera.Text = sqldrmatricula("Carrera")
                Me.TBSemestre.Text = sqldrmatricula("Semestre")
                Me.CB_Area.Text = sqldrmatricula("Area")
                'Me.TBTurno.Text = sqldrmatricula("Turno")
                MsgBox("Matricula Pendiente de pago << Favor de Pedir comprobante >>")
                sqldrmatricula.Close()
                Me.SqlConnection1.Close()
            Else
                ' SW_No_existe_Matricula = 1
                'MsgBox("No existe registro de Alumnos, favor de pedir comprobante.")
                'sqldrmatricula.Close()
                ' Me.SqlConnection1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()


    End Sub
    Sub seleccionar_matricula_ConAsistenciaRegistrada()
        'SW_Si_Existe_Matricula = 0
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandText = CommandType.Text
            'sqlmatricula.CommandText = ("Select * from Aspirantes where Aspirantes.matricula= '" & TBMatricula.Text & "'" & "AND Pago_Curso='" & "S" & "'" & "OR Pago_Curso='" & "N" & "'")
            sqlmatricula.CommandText = ("Select * from Alumnos where Alumnos.matricula= '" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then

                Me.TBNombre.Text = sqldrmatricula("Nombre")
                Me.TBCarrera.Text = sqldrmatricula("Carrera")
                Me.TBSemestre.Text = sqldrmatricula("Semestre")
                'Me.CB_Area.Text = sqldrmatricula("Area")
                'Me.TBTurno.Text = sqldrmatricula("Turno")
                'Else
                'SW_Si_Existe_Matricula = 1
                '    MsgBox("No existe registro de Alumnos, favor de pedir comprobante.")
                '    sqldrmatricula.Close()
                '    Me.SqlConnection1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()

    End Sub
    Sub registro_asistencia()
        Try
            '   ' If agregardatos = vbYes Then
            Me.SqlConnection1.Open()
            ''sin usuario
            Dim Ins_asistencia_propedeutico As String = "INSERT INTO Asistencias (Matricula,Nombre,Carrera,Semestre,Area,Fecha_Asistencia) values(@Matricula,@Nombre,@Carrera,@Semestre,@Area,@Fecha_Asistencia)"

            ''Con usuario
            'Dim Ins_asistencia_propedeutico As String = "INSERT INTO Asistencia (Matricula,Nombre,Carrera,Area,Fecha_Asistencia,Usuario) values(@Matricula,@Nombre,@Carrera,@Aula,@Fecha_Asistencia,@Usuario)"

            Dim ConexA As New SqlClient.SqlCommand(Ins_asistencia_propedeutico, Me.SqlConnection1)
            ConexA.Parameters.Add(New SqlParameter("@Matricula", SqlDbType.NChar, 7)).Value = Me.TBMatricula.Text
            ConexA.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
            ConexA.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NChar, 1)).Value = Me.TBCarrera.Text
            ConexA.Parameters.Add(New SqlParameter("@Semestre", SqlDbType.NChar, 2)).Value = Me.TBSemestre.Text
            ConexA.Parameters.Add(New SqlParameter("@Area", SqlDbType.NChar, 10)).Value = Me.CB_Area.Text
            ConexA.Parameters.Add(New SqlParameter("@Fecha_Asistencia", SqlDbType.SmallDateTime)).Value = DateTimeAsistencia.Text
            'ConexA.Parameters.Add(New SqlParameter("@Turno", SqlDbType.NChar, 10)).Value = Me.TBAula.Text

            'ConexA.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar, 20)).Value = Frm_login.USUARIO_IMPRESIONES
            ConexA.CommandText = Ins_asistencia_propedeutico
            ConexA.ExecuteNonQuery()
            Me.SqlConnection1.Close()

            MsgBox("Datos guardados correctamente", , "Guardar")
            Call LIMPIAR_CAMPOS()
            ''End If
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub actualizar_total_asistencia()
        SW_total_asistencia = 0
        SW_total_asistencia = Val(Me.TBTotal_Asistencias.Text) + 1
        'MsgBox(SW_total_asistencia)
        Try
            Me.SqlConnection1.Open()
            Dim Actualizar_Asistencia As String = ("UPDATE Alumnos SET Total_Asistencias=@Total_Asistencias  WHERE Matricula = '" & TBMatricula.Text & "'")
            Dim ConexA As New SqlClient.SqlCommand(Actualizar_Asistencia, Me.SqlConnection1)
            ConexA.Parameters.Add(New SqlParameter("@Total_Asistencias", SqlDbType.Int)).Value = SW_total_asistencia.ToString
            ConexA.CommandText = Actualizar_Asistencia
            ConexA.ExecuteNonQuery()
            Me.SqlConnection1.Close()

            'MsgBox("Datos guardados correctamente", , "Guardar")
            'Call LIMPIAR_CAMPOS()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub TBMatricula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBMatricula.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            'RadioButtonCarta.Focus()
            MsgBox("No se pueden ingresar letra")
        End If
        If Asc(e.KeyChar) = 13 Then
            Call Validar_existencia_matricula()
            Call validar_Asistencia()
            If SW_Asistencia = 1 Then
                Call cargar_lisview()
                Call contar_registros_asistencia()
                Call seleccionar_matricula_ConAsistenciaRegistrada()
                MsgBox("Ya fue registrada la Asistencia de hoy para esta matricula")
                Btn_Guardar.Enabled = False
                Call LIMPIAR_CAMPOS()
                Return
            End If

            Call buscar_matricula_Si()
            If SW_PagoS = 1 Then
                Call cargar_lisview()
                Call contar_registros_asistencia()
                Call actualizar_total_asistencia()
                Btn_Guardar.Focus()
                Return
            Else
                Call buscar_matricula_NopagoCurso()
                If SW_PagoN = 1 Then
                    Call cargar_lisview()
                    Call contar_registros_asistencia()
                    Call actualizar_total_asistencia()
                    Btn_Guardar.Focus()
                    Return
                Else
                    'Call validar_pago_matricula()
                    'Call seleccionar_matricula_ConAsistenciaRegistrada()
                    drd = 0
                    Me.TBMatricula.Focus()
                End If
            End If
            ' Call LIMPIAR_CAMPOS()
        End If
    End Sub
    Sub cargar_lisview()
        Try
            Me.SqlConnection1.Open()
            'CBA2.Items.Clear()
            ListViewAsistencia.Items.Clear()
            sqlregistro_asistencia_listview.CommandType = CommandType.Text
            sqlregistro_asistencia_listview.CommandText = ("Select Matricula,Carrera,Area,Fecha_Asistencia from Asistencias where Asistencias.Matricula =  '" & TBMatricula.Text & "'")
            sqlregistro_asistencia_listview.Connection = Me.SqlConnection1
            sqldr_registro_asistencia_listview = sqlregistro_asistencia_listview.ExecuteReader()

            While (sqldr_registro_asistencia_listview.Read())
                With ListViewAsistencia.Items.Add(sqldr_registro_asistencia_listview("Matricula"))
                    '.subitems.add(sqldr_registro_hojas("Nombre"))
                    .SubItems.Add(sqldr_registro_asistencia_listview("Carrera"))
                    .SubItems.Add(sqldr_registro_asistencia_listview("Area"))

                    'If Not IsDBNull(sqldr_registro_asistencia_listview("Hojas_Carta")) Then
                    '.SubItems.Add(sqldr_registro_asistencia_listview("Hojas_Carta"))
                    'End If

                    .SubItems.Add(sqldr_registro_asistencia_listview("Fecha_Asistencia"))
                End With
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldr_registro_asistencia_listview.Close()
        Me.SqlConnection1.Close()

    End Sub

    Sub contar_registros_asistencia()
        Dim drd As Integer = 0
        Try
            Me.SqlConnection1.Open()
            Dim consulta_asistencia As String = ("Select count (*)  from Asistencias where Asistencias.matricula= '" & TBMatricula.Text & "'")
            Dim sqlcomando_asistencia As New SqlCommand(consulta_asistencia, Me.SqlConnection1)
            drd = sqlcomando_asistencia.ExecuteScalar()
            If drd.ToString > 0 Then

                'MsgBox(drd)
                Me.TBTotal_Asistencias.Text = drd.ToString
                ' Me.TxtNumeroCompra.Text = drd.ToString + 1
                ' con.Close()
            Else
                drd = 0
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()

        'Else
        'Call LIMPIAR_CAMPOS()
        'End If
    End Sub

    Sub LIMPIAR_CAMPOS()
        TBMatricula.Text = ""
        TBNombre.Text = ""
        TBCarrera.Text = ""
        'TBPagoCurso.Text = ""
        TBTotal_Asistencias.Text = ""
        'CB_Area.Text = ""
        'TBTurno.Text = ""
        CB_Nombre.Text = ""
        drd = 0
        TBMatricula.Focus()
        ListViewAsistencia.Items.Clear()
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Call registro_asistencia()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call LIMPIAR_CAMPOS()
    End Sub


End Class