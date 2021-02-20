Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WIP mathy stuff




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim surface As Graphics = CreateGraphics()
        Dim Brush1 As Brush
        Dim solidBrushGreen As SolidBrush = New SolidBrush(Color.DarkGreen)
        Dim penGreen As Pen = New Pen(Color.DarkGreen)
        Dim solidBrushGray As SolidBrush = New SolidBrush(Color.LightGray)
        Dim solidBrushYellow As SolidBrush = New SolidBrush(Color.LightYellow)
        Dim rects(8, 8) As Rectangle

        Dim myGraphics As Graphics


        '                           new stuff
        Dim carX As Integer = 250
        Dim carY As Integer = 250
        Dim angle As Integer = 50
        Dim width As Integer = 50
        Dim height As Integer = 100

        Dim a As Point = New Point(Math.Sin((45 + angle) / 180 * 3.14) * width + carX, Math.Cos((45 + angle) / 180 * 3.14) * height + carY)
        Dim b As Point = New Point(Math.Sin((135 + angle) / 180 * 3.14) * width + carX, Math.Cos((135 + angle) / 180 * 3.14) * height + carY)
        Dim c As Point = New Point(Math.Sin((225 + angle) / 180 * 3.14) * width + carX, Math.Cos((225 + angle) / 180 * 3.14) * height + carY)
        Dim d As Point = New Point(Math.Sin((315 + angle) / 180 * 3.14) * width + carX, Math.Cos((315 + angle) / 180 * 3.14) * height + carY)



        '    Dim bottomRight As PointF = New PointF((Math.Sin((135) / 180 * 3.14) + x), (Math.Cos((135) / 180 * 3.14) + y))
        '     Dim bottomLeft As PointF = New PointF((Math.Sin((225) / 180 * 3.14) + x), (Math.Cos((225) / 180 * 3.14) + y))
        '     Dim topLeft As PointF = New PointF((Math.Sin((315) / 180 * 3.14) + x), (Math.Cos((315) / 180 * 3.14) + y))



        ' Dim bottomRight As PointF = New PointF((Math.Cos(135 + angle) * 50) + x, (Math.Sin(135 + angle) * 50) + y)
        'Dim bottomleft As PointF = New PointF((Math.Cos(225 + angle) * 50) + x, (Math.Sin(225 + angle) * 50) + y)
        'Dim topLeft As PointF = New PointF((Math.Cos(315 + angle) * 50) + x, (Math.Sin(315 + angle) * 50) + y)
        'aaagh!!!








        Dim car = {a, b, c, d}





        surface.FillPolygon(solidBrushGreen, car)
        'surface.FillRectangle(solidBrushGreen, rects2)


        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)





    End Sub


End Class
