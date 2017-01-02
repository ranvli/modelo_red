Imports Microsoft.Office.Interop

Public Class reporte

    Public modeloID As Integer


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        tbMsg.Clear()

        Cursor = Cursors.WaitCursor


        If CheckBox1.Checked Then

            Dim log As DataTable = LogTableAdapter.getDataPorModeloID(modeloID)

            For Each row As DataRow In log.Rows
                mensaje(row.Item("fechahora").ToString + " - " + row.Item("accion").ToString)
            Next

        End If

        'fecha rango
        Dim fechaIni As String = DateTimePicker1.Value.ToString
        Dim fechaFin As String = DateTimePicker2.Value.ToString

        If Not CheckBox1.Checked Then

            Dim log As DataTable = LogTableAdapter.GetDataPorRangoFecha(fechaIni, fechaFin, modeloID)

            For Each row As DataRow In log.Rows
                mensaje(row.Item("fechahora").ToString + " - " + row.Item("accion").ToString)
            Next

        End If

        Cursor = Cursors.Default



    End Sub

    Private Sub mensaje(ByVal msg As String)



        tbMsg.Text = tbMsg.Text + vbCrLf + msg
        tbMsg.Select(tbMsg.Text.Length - 1, 0)
        tbMsg.ScrollToCaret()
        tbMsg.Refresh()

        Application.DoEvents()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        MsgBox("Esta operación toma unos segunditos, aguántese un toque.")

        Cursor = Cursors.WaitCursor


        'salva el documento en un archivo word
        Dim strFileName As String
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        Try
            doc = word.Documents.Add()
            Dim insertText As String = "Reporte de simulación"
            Dim range As Microsoft.Office.Interop.Word.Range = doc.Range(Start:=0, End:=0)
            range.Text = tbMsg.Text
            doc.SaveAs(Application.StartupPath + "\reporte.doc")
        Catch ex As Exception
            MessageBox.Show("Error accesando Word.")
        Finally
            doc.Close(True)
        End Try

        MsgBox("ESPERE MAS.. ABRIENDO WORD Y EL DOCUMENTO RECIEN GENERADO..")

        mensaje("ESPERE MAS.. ABRIENDO WORD Y EL DOCUMENTO RECIEN GENERADO...")
        'abrir el documento gnerado en word
        Dim appWord As New Word.Application
        Dim docWord As New Word.Document

        appWord.Visible = True
        docWord = appWord.Documents.Open(Application.StartupPath.ToString + "\reporte.doc")
        docWord.Activate()

        mensaje("Listo.")

        Cursor = Cursors.Default


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()


    End Sub

    Private Sub reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class