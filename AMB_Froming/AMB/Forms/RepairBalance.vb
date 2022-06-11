Public Class RepairBalance


    Public Sub RepairBalance(LineID As Int64, Date1 As String, Date2 As String)
        'Dim LineID As Int64 = Form1.LineID
        'Dim Date1 As String = Form1.Date1
        'Dim Date2 As String = Form1.Date2
        Try
            'Me.View_AMb_FormingTableAdapter.Fill(Me.DSAMB.View_AMb_Forming, 1, LineID, Date1, Date2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim RCheck = Me.DSAMB.View_AMb_Forming.Rows(0).Item("RCheck")
        Dim RPASS = Me.DSAMB.View_AMb_Forming.Rows(0).Item("RPass")
        Dim Balance = RCheck - RPASS

        Label4.Text = Balance
        Label4.Text = Format(Val(Label4.Text), "0")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


End Class