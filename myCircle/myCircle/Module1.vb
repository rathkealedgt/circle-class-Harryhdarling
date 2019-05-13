Module Module1

    Sub Main()
        Dim p As New Point(3, 5)
        Dim c As New Circle(3, p)

        Console.WriteLine(c.ToString)
        Console.WriteLine("Diameter = " & c.GetDiameter())
        Console.WriteLine("Area = " & c.GetArea())
        Console.WriteLine("Perimeter = " & c.GetCircumference())
        Console.WriteLine("Centre Point is = " & c.GetPoint().ToString())
        Console.WriteLine("Distance From Origin = " & c.GetPoint().Distance().ToString)
        Console.Read()

    End Sub

End Module
