


Imports System.Net
Public Class Form1
    'Public Shared LineID As Int64
    Public Shared Date1 As String
    Public Shared Date2 As String
    Dim HostName As String = Dns.GetHostName
    Dim ipEntry As IPHostEntry = Dns.GetHostEntry(HostName)
    Dim IpAddr As IPAddress() = ipEntry.AddressList
    Dim SysIpAdd As String = Nothing
    Dim PuC = 0
    Dim CoreCavity = 0
    Dim Touching = 0
    Dim Otherissue = 0
    Dim panalCavity = 0
    Dim openStrip = 0
    Dim SingleStrip = 0
    Dim unbounded = 0
    Dim ArtWork = 0
    Dim Wrinkle = 0
    Dim ZigZag = 0
    Dim Overlap = 0
    Dim panalGmd = 0
    Dim bgrade = 0
    Dim StraightCut = 0
    Dim Burning = 0
    Dim MissAlligmnet = 0
    Dim Discolor = 0
    Dim LogoSMearing = 0
    Dim LogoDoubling = 0
    Dim barcodemisalligment = 0
    Dim LargerSpots = 0
    Dim Smearing = 0
    Dim hfMisAlignment = 0
    Dim seamClosingGlue = 0
    Dim cuttingResidual = 0
    Dim BlurPrinting = 0
    Dim isFreshBall = True
    Dim BallType As String
    Dim unevensurface = 0
    Dim unshapecut = 0
    Dim zigzagcut = 0
    Dim cutingpanel = 0
    Dim heavyprintdefects = 0
    Dim newtouching = 0
    Dim printmissallignment = 0
    Dim anymisprint = 0
    Dim colourshade = 0
    Dim wrongartwork = 0
    Dim materialdefects = 0
    Dim openseam = 0
    Dim seamoverlapping = 0
    Dim wrikles = 0
    Dim excessglue = 0
    Dim missingglue = 0
    Dim pressuremark = 0
    Dim airbubble = 0
    Dim LineID As Int64
    Dim ManchineName As String = Environment.MachineName
    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal fRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCardNo.Focus()
        CreateSystemDSN()

        'TODO: This line of code loads data into the 'DSAMB.tbl_PC_AMB_Line' table. You can move, or remove it, as needed.
        SysIpAdd = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        Label37.Text = SysIpAdd

        'Try
        '    If Label63.Text = "192.168.40.81" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 3)
        '    ElseIf Label63.Text = "192.168.40.82" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 4)
        '    ElseIf Label63.Text = "192.168.40.83" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 5)
        '    ElseIf Label63.Text = "192.168.40.84" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 6)
        '    ElseIf Label63.Text = "192.168.40.85" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 7)
        '    ElseIf Label63.Text = "192.168.40.86" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 8)
        '    ElseIf Label63.Text = "192.168.40.87" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, 9)
        '    ElseIf Label63.Text = "192.168.40.15" Then
        '        Me.Tbl_PC_AMB_LineTableAdapter.FillBy(Me.DSAMB.tbl_PC_AMB_Line)
        '    Else
        Me.Tbl_PC_AMB_LineTableAdapter.FillBy(Me.DSAMB.tbl_PC_AMB_Line)
        '    End If
        'Catch ex As Exception

        'End Try

        Try
            If Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, Now.Date) > 0 Then
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, Now.Date)
            Else
                Me.Tbl_Inv_Tran_DateTableAdapter.Insert(Now.Date)
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, Now.Date)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
        'TODO: This line of code loads data into the 'DSAMB.tbl_PC_AMB_Hours_Tran' table. You can move, or remove it, as needed.
        'Me.Tbl_PC_AMB_Hours_TranTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Hours_Tran)
        'TODO: This line of code loads data into the 'DSAMB.tbl_Pro_Article_D' table. You can move, or remove it, as needed.
        Me.Tbl_Pro_Article_DTableAdapter.Fill(Me.DSAMB.tbl_Pro_Article_D)
        'TODO: This line of code loads data into the 'DSAMB.tbl_Pro_Article' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Pro_ArticleTableAdapter.Fill(Me.DSAMB.tbl_Pro_Article)
        Catch ex As Exception

        End Try

        Timer1.Start()
        Timer1.Interval = 1000
        Timer2 = New Timer
        AddHandler Timer2.Tick, AddressOf Timer2_Tick
        Timer2.Interval = 1000
        Timer2.Start()

        txtCardNo.Focus()
        values()
        DayID()

    End Sub
    Private Sub Insertion(pass As Int64, seamClosingGlue As Int64, panalGmd As Int64, Overlap As Int64, ZigZag As Int64, Wrinkle As Int64, ArtWork As Int64, StraightCut As Int64, Burning As Int64, unbounded As Int64, SingleStrip As Int64, openStrip As Int64, panalCavity As Int64, CoreCavity As Int64, PuC As Int64, bgrade As Int64, Otherissue As Int64, Touching As Int64, MissAlligmnet As Int64, Fail As Int64, Discolor As Int64, LogoSMearing As Int64, LogoDoubling As Int64, barcodemisalligment As Int64, LargerSpots As Int64, Smearing As Int64, cuttingResidual As Int64, hfMisAlignment As Int64, status As Boolean, RPass As Int64, RCheck As Int64, BlurPrinting As Int64, check As Int64, BallType As String, unevenballSurface As Int64, UNSHAPECUT As Int64, zigzagedge As Int64, cutting As Int64, heavyprint As Int64, newtouhing As Int64, printmissalligment As Int64, anymisprint As Int64, colorshade As Int64, wrongartwork As Int64, materialfDefects As Int64, openseam As Int64, seamoverlaping As Int64, wrikles As Int64, excessglue As Int64, missingglue As Int64, pressuremark As Int64, airbubble As Int64)

        Try
            Me.Tbl_PC_AMB_Hours_TranTableAdapter.InsertQuery(0, 0, 0, ArtSizeComboBox.Text, Val(DayNoLabel1.Text), 1, LineID, 2, Val(TextBox1.Text), 0, 0, 0, Val(Label31.Text), 0, Val(Label50.Text), 0, 0, 0, 0, Val(ClientID.Text), Val(ModelID.Text), Val(ArtID.Text), seamClosingGlue, PuC, CoreCavity, Touching, Otherissue, panalCavity, openStrip, SingleStrip, unbounded, ArtWork, Wrinkle, ZigZag, Overlap, panalGmd, bgrade, 0, 0, check, pass, Fail, StraightCut, cuttingResidual, Burning, SingleStrip, openStrip, 0, RCheck, MissAlligmnet, Discolor, LogoSMearing, LogoDoubling, barcodemisalligment, LargerSpots, Smearing, hfMisAlignment, status, RPass, BlurPrinting, BallType, Nothing, unevenballSurface, UNSHAPECUT, zigzagedge, cutting, heavyprint, newtouhing, printmissalligment, anymisprint, colorshade, wrongartwork, materialfDefects, openseam, seamoverlaping, wrikles, excessglue, missingglue, pressuremark, airbubble, ManchineName)
        Catch ex As Exception
        End Try
        Data()
        values()
        reset()



    End Sub

    Private Sub values()
        txtCardNo.Focus()
        Label43.Text = Format(Val(Label43.Text), "0")
        Label86.Text = Format(Val(Label86.Text), "0")
        Label45.Text = Format(Val(Label45.Text), "0")
        TextBox1.Text = Format(Val(TextBox1.Text), "0")
        Label9.Text = Format(Val(Label9.Text), "0")
        Label10.Text = Format(Val(Label10.Text), "0")
        Label11.Text = Format(Val(Label11.Text), "0")
        Label13.Text = Format(Val(Label13.Text), "0")
        Label12.Text = Format(Val(Label12.Text), "0")
        Label16.Text = Format(Val(Label16.Text), "0")
        Label17.Text = Format(Val(Label17.Text), "0")
        Label18.Text = Format(Val(Label18.Text), "0")
        Label49.Text = Format(Val(Label49.Text), "0")
        Label7.Text = Format(Val(Label7.Text), "0")
        Label14.Text = Format(Val(Label14.Text), "0")
        Label19.Text = Format(Val(Label19.Text), "0")
        Label20.Text = Format(Val(Label20.Text), "0")
        Label21.Text = Format(Val(Label21.Text), "0")
        Label22.Text = Format(Val(Label22.Text), "0")
        Label23.Text = Format(Val(Label23.Text), "0")
        Label24.Text = Format(Val(Label24.Text), "0")
        Label57.Text = Format(Val(Label57.Text), "0")
        Label58.Text = Format(Val(Label58.Text), "0")
        Label59.Text = Format(Val(Label59.Text), "0")
        Label60.Text = Format(Val(Label60.Text), "0")
        Label61.Text = Format(Val(Label61.Text), "0")
        Label62.Text = Format(Val(Label62.Text), "0")
        Label65.Text = Format(Val(Label65.Text), "0")
        Label66.Text = Format(Val(Label66.Text), "0")
        Label67.Text = Format(Val(Label67.Text), "0")

        Label68.Text = Format(Val(Label68.Text), "0")

        Label33.Text = Val(Label10.Text) + Val(Label23.Text) + Val(Label16.Text)
        Label33.Text = Format(Val(Label33.Text), "0")
        Label29.Text = Val(Label20.Text) + Val(Label66.Text) + Val(Label13.Text) + Val(Label11.Text) + Val(Label12.Text)
        Label29.Text = Format(Val(Label29.Text), "0")
        Label30.Text = Val(Label49.Text) + Val(Label14.Text) + Val(Label60.Text) + Val(Label22.Text) + Val(Label18.Text) + Val(Label17.Text) + Val(Label65.Text) + Val(Label24.Text) + Val(Label58.Text)
        Label30.Text = Format(Val(Label30.Text), "0")
        Dim ArtFail = Val(Label86.Text) - Val(Label45.Text)
        Label43.Text = ArtFail

        Label38.Text = Format(Val(Label38.Text), "0")
        Label52.Text = Format(Val(Label52.Text), "0")
        Label47.Text = Format(Val(Label47.Text), "0")
        Label39.Text = Format((Val(Label52.Text) / Val(Label38.Text)) * 100, "0").ToString + "%"

        Label39.Text = Format(Val(Label39.Text), "0").ToString + "%"

        Label43.Text = Format(Val(Label43.Text), "0")
        Label45.Text = Format(Val(Label45.Text), "0")
        Label55.Text = Format(Val(Label55.Text), "0").ToString + "%"

        Label55.Text = Format((Val(Label45.Text) / Val(Label86.Text)) * 100, "0").ToString + "%"
        Label89.Text = Val(Label9.Text) + Val(Label10.Text) + Val(Label11.Text) + Val(Label12.Text) + Val(Label13.Text) + Val(Label14.Text) + Val(Label16.Text) + Val(Label23.Text) + Val(Label20.Text) + Val(Label66.Text) + Val(Label60.Text) + Val(Label49.Text)
        Label89.Text = Format(Val(Label89.Text), "0")
        Label90.Text = Val(Label24.Text) + Val(Label58.Text) + Val(Label57.Text) + Val(Label59.Text) + Val(Label61.Text) + Val(Label62.Text) + Val(Label19.Text) + Val(Label67.Text) + Val(Label21.Text) + Val(Label68.Text)
        Label90.Text = Format(Val(Label90.Text), "0")
        Dim RFT As Double
        Dim WFT As Double

        RFT = 100 - WFT

    End Sub

    Private Sub reset()
        Button27.BackColor = Color.White
        Button22.BackColor = Color.White
        Button23.BackColor = Color.White
        Button24.BackColor = Color.White
        Button25.BackColor = Color.White
        Button26.BackColor = Color.White
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button9.BackColor = Color.White
        Button10.BackColor = Color.White
        Button11.BackColor = Color.White
        Button12.BackColor = Color.White
        Button13.BackColor = Color.White
        Button14.BackColor = Color.White
        Button15.BackColor = Color.White
        Button16.BackColor = Color.White
        Button17.BackColor = Color.White
        Button19.BackColor = Color.White
        Button20.BackColor = Color.White
        Button30.BackColor = Color.White
        Button28.BackColor = Color.White
        Button29.BackColor = Color.White
        Button31.BackColor = Color.White

        Button18.BackColor = Color.White
        Button32.BackColor = Color.White
        Button33.BackColor = Color.White
        Button34.BackColor = Color.White
        Button35.BackColor = Color.White
        Button36.BackColor = Color.White
        Button37.BackColor = Color.White
        Button38.BackColor = Color.White
        Button39.BackColor = Color.White

        PuC = 0
        CoreCavity = 0
        Touching = 0
        Otherissue = 0
        panalCavity = 0
        openStrip = 0
        SingleStrip = 0
        unbounded = 0
        ArtWork = 0
        Wrinkle = 0
        ZigZag = 0
        Overlap = 0
        panalGmd = 0
        bgrade = 0
        StraightCut = 0
        Burning = 0
        MissAlligmnet = 0
        Discolor = 0
        LogoSMearing = 0
        LogoDoubling = 0
        barcodemisalligment = 0
        LargerSpots = 0
        Smearing = 0
        hfMisAlignment = 0
        seamClosingGlue = 0
        cuttingResidual = 0
        BlurPrinting = 0
        unevensurface = 0
        unshapecut = 0
        zigzagcut = 0
        cutingpanel = 0
        heavyprintdefects = 0
        newtouching = 0
        printmissallignment = 0
        anymisprint = 0
        colourshade = 0
        wrongartwork = 0
        materialdefects = 0
        openseam = 0
        seamoverlapping = 0
        wrikles = 0
        excessglue = 0
        missingglue = 0
        pressuremark = 0
        airbubble = 0
    End Sub

    Private Sub Tbl_Pro_Article_DBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Pro_Article_DBindingSource.PositionChanged
        Data()
        values()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Insertion(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, True, 0, 0, 0, 1, Nothing, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        reset()
        Button1.BackColor = Color.Green
        Entryflag = True


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        clickDefect(unevensurface, Button2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clickDefect(unshapecut, Button3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clickDefect(colourshade, Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        clickDefect(anymisprint, Button5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        clickDefect(printmissallignment, Button6)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        clickDefect(Wrinkle, Button11)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        clickDefect(excessglue, Button10)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        clickDefect(cutingpanel, Button9)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        clickDefect(materialdefects, Button7)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        clickDefect(zigzagcut, Button16)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        clickDefect(seamoverlapping, Button15)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        clickDefect(PuC, Button14)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        clickDefect(heavyprintdefects, Button13)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        clickDefect(Otherissue, Button12)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        clickDefect(pressuremark, Button17)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        clickDefect(wrongartwork, Button20)
    End Sub

    Dim TimerFlag As Boolean = False
    Dim Entryflag As Boolean = False
    Dim BalanceFlag = False
    Dim BalanceCOuner As Int16 = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'clock.Text = "Date: " & Now.Date & " " & TimeOfDay
        'If TimeOfDay.Minute = 0 And TimeOfDay.Second = 1 Then

        '    BalanceFlag = True

        '    If BalanceFlag = True Then
        '        Dim box1 = New RepairBalance()
        '        box1.RepairBalance(LineNameComboBox.SelectedValue, DateTimePicker1.Text, DateTimePicker2.Text)
        '        box1.ShowDialog()
        '        BalanceFlag = False
        '    End If
        'End If
    End Sub
    'Dim box = New RepairBalance()
    '        box.ShowDialog()
    Dim TimerCOuner As Int16 = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CallTimer()

    End Sub
    Private Sub CallTimer()
        If TimerFlag = True Then
            If TimerCOuner <= 0 Then
                Panel1.Enabled = False
                TimerCOuner = TimerCOuner + 1
                Button19.Enabled = True
                Entryflag = False
            Else
                TimerCOuner = 0
                TimerFlag = False
                Panel1.Enabled = True
                Entryflag = True
                Button19.Enabled = False
                reset()
            End If
        Else
            Panel1.Enabled = True
        End If
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Data()
        values()
    End Sub

    Private Sub ArtCodeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArtCodeComboBox.SelectedIndexChanged
        Data()
        values()


    End Sub
    Private Shared Sub CreateSystemDSN()
        'Dim ReturnValue As Integer
        'Dim Driver As String
        'Dim Attributes As String
        'Driver = "SQL Native Client"
        'Attributes = "SERVER=" & "SERVER" & Chr(0)
        ''Attributes = Attributes & "DESCRIPTION=" & "HRMS" & Chr(0)
        'Attributes = Attributes & "DSN=" & "ERPFS" & Chr(0)
        'Attributes = Attributes & "DATABASE=" & "MIS" & Chr(0)
        'Attributes = Attributes & "TRUSTED_CONNECTION=YES" & Chr(0)
        'ReturnValue = SQLConfigDataSource(0, 1, Driver, Attributes)
        'If ReturnValue <> 0 Then
        '    'MsgBox("DSN Created Gear")
        'Else
        '    MsgBox("Please contact administrator. ODBC Connection failed.")
        'End If
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.Close()
    End Sub







    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        clickDefect(Discolor, Button26)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click

        clickDefect(openseam, Button25)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

        clickDefect(LogoDoubling, Button24)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        clickDefect(airbubble, Button23)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        clickDefect(LargerSpots, Button22)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        clickDefect(Smearing, Button27)

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click

        clickDefect(newtouching, Button29)

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click

        clickDefect(seamClosingGlue, Button30)

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        clickDefect(missingglue, Button28)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        CallFresh()
        Button1.Visible = True
        'If RadioButton1.Checked = True Then


        '    Label7.Visible = True

        '    Dim Box As New FressAlert
        '    Box.ShowDialog()
        'Else


        '    Label7.Visible = False

        'End If


        DayID()

        Data()
        values()
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In Me.MdiChildren
            If f.Name = childWindow Then
                f.WindowState = FormWindowState.Maximized
                Return True
            End If
        Next
        Return False

        Dim box = New AlertBox()
        box.ShowDialog()

    End Function
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

        'CallRepair()
        Button1.Visible = False
        BallType = "RepairPass"
        'If RadioButton2.Checked = True Then

        '    'If ChildWindowOpen("AlertBox") = False Then
        '    '    Dim objMLPLam As New AlertBox
        '    '    'objMLPLam.MdiParent = Me
        '    '    objMLPLam.Show()
        '    'End If

        '    Dim box = New AlertBox()
        '    box.ShowDialog()


        '    Label7.Visible = False


        'Else



        Label7.Visible = True

        'End If
        DayID()
        Data()
        values()
    End Sub

    Private Sub clickDefect(ByRef value, button)

        Dim rpass
        Dim rcheck
        Dim status
        Dim fail
        Dim check

        'If RadioButton1.Checked = True Then
        '    BallType = "FreshBall"

        value = 1
            rpass = 0
            rcheck = 0
            status = True
            fail = 1
            check = 1


        'ElseIf RadioButton2.Checked = True Then
        '    BallType = "RepairPass"

        '    value = -1
        '    rpass = 1
        '    rcheck = 1
        '    status = False
        '    fail = -1
        '    check = 0

        'ElseIf RadioButton3.Checked = True Then
        '    BallType = "RepairFail"

        '    value = 1
        '    rpass = 0
        '    rcheck = 1
        '    status = False
        '    fail = 1
        '    check = 0

        'End If
        button.BackColor = Color.Red
        TimerFlag = True
        CallTimer()

        Insertion(0, seamClosingGlue, panalGmd, Overlap, ZigZag, Wrinkle, ArtWork,
                  StraightCut, Burning, unbounded, SingleStrip, openStrip, panalCavity,
                  CoreCavity, PuC, bgrade,
                  Otherissue, Touching, MissAlligmnet, fail, Discolor, LogoSMearing,
                  LogoDoubling, barcodemisalligment, LargerSpots, Smearing, cuttingResidual,
                  hfMisAlignment, status, rpass, rcheck, BlurPrinting, check, BallType,
                  unevensurface, unshapecut,
                  zigzagcut,
    cutingpanel,
     heavyprintdefects,
     newtouching,
     printmissallignment,
     anymisprint,
     colourshade,
     wrongartwork,
     materialdefects,
     openseam,
    seamoverlapping,
     wrikles,
     excessglue,
     missingglue,
     pressuremark,
     airbubble)
        'CallRepair()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        clickDefect(BlurPrinting, Button31)
    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

    End Sub

    Private Sub Tbl_PC_AMB_LineBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_PC_AMB_LineBindingSource.PositionChanged
        Data()
        values()
    End Sub
    Private Sub Data()

        txtCardNo.Text = ""
        txtCardNo.Focus()

        Try
            Me.View_AMb_Article_Wise_SumTableAdapter.Fill(Me.DSAMB.View_AMb_Article_Wise_Sum, 2, LineID, Val(ClientID.Text), Val(ModelID.Text), ArtCodeComboBox.SelectedValue, Val(DayNoLabel1.Text), Label37.Text)
            Me.View_AMb_FormingTableAdapter.Fill(Me.DSAMB.View_AMb_Forming, 2, Val(DayNoLabel1.Text), Label37.Text)
        Catch ex As System.Exception

        End Try
        'End If
        txtCardNo.Focus()
    End Sub

    Private Sub Tbl_Pro_ArticleBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Pro_ArticleBindingSource.PositionChanged

        Data()
        values()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

        Data()
        values()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

        Data()
        values()
    End Sub



    Private Sub DayID()
        'If RadioButton1.Checked = True Then
        Try
                Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, CType(Label87.Text, String))
            Catch ex As Exception

            End Try
        'Else
        '    Try
        '        Me.Tbl_Inv_Tran_DateTableAdapter.Fill(Me.DSAMB.tbl_Inv_Tran_Date, CType(DateTimePicker1.Text, String))
        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub
    'Private Sub CallRepair()
    '    If RadioButton2.Checked = True Then

    '        Dim RevenSurface As Int64
    '        RevenSurface = Val(Label9.Text)

    '        Dim Runshape As Int64
    '        Runshape = Val(Label10.Text)

    '        Dim RZigZagcut As Int64
    '        RZigZagcut = Val(Label23.Text)

    '        Dim RCutitingpanel As Int64
    '        RCutitingpanel = Val(Label16.Text)

    '        Dim Rheavyprintdefect As Int64
    '        Rheavyprintdefect = Val(Label20.Text)

    '        Dim RTouching As Int64
    '        RTouching = Val(Label66.Text)

    '        Dim RpirnMissallignament As Int64
    '        RpirnMissallignament = Val(Label13.Text)

    '        Dim RAnyMissprint As Int64
    '        RAnyMissprint = Val(Label12.Text)

    '        Dim RCOlourShape As Int64
    '        RCOlourShape = Val(Label11.Text)

    '        Dim RWrongArtWork As Int64
    '        RWrongArtWork = Val(Label49.Text)

    '        Dim RAmaterialDefetcs As Int64
    '        RAmaterialDefetcs = Val(Label14.Text)

    '        Dim RpoenSeam As Int64
    '        RpoenSeam = Val(Label60.Text)

    '        Dim RSeamOverLapping As Int64
    '        RSeamOverLapping = Val(Label22.Text)

    '        Dim Rwrinkles As Int64
    '        Rwrinkles = Val(Label18.Text)

    '        Dim RExcessGlue As Int64
    '        RExcessGlue = Val(Label17.Text)

    '        Dim RMissGlue As Int64
    '        RMissGlue = Val(Label65.Text)

    '        Dim Rpressuremark As Int64
    '        Rpressuremark = Val(Label24.Text)

    '        Dim Rairbubble As Int64
    '        Rairbubble = Val(Label58.Text)






    '        If RevenSurface = 0 Then
    '            Button2.Enabled = False
    '            Label9.Enabled = False
    '        Else
    '            Button2.Enabled = True
    '            Label9.Enabled = True
    '        End If
    '        If Runshape = 0 Then
    '            Button3.Enabled = False
    '            Label10.Enabled = False
    '        Else
    '            Button3.Enabled = True
    '            Label10.Enabled = True
    '        End If
    '        If RZigZagcut = 0 Then
    '            Button16.Enabled = False
    '            Label23.Enabled = False
    '        Else
    '            Button16.Enabled = True
    '            Label23.Enabled = True
    '        End If


    '        If RCutitingpanel = 0 Then
    '            Button9.Enabled = False
    '            Label16.Enabled = False
    '        Else
    '            Button9.Enabled = True
    '            Label16.Enabled = True
    '        End If

    '        If Rheavyprintdefect = 0 Then
    '            Button13.Enabled = False
    '            Label20.Enabled = False
    '        Else
    '            Button13.Enabled = True
    '            Label20.Enabled = True
    '        End If

    '        If RTouching = 0 Then
    '            Button29.Enabled = False
    '            Label66.Enabled = False
    '        Else
    '            Button29.Enabled = True
    '            Label66.Enabled = True
    '        End If

    '        If RpirnMissallignament = 0 Then
    '            Button6.Enabled = False
    '            Label13.Enabled = False
    '        Else
    '            Button6.Enabled = True
    '            Label13.Enabled = True
    '        End If

    '        If RAnyMissprint = 0 Then
    '            Button5.Enabled = False
    '            Label12.Enabled = False
    '        Else
    '            Button5.Enabled = True
    '            Label12.Enabled = True
    '        End If

    '        If RCOlourShape = 0 Then
    '            Button4.Enabled = False
    '            Label11.Enabled = False
    '        Else
    '            Button4.Enabled = True
    '            Label11.Enabled = True
    '        End If



    '        If RWrongArtWork = 0 Then
    '            Button20.Enabled = False
    '            Label49.Enabled = False
    '        Else
    '            Button20.Enabled = True
    '            Label49.Enabled = True
    '        End If

    '        If RAmaterialDefetcs = 0 Then
    '            Button7.Enabled = False
    '            Label14.Enabled = False
    '        Else
    '            Button7.Enabled = True
    '            Label14.Enabled = True
    '        End If




    '        If Rwrinkles = 0 Then
    '            Button11.Enabled = False
    '            Label18.Enabled = False
    '        Else
    '            Button11.Enabled = True
    '            Label18.Enabled = True
    '        End If
    '        If RpoenSeam = 0 Then
    '            Button25.Enabled = False
    '            Label60.Enabled = False
    '        Else
    '            Button25.Enabled = True
    '            Label60.Enabled = True
    '        End If
    '        If RSeamOverLapping = 0 Then
    '            Button15.Enabled = False
    '            Label22.Enabled = False
    '        Else
    '            Button15.Enabled = True
    '            Label22.Enabled = True
    '        End If


    '        If RExcessGlue = 0 Then
    '            Button10.Enabled = False
    '            Label17.Enabled = False
    '        Else
    '            Button10.Enabled = True
    '            Label17.Enabled = True
    '        End If

    '        If RMissGlue = 0 Then
    '            Button28.Enabled = False
    '            Label65.Enabled = False
    '        Else
    '            Button28.Enabled = True
    '            Label65.Enabled = True
    '        End If


    '        If Rpressuremark = 0 Then
    '            Button17.Enabled = False
    '            Label24.Enabled = False
    '        Else
    '            Button17.Enabled = True
    '            Label24.Enabled = True
    '        End If

    '        If Rairbubble = 0 Then
    '            Button23.Enabled = False
    '            Label58.Enabled = False
    '        Else
    '            Button23.Enabled = True
    '            Label58.Enabled = True
    '        End If


    '    Else

    '    End If

    'End Sub
    Private Sub CallFresh()
        Button2.Enabled = True
        Label9.Enabled = True
        Button3.Enabled = True
        Label10.Enabled = True
        Button16.Enabled = True
        Label23.Enabled = True
        Button9.Enabled = True
        Label16.Enabled = True
        Button6.Enabled = True
        Label13.Enabled = True
        Button5.Enabled = True
        Label12.Enabled = True
        Button4.Enabled = True
        Label11.Enabled = True
        Button20.Enabled = True
        Label49.Enabled = True
        Button7.Enabled = True
        Label14.Enabled = True
        Button25.Enabled = True
        Label60.Enabled = True
        Button13.Enabled = True
        Label20.Enabled = True
        Button29.Enabled = True
        Label66.Enabled = True
        Button17.Enabled = True
        Label24.Enabled = True
        Button23.Enabled = True
        Label58.Enabled = True
        Button22.Enabled = True
        Label57.Enabled = True
        Button27.Enabled = True
        Label62.Enabled = True
        Button26.Enabled = True
        Label61.Enabled = True
        Button24.Enabled = True
        Label59.Enabled = True
        Button12.Enabled = True
        Label19.Enabled = True
        Button30.Enabled = True
        Label67.Enabled = True
        Button14.Enabled = True
        Label21.Enabled = True
        Button31.Enabled = True
        Label68.Enabled = True
        Button15.Enabled = True
        Label22.Enabled = True
        Button11.Enabled = True
        Label18.Enabled = True
        Button10.Enabled = True
        Label17.Enabled = True
        Button28.Enabled = True
        Label65.Enabled = True


    End Sub
    Dim COunter = 0
    Private Sub TImerforBalance()

        If TimeOfDay.Minute = 0 And TimeOfDay.Second = 1 Then
            COunter = 1
        Else
            COunter = 0
        End If
        If COunter = 1 Then
            Dim box = New AlertBox()
            box.ShowDialog()
        Else
            COunter = 0
        End If
    End Sub
    Private Sub CallRepairFail()
        Try
            Me.View_AMb_Article_Wise_SumTableAdapter.FillBy(Me.DSAMB.View_AMb_Article_Wise_Sum, 1, LineNameComboBox.SelectedValue, Val(ClientID.Text), Val(ModelID.Text), ArtCodeComboBox.SelectedValue, Val(DayNoLabel1.Text))

        Catch ex As Exception

        End Try
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        CallFresh()
        CallRepairFail()
        BallType = "RepairFail"
        Button1.Visible = False
        Label7.Visible = False
        'If RadioButton3.Checked = True Then
        '    Dim box = New RepairFail()
        '    box.ShowDialog()


        'Else


        'End If

        DayID()

        Data()
        values()

    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim box2 = New Reports()
        box2.RepairReprts(LineNameComboBox.SelectedValue, Now.Date, Now.Date, Val(ClientID.Text), Val(ModelID.Text), ArtCodeComboBox.SelectedValue, Val(DayNoLabel1.Text))
        box2.ShowDialog()

    End Sub
    Private Sub getLineValue()

        If RadioButton1.Checked = True Then
            LineID = 3
        ElseIf RadioButton2.Checked = True Then
            LineID = 4
        ElseIf RadioButton3.Checked = True Then
            LineID = 5
        ElseIf RadioButton4.Checked = True Then
            LineID = 6
        ElseIf RadioButton5.Checked = True Then
            LineID = 7
        ElseIf RadioButton6.Checked = True Then
            LineID = 8
        ElseIf RadioButton7.Checked = True Then
            LineID = 9
        ElseIf RadioButton8.Checked = True Then
            LineID = 10
        ElseIf RadioButton9.Checked = True Then
            LineID = 11
        End If
        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.DSAMB.tbl_PC_AMB_Line, LineID)
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        getLineValue()
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        getLineValue()
    End Sub

    Private Sub txtCardNo_TextChanged(sender As Object, e As EventArgs) Handles txtCardNo.TextChanged
        Dim barCodeNo As String

        barCodeNo = txtCardNo.Text
        If barCodeNo.Length > 0 Then
            'If barCodeNo.Length = 13 Then


            Try




                Me.View_Pro_Article_BarCodeTableAdapter.Fill(Me.DSproduction.View_Pro_Article_BarCode, barCodeNo)
                Entry(barCodeNo)

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                'txtCardNo.Text = ""
            End Try
        End If

        'End If
    End Sub
    Private Sub Entry(ByVal Card As String)

        Dim EmpCardVerify As Integer


        EmpCardVerify = VerifyEmp(Card)

        If EmpCardVerify = 1 Then
            Attendence()
            'Attendence(Label4.Text, Label5.Text, Label9.Text, Label11.Text, Label8.Text, Now.Date)

        End If


        Try
            'TInterval = 600
            'ClearTimer.Enabled = True
        Catch ex As Exception
            'lblMsg.Text = ex.Message
        End Try

    End Sub
    Private Function VerifyEmp(ByVal CardForVerify As String) As Integer
        Dim EmpVerification As Integer
        Try
            EmpVerification = View_Pro_Article_BarCodeTableAdapter.Fill(Me.DSproduction.View_Pro_Article_BarCode, Val(CardForVerify))
            'EmpVerification = Me.View_All_EmployeesTableAdapter.FillBy1(Me.DSPayRoll.View_All_Employees, Val(CardForVerify))
        Catch ex As Exception
            'EmpVerification = Me.View_All_EmployeesTableAdapter.FillBy1(Me.DSPayRoll.View_All_Employees, Val(CardForVerify))
            EmpVerification = View_Pro_Article_BarCodeTableAdapter.Fill(Me.DSproduction.View_Pro_Article_BarCode, Val(CardForVerify))
        End Try


        Return EmpVerification
    End Function
    Private Sub Attendence()


        Try
            Insertion(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, True, 0, 0, 0, 1, Nothing, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
            reset()
            Button1.BackColor = Color.Green
            Entryflag = True
            txtCardNo.Text = ""
            'loadData()
        Catch ex As Exception

        End Try

    End Sub
    'Private Sub ClcikBtn(Button)
    '    Button.BackColor = Color.Red
    'End Sub
    'Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
    '    LineID = 3
    '    getLineValue(LineID)
    '    ClcikBtn(Button18)
    'End Sub

    'Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
    '    LineID = 4
    '    getLineValue(LineID)
    '    ClcikBtn(Button32)
    'End Sub

    'Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
    '    LineID = 5
    '    getLineValue(LineID)
    '    ClcikBtn(Button33)

    'End Sub

    'Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
    '    LineID = 6
    '    getLineValue(LineID)
    '    ClcikBtn(Button34)
    'End Sub

    'Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
    '    LineID = 7
    '    getLineValue(LineID)
    '    ClcikBtn(Button35)
    'End Sub

    'Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
    '    LineID = 8
    '    getLineValue(LineID)
    '    ClcikBtn(Button36)
    'End Sub

    'Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
    '    LineID = 9
    '    getLineValue(LineID)
    '    ClcikBtn(Button37)
    'End Sub

    'Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
    '    LineID = 10
    '    getLineValue(LineID)
    '    ClcikBtn(Button38)
    'End Sub

    'Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
    '    LineID = 11
    '    getLineValue(LineID)
    '    ClcikBtn(Button39)
    'End Sub
End Class
