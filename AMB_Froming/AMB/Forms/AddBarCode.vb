Public Class AddBarCode
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub AddBarCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSproduction.tbl_Pro_Article_BarCode' table. You can move, or remove it, as needed.
        '' Me.Tbl_Pro_Article_BarCodeTableAdapter.Fill(Me.DSproduction.tbl_Pro_Article_BarCode)
        'TODO: This line of code loads data into the 'DSAMB.tbl_Pro_Article' table. You can move, or remove it, as needed.
        Me.Tbl_Pro_ArticleTableAdapter.Fill(Me.DSAMB.tbl_Pro_Article)

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArtCodeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArtCodeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Public Function callbarcode()
        Dim barCodeNo As String

        barCodeNo = txtCardNo.Text

        If barCodeNo.Length > 0 Then
            'If barCodeNo.Length = 13 Then
            'Me.View_Pro_Article_BarCodeTableAdapter.Fill(Me.DSProduction.View_Pro_Article_BarCode, barCodeNo)



            Try
                Tbl_Pro_Article_BarCodeTableAdapter.Insert(Label1.Text, Label2.Text, ArtCodeComboBox.SelectedValue, ComboBox1.Text, ComboBox2.Text, barCodeNo)
                MsgBox("Bar Code Generated Successfully")
                txtCardNo.Text = ""
                txtCardNo.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'txtCardNo.Text = ""
            End Try


        End If
    End Function

    Private Sub txtCardNo_TextChanged(sender As Object, e As EventArgs) Handles txtCardNo.TextChanged
        If ComboBox1.Text = "" Then
            MsgBox("Select Size")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Select Type")
        Else
            callbarcode()
        End If
    End Sub

    Private Sub ArtCodeComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ArtCodeComboBox.SelectedIndexChanged

    End Sub
End Class