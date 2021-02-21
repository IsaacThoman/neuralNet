Public Class Form1
    Dim angle As Integer = 50
    Dim inputAccel As Boolean = False
    Dim inputLeft As Boolean = False
    Dim inputRight As Boolean = False

    Dim carX As Integer = 300
    Dim carY As Integer = 250
    Dim width As Integer = 50
    Dim height As Integer = 50

    Dim accelForward As Integer
    Dim accelRotation As Decimal

    Dim speedLimit As Integer = 10
    Dim speedLimitRotation As Integer = 10

    Function render()

        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidBrushGreen As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim penGreen As Pen = New Pen(Color.DarkGreen)
        Dim myGraphics As Graphics
        surface.Clear(Color.WhiteSmoke)


        '                           new stuff


        Dim a As Point = New Point(Math.Sin((45 + angle) / 180 * 3.14) * width + carX, Math.Cos((45 + angle) / 180 * 3.14) * height + carY)
        Dim b As Point = New Point(Math.Sin((135 + angle) / 180 * 3.14) * width + carX, Math.Cos((135 + angle) / 180 * 3.14) * height + carY)
        Dim c As Point = New Point(Math.Sin((225 + angle) / 180 * 3.14) * width + carX, Math.Cos((225 + angle) / 180 * 3.14) * height + carY)
        Dim d As Point = New Point(Math.Sin((315 + angle) / 180 * 3.14) * width + carX, Math.Cos((315 + angle) / 180 * 3.14) * height + carY)







        Dim car = {a, b, c, d}





        surface.FillPolygon(solidBrushGreen, car)
        'surface.FillRectangle(solidBrushGreen, rects2)


        '   myGraphics = Graphics.FromHwnd(ActiveForm().Handle)
        ' Not sure what the above line did, but it seemed to break things so I disabled it

    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' angle += 1
        If inputLeft Then
            accelRotation += 1

        End If
        If inputRight Then
            accelRotation += -1
        End If

        If accelRotation > 0 Then
            accelRotation += -0.5
        ElseIf accelRotation < 0 Then
            accelRotation += 0.5

        End If

        angle += accelRotation


        If inputAccel Then
            accelForward += 1
        ElseIf accelForward > 0 Then
            accelForward += -1
        End If

        If accelRotation > speedLimitRotation Then
            accelRotation = speedLimitRotation
        End If
        If accelRotation < 0 - speedLimitRotation Then
            accelRotation = 0 - speedLimitRotation
        End If
        If accelForward > speedLimit Then
            accelForward = speedLimit
        End If
        If accelForward < 0 - speedLimit Then
            accelForward = 0 - speedLimit
        End If

        carX += Math.Sin(angle / 180 * 3.14) * accelForward
        carY += Math.Cos(angle / 180 * 3.14) * accelForward


        render()


    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control Or e.Shift Or e.Alt Then

        End If

        Label1.Text = e.KeyValue

        If e.KeyValue = 87 Then
            inputAccel = True
        End If
        If e.KeyValue = 65 Then
            inputLeft = True

        End If
        If e.KeyValue = 68 Then
            inputRight = True
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = 87 Then
            inputAccel = False
        End If
        If e.KeyValue = 65 Then
            inputLeft = False

        End If
        If e.KeyValue = 68 Then
            inputRight = False
        End If
    End Sub
End Class
