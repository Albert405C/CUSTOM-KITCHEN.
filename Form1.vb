Imports System.IO
Public Class frmmainform
    'declaring a two dimensional array of 20col and 4row for kitchen styles
    Dim _strkitchen_designstyles(20, 4) As String
    'declaring a two dimensional array of 5col and 1row for optionalkitchenappliances
    Dim _strOptionalKitchen_appliances(5, 1) As String
    Dim thecost As String

    'Public Sub objectConversion(ByVal anObject As Object)
    '    Dim anInteger As Integer
    '    Dim aString As String
    '    anInteger = CType(anObject, Integer)
    '    aString = CType(anObject, String)
    'End Sub


    Private Sub frmmainfom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'assigning values to each element
        _strkitchen_designstyles(0, 0) = "Small L-shaped kitchen"
        _strkitchen_designstyles(0, 1) = "250"
        _strkitchen_designstyles(0, 2) = "180"
        _strkitchen_designstyles(0, 3) = "Laminate"
        _strkitchen_designstyles(0, 4) = "3500"

        _strkitchen_designstyles(1, 0) = "Small L-shaped kitchen"
        _strkitchen_designstyles(1, 1) = "250"
        _strkitchen_designstyles(1, 2) = "180"
        _strkitchen_designstyles(1, 3) = "Wood Block"
        _strkitchen_designstyles(1, 4) = "4500"

        _strkitchen_designstyles(2, 0) = "Small L-shaped kitchen"
        _strkitchen_designstyles(2, 1) = "250"
        _strkitchen_designstyles(2, 2) = "180"
        _strkitchen_designstyles(2, 3) = "Granite"
        _strkitchen_designstyles(2, 4) = "5750"

        _strkitchen_designstyles(3, 0) = "Medium L-shaped kitchen"
        _strkitchen_designstyles(3, 1) = "350"
        _strkitchen_designstyles(3, 2) = "240"
        _strkitchen_designstyles(3, 3) = "Laminate"
        _strkitchen_designstyles(3, 4) = "6500"

        _strkitchen_designstyles(4, 0) = "Medium L-shaped kitchen"
        _strkitchen_designstyles(4, 1) = "350"
        _strkitchen_designstyles(4, 2) = "240"
        _strkitchen_designstyles(4, 3) = "Wood Block"
        _strkitchen_designstyles(4, 4) = "7750"

        _strkitchen_designstyles(5, 0) = "Medium L-shaped kitchen"
        _strkitchen_designstyles(5, 1) = "350"
        _strkitchen_designstyles(5, 2) = "240"
        _strkitchen_designstyles(5, 3) = "Granite"
        _strkitchen_designstyles(5, 4) = "9500"

        _strkitchen_designstyles(6, 0) = "Large L-shaped kitchen"
        _strkitchen_designstyles(6, 1) = "450"
        _strkitchen_designstyles(6, 2) = "450"
        _strkitchen_designstyles(6, 3) = "Laminate"
        _strkitchen_designstyles(6, 4) = "8250"

        _strkitchen_designstyles(7, 0) = "Large L-shaped kitchen"
        _strkitchen_designstyles(7, 1) = "450"
        _strkitchen_designstyles(7, 2) = "450"
        _strkitchen_designstyles(7, 3) = "Wood Block"
        _strkitchen_designstyles(7, 4) = "9500"

        _strkitchen_designstyles(8, 0) = "Large L-shaped kitchen"
        _strkitchen_designstyles(8, 1) = "450"
        _strkitchen_designstyles(8, 2) = "450"
        _strkitchen_designstyles(8, 3) = "Granite"
        _strkitchen_designstyles(8, 4) = "12500"

        _strkitchen_designstyles(9, 0) = "Small straight kitchen"
        _strkitchen_designstyles(9, 1) = "150"
        _strkitchen_designstyles(9, 2) = "60"
        _strkitchen_designstyles(9, 3) = "Laminate"
        _strkitchen_designstyles(9, 4) = "1000"

        _strkitchen_designstyles(10, 0) = "Small straight kitchen"
        _strkitchen_designstyles(10, 1) = "150"
        _strkitchen_designstyles(10, 2) = "60"
        _strkitchen_designstyles(10, 3) = "Wood Block"
        _strkitchen_designstyles(10, 4) = "1500"

        _strkitchen_designstyles(11, 0) = "Small straight kitchen"
        _strkitchen_designstyles(11, 1) = "150"
        _strkitchen_designstyles(11, 2) = "60"
        _strkitchen_designstyles(11, 3) = "Granite"
        _strkitchen_designstyles(11, 4) = "2200"

        _strkitchen_designstyles(12, 0) = "Medium straight kitchen"
        _strkitchen_designstyles(12, 1) = "350"
        _strkitchen_designstyles(12, 2) = "60"
        _strkitchen_designstyles(12, 3) = "Laminate"
        _strkitchen_designstyles(12, 4) = "5250"

        _strkitchen_designstyles(13, 0) = "Medium straight kitchen"
        _strkitchen_designstyles(13, 1) = "350"
        _strkitchen_designstyles(13, 2) = "60"
        _strkitchen_designstyles(13, 3) = "Wood Block"
        _strkitchen_designstyles(13, 4) = "6200"

        _strkitchen_designstyles(14, 0) = "Medium straight kitchen"
        _strkitchen_designstyles(14, 1) = "350"
        _strkitchen_designstyles(14, 2) = "60"
        _strkitchen_designstyles(14, 3) = "Granite"
        _strkitchen_designstyles(14, 4) = "8000"

        _strkitchen_designstyles(15, 0) = "Large straight kitchen"
        _strkitchen_designstyles(15, 1) = "500"
        _strkitchen_designstyles(15, 2) = "60"
        _strkitchen_designstyles(15, 3) = "Laminate"
        _strkitchen_designstyles(15, 4) = "6750"

        _strkitchen_designstyles(16, 0) = "Large straigt kitchen"
        _strkitchen_designstyles(16, 1) = "500"
        _strkitchen_designstyles(16, 2) = "60"
        _strkitchen_designstyles(16, 3) = "Wood Block"
        _strkitchen_designstyles(16, 4) = "8500"

        _strkitchen_designstyles(17, 0) = "Large straight kitchen"
        _strkitchen_designstyles(17, 1) = "500"
        _strkitchen_designstyles(17, 2) = "60"
        _strkitchen_designstyles(17, 3) = "Granite"
        _strkitchen_designstyles(17, 4) = "11000"

        _strkitchen_designstyles(18, 0) = "Large island kitchen"
        _strkitchen_designstyles(18, 1) = "450"
        _strkitchen_designstyles(18, 2) = "450"
        _strkitchen_designstyles(18, 3) = "Laminate"
        _strkitchen_designstyles(18, 4) = "12500"

        _strkitchen_designstyles(19, 0) = "Large island kitchen"
        _strkitchen_designstyles(19, 1) = "450"
        _strkitchen_designstyles(19, 2) = "450"
        _strkitchen_designstyles(19, 3) = "Wood Block"
        _strkitchen_designstyles(19, 4) = "15000"

        _strkitchen_designstyles(20, 0) = "Large island kitchen"
        _strkitchen_designstyles(20, 1) = "450"
        _strkitchen_designstyles(20, 2) = "450"
        _strkitchen_designstyles(20, 3) = "Granite"
        _strkitchen_designstyles(20, 4) = "23000"


        populateOptionalKitchen_appliances()
    End Sub

    Sub populateOptionalKitchen_appliances()
        'assigning values for each element
        _strOptionalKitchen_appliances(0, 0) = "Basic Fridge Freezer"
        _strOptionalKitchen_appliances(0, 1) = "180"

        _strOptionalKitchen_appliances(1, 0) = "American Style Fridge Freezer"
        _strOptionalKitchen_appliances(1, 1) = "750"

        _strOptionalKitchen_appliances(2, 0) = "Hob"
        _strOptionalKitchen_appliances(2, 1) = "400"

        _strOptionalKitchen_appliances(3, 0) = "Single Oven"
        _strOptionalKitchen_appliances(3, 1) = "340"

        _strOptionalKitchen_appliances(4, 0) = "Double Oven"
        _strOptionalKitchen_appliances(4, 1) = "550"

        _strOptionalKitchen_appliances(5, 0) = "Dishwasher"
        _strOptionalKitchen_appliances(5, 1) = "270"
        'displaying the values of each element in the kitchen appliances
        Dim counter As Integer
        For counter = 0 To 5
            cbxoptionalkitchenappliances.Items.Add(_strOptionalKitchen_appliances(counter, 0) & " " & (_strOptionalKitchen_appliances(counter, 1)))
        Next
    End Sub


    Private Sub btnenterspecifications_Click(sender As Object, e As EventArgs) Handles btnenterspecifications.Click
        'validating the length,width and budget to the limits given and validating the dimensions to not be null and must be a numeric value
        If txtlength.Text = "" Then
            MessageBox.Show("Please enter a valid length dimension" & vbCrLf & "__________________")
        ElseIf txtwidth.Text = "" Then
            MessageBox.Show("Please enter a valid width dimension" & vbCrLf & vbCrLf & "__________________")
        ElseIf txtmaximumbudget.Text = "" Then
            MessageBox.Show("Please enter amount in Sterling pounds" & vbCrLf & vbCrLf & "__________________")
        ElseIf Not IsNumeric(txtlength.Text) Then
            MessageBox.Show("Please enter a valid length dimension" & vbCrLf & vbCrLf & "__________________")
        ElseIf Not IsNumeric(txtwidth.Text) Then
            MessageBox.Show("Please enter a valid length dimension" & vbCrLf & vbCrLf & "__________________")
        ElseIf Not IsNumeric(txtmaximumbudget.Text) Then
            MessageBox.Show("Please enter a valid length dimension" & vbCrLf & vbCrLf & "__________________")
        ElseIf Not (txtlength.Text >= 120 And txtlength.Text <= 600) Then
            MessageBox.Show("dear customer" & vbCrLf & "-__-__-__-__-__-__-" & vbCrLf & "The minimum length is 120cm and the maximum length is 600cm")
        ElseIf Not (txtwidth.Text >= 150 And txtwidth.Text <= 600) Then
            MessageBox.Show("dear customer" & vbCrLf & "-__-__-__-__-__-__-" & vbCrLf & "The minimum width is 150cm and the maximum width is 600cm")
        ElseIf Not (txtmaximumbudget.Text >= 1000 And txtmaximumbudget.Text <= 25000) Then
            MessageBox.Show("dear customer" & vbCrLf & "The minimum amount is 1000€" & vbCrLf & "The maximum amount is 25000€" & vbCrLf & "__________________")
        Else
            'displaying the values of each element in the kitchen design styles
            Dim length As Integer = txtlength.Text
            Dim width As Double = txtwidth.Text
            Dim maximumbudget As Integer = txtmaximumbudget.Text
            Dim counter As Integer
            Panel1.Visible = True
            For counter = 0 To 20
                'If Length >= kitchen_Style(Counter, 1) And Width >= kitchen_Style(Counter, 2) And MaximumBudget >= kitchen_Style(Counter, 4) Then
                If length >= _strkitchen_designstyles(counter, 1) And width >= _strkitchen_designstyles(counter, 2) And maximumbudget >= _strkitchen_designstyles(counter, 4) Then

                    cbxKitchendesignstyles.Items.Add(_strkitchen_designstyles(counter, 0) & "  " & (_strkitchen_designstyles(counter, 1) & "  " & (_strkitchen_designstyles(counter, 2) & "  " & (_strkitchen_designstyles(counter, 3) & "  " & (_strkitchen_designstyles(counter, 4))))))
                End If
            Next
        End If
    End Sub

    Sub _kitcheninstallation_cost(choose As String)
        If choose.Contains("Small L-shaped kitchen") Then
            Lblcustominstallation.Text = "1250"
        ElseIf choose.Contains("Medium L-shaped kitchen") Then
            Lblcustominstallation.Text = "2750"
        ElseIf choose.Contains("Large L-shaped kitchen") Then
            Lblcustominstallation.Text = "3750"
        ElseIf choose.Contains("Small straight kitchen") Then
            Lblcustominstallation.Text = "750"
        ElseIf choose.Contains("Medium straight kitchen") Then
            Lblcustominstallation.Text = "1500"
        ElseIf choose.Contains("Large straight kitchen") Then
            Lblcustominstallation.Text = "2500"
        ElseIf choose.Contains("Large island kitchen") Then
            Lblcustominstallation.Text = "4750"
        End If
    End Sub

    Private Sub btnselectkitchen_Click(sender As Object, e As EventArgs) Handles btnselectkitchen.Click
        'summing up the installation cost
        _kitcheninstallation_cost(cbxKitchendesignstyles.Text)
    End Sub


    Private Sub btnpurchase_Click(sender As Object, e As EventArgs) Handles btnpurchase.Click
        Dim thekitchencost As String = cbxKitchendesignstyles.SelectedValue
        'Dim subthekitchencost As String = thekitchencost.Substring(thekitchencost.Length - 4)
        Dim _strOptionalKitchen_appliances As String = cbxoptionalkitchenappliances.SelectedItem
        Dim subpopulateOptionalKitchen_appliances = "0"
        If cbxoptionalkitchenappliances.SelectedItem <> "" Then
            subpopulateOptionalKitchen_appliances = _strOptionalKitchen_appliances.Substring(_strOptionalKitchen_appliances.Length - 3)
        End If
        Dim _kitcheninstallation_cost As String = Lblcustominstallation.Text
        Dim shippingfee As Double = 95
        Dim finalkitchencost As Integer
        finalkitchencost = thekitchencost

        If Ccbcustominstallation.Checked Then
            finalkitchencost += _kitcheninstallation_cost
        Else
            finalkitchencost += shippingfee
        End If
        lblfinalcost.Text = finalkitchencost
        finalkitchencost += subpopulateOptionalKitchen_appliances
        Frmcustomerdetails.ShowDialog()

        '        Dim kitcheninstallation As Integer
        '        Dim kitchencost As String = cbxKitchendesignstyles.SelectedValue
        '        Dim optionaplkliances As String = cbxKitchendesignstyles.SelectedValue
        '        Dim subappliances As String = "0"
        '        If cbxKitchendesignstyles.SelectedItem <> "" Then
        '            subappliances = optionaplkliances.Substring(optionaplkliances.Length - 3)

        '        End If
        '        Dim installationcost As String = txtinstallationcost.Text
        '        Dim shippingfee As Double = 95
        '        Dim totalcost As Double
        '        If Ccbcustominstallation.Checked Then
        '            totalcost += installationcost
        '        Else
        '            totalcost += shippingfee
        '        End If
        '        txtfinalcost.Text = totalcost
        '        totalcost += subappliances
        '        Frmcustomerdetails.ShowDialog()



    End Sub

End Class
