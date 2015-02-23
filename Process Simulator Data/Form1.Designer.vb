<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblPeep = New System.Windows.Forms.Label()
        Me.LblMinP = New System.Windows.Forms.Label()
        Me.LblDelay = New System.Windows.Forms.Label()
        Me.LblWOB = New System.Windows.Forms.Label()
        Me.GBOX1 = New System.Windows.Forms.GroupBox()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Folderdialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GBOX1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnProcess
        '
        Me.BtnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcess.Location = New System.Drawing.Point(42, 116)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(145, 65)
        Me.BtnProcess.TabIndex = 0
        Me.BtnProcess.Text = "Process Folder"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PEEP (CMW)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PDROP (CMW)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Delay (mSec)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "WOB ( )"
        '
        'LblPeep
        '
        Me.LblPeep.AutoSize = True
        Me.LblPeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeep.Location = New System.Drawing.Point(164, 50)
        Me.LblPeep.Name = "LblPeep"
        Me.LblPeep.Size = New System.Drawing.Size(66, 24)
        Me.LblPeep.TabIndex = 6
        Me.LblPeep.Text = "Label5"
        '
        'LblMinP
        '
        Me.LblMinP.AutoSize = True
        Me.LblMinP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinP.Location = New System.Drawing.Point(164, 98)
        Me.LblMinP.Name = "LblMinP"
        Me.LblMinP.Size = New System.Drawing.Size(66, 24)
        Me.LblMinP.TabIndex = 7
        Me.LblMinP.Text = "Label6"
        '
        'LblDelay
        '
        Me.LblDelay.AutoSize = True
        Me.LblDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDelay.Location = New System.Drawing.Point(164, 146)
        Me.LblDelay.Name = "LblDelay"
        Me.LblDelay.Size = New System.Drawing.Size(66, 24)
        Me.LblDelay.TabIndex = 8
        Me.LblDelay.Text = "Label7"
        '
        'LblWOB
        '
        Me.LblWOB.AutoSize = True
        Me.LblWOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWOB.Location = New System.Drawing.Point(164, 194)
        Me.LblWOB.Name = "LblWOB"
        Me.LblWOB.Size = New System.Drawing.Size(66, 24)
        Me.LblWOB.TabIndex = 9
        Me.LblWOB.Text = "Label8"
        '
        'GBOX1
        '
        Me.GBOX1.Controls.Add(Me.Label1)
        Me.GBOX1.Controls.Add(Me.LblWOB)
        Me.GBOX1.Controls.Add(Me.Label2)
        Me.GBOX1.Controls.Add(Me.LblDelay)
        Me.GBOX1.Controls.Add(Me.Label3)
        Me.GBOX1.Controls.Add(Me.LblMinP)
        Me.GBOX1.Controls.Add(Me.Label4)
        Me.GBOX1.Controls.Add(Me.LblPeep)
        Me.GBOX1.Location = New System.Drawing.Point(251, 29)
        Me.GBOX1.Name = "GBOX1"
        Me.GBOX1.Size = New System.Drawing.Size(278, 242)
        Me.GBOX1.TabIndex = 10
        Me.GBOX1.TabStop = False
        Me.GBOX1.Text = "FIle Data"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "File Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 80)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Places data in file called" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Output.txt in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "directory that the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "data files ar" & _
    "e in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 309)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GBOX1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnProcess)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBOX1.ResumeLayout(False)
        Me.GBOX1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnProcess As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblPeep As System.Windows.Forms.Label
    Friend WithEvents LblMinP As System.Windows.Forms.Label
    Friend WithEvents LblDelay As System.Windows.Forms.Label
    Friend WithEvents LblWOB As System.Windows.Forms.Label
    Friend WithEvents GBOX1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Folderdialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
