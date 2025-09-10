Option Strict On
Option Explicit On
Option Infer Off
Public Class Person
    'Instance Variables
    Protected _Name As String
    Protected _Age As Integer

    Public Sub New(_Name As String, _Age As Integer)
        Me._Name = _Name
        Me._Age = _Age
    End Sub

    Public Overridable Function Introduce() As String

        Dim Output As String = ""

        Output += "My Name is: " + _Name + vbNewLine
        Output += "I am " + CStr(_Age) + " years old" + vbNewLine

        Return Output

    End Function
End Class
