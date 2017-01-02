Imports System.Drawing.Drawing2D
Imports Microsoft.Office.Interop

Public Class editor

    'modelo id
    Public modeloID As Integer

    Dim opcionMenu As Integer = 1

    'posicion del mouse en el panel
    Dim curPosX As Integer
    Dim curPosY As Integer

    'tamano de la bolita
    Dim tam As Integer = 20
    'valor de los nodos
    Dim numNodo As Integer = 0
    'nodo seleccionado
    Dim nSelec As nodo
    Dim nodoSel As Integer = 0
    Dim nodoPrincipal As Integer = 0

    'nodo receptor
    Dim nConec As nodo
    Dim conectando As Boolean

    'accion
    Dim accion As String = "colocaNodo"

    'colores
    Dim colorNodoPrinc As Brush = Brushes.Green
    Dim colorNodoSel As Brush = Brushes.Yellow
    Dim colorNodoSelPrinc As Brush = Brushes.YellowGreen
    Dim ColorfondoEditor As Color = Color.SkyBlue
    Dim colorTexto As Brush = Brushes.DarkOrange
    Dim colorCamino As Color = Color.Yellow

    'nodos del modelo
    Dim nodos As ArrayList = New ArrayList
    Dim tablaNodos As DataTable
    Dim tnodosImpacto As Integer

    'array de verif enciclamiento
    Dim cEnciclaSim As ArrayList = New ArrayList
    Dim vEnciclaSim As ArrayList = New ArrayList
    Dim naEnciclaSim As ArrayList = New ArrayList
    Dim nodosProcesados As ArrayList = New ArrayList

    'array de bitacora
    Dim log As ArrayList = New ArrayList
    Dim reprep As ArrayList = New ArrayList

    Private Sub creaNodo(ByVal posX As Integer, ByVal posY As Integer)

        'aumenta el numero de nodo a insertar
        numNodo += 1

        'inserta el nodo en el cache de nodos de este modelo
        nodos.Add(New nodo(posX, posY, numNodo, "", New ArrayList(), True))

        'bitacora
        mensaje("Nodo ha sido creado. Nodo id = " + numNodo.ToString)

        dibujaNodos()

    End Sub
    Private Sub quitaNodo(ByVal posX As Integer, ByVal posY As Integer)

        Dim nodoValorAremover As Integer = nodoSenalado(posX, posY)

        'borra el nodo en el cache de nodos de este modelo
        nodos.Remove(getInfoNodo(nodoSenalado(posX, posY)))

        'remueve referencias de hijos a ese nodo borrado
        Dim nodosTMP As ArrayList = New ArrayList

        For Each nodo As nodo In nodos
            nodosTMP.Add(nodo)
        Next

        For Each nodo As nodo In nodosTMP
            nodo.hijos.Remove(nodoValorAremover)
            ModificaNodo(nodo.valor, -1, -1, -1, Nothing, nodo.hijos, -1)
        Next

        'bitacora
        mensaje("Nodo ha sido removido. Nodo id = " + nodoValorAremover.ToString)

        dibujaNodos()

    End Sub
    Private Sub dibujaNodos()


        'crea los grafcos en el panel1 y limpia el panel
        Dim g As Graphics = Panel1.CreateGraphics
        g.Clear(ColorfondoEditor)

        'recorre el arraylist de nodos y los dibuja todos
        For Each nodo As nodo In nodos
            dibujaNodo(nodo, False, Nothing)
        Next


    End Sub

    Private Sub dibujaNodo(ByVal nodo As nodo, ByVal simula As Boolean, ByVal colorSimula As Brush)


        'crea los grafcos en el panel1
        Dim g As Graphics = Panel1.CreateGraphics


        'dibuja el nodo, la bolita
        g.DrawEllipse(Pens.Black, nodo.posX, nodo.posY, tam, tam)

        'cambia el color del nodo seleccionado si el valor es igual al del seleccionado
        Dim treduc As Integer = Convert.ToInt16(tam / 15)
        Dim tmov As Integer = Convert.ToInt16(tam / 39)

        'cambia color del nodo seleccionado
        If nodo.valor = nodoSel Then g.FillEllipse(colorNodoSel, nodo.posX + tmov, nodo.posY + tmov, tam - treduc, tam - treduc)

        'cambia el color del nodo principal 
        If nodo.valor = nodoPrincipal Then g.FillEllipse(colorNodoPrinc, nodo.posX + tmov, nodo.posY + tmov, tam - treduc, tam - treduc)

        'si el nodo es el seleccionado y es tambien el principal
        If nodo.valor = nodoSel And nodo.valor = nodoPrincipal Then g.FillEllipse(colorNodoSelPrinc, nodo.posX + tmov, nodo.posY + tmov, tam - treduc, tam - treduc)

        'si esta en simulación pintarlo con el color de ke tiene conexcion
        If simula Then g.FillEllipse(colorSimula, nodo.posX + tmov, nodo.posY + tmov, tam - treduc, tam - treduc)

        'le pone el numero aentrsho
        g.DrawString(nodo.valor.ToString, New Font("Arial", tam / 2), colorTexto, nodo.posX, nodo.posY + (tam / 7))

        'le pone el nombre del nodo ajuerita
        g.DrawString(nodo.nombre, New Font("Arial", tam / 2), colorTexto, nodo.posX + tam, nodo.posY)

        'le pone el estado encendido
        If nodo.encendido Then g.DrawString("ON", New Font("Arial", tam / 4), Brushes.DarkGreen, nodo.posX - tam, nodo.posY)
        If Not nodo.encendido Then g.DrawString("OFF", New Font("Arial", tam / 4), Brushes.DarkRed, nodo.posX - tam, nodo.posY)

        'dibuja llas conectivas a los hijos
        If nodo.hijos.Count > 0 Then
            Dim nPXY As ArrayList
            Dim nPXYrecep As ArrayList
            Dim nCon As nodo

            For Each nhijo In nodo.hijos
                nCon = getInfoNodo(nhijo) 'carga el nodo hijo destino
                nPXY = transformaPosaNodoX(nodo, nCon.posX, nCon.posY) 'calcula pos de arista salida hasta nCon
                nPXYrecep = transformaPosaNodoX(nCon, nodo.posX, nodo.posY) 'calcula pos de arista salida hasta nodo

                'g.DrawLine(Pens.Black, nPXY(0), nPXY(1), nPXYrecep(0), nPXYrecep(1))

                'dibuja direccion
                'crea cusotm flecha
                Dim mFlecha As New AdjustableArrowCap(tam / 2, tam / 2, False)
                Dim cFlecha As CustomLineCap = mFlecha
                Dim aristaDirigida As New Pen(Color.Blue, 1)
                aristaDirigida.StartCap = Drawing2D.LineCap.RoundAnchor
                aristaDirigida.CustomEndCap = cFlecha


                g.DrawLine(aristaDirigida, nPXY(0), nPXY(1), nPXYrecep(0), nPXYrecep(1))



            Next
        End If



    End Sub
    Private Function transformaPosaNodo(ByVal nSelec As nodo) As ArrayList

        Dim res As New ArrayList
        Dim nodoPx As Integer
        Dim nodoPy As Integer
        Dim pXmax As Integer = nSelec.posX + tam
        Dim pXmin As Integer = nSelec.posX

        Dim pYmax As Integer = nSelec.posY + tam
        Dim pYmin As Integer = nSelec.posY

        nodoPx = pXmin
        nodoPy = pYmin

        For x = pXmin To curPosX
            If x > pXmax Then Exit For
            nodoPx = x
        Next

        For y = pYmin To curPosY
            If y > pYmax Then Exit For
            nodoPy = y
        Next


        'ajuste de las esquinas

        If curPosY >= pYmax Then
            If nodoPx <= pXmin + (tam / 4) Then nodoPy -= (pXmin + (tam / 4)) - nodoPx
            If nodoPx >= pXmax - (tam / 4) Then nodoPy -= nodoPx - (pXmax - (tam / 4))
        End If

        If curPosY <= pYmin Then
            If nodoPx <= pXmin + (tam / 4) Then nodoPy += (pXmin + (tam / 4)) - nodoPx
            If nodoPx >= pXmax - (tam / 4) Then nodoPy += nodoPx - (pXmax - (tam / 4))
        End If

        If curPosX >= pXmax Then
            If nodoPy <= pYmin + (tam / 4) Then nodoPx -= (pYmin + (tam / 4)) - nodoPy
            If nodoPy >= pYmax - (tam / 4) Then nodoPx -= nodoPy - (pYmax - (tam / 4))
        End If
        If curPosX <= pXmin Then
            If nodoPy <= pYmin + (tam / 4) Then nodoPx += (pYmin + (tam / 4)) - nodoPy
            If nodoPy >= pYmax - (tam / 4) Then nodoPx += nodoPy - (pYmax - (tam / 4))
        End If



        res.Add(nodoPx)
        res.Add(nodoPy)


        Return res


    End Function


    Private Function transformaPosaNodoX(ByVal nSelec As nodo, ByVal posRecepX As Integer, ByVal posRecepY As Integer) As ArrayList

        Dim res As New ArrayList

        'resultados a devolver
        Dim nodoPx As Integer
        Dim nodoPy As Integer

        Dim pXmax As Integer = nSelec.posX + tam
        Dim pXmin As Integer = nSelec.posX

        Dim pYmax As Integer = nSelec.posY + tam
        Dim pYmin As Integer = nSelec.posY

        nodoPx = pXmin
        nodoPy = pYmin

        For x = pXmin To posRecepX
            If x > pXmax Then Exit For
            nodoPx = x
        Next

        For y = pYmin To posRecepY
            If y > pYmax Then Exit For
            nodoPy = y
        Next


        'ajuste de las esquinas

        If posRecepY >= pYmax Then
            If nodoPx <= pXmin + (tam / 4) Then nodoPy -= (pXmin + (tam / 4)) - nodoPx
            If nodoPx >= pXmax - (tam / 4) Then nodoPy -= nodoPx - (pXmax - (tam / 4))
        End If

        If posRecepY <= pYmin Then
            If nodoPx <= pXmin + (tam / 4) Then nodoPy += (pXmin + (tam / 4)) - nodoPx
            If nodoPx >= pXmax - (tam / 4) Then nodoPy += nodoPx - (pXmax - (tam / 4))
        End If

        If posRecepX >= pXmax Then
            If nodoPy <= pYmin + (tam / 4) Then nodoPx -= (pYmin + (tam / 4)) - nodoPy
            If nodoPy >= pYmax - (tam / 4) Then nodoPx -= nodoPy - (pYmax - (tam / 4))
        End If
        If posRecepX <= pXmin Then
            If nodoPy <= pYmin + (tam / 4) Then nodoPx += (pYmin + (tam / 4)) - nodoPy
            If nodoPy >= pYmax - (tam / 4) Then nodoPx += nodoPy - (pYmax - (tam / 4))
        End If



        res.Add(nodoPx)
        res.Add(nodoPy)


        Return res


    End Function
    Private Function getInfoNodo(ByVal numNodoBusca As Integer) As nodo

        'busca en los nodos el numero de nodo seleccionado y retorna ese nodo
        For Each nodo As nodo In nodos
            If nodo.valor = numNodoBusca Then
                Return nodo
            End If
        Next

        Dim nodoNulo As New nodo(-1, -1, -1, Nothing, Nothing, False)
        Return nodoNulo


    End Function


    Private Function nodoSenalado(ByVal posActX As Integer, ByVal posActY As Integer) As Integer
        'retorna el numero de nodo, EL ID

        Dim xEnRango As Boolean
        Dim yEnRango As Boolean

        For Each nodo As nodo In nodos
            xEnRango = False
            yEnRango = False

            For it = 0 To tam
                If nodo.posX + it = posActX Then
                    xEnRango = True
                End If
            Next
            For it = 0 To tam
                If nodo.posY + it = posActY Then
                    yEnRango = True
                End If
            Next
            If xEnRango And yEnRango Then Return nodo.valor
        Next

        Return 0

    End Function
    Private Sub dibujaArista()


        'refresca los nodos y limpia aristas viejas
        dibujaNodos()

        Dim g As Graphics = Panel1.CreateGraphics

        Dim nodopX As Integer
        Dim nodopY As Integer
        Dim nPXY As ArrayList = transformaPosaNodo(nSelec)

        nodopX = nPXY(0)
        nodopY = nPXY(1)

        'g.DrawLine(Pens.Black, nodopX, nodopY, curPosX, curPosY)

        'dibuja direccion
        'crea cusotm flecha
        Dim mFlecha As New AdjustableArrowCap(tam / 2, tam / 2, False)
        Dim cFlecha As CustomLineCap = mFlecha
        Dim colAc As Color

        If accion = "quitaConectiva" Then colAc = Color.Red
        If accion = "colocaConectiva" Then colAc = Color.Blue

        Dim aristaDirigida As New Pen(colAc, 1)
        aristaDirigida.StartCap = Drawing2D.LineCap.RoundAnchor
        aristaDirigida.CustomEndCap = cFlecha

        g.DrawLine(aristaDirigida, nodopX, nodopY, curPosX, curPosY)




    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown

        'si es el boton derecho entones crear nodo
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If accion = "colocaNodo" Then creaNodo(curPosX, curPosY)
            If accion = "quitaNodo" Then quitaNodo(curPosX, curPosY)
            If accion = "colocaConectiva" Or accion = "quitaConectiva" Then selnodoCurPos()
        End If

        If e.Button = Windows.Forms.MouseButtons.Left Then
            selnodoCurPos()
        End If


        Panel1.Focus()

    End Sub
    Private Sub selnodoCurPos()

        'actualiza la variable global del nodo seleccionado
        nodoSel = nodoSenalado(curPosX, curPosY)

        If nodoSel = 0 Then
            lbNodoSel.Text = "Nodo señalado : ninguno"
            lbPrinc.Text = "Es principal : "
            lbEncendido.Text = "Encendido : "
            tbNomNodo.Text = ""
            nSelec.valor = -1
            dibujaNodos()
            Exit Sub 'salir si no hay ningun nodo seleccionado
        End If


        'carga en nSelec el nodo seleccionado
        nSelec = getInfoNodo(nodoSel)

        'carga la informacion del nodo con el numero de nodo seleccionado
        lbNodoSel.Text = "Id del nodo : " + nSelec.valor.ToString
        tbNomNodo.Text = nSelec.nombre

        lbPrinc.Text = "Es principal : No"
        If nodoSel = nodoPrincipal Then lbPrinc.Text = "Es principal : Si"

        lbEncendido.Text = "Encendido : No"
        btEncAp.Text = "Encender nodo"

        If nSelec.encendido Then
            lbEncendido.Text = "Encendido : Si"
            btEncAp.Text = "Apagar nodo"
        End If

        dibujaNodos()


    End Sub
    Private Sub escribeEnPanel(ByVal msg As String, ByVal posX As Integer, ByVal posY As Integer)

        Dim g As Graphics = Panel1.CreateGraphics
        g.DrawString(msg, New Font("Arial", 8), Brushes.DarkOrange, posX, posY)

    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove


        curPosX = e.X
        curPosY = e.Y

        ToolStripStatusLabel2.Text = "   -   Posición sobre el panel X: " + curPosX.ToString + ", Y: " + curPosY.ToString

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If accion = "colocaConectiva" Or accion = "quitaConectiva" And nSelec.valor <> -1 Then
                dibujaArista()
                conectando = True
                'ver si hay un nodo receptor en donde sta arrastrando la arista para
                'desplegar la informacion y fijar el nConec ke es el receptor
                nConec = getInfoNodo(nodoSenalado(curPosX, curPosY))
                If nConec.valor <> -1 And nodoSenalado(curPosX, curPosY) <> 0 And nodoSenalado(curPosX, curPosY) <> nodoSel Then
                    If accion = "colocaConectiva" Then escribeEnPanel("Establecer conexión con nodo " + nConec.valor.ToString, curPosX, curPosY)
                    If accion = "quitaConectiva" Then escribeEnPanel("Quitar conexión con nodo " + nConec.valor.ToString, curPosX, curPosY)
                End If
            End If
        End If

        If e.Button = Windows.Forms.MouseButtons.Left Then
            'arrastra nodo
            If nodoSel = 0 Then Exit Sub
            ToolStripStatusLabel1.Text = "Arrastrando nodo id: " + nodoSel.ToString
            ModificaNodo(nodoSel, curPosX, curPosY, -1, Nothing, Nothing, -1)
            dibujaNodos()
        End If

        If e.Button = Windows.Forms.MouseButtons.None Then
            Timer1.Enabled = True 'status strip
        End If



    End Sub
    Public Structure infoBitacora

        Private _fecha As Date
        Private _msg As String

        Public Property fecha() As Date
            Get
                Return _fecha
            End Get
            Set(ByVal value As Date)
                _fecha = value
            End Set
        End Property

        Public Property msg() As String
            Get
                Return _msg
            End Get
            Set(ByVal value As String)
                _msg = value
            End Set
        End Property

        Public Sub New(ByRef fecha As Date, ByRef msg As String)
            _fecha = fecha
            _msg = msg
        End Sub

    End Structure

    Public Structure nodo
        Private _posX As Integer
        Private _posY As Integer
        Private _valor As Integer
        Private _nombre As String
        Private _encendido As Boolean
        Private _hijos As ArrayList

        Public Property encendido() As Boolean
            Get
                Return _encendido
            End Get
            Set(ByVal value As Boolean)
                _encendido = value
            End Set
        End Property
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Public Property valor() As Integer
            Get
                Return _valor
            End Get
            Set(ByVal value As Integer)
                _valor = value
            End Set
        End Property

        Public Property posX() As Integer
            Get
                Return _posX
            End Get
            Set(ByVal value As Integer)
                _posX = value
            End Set
        End Property
        Public Property posY() As Integer
            Get
                Return _posY
            End Get
            Set(ByVal value As Integer)
                _posY = value
            End Set
        End Property
        Public Property hijos() As ArrayList
            Get
                Return _hijos
            End Get
            Set(ByVal value As ArrayList)
                _hijos = value
            End Set
        End Property

        Public Sub New(ByRef posX As Integer, ByRef posY As Integer, ByRef valor As Integer, ByRef nombre As String, ByRef hijos As ArrayList, ByRef status As Boolean)
            _posX = posX
            _posY = posY
            _valor = valor
            _nombre = nombre
            _hijos = hijos
            _encendido = status
        End Sub

    End Structure

    Private Sub tbNomNodo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNomNodo.TextChanged


        If nodoSel = 0 Then Exit Sub 'salir si no hay ningun nodo seleccionado

        'carga en nSelec el nodo seleccionado
        Dim nSelec As nodo = getInfoNodo(nodoSel)

        'cambia el campo del nombre del nodo seleccioado
        ModificaNodo(nodoSel, -1, -1, -1, tbNomNodo.Text, Nothing, -1)
        dibujaNodos()


    End Sub


    Private Sub ModificaNodo(ByVal valNodoAMod As Integer, ByVal posX As Integer, ByVal posY As Integer, ByVal valor As Integer, ByVal nombre As String, ByVal hijos As ArrayList, ByVal encendido As Integer)


        'carga en nSelec el nodo seleccionado
        Dim nSt As nodo = getInfoNodo(valNodoAMod)

        'remueve el nodo de cache de nodos
        nodos.Remove(nSt)

        'modifica la info del nodo jalao
        If posX <> -1 Then nSt.posX = posX
        If posY <> -1 Then nSt.posY = posY
        If valor <> -1 Then nSt.valor = valor

        'If encendido = -1 Then nSt.encendido = encendido
        If encendido = 0 Then nSt.encendido = False
        If encendido = 1 Then nSt.encendido = True

        If nombre Is Nothing Then
            nodos.Add(New nodo(nSt.posX, nSt.posY, nSt.valor, nSt.nombre, nSt.hijos, nSt.encendido))
            Exit Sub
        End If
        nSt.nombre = nombre

        If hijos Is Nothing Then
            nodos.Add(New nodo(nSt.posX, nSt.posY, nSt.valor, nSt.nombre, nSt.hijos, nSt.encendido))
            Exit Sub
        End If

        nSt.hijos = hijos
        nodos.Add(New nodo(nSt.posX, nSt.posY, nSt.valor, nSt.nombre, nSt.hijos, nSt.encendido))


    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp



        If e.Button = Windows.Forms.MouseButtons.Right And (accion = "colocaConectiva" Or accion = "quitaConectiva") And conectando And nConec.valor <> -1 And nSelec.valor <> -1 Then
            If nodoSenalado(curPosX, curPosY) <> 0 Then
                If accion = "colocaConectiva" Then estableceHijo()
                If accion = "quitaConectiva" Then quitaHijo()
            End If
            conectando = False
            nConec.valor = -1
        End If

        If nodoSenalado(curPosX, curPosY) = 0 Or nSelec.valor = -1 Or nConec.valor = -1 Then dibujaNodos()


    End Sub
    Private Sub quitaHijo()
        'quita como hijo nSelec actual al nConec actual


        'ver si ya existe la conectiva
        If Not nSelec.hijos.Contains(nConec.valor.ToString) Then
            MsgBox("No existe conexión con este nodo.")
            dibujaNodos()
            Exit Sub
        End If

        'quita al arraylist del nodo seleccionado el valor del nodo receptor
        nSelec.hijos.Remove(nConec.valor.ToString)

        'modifica el nodo con la nuevo arraylist de hijos
        ModificaNodo(nodoSel, -1, -1, -1, Nothing, nSelec.hijos, -1)

        'refresca diagrama
        dibujaNodos()

        'bitacora
        mensaje("Conexión con nodo " + nConec.valor.ToString + " ha sido removido del nodo id " + nodoSel.ToString)


    End Sub
    Private Sub estableceHijo()
        'establece como hijo nSelec actual al nConec actual


        'ver si ya existe la conectiva
        If nSelec.hijos.Contains(nConec.valor.ToString) Then
            MsgBox("Ya existe conexión con este nodo.")
            dibujaNodos()
            Exit Sub
        End If

        'agrega al arraylist del nodo seleccionado el valor del nodo receptor
        nSelec.hijos.Add(nConec.valor.ToString)

        'modifica el nodo con la nuevo arraylist de hijos
        ModificaNodo(nodoSel, -1, -1, -1, Nothing, nSelec.hijos, -1)

        'refresca diagrama
        dibujaNodos()

        'bitacora
        mensaje("Conexión con nodo " + nConec.valor.ToString + " ha sido agregado al nodo id " + nodoSel.ToString)


    End Sub
    Private Sub Panel1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseWheel


        If (e.Delta) > 0 Then
            opcionMenu -= 1
        End If

        If (e.Delta) < 0 Then
            opcionMenu += 1
        End If


        If opcionMenu = 0 Then opcionMenu = 4
        If opcionMenu = 5 Then opcionMenu = 1

        Select Case opcionMenu
            Case Is = 1
                Call Label1_Click(Nothing, Nothing)
            Case Is = 2
                Call lbQnodo_Click(Nothing, Nothing)
            Case Is = 3
                Call lbCconect_Click(Nothing, Nothing)
            Case Is = 4
                Call Label12_Click(Nothing, Nothing)
        End Select



    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ToolStripStatusLabel1.Text = "Listo."
        Timer1.Enabled = False


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCnodo.Click

        accion = "colocaNodo"

        lbCnodo.BackColor = Color.Salmon
        lbQnodo.BackColor = Color.Gray

        lbCconect.BackColor = Color.Gray
        lbDelConectiva.BackColor = Color.Gray


    End Sub

    Private Sub lbCconect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbCconect.Click

        accion = "colocaConectiva"


        lbCnodo.BackColor = Color.Gray
        lbQnodo.BackColor = Color.Gray

        lbCconect.BackColor = Color.Salmon
        lbDelConectiva.BackColor = Color.Gray

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If nodoSel = 0 Then Exit Sub 'salir si no hay ningun nodo seleccionado

        nodoPrincipal = nodoSel
        lbPrinc.Text = "Es principal : Si"
        dibujaNodos()

        'bitacora
        mensaje("El nodo principal ha sido fijado al nodo id = " + nodoPrincipal.ToString)


    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click


        ColorDialog1.Color = Color.Transparent
        ColorDialog1.ShowDialog()

        If ColorDialog1.Color = Color.Transparent Then Exit Sub

        colorNodoPrinc = New SolidBrush(ColorDialog1.Color)
        Label1.BackColor = ColorDialog1.Color

        'refresca pa dibujar nuevos colores
        dibujaNodos()



    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        ColorDialog1.Color = Color.Transparent
        ColorDialog1.ShowDialog()

        If ColorDialog1.Color = Color.Transparent Then Exit Sub

        colorNodoSel = New SolidBrush(ColorDialog1.Color)
        Label3.BackColor = ColorDialog1.Color

        'refresca pa dibujar nuevos colores
        dibujaNodos()


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

        ColorDialog1.Color = Color.Transparent
        ColorDialog1.ShowDialog()

        If ColorDialog1.Color = Color.Transparent Then Exit Sub

        colorNodoSelPrinc = New SolidBrush(ColorDialog1.Color)
        Label4.BackColor = ColorDialog1.Color

        'refresca pa dibujar nuevos colores
        dibujaNodos()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

        ColorDialog1.Color = Color.Transparent
        ColorDialog1.ShowDialog()

        If ColorDialog1.Color = Color.Transparent Then Exit Sub

        ColorfondoEditor = ColorDialog1.Color
        Label5.BackColor = ColorDialog1.Color

        'refresca pa dibujar nuevos colores
        dibujaNodos()


    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

        ColorDialog1.Color = Color.Transparent
        ColorDialog1.ShowDialog()

        If ColorDialog1.Color = Color.Transparent Then Exit Sub

        colorTexto = New SolidBrush(ColorDialog1.Color)
        Label6.ForeColor = ColorDialog1.Color

        'refresca pa dibujar nuevos colores
        dibujaNodos()



    End Sub

    Private Sub btEncAp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEncAp.Click




        If nodoSel = 0 Then Exit Sub 'salir si no hay ningun nodo seleccionado

        If nSelec.encendido Then
            ModificaNodo(nodoSel, -1, -1, -1, Nothing, Nothing, 0)
            'bitacora
            mensaje("Nodo id " + nSelec.valor.ToString + " ha sido apagado.")
            GoTo ex
        End If
        If Not nSelec.encendido Then
            ModificaNodo(nodoSel, -1, -1, -1, Nothing, Nothing, 1)
            'bitacora
            mensaje("Nodo id " + nSelec.valor.ToString + " ha sido encendido.")
        End If

