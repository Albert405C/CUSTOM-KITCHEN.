Imports System.IO
Public Class Frmcustomerdetails
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btngeneratereceipt.Click
        Dim shippingfee As Integer = "95"
        Dim kitchencost As Integer = "95+5700"
        Dim totalcost As Integer
        totalcost = shippingfee + kitchencost

        Dim name As String = txtname.Text
        Dim email As String = txtemail.Text
        Dim creditcardinformation As Integer = "0"
        Dim housenumber As Integer = "0"
        Dim streetname As String = Txtstreetname.Text
        Dim postalcode As Integer = "0"
        Dim city As String = txtcity.Text
        If name Is "" And name IsNot "string" Then
            MessageBox.Show("please enter a valid name")
        ElseIf Not (email.Contains("@")) Then
            MessageBox.Show("please enter a valid email")
        ElseIf Not IsNumeric(postalcode) Then
            MessageBox.Show("enter a valid postalcode")
        ElseIf streetname Is "" And streetname IsNot "string" Then
            MessageBox.Show("enter a valid streetname")
        ElseIf city Is "" And city IsNot "string" Then
            MessageBox.Show("please enter a valid city name")
        ElseIf Not IsNumeric(txtcreditcardinformation.Text) Then
            MessageBox.Show("the card number should be 16 numbers" & vbCrLf & "the card number should be numerical")
        ElseIf Not IsNumeric(txtpostalcode.Text) And IsNothing("") Then
            MessageBox.Show("enter a valid postalcode")

        Else
        End If
        ''Dim Newfile As String = ("C:\Users\Public\Reciept")
        ''Dim file As New IO.StreamWriter(Newfile, True)
        ''file.WriteLine("Example")
        ' file1.Close()
        'Dim myfile As StreamWriter
        Dim customerreceipt As String = txtcreditcardinformation.Text & txtemail.Text & txtcity.Text & txthousenumber.Text
        Dim lblfinalcost As Integer = 0

        Dim myfile = File.CreateText("C:\Users\user\Documents\FINAL RECEIPT.txt")
        myfile.WriteLine("HELLO" & vbCrLf & "THANK YOU FOR SHOPPING WITH CUSTOM KITCHENS")
        myfile.WriteLine("NAME:" & "_----_----_----_----_----_" & txtname.Text)
        myfile.WriteLine("HOUSE NUMBER:" & "_----_----_----_----_----_" & txthousenumber.Text)
        myfile.WriteLine("EMAIL:" & "_----_----_----_----_----_" & txtemail.Text)
        myfile.WriteLine("CREDIT CARD INFORMATION:" & "_----_----_----_----_----_" & txtcreditcardinformation.Text)
        myfile.WriteLine("STREET NAME:" & "_----_----_----_----_----_" & Txtstreetname.Text)
        myfile.WriteLine("TOWN/CITY:" & "_----_----_----_----_----_" & txtcity.Text)
        myfile.WriteLine("POSTAL CODE:" & "_----_----_----_----_----_" & txtpostalcode.Text)
        myfile.WriteLine("YOUR TOTAL COST IS" & vbCrLf & "______________________________")
        myfile.WriteLine(frmmainform.lblfinalcost.AccessibleName)

        myfile.Close()
        'Dim receiptpath As String = ("C:\Users\Public\Reciept")
        ' receipt As FileStream = File.Create
        'Dim info As Byte() = New System.Text.UTF8Encoding(True).GetBytes("this is your receipt")
        'receipt.Write(info, 0, info.Length)
        'receipt.Close()


    End Sub

End Class