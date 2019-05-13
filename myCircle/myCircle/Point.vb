Public Class Point
    Private x As Integer
    Private y As Integer

    Public Sub New()
        Me.x = 0
        Me.y = 0

    End Sub

    Public Sub New(x As Integer, y As Integer)
        Me.x = x
        Me.y = y

    End Sub

    Public Function GetX() As Integer
        Return Me.x

    End Function

    Public Function GetY() As Integer
        Return Me.y

    End Function

    Public Sub SetX(x As Integer)
        Me.x = x

    End Sub

    Public Sub SetY(y As Integer)
        Me.y = y

    End Sub

    Public Overrides Function ToString() As String
        Return "(" & Me.x & ", " & Me.y & ")"

    End Function

    Public Function Distance() As Double
        Dim p As New Point(0, 0)
        Return Distance(p)
    End Function

    Public Function Distance(p As Point) As Double
        Dim xs As Double = Math.Pow(Me.x, 2)
        Dim ys As Double = Math.Pow(Me.y, 2)

        Return Math.Sqrt(xs + ys)

    End Function
End Class
