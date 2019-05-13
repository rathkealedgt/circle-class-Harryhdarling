Public Class Circle
    Private Radius As Integer
    Private ReadOnly P As Point
    Const PI As Double = 3.1415926

    Public Sub New()
        Me.Radius = 1
        Me.P = New Point(0, 0)

    End Sub

    Public Sub New(r As Integer)
        Me.Radius = r
        Me.P = New Point(0, 0)
    End Sub

    Public Sub New(r As Integer, p As Point)
        Me.Radius = r
        Me.P = p

    End Sub

    Public Function GetRadius() As Double
        Return Me.Radius

    End Function

    Public Sub SetRadius(r As Integer)
        Me.Radius = r

    End Sub

    Public Function GetDiameter() As Double
        Return Me.Radius * 2

    End Function

    Public Function GetArea() As Double
        Return PI * Me.Radius * Me.Radius

    End Function

    Public Function GetCircumference() As Double
        Return 2 * PI * Me.Radius

    End Function

    Public Function GetPoint() As Point
        Return Me.P

    End Function

    Public Overrides Function ToString() As String
        Return "I am a circle at " & Me.P.ToString & ". I have a radius of " & Me.GetRadius.ToString & "."

    End Function
End Class
