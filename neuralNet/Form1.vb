Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WIP mathy stuff
        Dim x As Integer
        Dim y As Integer
        Dim angle As Integer = 0


        Dim topRight As PointF = New PointF((Math.Cos(45 + angle) * 50) + x, (Math.Sin(45 + angle) * 50) + y)
        Dim bottomRight As PointF = New PointF((Math.Cos(135 + angle) * 50) + x, (Math.Sin(135 + angle) * 50) + y)
        Dim bottomleft As PointF = New PointF((Math.Cos(225 + angle) * 50) + x, (Math.Sin(225 + angle) * 50) + y)
        Dim topLeft As PointF = New PointF((Math.Cos(315 + angle) * 50) + x, (Math.Sin(315 + angle) * 50) + y)

        Dim car = {topRight, bottomRight, bottomleft, topLeft}



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



        Dim rects2 As Rectangle = New Rectangle(10, 10, 10, 10)
        Dim point1 As PointF = New PointF(10, 10)
        Dim point2 As PointF = New PointF(150, 150)
        Dim point3 As PointF = New PointF(10, 150)
        Dim point4 As PointF = New PointF(50, 60)
        Dim curve = {point1, point2, point3}


        surface.DrawLine(penGreen, point1, point2)
        surface.FillPolygon(solidBrushGreen, curve)
        'surface.FillRectangle(solidBrushGreen, rects2)


        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)





    End Sub


End Class