ex:
        'refresca el nSelec con el nodo modificado
        nSelec = getInfoNodo(nodoSel)

        lbEncendido.Text = "Encendido : No"
        btEncAp.Text = "Encender nodo"

        If nSelec.encendido Then
            lbEncendido.Text = "Encendido : Si"
            btEncAp.Text = "Apagar nodo"
        End If

        dibujaNodos()



    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click



        'limia array de verif de encliclamiento
        cEnciclaSim.Clear()
        naEnciclaSim.Clear()
        vEnciclaSim.Clear()
        reprep.Clear()
        tnodosImpacto = 0 'tot nodos impactados

        'limpia panel y redibuja los nodos
        dibujaNodos()


        If getInfoNodo(nodoPrincipal).encendido = False Then
            MsgBox("El nodo principal se encuentra apagado por lo tanto no puede iniciarse la simulación.")
            Exit Sub
        End If

        tbMsg.Clear()
        'bitacora
        mensaje("Simulación ha sido iniciada.")

        'setea todos los nodos en rojo por si no se puede alcanzar
        For Each nodo As nodo In nodos
            dibujaNodo(nodo, True, Brushes.Red)
        Next

        nodosProcesados.Clear()
        procesaNodo(getInfoNodo(nodoPrincipal))

        'ver nodos que quedan apagados porque no tiene conexión con el principal
        Dim tnodos As Integer = nodos.Count
        Dim tnodosNoViable As Integer = 0

        For Each nodoSinCon As nodo In nodos
            vEnciclaSim.Clear()
            If Not tieneConexionConPrincipal2(nodoSinCon.valor, nodoPrincipal) Then
                tnodosNoViable += 1
                mensaje("El nodo id : " + nodoSinCon.valor.ToString + " (" + nodoSinCon.nombre + ") carece de una conexión viable hasta el nodo principal.")
            End If
        Next

        'calcular porcentaje de apagado
        mensaje("Listo. Generando estadísticas del resultado de la simulación...")
        mensaje("TOTAL NODOS : " + tnodos.ToString)
        mensaje("TOTAL NODOS IMPACTADOS POR APAGON : " + tnodosImpacto.ToString + " ** Porcentaje : " + ((tnodosImpacto / tnodos) * 100).ToString)
        mensaje("TOTAL NODOS SIN CONEXIÓN VIABLE : " + tnodosNoViable.ToString + " ** Porcentaje : " + ((tnodosNoViable / tnodos) * 100).ToString)

        'bitacora
        mensaje("Simulación ha sido terminada.")


        Dim resp As String = MsgBox("Simulación terminada. Desea abrir el reporte en Microsoft Word?", MsgBoxStyle.YesNo)
        If resp = vbNo Then Exit Sub

        Cursor = Cursors.WaitCursor

        mensaje("PORFAVOR ESPERE, CREANDO DOCUMENTO DE WORD.")

        FileOpen(1, Application.StartupPath + "\reporte.txt", OpenMode.Output, OpenAccess.Write)
        Print(1, tbMsg.Text)
        FileClose(1)

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
    Private Function tieneConexionConPrincipal(ByVal valorNodoBuscado As Integer, ByVal nodoHijoSig As Integer) As Boolean

        'verifica recursivamente si un nodo tiene conexcion ocn el principal y ke el estado esté encendido

        For Each hijo In getInfoNodo(nodoHijoSig).hijos

            'verifica recorrido por algun enciclamiento
            If vEnciclaSim.Contains(nodoHijoSig) And vEnciclaSim.IndexOf(nodoHijoSig) + 1 < vEnciclaSim.Count - 1 Then
                If hijo = vEnciclaSim((vEnciclaSim.IndexOf(nodoHijoSig) + 1)) Then
                    'MsgBox("Enciclamiento detectado en nodo : " + nodoAprocesar.valor.ToString + ". Brincando al siguiente nodo.")
                    Exit For
                End If
            End If
            'agrega al recorrido de verif de enciclamiento
            vEnciclaSim.Add(nodoHijoSig)

            If tieneConexionConPrincipal(valorNodoBuscado, hijo) And getInfoNodo(hijo).encendido Then Return True
        Next

        If nodoHijoSig = valorNodoBuscado Then Return True


    End Function
    Private Function tieneConexionConPrincipal2(ByVal valorNodoBuscado As Integer, ByVal nodoHijoSig As Integer) As Boolean

        'verifica recursivamente si un nodo tiene conexcion ocn el principal PERO IGNORA EL ESTADO

        For Each hijo In getInfoNodo(nodoHijoSig).hijos

            'verifica recorrido por algun enciclamiento
            If vEnciclaSim.Contains(nodoHijoSig) And vEnciclaSim.IndexOf(nodoHijoSig) + 1 < vEnciclaSim.Count - 1 Then
                If hijo = vEnciclaSim((vEnciclaSim.IndexOf(nodoHijoSig) + 1)) Then
                    'MsgBox("Enciclamiento detectado en nodo : " + nodoAprocesar.valor.ToString + ". Brincando al siguiente nodo.")
                    Exit For
                End If
            End If
            'agrega al recorrido de verif de enciclamiento
            vEnciclaSim.Add(nodoHijoSig)

            If tieneConexionConPrincipal2(valorNodoBuscado, hijo) Then
                Return True
            End If
        Next

        If nodoHijoSig = valorNodoBuscado Then Return True
        If nodoHijoSig <> valorNodoBuscado Then Return False


    End Function

    Private Sub procesaNodo(ByVal nodoAprocesar As nodo)

        Dim repString As String

        For Each hijo In nodoAprocesar.hijos

            'pinta el nodo con conexin a verde para indicar ke si conecta
            dibujaNodo(nodoAprocesar, True, Brushes.Green)

            'bitacora
            If Not reprep.Contains(nodoAprocesar.valor) Then
                mensaje("Nodo id : " + nodoAprocesar.valor.ToString + " (" + nodoAprocesar.nombre + ") tiene conexión.")
                reprep.Add(nodoAprocesar.valor)
            End If

            'verifica recorrido por algun enciclamiento
            If cEnciclaSim.Contains(nodoAprocesar.valor) And cEnciclaSim.IndexOf(nodoAprocesar.valor) + 1 < cEnciclaSim.Count - 1 Then
                If hijo = cEnciclaSim((cEnciclaSim.IndexOf(nodoAprocesar.valor) + 1)) Then
                    'MsgBox("Enciclamiento detectado en nodo : " + nodoAprocesar.valor.ToString + ". Brincando al siguiente nodo.")
                    Exit For
                End If
            End If
            'agrega al recorrido de verif de enciclamiento
            cEnciclaSim.Add(nodoAprocesar.valor)

            'animar
            animaMov(nodoAprocesar, getInfoNodo(hijo))

            'si el hijo está encendido entonces procesarlo
            If getInfoNodo(hijo).encendido Then
                If nodosprocesados.contains(hijo) Then GoTo proSigNo
                procesaNodo(getInfoNodo(hijo))
                nodosProcesados.add(hijo)
            End If

            'si hay un nodo apagado entonces calcular impacto
            If Not getInfoNodo(hijo).encendido Then
                If nodosProcesados.Contains(hijo) Then GoTo proSigNo
                nodosProcesados.Add(hijo)

                'bitacora
                mensaje("Nodo id : " + hijo.ToString + " (" + getInfoNodo(hijo).nombre + ") se encuentra apagado. A continuación se detalla el impacto.")

                'analizar los nodos posiblemente afectados
                mensaje("Lista de nodos afectados por causa de que el nodo id : " + hijo.ToString + " (" + getInfoNodo(hijo).nombre + ") se encuentra apagado")
                mensaje("---------------------------------------------------------------------------------")
                naEnciclaSim.Clear() 'array de verif. de enciclamiento
                analizaNodosAfectados(hijo)
                'guardar total nodos impactados x causa de apagon
                mensaje("*** Nodos impactados : " + naEnciclaSim.Count.ToString + " *** PORCENTAJE DE NODOS IMPACTADOS : " + ((naEnciclaSim.Count / nodos.Count) * 100).ToString)
                tnodosImpacto += naEnciclaSim.Count
                mensaje("------------------ Fin de la lista de nodos afectados ---------------------------")

            End If
