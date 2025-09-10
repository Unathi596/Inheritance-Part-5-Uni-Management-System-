Option Strict On
Option Explicit On
Option Infer Off
Public Class Course
    'Instance Variable'
    Private _CourseCode As String
    Private _CourseName As String

    Public Property CourseCode() As String
        Get
            Return _CourseCode
        End Get
        Set(value As String)
            _CourseCode = value
        End Set
    End Property

    Public Property CourseName() As String
        Get
            Return _CourseName
        End Get
        Set(value As String)
            _CourseName = value
        End Set
    End Property

    Public Function GetCourseDetails() As String
        Dim Output As String = ""

        Output += "My Code for " & _CourseName & " is : " & _CourseCode & vbNewLine & vbNewLine

        Return Output
    End Function
End Class
