
Public Class frmRand
    Inherits System.Windows.Forms.Form
    'Folder:        RandListDemo15

    'Programmer:    Lemery and Afia
    'Date:          Jan. 2018
    'Description:   Creates a list of random numbers and find the average and biggest number in it

    Dim j As Integer    'OK to dim a subscript here at the class-level

    'Creates list of random numbers
    Private Sub btnCreate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCreate.Click

        Dim randomRoller As New Random  'Random Generator

        Dim intR As Integer     ' will hold a random number

        'Clears out listbox.
        lstRand.Items.Clear()

        'Creates a list of numbers that range from 21 to 55 and add it to the list box.
        For j = 0 To 9
            intR = randomRoller.Next(21, 56)
            lstRand.Items.Add(intR)
        Next j


        lblAvg.Text = "Find Avg"
        lblMax.Text = "Find Max"

    End Sub


    'Button displays Average
    Private Sub btnFindAvg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnFindAvg.Click


        'Error Check to see if the list is empty
        If lstRand.Items.Count = 0 Then
            MessageBox.Show("Please Press The Create List Button")
            Exit Sub
        End If

        Dim sngAvg As Single 'Variable for Average
        Dim intTotal As Integer = lstRand.Items.Count 'Variable for the total number of items in the List

        'Finds the Average.
        For j = 0 To lstRand.Items.Count - 1
            sngAvg = sngAvg + lstRand.Items(j)
        Next j

        sngAvg = sngAvg / intTotal


        'Display's Average
        lblAvg.Text = sngAvg.ToString

    End Sub


    'Finds the biggest number.
    Private Sub btnFindMax_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnFindMax.Click

        'Variable for finding the largest number
        Dim intLargest As Integer = lstRand.Items(0)

        'Uses a loop to find the biggest number
        For j = 0 To lstRand.Items.Count - 1
            If intLargest < lstRand.Items(j) Then
                intLargest = lstRand.Items(j)
            End If
        Next j

        'Display the biggest Number.
        lblMax.Text = intLargest.ToString
    End Sub


    'Exit application
    Public Sub mnuFileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFileExit.Click
        End
    End Sub


    'Just For Fun; Display message for CD.
    Public Sub mnuHelpAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHelpAbout.Click
        MsgBox("Please insert Help CD - available for $899" & ControlChars.CrLf & "from AfiaNation")
    End Sub

End Class