<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.grdUMS = New UJGrid.UJGrid()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(31, 32)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(173, 86)
        Me.btnSetup.TabIndex = 0
        Me.btnSetup.Text = "Grid SetUp"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'grdUMS
        '
        Me.grdUMS.FixedCols = 1
        Me.grdUMS.FixedRows = 1
        Me.grdUMS.Location = New System.Drawing.Point(13, 345)
        Me.grdUMS.Margin = New System.Windows.Forms.Padding(4)
        Me.grdUMS.Name = "grdUMS"
        Me.grdUMS.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdUMS.Size = New System.Drawing.Size(649, 211)
        Me.grdUMS.TabIndex = 1
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(680, 19)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplay.Size = New System.Drawing.Size(463, 525)
        Me.txtDisplay.TabIndex = 2
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(419, 32)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(173, 86)
        Me.btnInput.TabIndex = 3
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(90, 184)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(387, 112)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frmUMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 569)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.grdUMS)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "frmUMS"
        Me.Text = "University Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetup As Button
    Friend WithEvents grdUMS As UJGrid.UJGrid
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnDisplay As Button
End Class
