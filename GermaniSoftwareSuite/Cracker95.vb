Imports System.IO

Public Class Cracker95
    Shared random As New Random()
    Private Sub GenButton_Click(sender As Object, e As EventArgs) Handles GenButton.Click
        If CdSelect.Checked = True Then
            Dim pre_dash As String = 0
            Dim post_dash As String = "0000001"

            'ValidatorOutput.Text = pre_dash
            If random.Next(1, 9000) > 8000 Then
                pre_dash = "YOLO"
            Else
                While Convert.ToString(pre_dash) = "0" Or Convert.ToString(pre_dash) = "333" Or Convert.ToString(pre_dash) = "444" Or Convert.ToString(pre_dash) = "555" Or Convert.ToString(pre_dash) = "666" Or Convert.ToString(pre_dash) = "777" Or Convert.ToString(pre_dash) = "888" Or Convert.ToString(pre_dash) = "999"
                    pre_dash = random.Next(100, 999)
                End While
                pre_dash = pre_dash + "-"
            End If

            While (Convert.ToInt32(post_dash(0)) + Convert.ToInt32(post_dash(1)) + Convert.ToInt32(post_dash(2)) + Convert.ToInt32(post_dash(3)) + Convert.ToInt32(post_dash(4)) + Convert.ToInt32(post_dash(5)) + Convert.ToInt32(post_dash(6))) Mod 7 > 0
                post_dash = Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 7))
            End While


            OutputBox.Text = Convert.ToString(pre_dash) + post_dash

        ElseIf OemSelect.Checked = True Then
            Dim box1 As String = Convert.ToString(random.Next(100, 365)) + Convert.ToString(random.Next(95, 99))
            Dim box3 As String = "0000001"
            Dim box4 As String = Convert.ToString(random.Next(10000, 99999))

            While (Convert.ToInt32(box3(0)) + Convert.ToInt32(box3(1)) + Convert.ToInt32(box3(2)) + Convert.ToInt32(box3(3)) + Convert.ToInt32(box3(4)) + Convert.ToInt32(box3(5)) + Convert.ToInt32(box3(6))) Mod 7 > 0
                box3 = "0" + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 9)) + Convert.ToString(random.Next(1, 7))
            End While

            OutputBox.Text = box1 + "-OEM-" + box3 + "-" + box4
        End If
    End Sub

    Private Sub ValidatorBtn_Click(sender As Object, e As EventArgs) Handles ValidatorBtn.Click
        ValidatorOutput.ForeColor = SystemColors.ControlText
        ValidatorOutput.Text = ""
        Dim oem_status As Boolean = False
        Try
            Dim oem_check_var As String = ValidatorInput.Text(6)
            If oem_check_var.ToLower() = "o" Then
                oem_status = True
            Else
                oem_status = False
            End If


            If oem_status = True Then
                Dim box1p1 As String = ValidatorInput.Text(0) + ValidatorInput.Text(1) + ValidatorInput.Text(2)
                Dim box1p2 As String = ValidatorInput.Text(3) + ValidatorInput.Text(4)
                Dim box3 As String = ValidatorInput.Text(10) + ValidatorInput.Text(11) + ValidatorInput.Text(12) + ValidatorInput.Text(13) + ValidatorInput.Text(14) + ValidatorInput.Text(15) + ValidatorInput.Text(16)
                Dim box4 As String = ValidatorInput.Text(18) + ValidatorInput.Text(19) + ValidatorInput.Text(20) + ValidatorInput.Text(21) + ValidatorInput.Text(22)
                Dim validity_score As Integer = 0
                Dim errors As String = ""
                Dim box1p2list As New List(Of String)({"95", "96", "97", "98", "99", "00", "01", "02"})

                If 1 <= Int(box1p1) <= 366 Then
                    validity_score += 1
                Else
                    errors = errors + "first 3 characters are not between 1 and 366, "
                End If

                If box1p2list.Contains(box1p2) Then
                    validity_score += 1
                Else
                    errors = errors + "last 2 characters of the first box are not in whitelist, "
                End If

                If ValidatorInput.Text(5) = "-" And ValidatorInput.Text(9) = "-" And ValidatorInput.Text(17) = "-" Then
                    validity_score += 1
                Else
                    errors = errors + "characters number 6 or 10 or 18 are not dashes, "
                End If

                If ((Convert.ToInt32(box3(0)) + Convert.ToInt32(box3(1)) + Convert.ToInt32(box3(2)) + Convert.ToInt32(box3(3)) + Convert.ToInt32(box3(4)) + Convert.ToInt32(box3(5)) + Convert.ToInt32(box3(6))) Mod 7 > 0) = False Then
                    validity_score += 1
                Else
                    errors = errors + "sum of the second box isnt devidable by 7, "
                End If

                If box4.Length = 5 Then
                    validity_score += 1
                Else
                    errors = errors + "lenght of the fourth box isnt 5, "
                End If

                If ValidatorInput.TextLength = 23 Then
                    validity_score += 1
                Else
                    errors = errors + "length of key isnt 23, "
                End If

                If box3(0) = "0" Then
                    validity_score += 1
                Else
                    errors = errors + "first character in box3 isnt 0."
                End If

                'ValidatorInput.Text = validity_score
                If validity_score = 7 Then
                    ValidatorOutput.ForeColor = Color.Green
                    ValidatorOutput.Text = "OEM key is valid!"
                Else
                    ValidatorOutput.ForeColor = Color.Red
                    ValidatorOutput.Text = "Key Invalid, " + errors
                End If
            ElseIf oem_status = False Then
                Dim box1 As String = ValidatorInput.Text(0) + ValidatorInput.Text(1) + ValidatorInput.Text(2)
                Dim box2 As String = ValidatorInput.Text(4) + ValidatorInput.Text(5) + ValidatorInput.Text(6) + ValidatorInput.Text(7) + ValidatorInput.Text(8) + ValidatorInput.Text(9) + ValidatorInput.Text(10)
                Dim validity_score As Integer = 0
                Dim errors As String = ""
                Dim box1list As New List(Of String)({"333", "444", "555", "666", "777", "888", "999"})

                If box1list.Contains(box1) = False Then
                    validity_score += 1
                Else
                    errors += "first 3 characters in blacklist, "
                End If

                If ((Convert.ToInt32(box2(0)) + Convert.ToInt32(box2(1)) + Convert.ToInt32(box2(2)) + Convert.ToInt32(box2(3)) + Convert.ToInt32(box2(4)) + Convert.ToInt32(box2(5)) + Convert.ToInt32(box2(6))) Mod 7 > 0) = False Then
                    validity_score += 1
                Else
                    errors += "sum of numbers starting from the 4th character isnt devidible by 7, "
                End If

                If ValidatorInput.TextLength = 11 Then
                    validity_score += 1
                Else
                    errors += "length of key isnt 11, "
                End If

                If box2(box2.Length - 1) = "8" Or box2(box2.Length - 1) = "9" Then
                    errors += "last character is bigger than 7."
                Else
                    validity_score += 1
                End If

                If validity_score = 4 Then
                    ValidatorOutput.ForeColor = Color.Green
                    ValidatorOutput.Text = "CD key is valid!"
                Else
                    ValidatorOutput.ForeColor = Color.Red
                    ValidatorOutput.Text = "Key Invalid, " + errors
                End If
            End If
        Catch aoe As IndexOutOfRangeException
            ValidatorOutput.ForeColor = Color.Red
            ValidatorOutput.Text = "Invalid Key Entered"
        End Try
    End Sub

    Private Sub CopyBtn_Click(sender As Object, e As EventArgs) Handles CopyBtn.Click
        Try
            My.Computer.Clipboard.SetText(OutputBox.Text)
        Catch jgdf As ArgumentNullException
            Console.Write("User tried to copy empty value")
        End Try
    End Sub

    Private Sub SuiteReturnBTN_Click(sender As Object, e As EventArgs) Handles SuiteReturnBTN.Click
        Form1.Show()
        Close()
    End Sub
End Class
