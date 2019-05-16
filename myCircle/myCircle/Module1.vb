Module Module1

    Sub Main()
        Dim p As New Point(3, 5)
        Dim c As New Circle(3, p)

        Console.WriteLine(c.ToString)
        Console.WriteLine("Radius = " & c.GetRadius())
        Console.WriteLine("Diameter = " & c.GetDiameter())
        Console.WriteLine("Area = " & c.GetArea())
        Console.WriteLine("Perimeter = " & c.GetCircumference())
        Console.WriteLine("Centre Point is = " & c.GetPoint().ToString())
        Console.WriteLine("Distance From Origin = " & c.GetPoint().Distance().ToString)


        Dim up As New Point(-3, -5)
        Dim down As New Circle(5, up)

        Console.WriteLine(c.ToString)
        Console.WriteLine("Radius = " & down.GetRadius())
        Console.WriteLine("Diameter = " & down.GetDiameter())
        Console.WriteLine("Area = " & down.GetArea())
        Console.WriteLine("Perimeter = " & down.GetCircumference())

        Dim po As Point = down.GetPoint()
        Console.WriteLine("Distance between p and po " & po.Distance(p))
        Console.WriteLine("Centre Point is = " & po.ToString())

        Console.WriteLine("Centre Point is = " & down.GetPoint().ToString())
        Console.WriteLine("Distance From Origin = " & down.GetPoint().Distance().ToString)
        Console.Read()
        Console.Read()
    End Sub

End Module