proSigNo:
        Next

        'bitacora
        If Not reprep.Contains(nodoAprocesar.valor) Then
            mensaje("Nodo id : " + nodoAprocesar.valor.ToString + " (" + nodoAprocesar.nombre + ") tiene conexión.")
            reprep.Add(nodoAprocesar.valor)
        End If

        'pinta el ultimo nodo
        dibujaNodo(nodoAprocesar, True, Brushes.Green)


    End Sub

    Private Sub analizaNodosAfectados(ByVal nodoAfec As Integer)

        Dim repString As String
        Dim hijosNodoAfec As ArrayList = getInfoNodo(nodoAfec).hijos

        For Each nodoAfectado In hijosNodoAfec

            vEnciclaSim.Clear()
            If Not tieneConexionConPrincipal(nodoAfectado, nodoPrincipal) Then

                ''verifica recorrido por algun enciclamiento
                'If naEnciclaSim.Contains(nodoAfectado) And naEnciclaSim.IndexOf(nodoAfectado) + 1 < naEnciclaSim.Count - 1 Then
                '    If nodoAfectado = naEnciclaSim((naEnciclaSim.IndexOf(nodoAfectado) + 1)) Then
                '        'MsgBox("Enciclamiento detectado en nodo : " + nodoAprocesar.valor.ToString + ". Brincando al siguiente nodo.")
                '        Exit For
                '    End If
                'End If

                If naEnciclaSim.Contains(nodoAfectado) Then GoTo sNa
                'agrega al recorrido de verif de enciclamiento
                naEnciclaSim.Add(nodoAfectado)


                mensaje("El nodo id : " + nodoAfectado.ToString + " (" + getInfoNodo(nodoAfectado).nombre + ") se verá afectado.")
                'agrega no les llega conexion
                repString = nodoAfectado.ToString + ",0"
                analizaNodosAfectados(nodoAfectado)
            End If
