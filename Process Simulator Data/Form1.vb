Option Explicit On
Imports System.IO
Imports System.Text
Imports System.Collections

Public Class Form1
    Dim Flow(2001) As Single
    Dim Pressure(2001) As Single
    Dim Volume(2001) As Single
    Dim Effort(2001) As Single
    Dim sdata(2001, 4) As String
    Dim headerdata As String = ""

    Dim peep As Single
    Dim minpress As Single
    Dim triggerdelay As Single
    Dim wob As Single
    Dim pathnm As String


    Dim filenm As String = ""
    'General Plan
    'Read in file one line at a time
    'save file name
    ' Strip off first 16 lines


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click


        Dim parsedpacket(5) As String
        Dim filetoprocss As String
        '  Dim folderfiles() As String

        If Folderdialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pathnm = Folderdialog1.SelectedPath

            If File.Exists(pathnm & "\outputtext.txt") Then
                File.Delete(pathnm & "\outputtext.txt")
            End If

            Dim folderfiles As String() = Directory.GetFiles(pathnm)

            For Each filetoprocss In folderfiles
                filenm = Path.GetFileName(filetoprocss)
                processfile(filetoprocss)
                CalculateValues()
                writedata()
            Next

        End If




    End Sub
    Private Sub processfile(ByVal filetoprocess As String)
        Dim sr As StreamReader
        Dim datapacket As String
        Dim i As Int16 = 0 'array counter
        Dim parsedpacket(5) As String
        sr = New StreamReader(filetoprocess)


        Do Until sr.Peek = -1 ' Read in the file

            If i < 16 Then ' strip out first 16 lines of the file

                headerdata = sr.ReadLine()
                headerdata = ""

            Else ' We have stripped out now read values


                datapacket = sr.ReadLine() ' Reads in data line
                ' parse data line ing 
                parsedpacket = datapacket.Split(CChar(vbTab))
                For j = 0 To 4
                    sdata(i - 16, j) = parsedpacket(j)



                Next
                ' Convert values to numbers and 
                Flow(i - 16) = Single.Parse(sdata(i - 16, 1))
                Pressure(i - 16) = Single.Parse(sdata(i - 16, 2))
                Volume(i - 16) = Single.Parse(sdata(i - 16, 3))
                Effort(i - 16) = Single.Parse(sdata(i - 16, 4))

            End If

            i += 1
        Loop


    End Sub


    Private Sub CalculateValues()
        Dim i As Int16 = 0
        Dim individualeff As Single
        Dim Effortstart As Int16
        Dim breathstart As Int16
        Dim state As String = "waiting"
        Dim enterstate As Boolean = True
        state = "waiting"

        For Each individualeff In Effort
            Select Case state
                Case "waiting"
                    wob = 0
                    ' doing nothing except waiting for effort
                    ' on exit calculate peep
                    'set flag for start of effort
                    ' set min pressure = peep
                    If Effort(i) < 0 Then
                        Effortstart = i
                        state = "effort"
                        peep = (Pressure(i - 2) + Pressure(i - 1) + Pressure(i)) / 3
                        minpress = peep
                    End If

                Case "effort" ' looking for minimum value and trigger
                    wob = wob + (peep - Pressure(i)) * ((Volume(i) - Volume(i - 1)))

                    If Pressure(i) < minpress Then
                        minpress = Pressure(i)
                    End If
                    If Pressure(i) > peep + 1.0 Then
                        state = "triggered"
                        breathstart = i
                        minpress = peep - minpress
                        triggerdelay = (breathstart - Effortstart) * 5
                    End If

                Case "triggered"

                    'write the data out
                    LblPeep.Text = peep.ToString("0.0")
                    LblMinP.Text = minpress.ToString("0.0")
                    LblDelay.Text = triggerdelay.ToString
                    LblWOB.Text = wob.ToString("0.00")
                    Return ' exit routine

            End Select

            i += 1
        Next

    End Sub

    Private Sub writedata()
        Dim sb As New StringBuilder
        Dim outputfile As String
        outputfile = pathnm & "\outputtext.txt"
        Dim fo As New StreamWriter(outputfile, True)

        sb.Append(filenm)
        sb.Append(", ")
        sb.Append(peep.ToString("0.0"))
        sb.Append(", ")
        sb.Append(minpress.ToString("0.0"))
        sb.Append(", ")
        sb.Append(triggerdelay.ToString)
        sb.Append(", ")
        sb.Append(wob.ToString("0.00"))



        fo.WriteLine(sb.ToString)
        fo.Close()


    End Sub
End Class
