Public Class frmReceiptTest
    Private Sub frmReceiptTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReceiptDataSet.qryReceipt' table. You can move, or remove it, as needed.
        Me.QryReceiptTableAdapter.Fill(Me.ReceiptDataSet.qryReceipt)

    End Sub
End Class