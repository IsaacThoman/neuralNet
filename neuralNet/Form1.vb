Public Class Form1
    Dim angle As Integer = 50
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidBrushGreen As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim penGreen As Pen = New Pen(Color.DarkGreen)
        Dim myGraphics As Graphics
        surface.Clear(Color.WhiteSmoke)


        '                           new stuff
        Dim carX As Integer = 300
        Dim carY As Integer = 250
        angle += 1
        Dim width As Integer = 300
        Dim height As Integer = 100

        Dim a As Point = New Point(Math.Sin((45 + angle) / 180 * 3.14) * width + carX, Math.Cos((45 + angle) / 180 * 3.14) * height + carY)
        Dim b As Point = New Point(Math.Sin((135 + angle) / 180 * 3.14) * width + carX, Math.Cos((135 + angle) / 180 * 3.14) * height + carY)
        Dim c As Point = New Point(Math.Sin((225 + angle) / 180 * 3.14) * width + carX, Math.Cos((225 + angle) / 180 * 3.14) * height + carY)
        Dim d As Point = New Point(Math.Sin((315 + angle) / 180 * 3.14) * width + carX, Math.Cos((315 + angle) / 180 * 3.14) * height + carY)







        Dim car = {a, b, c, d}





        surface.FillPolygon(solidBrushGreen, car)
        'surface.FillRectangle(solidBrushGreen, rects2)


        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)



    End Sub
End Class
