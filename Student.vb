Option Strict On
Option Explicit On
Option Infer Off
Public Class Student
    Inherits Person

    'Instance Variable'
    Private _StudentID As String
    Private _Courses As Course
    Private Shared _TotalStudents As Integer

    'Constructor'
    Public Sub New(Name As String, Age As Integer, _StudentID As String)
        'Calling my parents'
        MyBase.New(Name, Age)

        'Method Overshadowing'
        Me._StudentID = _StudentID


        _Courses = New Course()

        _TotalStudents += 1
    End Sub

    Public ReadOnly Property Courses() As Course
        Get
            Return _Courses
        End Get
    End Property
    Public Shared ReadOnly Property TotalStudents() As Integer
        Get
            Return _TotalStudents
        End Get
    End Property

    Public Overrides Function Introduce() As String
        Dim Output As String = ""

        Output +=
            MyBase.Introduce()

        Output += "CourseName: " & _Courses.CourseName & vbNewLine


        Return Output
    End Function
End Class
