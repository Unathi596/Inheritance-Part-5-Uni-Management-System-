Option Strict On
Option Explicit On
Option Infer Off
Public Class frmUMS
    Private nStudents As Integer
    Private Student() As Student
    Private Sub PIG(ByVal C As Integer, ByVal R As Integer, ByVal T As String)
        grdUMS.Col = C
        grdUMS.Row = R
        grdUMS.Text = T
    End Sub
    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        'Input'
        nStudents = CInt(InputBox("Enter the number of students available"))

        'Resizing array'
        ReDim Student(nStudents)

        'Resizing grid'
        grdUMS.Rows = nStudents + 1
        grdUMS.Cols = 6
        'Label'
        For s As Integer = 1 To nStudents
            PIG(0, s, "Student #" & CStr(s))
        Next s

        PIG(1, 0, "Name")
        PIG(2, 0, "Age")
        PIG(3, 0, "ID")
        PIG(4, 0, "Course Code")
        PIG(5, 0, "Course Name")
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        For s As Integer = 1 To nStudents
            Dim Name As String
            Dim Age As Integer
            Dim StudentID As String

            'Input for each student'
            Name = InputBox("Enter the name of student " & CStr(s))
            PIG(1, s, Name)
            Age = CInt(InputBox("Enter the age of student " & s))
            PIG(2, s, CStr(Age))
            StudentID = InputBox("Enter the student ID for student " & CStr(s))
            PIG(3, s, CStr(StudentID))




            'Instantiation'
            Student(s) = New Student(Name, Age, StudentID)

            Student(s).Courses.CourseCode = InputBox("Enter the course code for student " & CStr(s))
            PIG(4, s, Student(s).Courses.CourseCode)
            Student(s).Courses.CourseName = InputBox("Enter the course name for student " & CStr(s))
            PIG(5, s, Student(s).Courses.CourseName)

        Next s

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Output As String = ""

        For s As Integer = 1 To nStudents
            Output += "Student " & CStr(s) & vbNewLine
            Output += Student(s).Introduce()
            Output += Student(s).Courses.GetCourseDetails()
        Next s

        txtDisplay.Text = Output
    End Sub
End Class
