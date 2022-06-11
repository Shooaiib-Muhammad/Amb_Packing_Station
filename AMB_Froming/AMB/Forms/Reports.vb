Public Class Reports

    Public Sub RepairReprts(LineID As Int64, Date1 As String, Date2 As String, ClientID As Int64, ModelID As Int64, ArtID As Int64, DayID As Int64)


        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, Date1) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, Now.Date)
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, Now.Date)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try


        Me.View_AMb_Fresh_PassTableAdapter.Fill(Me.DSAMB.View_AMb_Fresh_Pass, 1, LineID, Date1, Date2)
        Me.View_AMb_Forming_RepairTableAdapter.Fill(Me.DSAMB.View_AMb_Forming_Repair, 1, LineID, Date1, Date2)
        Me.View_AMb_Article_Wise_FreshTableAdapter.Fill(Me.DSAMB.View_AMb_Article_Wise_Fresh, 1, LineID, ClientID, ModelID, ArtID, DayID)

        Me.View_Article_Wise_FailTableAdapter.Fill(Me.DSAMB.View_Article_Wise_Fail, LineID, ClientID, ModelID, ArtID, DayID)
        Me.View_AMB_Incentive_RFTTableAdapter.Fill(Me.DSAMB.View_AMB_Incentive_RFT, Date1, Date2, LineID)
        Me.Froming_HourllyTableAdapter.Fill(Me.DSAMB.Froming_Hourlly, Date1, LineID)
        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, LineID)


        Me.Tbl_Pro_Amb_ArticleTableAdapter.Fill(Me.DSAMB.tbl_Pro_Amb_Article, ClientID, ModelID, ArtID)

        'Label95.Text = Val(Label3.Text) + Val(Label97.Text)


    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label95.Text = Val(Label3.Text) + Val(Label97.Text)
        Label95.Text = Format(Val(Label95.Text), "0")

        Label94.Text = Val(Label4.Text) + Val(Label93.Text)
        Label37.Text = Val(Label43.Text) + Val(Label69.Text)
        Label38.Text = Val(Label45.Text) + Val(Label54.Text)
        Label91.Text = Val(Label4.Text) - Val(Label97.Text)
        Label108.Text = Val(Label95.Text) + Val(Label94.Text)
        Label33.Text = Val(Label38.Text) + Val(Label37.Text)
        TotalCheckedLabel1.Text = Format(Val(TotalCheckedLabel1.Text), "0")
        Label3.Text = Format(Val(Label3.Text), "0")
        Label4.Text = Format(Val(Label4.Text), "0")
        Label6.Text = Format(Val(Label6.Text), "0")
        Label96.Text = Format(Val(Label96.Text), "0")
        Label97.Text = Format(Val(Label97.Text), "0")
        Label93.Text = Format(Val(Label93.Text), "0")
        Label105.Text = Format(Val(Label105.Text), "0")
        Label1.Text = Format(Val(Label1.Text), "0")
        Label45.Text = Format(Val(Label45.Text), "0")
        Label43.Text = Format(Val(Label43.Text), "0")
        Label41.Text = Format(Val(Label41.Text), "0")
        Label82.Text = Format(Val(Label82.Text), "0")
        Label80.Text = Format(Val(Label80.Text), "0")
        Label78.Text = Format(Val(Label78.Text), "0")
        Label91.Text = Format(Val(Label91.Text), "0")
        Label108.Text = Format(Val(Label108.Text), "0")
        Label95.Text = Format(Val(Label95.Text), "0")
        Label94.Text = Format(Val(Label94.Text), "0")
        Label33.Text = Format(Val(Label33.Text), "0")
        Label38.Text = Format(Val(Label38.Text), "0")
        Label37.Text = Format(Val(Label37.Text), "0")
        Label95.Text = Format(Val(Label95.Text), "0")
        Label36.Text = Format(Val(Label36.Text), "0")
        Label54.Text = Format(Val(Label54.Text), "0")
        Label69.Text = Format(Val(Label69.Text), "0")
        Label40.Text = Format(Val(Label40.Text), "0")
        Label51.Text = Format((Val(Label3.Text) / Val(TotalCheckedLabel1.Text)) * 100, "0").ToString + "%"
        Label102.Text = Format((Val(Label97.Text) / Val(Label96.Text)) * 100, "0").ToString + "%"
        Label55.Text = Format((Val(Label45.Text) / Val(Label1.Text)) * 100, "0").ToString + "%"
        Label53.Text = Format((Val(Label54.Text) / Val(Label36.Text)) * 100, "0").ToString + "%"
        Label15.Text = Format((Val(Label80.Text) / Val(Label82.Text)) * 100, "0").ToString + "%"
    End Sub



End Class