sNa:
        Next

    End Sub

    Private Sub animaMov(ByVal nodoInicio As nodo, ByVal nodoFin As nodo)


        Dim g As Graphics = Panel1.CreateGraphics

        Dim x As Integer = nodoInicio.posX
        Dim y As Integer = nodoInicio.posY
        Dim dib As Integer = 0

        Do
            If x > nodoFin.posX Then x -= 1
            If x < nodoFin.posX Then x += 1

            If y > nodoFin.posY Then y -= 1
            If y < nodoFin.posY Then y += 1

            dib += 1
            If dib = tbDistCam.Text Then
                dib = 0
                g.DrawEllipse(New Pen(colorCamino), x, y, 2, 2)
            End If

            Threading.Thread.Sleep(tbRetraso.Text)

        Loop Until x = nodoFin.posX And y = nodoFin.posY





    End Sub



    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

        ColorDialog1.Color = Color.Transparent
        ColorDialog1.ShowDialog()

        If ColorDialog1.Color = Color.Transparent Then Exit Sub

        colorCamino = ColorDialog1.Color
        Label11.BackColor = ColorDialog1.Color

        ''refresca pa dibujar nuevos colores
        'dibujaNodos()


    End Sub

    Private Sub editor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown





    End Sub

    Private Sub editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_modelo_redDataSet.log' Puede moverla o quitarla según sea necesario.
        Me.LogTableAdapter.Fill(Me._modelo_redDataSet.log)
        'TODO: esta línea de código carga datos en la tabla '_modelo_redDataSet.nodos' Puede moverla o quitarla según sea necesario.
        Me.NodosTableAdapter.Fill(Me._modelo_redDataSet.nodos)

        nodos.Clear()
        nodoPrincipal = -1
        nodoSel = 0
        nConec.valor = -1
        nSelec.valor = -1
        tbMsg.Clear()
        numNodo = 0

        mensaje("Iniciando editor.")

        Me.Visible = True
        Me.Update()

        Application.DoEvents()

        Timer2.Enabled = True




    End Sub
    Private Sub cargaNodosDeBD()


        tablaNodos = NodosTableAdapter.cargaNodosModeloId(modeloID)

        Dim nodoRow As DataRow
        Dim nombreCarga As String

        'pasa los nodos de la bd al arraylist de nodos
        For Each nodoRow In tablaNodos.Rows
            Dim hijosNodoRow As ArrayList = New ArrayList
            Dim encendidoNodoRow As Boolean
            nombreCarga = ""

            'splitea los hijos en el campo hijos
            'ej. 1,3,5,6 queda en 4 ihhos
            Dim s As String() = nodoRow.Item("hijos").ToString.Split(",")
            For Each hS As String In s
                If hS = "" Then Exit For
                hijosNodoRow.Add(hS)
            Next

            'parsea el tinyint oriundo de SQL Server a true false
            If nodoRow.Item("encendido") = 0 Then encendidoNodoRow = False
            If nodoRow.Item("encendido") = 1 Then encendidoNodoRow = True

            'actualiza numNodo al valor mas grande
            If numNodo < nodoRow.Item("valor") Then numNodo = nodoRow.Item("valor")

            If nodoRow.Item("nombre").ToString <> "" Then nombreCarga = nodoRow.Item("nombre")
            If nombreCarga.EndsWith("!/P/!") Then
                nombreCarga = nombreCarga.Substring(0, nombreCarga.Length - 5)
                nodoPrincipal = nodoRow.Item("valor")
            End If


            Dim nodoNuevo As nodo = New nodo(nodoRow.Item("posx"), nodoRow.Item("posy"), nodoRow.Item("valor"), nombreCarga, hijosNodoRow, encendidoNodoRow)
            nodos.Add(nodoNuevo)
        Next

        'una vez cargados entonces dibujarlos
        dibujaNodos()

    End Sub
    Private Sub btBorrarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBorrarTodo.Click


        numNodo = 0
        nodoPrincipal = 0
        nSelec.valor = -1
        nConec.valor = -1

        nodos.Clear()
        dibujaNodos()

        'bitacora
        mensaje("El diagrama ha sido limpiado por completo.")


    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbDelConectiva.Click


        accion = "quitaConectiva"

        lbCnodo.BackColor = Color.Gray
        lbQnodo.BackColor = Color.Gray

        lbCconect.BackColor = Color.Gray
        lbDelConectiva.BackColor = Color.Salmon



    End Sub

    Private Sub lbQnodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbQnodo.Click


        accion = "quitaNodo"

        lbCnodo.BackColor = Color.Gray
        lbQnodo.BackColor = Color.Salmon

        lbCconect.BackColor = Color.Gray
        lbDelConectiva.BackColor = Color.Gray


    End Sub

    Private Sub mensaje(ByVal msg As String)


        'agrega al array de log para luego pasarlo a la bd
        log.Add(New infoBitacora(Date.Now, msg))

        tbMsg.Text = tbMsg.Text + vbCrLf + Date.Now.ToString + " - " + msg
        tbMsg.Select(tbMsg.Text.Length - 1, 0)
        tbMsg.ScrollToCaret()
        tbMsg.Refresh()

        Application.DoEvents()

    End Sub


    Private Sub SalirDelEditorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelEditorToolStripMenuItem.Click

        Me.Close()


    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambiosToolStripMenuItem.Click


        'primero vea ver si es creador sino no puede salvarlo
        If menuModelos.esCreador = 0 Then
            MsgBox("No tiene permisos para salvar el modelo.")
            Exit Sub
        End If

        'primero borra los nodos de este modelo
        NodosTableAdapter.borraNodosDeId(modeloID)


        'ahora agrega los nuevos
        Dim hijosAguardar As String
        Dim encendidoAguardar As Integer
        Dim nombreGuarda As String

        'recorre todos los nodos para ir metiendolos en la BD
        For Each nodo As nodo In nodos

            hijosAguardar = ""
            nombreGuarda = ""

            'si tiene hijos entonces crear el string de hijos tokenized
            If nodo.hijos.Count > 0 Then
                For Each nodoHijo As Integer In nodo.hijos
                    hijosAguardar += nodoHijo.ToString + ","
                Next
                hijosAguardar = hijosAguardar.Substring(0, hijosAguardar.Length - 1)
            End If

            'castea el boolean a tinyint
            If nodo.encendido Then encendidoAguardar = 1
            If Not nodo.encendido Then encendidoAguardar = 0

            nombreGuarda = nodo.nombre
            If nodoPrincipal = nodo.valor Then nombreGuarda = nodo.nombre + "!/P/!"


            NodosTableAdapter.insertaNodo(modeloID, nodo.valor, nombreGuarda, encendidoAguardar, nodo.posX, nodo.posY, hijosAguardar)
        Next

        'guarda log
        For Each infoLog As infoBitacora In log
            LogTableAdapter.Insert(modeloID, infoLog.msg, infoLog.fecha)
        Next

        log.Clear()

        MsgBox("Diagrama del modelo ha sido guardado.")


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        mensaje("Cargando nodos de la base de datos para el modelo seleccionado.")
        Timer2.Enabled = False

        cargaNodosDeBD()


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'modifica el tamano
        tam = tam - 1
        If tam <= 0 Then tam = 1
        ToolStripStatusLabel1.Text = "Tamaño fijado a : " + tam.ToString
        'refresca nodos
        dibujaNodos()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        'modifica el tamano
        tam = tam + 1
        If tam <= 0 Then tam = 1
        ToolStripStatusLabel1.Text = "Tamaño fijado a : " + tam.ToString
        'refresca nodos
        dibujaNodos()

    End Sub

    Private Sub lbPrinc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbPrinc.Click

    End Sub
End Class