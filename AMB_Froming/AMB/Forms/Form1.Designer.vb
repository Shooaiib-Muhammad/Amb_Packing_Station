<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ArtCodeLabel As System.Windows.Forms.Label
        Dim ArtSizeLabel As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim LineNameLabel As System.Windows.Forms.Label
        Dim Label69 As System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.clock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DSAMB = New AMB_Froming.DSAMB()
        Me.Tbl_Pro_ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_ArticleTableAdapter = New AMB_Froming.DSAMBTableAdapters.tbl_Pro_ArticleTableAdapter()
        Me.TableAdapterManager = New AMB_Froming.DSAMBTableAdapters.TableAdapterManager()
        Me.ArtCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pro_Article_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_Article_DTableAdapter = New AMB_Froming.DSAMBTableAdapters.tbl_Pro_Article_DTableAdapter()
        Me.ArtSizeComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.View_AMb_Article_Wise_SumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbl_PC_AMB_LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LineNameComboBox = New System.Windows.Forms.ComboBox()
        Me.coreDefects = New System.Windows.Forms.GroupBox()
        Me.printingBox = New System.Windows.Forms.GroupBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.cuttingGroup = New System.Windows.Forms.GroupBox()
        Me.View_AMb_FormingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.View_Pro_Article_BarCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSproduction = New AMB_Froming.DSproduction()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_Repair_QtyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Daily_SumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button19 = New System.Windows.Forms.Button()
        Me.View_AMb_FormingTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_AMb_FormingTableAdapter()
        Me.View_Daily_SumTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_Daily_SumTableAdapter()
        Me.ModelID = New System.Windows.Forms.Label()
        Me.ArtID = New System.Windows.Forms.Label()
        Me.ClientID = New System.Windows.Forms.Label()
        Me.View_AMb_Article_Wise_SumTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_AMb_Article_Wise_SumTableAdapter()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.View_Article_Wise_FailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PC_AMB_Hours_TranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PC_AMB_Hours_TranTableAdapter = New AMB_Froming.DSAMBTableAdapters.tbl_PC_AMB_Hours_TranTableAdapter()
        Me.Tbl_Inv_Tran_DateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inv_Tran_DateTableAdapter = New AMB_Froming.DSAMBTableAdapters.tbl_Inv_Tran_DateTableAdapter()
        Me.DayNoLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_PC_AMB_LineTableAdapter = New AMB_Froming.DSAMBTableAdapters.tbl_PC_AMB_LineTableAdapter()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.View_max_FromingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_max_FromingTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_max_FromingTableAdapter()
        Me.TranIDLabel1 = New System.Windows.Forms.Label()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.View_AMb_RepairBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_AMb_RepairPAssBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_AMB_Incentive_RFTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_AMB_Incentive_RFTTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_AMB_Incentive_RFTTableAdapter()
        Me.View_AMb_RepairTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_AMb_RepairTableAdapter()
        Me.View_AMb_RepairPAssTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_AMb_RepairPAssTableAdapter()
        Me.Froming_HourllyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Froming_HourllyTableAdapter = New AMB_Froming.DSAMBTableAdapters.Froming_HourllyTableAdapter()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.View_Repair_QtyTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_Repair_QtyTableAdapter()
        Me.View_Article_Wise_FailTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_Article_Wise_FailTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.View_Pro_Article_BarCodeTableAdapter = New AMB_Froming.DSproductionTableAdapters.View_Pro_Article_BarCodeTableAdapter()
        Me.TableAdapterManager1 = New AMB_Froming.DSproductionTableAdapters.TableAdapterManager()
        Me.Button40 = New System.Windows.Forms.Button()
        ArtCodeLabel = New System.Windows.Forms.Label()
        ArtSizeLabel = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        LineNameLabel = New System.Windows.Forms.Label()
        Label69 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.DSAMB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_Article_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.View_AMb_Article_Wise_SumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PC_AMB_LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.printingBox.SuspendLayout()
        CType(Me.View_AMb_FormingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSproduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Repair_QtyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Daily_SumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.View_Article_Wise_FailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PC_AMB_Hours_TranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_max_FromingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AMb_RepairBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AMb_RepairPAssBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AMB_Incentive_RFTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Froming_HourllyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArtCodeLabel
        '
        ArtCodeLabel.AutoSize = True
        ArtCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArtCodeLabel.Location = New System.Drawing.Point(19, 26)
        ArtCodeLabel.Name = "ArtCodeLabel"
        ArtCodeLabel.Size = New System.Drawing.Size(112, 20)
        ArtCodeLabel.TabIndex = 85
        ArtCodeLabel.Text = "Article Code:"
        '
        'ArtSizeLabel
        '
        ArtSizeLabel.AutoSize = True
        ArtSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArtSizeLabel.Location = New System.Drawing.Point(259, 26)
        ArtSizeLabel.Name = "ArtSizeLabel"
        ArtSizeLabel.Size = New System.Drawing.Size(49, 20)
        ArtSizeLabel.TabIndex = 86
        ArtSizeLabel.Text = "Size:"
        '
        'Label34
        '
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(11, 110)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(113, 20)
        Label34.TabIndex = 55556
        Label34.Text = "Model Name:"
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(11, 51)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(113, 20)
        Label3.TabIndex = 55563
        Label3.Text = "Client Name:"
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(11, 80)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(116, 20)
        Label6.TabIndex = 55565
        Label6.Text = "Factory Code:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(439, 22)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(89, 20)
        Label8.TabIndex = 91
        Label8.Text = "Strength :"
        '
        'LineNameLabel
        '
        LineNameLabel.AutoSize = True
        LineNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        LineNameLabel.Location = New System.Drawing.Point(1605, 367)
        LineNameLabel.Name = "LineNameLabel"
        LineNameLabel.Size = New System.Drawing.Size(53, 20)
        LineNameLabel.TabIndex = 55571
        LineNameLabel.Text = "Line :"
        LineNameLabel.Visible = False
        '
        'Label69
        '
        Label69.AutoSize = True
        Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Label69.Location = New System.Drawing.Point(3, 785)
        Label69.Name = "Label69"
        Label69.Size = New System.Drawing.Size(156, 31)
        Label69.TabIndex = 55604
        Label69.Text = "System IP:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1819, 40)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Airless Mini Ball Packing"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.clock)
        Me.Panel3.Location = New System.Drawing.Point(1105, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(626, 45)
        Me.Panel3.TabIndex = 84
        '
        'clock
        '
        Me.clock.BackColor = System.Drawing.Color.SkyBlue
        Me.clock.Dock = System.Windows.Forms.DockStyle.Top
        Me.clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clock.ForeColor = System.Drawing.Color.White
        Me.clock.Location = New System.Drawing.Point(0, 0)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(626, 42)
        Me.clock.TabIndex = 19
        Me.clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'DSAMB
        '
        Me.DSAMB.DataSetName = "DSAMB"
        Me.DSAMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Pro_ArticleBindingSource
        '
        Me.Tbl_Pro_ArticleBindingSource.DataMember = "tbl_Pro_Article"
        Me.Tbl_Pro_ArticleBindingSource.DataSource = Me.DSAMB
        '
        'Tbl_Pro_ArticleTableAdapter
        '
        Me.Tbl_Pro_ArticleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PC_AMB_Hours_TranTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PC_AMB_Line1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_PC_AMB_LineTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Pro_Amb_ArticleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AMB_Froming.DSAMBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ArtCodeComboBox
        '
        Me.ArtCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArtCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArtCodeComboBox.DataSource = Me.Tbl_Pro_ArticleBindingSource
        Me.ArtCodeComboBox.DisplayMember = "ArtCode"
        Me.ArtCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtCodeComboBox.FormattingEnabled = True
        Me.ArtCodeComboBox.Location = New System.Drawing.Point(132, 18)
        Me.ArtCodeComboBox.Name = "ArtCodeComboBox"
        Me.ArtCodeComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ArtCodeComboBox.TabIndex = 86
        Me.ArtCodeComboBox.ValueMember = "ArtID"
        '
        'Tbl_Pro_Article_DBindingSource
        '
        Me.Tbl_Pro_Article_DBindingSource.DataMember = "tbl_Pro_Article_tbl_Pro_Article_D"
        Me.Tbl_Pro_Article_DBindingSource.DataSource = Me.Tbl_Pro_ArticleBindingSource
        '
        'Tbl_Pro_Article_DTableAdapter
        '
        Me.Tbl_Pro_Article_DTableAdapter.ClearBeforeFill = True
        '
        'ArtSizeComboBox
        '
        Me.ArtSizeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArtSizeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArtSizeComboBox.DataSource = Me.Tbl_Pro_Article_DBindingSource
        Me.ArtSizeComboBox.DisplayMember = "ArtSize"
        Me.ArtSizeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtSizeComboBox.FormattingEnabled = True
        Me.ArtSizeComboBox.Location = New System.Drawing.Point(314, 18)
        Me.ArtSizeComboBox.Name = "ArtSizeComboBox"
        Me.ArtSizeComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ArtSizeComboBox.TabIndex = 87
        Me.ArtSizeComboBox.ValueMember = "ArtSize"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label32)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Controls.Add(Me.Label65)
        Me.Panel1.Controls.Add(Me.Button28)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Button15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Button23)
        Me.Panel1.Controls.Add(Me.Label58)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Button17)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label89)
        Me.Panel1.Controls.Add(Me.Label66)
        Me.Panel1.Controls.Add(Me.Button29)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button20)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label49)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ArtCodeComboBox)
        Me.Panel1.Controls.Add(Me.Label60)
        Me.Panel1.Controls.Add(ArtSizeLabel)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(ArtCodeLabel)
        Me.Panel1.Controls.Add(Me.Button25)
        Me.Panel1.Controls.Add(Me.ArtSizeComboBox)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button13)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(6, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1091, 864)
        Me.Panel1.TabIndex = 88
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label84)
        Me.Panel9.Controls.Add(Me.txtCardNo)
        Me.Panel9.Location = New System.Drawing.Point(19, 86)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(416, 73)
        Me.Panel9.TabIndex = 55594
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.DarkCyan
        Me.Label84.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.SystemColors.Control
        Me.Label84.Location = New System.Drawing.Point(0, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(414, 20)
        Me.Label84.TabIndex = 2
        Me.Label84.Text = "Barcode Terminal"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCardNo
        '
        Me.txtCardNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo.Location = New System.Drawing.Point(10, 37)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCardNo.Size = New System.Drawing.Size(389, 23)
        Me.txtCardNo.TabIndex = 0
        Me.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.SkyBlue
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(268, 452)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(102, 26)
        Me.Label33.TabIndex = 55593
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.SkyBlue
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(22, 452)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(240, 26)
        Me.Label36.TabIndex = 55592
        Me.Label36.Text = "Total:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.SkyBlue
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(978, 618)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(102, 26)
        Me.Label30.TabIndex = 55591
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.SkyBlue
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(740, 617)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(235, 26)
        Me.Label32.TabIndex = 55590
        Me.Label32.Text = "Total"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.SkyBlue
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(635, 450)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(102, 26)
        Me.Label29.TabIndex = 55589
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.SkyBlue
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(389, 450)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(240, 26)
        Me.Label28.TabIndex = 55588
        Me.Label28.Text = "Total:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Maroon
        Me.Label65.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "missingglue", True))
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.White
        Me.Label65.Location = New System.Drawing.Point(980, 492)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(96, 33)
        Me.Label65.TabIndex = 107
        Me.Label65.Text = "Label65"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_AMb_Article_Wise_SumBindingSource
        '
        Me.View_AMb_Article_Wise_SumBindingSource.DataMember = "View_AMb_Article Wise_Sum"
        Me.View_AMb_Article_Wise_SumBindingSource.DataSource = Me.DSAMB
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.White
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Location = New System.Drawing.Point(743, 492)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(231, 33)
        Me.Button28.TabIndex = 106
        Me.Button28.Text = "MISSING GLUE"
        Me.Button28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Maroon
        Me.Label22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "seamoverlapping", True))
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(980, 366)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 33)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(743, 366)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(231, 33)
        Me.Button15.TabIndex = 114
        Me.Button15.Text = "SEAM OVERLAPPING"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Maroon
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "excussglue", True))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(980, 450)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 33)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Label17"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.White
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(743, 576)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(231, 33)
        Me.Button23.TabIndex = 55583
        Me.Button23.Text = "AIR BUBBLE"
        Me.Button23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Maroon
        Me.Label58.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "airbubble", True))
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.White
        Me.Label58.Location = New System.Drawing.Point(979, 576)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 33)
        Me.Label58.TabIndex = 55584
        Me.Label58.Text = "Label58"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Maroon
        Me.Label24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "pressoremark", True))
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(980, 534)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 33)
        Me.Label24.TabIndex = 123
        Me.Label24.Text = "Label24"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.White
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(743, 534)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(231, 33)
        Me.Button17.TabIndex = 122
        Me.Button17.Text = "PRESSURE MARKS"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(743, 450)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(231, 33)
        Me.Button10.TabIndex = 104
        Me.Button10.Text = "EXCESS GLUE"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Maroon
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "Wrinkle", True))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(980, 408)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 33)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(743, 408)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(231, 33)
        Me.Button11.TabIndex = 102
        Me.Button11.Text = "WRINKLES"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.SkyBlue
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(743, 202)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(336, 27)
        Me.Label27.TabIndex = 55587
        Me.Label27.Text = "WORKMANSHIP DEFECTS"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.SkyBlue
        Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(386, 201)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(351, 27)
        Me.Label26.TabIndex = 55586
        Me.Label26.Text = "PRINTING DEFECTS"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(19, 289)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(351, 27)
        Me.Label25.TabIndex = 55585
        Me.Label25.Text = "CUTTING DEFECTS"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SkyBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(19, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(351, 27)
        Me.Label15.TabIndex = 55584
        Me.Label15.Text = "CORE DEFECTS"
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.Color.White
        Me.Label89.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label89.Location = New System.Drawing.Point(858, 812)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(160, 30)
        Me.Label89.TabIndex = 55583
        Me.Label89.Text = "Label89"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label89.Visible = False
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Maroon
        Me.Label66.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "NewTouching", True))
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.White
        Me.Label66.Location = New System.Drawing.Point(641, 282)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(96, 33)
        Me.Label66.TabIndex = 55582
        Me.Label66.Text = "Label66"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.White
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Location = New System.Drawing.Point(389, 282)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(240, 33)
        Me.Button29.TabIndex = 55581
        Me.Button29.Text = "TOUCHING"
        Me.Button29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(389, 324)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(240, 33)
        Me.Button6.TabIndex = 100
        Me.Button6.Text = "PRINT MISSALIGNMENT"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Maroon
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "printmissallignament", True))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(641, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 33)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Label13"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PC_AMB_LineBindingSource, "TotalStrength", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(537, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 90
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_PC_AMB_LineBindingSource
        '
        Me.Tbl_PC_AMB_LineBindingSource.DataMember = "tbl_PC_AMB_Line"
        Me.Tbl_PC_AMB_LineBindingSource.DataSource = Me.DSAMB
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.White
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(743, 240)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(231, 33)
        Me.Button20.TabIndex = 55573
        Me.Button20.Text = "WRONG ART WORK"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "Pass", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(19, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(416, 23)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Maroon
        Me.Label49.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "wrongartwork", True))
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(980, 240)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(96, 33)
        Me.Label49.TabIndex = 55574
        Me.Label49.Text = "Label49"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(563, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 99)
        Me.Button1.TabIndex = 88
        Me.Button1.Text = "PASS"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "unevenBallSurface", True))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(274, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 33)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Maroon
        Me.Label60.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "newopenSeam", True))
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.White
        Me.Label60.Location = New System.Drawing.Point(980, 324)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(96, 33)
        Me.Label60.TabIndex = 55580
        Me.Label60.Text = "Label60"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(19, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 33)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "UNEVEN BALL SURFACE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.White
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(743, 324)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(231, 33)
        Me.Button25.TabIndex = 55579
        Me.Button25.Text = "OPEN SEAM"
        Me.Button25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "unshapecut", True))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(274, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 33)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(19, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 33)
        Me.Button3.TabIndex = 94
        Me.Button3.Text = "UN SHARPED CUT"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Maroon
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "heavyprintdefects", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(641, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 33)
        Me.Label20.TabIndex = 119
        Me.Label20.Text = "Label20"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Maroon
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "materialdefects", True))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(980, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 33)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Label14"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(743, 282)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(231, 33)
        Me.Button7.TabIndex = 110
        Me.Button7.Text = "MATERIAL DAMAGE"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(389, 240)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(240, 33)
        Me.Button13.TabIndex = 118
        Me.Button13.Text = "HEAVY PRINT DEFECTS"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Maroon
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "cuttingpanel", True))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(274, 409)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 33)
        Me.Label16.TabIndex = 107
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Maroon
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "zigzagedge", True))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(274, 365)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 33)
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "Label23"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(19, 409)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(240, 33)
        Me.Button9.TabIndex = 106
        Me.Button9.Text = "CUTTING PANEL"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(19, 365)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(240, 33)
        Me.Button16.TabIndex = 112
        Me.Button16.Text = "ZIG ZAG EDGE CUT"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Maroon
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "colourShape", True))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(641, 408)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 33)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(389, 366)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(240, 33)
        Me.Button5.TabIndex = 98
        Me.Button5.Text = "ANY MIS PRINT"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(389, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 33)
        Me.Button4.TabIndex = 96
        Me.Button4.Text = "COLOUR SHADE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "anymisprint", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(641, 366)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 33)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Label12"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LineNameComboBox
        '
        Me.LineNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LineNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LineNameComboBox.DataSource = Me.Tbl_PC_AMB_LineBindingSource
        Me.LineNameComboBox.DisplayMember = "LineName"
        Me.LineNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LineNameComboBox.FormattingEnabled = True
        Me.LineNameComboBox.Location = New System.Drawing.Point(1672, 359)
        Me.LineNameComboBox.Name = "LineNameComboBox"
        Me.LineNameComboBox.Size = New System.Drawing.Size(121, 28)
        Me.LineNameComboBox.TabIndex = 55572
        Me.LineNameComboBox.ValueMember = "LineID"
        Me.LineNameComboBox.Visible = False
        '
        'coreDefects
        '
        Me.coreDefects.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coreDefects.ForeColor = System.Drawing.Color.BlueViolet
        Me.coreDefects.Location = New System.Drawing.Point(1220, 841)
        Me.coreDefects.Name = "coreDefects"
        Me.coreDefects.Size = New System.Drawing.Size(123, 65)
        Me.coreDefects.TabIndex = 55592
        Me.coreDefects.TabStop = False
        Me.coreDefects.Text = "CORE DEFECTS"
        Me.coreDefects.Visible = False
        '
        'printingBox
        '
        Me.printingBox.Controls.Add(Me.Label90)
        Me.printingBox.Controls.Add(Me.Label68)
        Me.printingBox.Controls.Add(Me.Button31)
        Me.printingBox.Controls.Add(Me.Label67)
        Me.printingBox.Controls.Add(Me.Button30)
        Me.printingBox.Controls.Add(Me.Button22)
        Me.printingBox.Controls.Add(Me.Label59)
        Me.printingBox.Controls.Add(Me.Label57)
        Me.printingBox.Controls.Add(Me.Label21)
        Me.printingBox.Controls.Add(Me.Label19)
        Me.printingBox.Controls.Add(Me.Button14)
        Me.printingBox.Controls.Add(Me.Button27)
        Me.printingBox.Controls.Add(Me.Button12)
        Me.printingBox.Controls.Add(Me.Button24)
        Me.printingBox.Controls.Add(Me.Label61)
        Me.printingBox.Controls.Add(Me.Label62)
        Me.printingBox.Controls.Add(Me.Button26)
        Me.printingBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printingBox.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.printingBox.Location = New System.Drawing.Point(1474, 643)
        Me.printingBox.Name = "printingBox"
        Me.printingBox.Size = New System.Drawing.Size(209, 180)
        Me.printingBox.TabIndex = 55591
        Me.printingBox.TabStop = False
        Me.printingBox.Text = "PRINTING DEFECTS"
        Me.printingBox.Visible = False
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.White
        Me.Label90.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label90.Location = New System.Drawing.Point(237, 601)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(160, 30)
        Me.Label90.TabIndex = 55584
        Me.Label90.Text = "Label90"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Maroon
        Me.Label68.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "BlurPrinting", True))
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.White
        Me.Label68.Location = New System.Drawing.Point(7, 568)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(125, 23)
        Me.Label68.TabIndex = 55590
        Me.Label68.Text = "Label68"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.White
        Me.Button31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Location = New System.Drawing.Point(7, 455)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(125, 110)
        Me.Button31.TabIndex = 55589
        Me.Button31.Text = "Blur Printing"
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Maroon
        Me.Label67.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "SeamClosingGlue", True))
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.White
        Me.Label67.Location = New System.Drawing.Point(137, 427)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(125, 23)
        Me.Label67.TabIndex = 55588
        Me.Label67.Text = "Label67"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.White
        Me.Button30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Location = New System.Drawing.Point(137, 314)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(125, 110)
        Me.Button30.TabIndex = 55587
        Me.Button30.Text = "Covering Defects"
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.White
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(268, 27)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(125, 110)
        Me.Button22.TabIndex = 55585
        Me.Button22.Text = "Lacqure Spots"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Maroon
        Me.Label59.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "LogoDoubling", True))
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.White
        Me.Label59.Location = New System.Drawing.Point(269, 285)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(125, 23)
        Me.Label59.TabIndex = 55582
        Me.Label59.Text = "Label59"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Maroon
        Me.Label57.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "LargerSpots", True))
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(268, 140)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(121, 23)
        Me.Label57.TabIndex = 55586
        Me.Label57.Text = "Label57"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Maroon
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "PUC", True))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(268, 427)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(125, 23)
        Me.Label21.TabIndex = 117
        Me.Label21.Text = "Label21"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Maroon
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "OtherPrintingIssue", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(6, 427)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 23)
        Me.Label19.TabIndex = 121
        Me.Label19.Text = "Label19"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(268, 314)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(125, 110)
        Me.Button14.TabIndex = 116
        Me.Button14.Text = "Color Marks"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.White
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Location = New System.Drawing.Point(6, 172)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(125, 110)
        Me.Button27.TabIndex = 55575
        Me.Button27.Text = "Smearing"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(6, 314)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(125, 110)
        Me.Button12.TabIndex = 120
        Me.Button12.Text = "Miss Printing"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.White
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(268, 172)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(125, 110)
        Me.Button24.TabIndex = 55581
        Me.Button24.Text = "Logo Doubling"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Maroon
        Me.Label61.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "DisColor", True))
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.White
        Me.Label61.Location = New System.Drawing.Point(138, 285)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(125, 23)
        Me.Label61.TabIndex = 55578
        Me.Label61.Text = "Label61"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Maroon
        Me.Label62.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "Smearing", True))
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.White
        Me.Label62.Location = New System.Drawing.Point(7, 285)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(125, 23)
        Me.Label62.TabIndex = 55576
        Me.Label62.Text = "Label62"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.White
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.Location = New System.Drawing.Point(137, 172)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(125, 110)
        Me.Button26.TabIndex = 55577
        Me.Button26.Text = "Dis Color"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'cuttingGroup
        '
        Me.cuttingGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuttingGroup.ForeColor = System.Drawing.Color.DarkGreen
        Me.cuttingGroup.Location = New System.Drawing.Point(1562, 527)
        Me.cuttingGroup.Name = "cuttingGroup"
        Me.cuttingGroup.Size = New System.Drawing.Size(117, 65)
        Me.cuttingGroup.TabIndex = 55590
        Me.cuttingGroup.TabStop = False
        Me.cuttingGroup.Text = "HF-CUTTING"
        Me.cuttingGroup.Visible = False
        '
        'View_AMb_FormingBindingSource
        '
        Me.View_AMb_FormingBindingSource.DataMember = "View_AMb_Forming"
        Me.View_AMb_FormingBindingSource.DataSource = Me.DSAMB
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "Target", True))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(1488, 260)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 20)
        Me.Label31.TabIndex = 55560
        Me.Label31.Text = "Label1"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ModelName", True))
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(127, 110)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(243, 20)
        Me.Label35.TabIndex = 55561
        Me.Label35.Text = "Label1"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Label34)
        Me.Panel2.Location = New System.Drawing.Point(1106, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(501, 149)
        Me.Panel2.TabIndex = 55562
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.EmpPicPictureBox)
        Me.Panel10.Location = New System.Drawing.Point(380, 35)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(111, 109)
        Me.Panel10.TabIndex = 55567
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_Pro_Article_BarCodeBindingSource, "ArtImage", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(2, 3)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(106, 101)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 46
        Me.EmpPicPictureBox.TabStop = False
        '
        'View_Pro_Article_BarCodeBindingSource
        '
        Me.View_Pro_Article_BarCodeBindingSource.DataMember = "View_Pro_Article_BarCode"
        Me.View_Pro_Article_BarCodeBindingSource.DataSource = Me.DSproduction
        '
        'DSproduction
        '
        Me.DSproduction.DataSetName = "DSproduction"
        Me.DSproduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "FactoryCode", True))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 20)
        Me.Label4.TabIndex = 55566
        Me.Label4.Text = "Label1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ClientName", True))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 20)
        Me.Label2.TabIndex = 55564
        Me.Label2.Text = "Label1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SkyBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(499, 34)
        Me.Label1.TabIndex = 55562
        Me.Label1.Text = "Article Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Repair_QtyBindingSource
        '
        Me.View_Repair_QtyBindingSource.DataMember = "View_Repair_Qty"
        Me.View_Repair_QtyBindingSource.DataSource = Me.DSAMB
        '
        'View_Daily_SumBindingSource
        '
        Me.View_Daily_SumBindingSource.DataMember = "View_Daily_Sum"
        Me.View_Daily_SumBindingSource.DataSource = Me.DSAMB
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Red
        Me.Button19.Enabled = False
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button19.ForeColor = System.Drawing.Color.Black
        Me.Button19.Location = New System.Drawing.Point(1106, 653)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(187, 59)
        Me.Button19.TabIndex = 55566
        Me.Button19.Text = "Undo"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'View_AMb_FormingTableAdapter
        '
        Me.View_AMb_FormingTableAdapter.ClearBeforeFill = True
        '
        'View_Daily_SumTableAdapter
        '
        Me.View_Daily_SumTableAdapter.ClearBeforeFill = True
        '
        'ModelID
        '
        Me.ModelID.BackColor = System.Drawing.Color.White
        Me.ModelID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ModelID", True))
        Me.ModelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelID.ForeColor = System.Drawing.Color.White
        Me.ModelID.Location = New System.Drawing.Point(1681, 245)
        Me.ModelID.Name = "ModelID"
        Me.ModelID.Size = New System.Drawing.Size(93, 20)
        Me.ModelID.TabIndex = 55567
        Me.ModelID.Text = "Label1"
        Me.ModelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArtID
        '
        Me.ArtID.BackColor = System.Drawing.Color.White
        Me.ArtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ArtID", True))
        Me.ArtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtID.ForeColor = System.Drawing.Color.White
        Me.ArtID.Location = New System.Drawing.Point(1505, 521)
        Me.ArtID.Name = "ArtID"
        Me.ArtID.Size = New System.Drawing.Size(93, 20)
        Me.ArtID.TabIndex = 55568
        Me.ArtID.Text = "Label1"
        Me.ArtID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientID
        '
        Me.ClientID.BackColor = System.Drawing.Color.White
        Me.ClientID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ClientID", True))
        Me.ClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientID.ForeColor = System.Drawing.Color.White
        Me.ClientID.Location = New System.Drawing.Point(1160, 717)
        Me.ClientID.Name = "ClientID"
        Me.ClientID.Size = New System.Drawing.Size(93, 20)
        Me.ClientID.TabIndex = 55569
        Me.ClientID.Text = "Label1"
        Me.ClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_AMb_Article_Wise_SumTableAdapter
        '
        Me.View_AMb_Article_Wise_SumTableAdapter.ClearBeforeFill = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label75)
        Me.Panel6.Controls.Add(Me.Label86)
        Me.Panel6.Controls.Add(Me.Label55)
        Me.Panel6.Controls.Add(Me.Label56)
        Me.Panel6.Controls.Add(Me.Label42)
        Me.Panel6.Controls.Add(Me.Label43)
        Me.Panel6.Controls.Add(Me.Label44)
        Me.Panel6.Controls.Add(Me.Label45)
        Me.Panel6.Controls.Add(Me.Label46)
        Me.Panel6.Controls.Add(Me.Label48)
        Me.Panel6.Location = New System.Drawing.Point(1106, 324)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(376, 155)
        Me.Panel6.TabIndex = 55564
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.SkyBlue
        Me.Label75.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ArtCode", True))
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label75.ForeColor = System.Drawing.Color.Black
        Me.Label75.Location = New System.Drawing.Point(29, 9)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(73, 20)
        Me.Label75.TabIndex = 55601
        Me.Label75.Text = "Label75"
        '
        'Label86
        '
        Me.Label86.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label86.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "TotalChecked", True))
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label86.Location = New System.Drawing.Point(142, 39)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(93, 23)
        Me.Label86.TabIndex = 55598
        Me.Label86.Text = "Label86"
        Me.Label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.White
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "Fail", True))
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label55.Location = New System.Drawing.Point(143, 118)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(93, 23)
        Me.Label55.TabIndex = 55567
        Me.Label55.Text = "Label55"
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label56
        '
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(7, 117)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(131, 25)
        Me.Label56.TabIndex = 55566
        Me.Label56.Text = "RFT:"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.SkyBlue
        Me.Label42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label42.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(0, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(374, 34)
        Me.Label42.TabIndex = 55563
        Me.Label42.Text = " Quality Statistics"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "Fail", True))
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label43.Location = New System.Drawing.Point(143, 91)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(93, 23)
        Me.Label43.TabIndex = 5
        Me.Label43.Text = "Label43"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(7, 91)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(131, 25)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Fail :"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_Article_Wise_SumBindingSource, "Pass", True))
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label45.Location = New System.Drawing.Point(143, 65)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(93, 23)
        Me.Label45.TabIndex = 3
        Me.Label45.Text = "Label45"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(7, 65)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(131, 25)
        Me.Label46.TabIndex = 2
        Me.Label46.Text = "Pass :"
        '
        'Label48
        '
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(7, 39)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(131, 25)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "Check :"
        '
        'View_Article_Wise_FailBindingSource
        '
        Me.View_Article_Wise_FailBindingSource.DataMember = "View_Article_Wise_Fail"
        Me.View_Article_Wise_FailBindingSource.DataSource = Me.DSAMB
        '
        'Tbl_PC_AMB_Hours_TranBindingSource
        '
        Me.Tbl_PC_AMB_Hours_TranBindingSource.DataMember = "tbl_PC_AMB_Hours_Tran"
        Me.Tbl_PC_AMB_Hours_TranBindingSource.DataSource = Me.DSAMB
        '
        'Tbl_PC_AMB_Hours_TranTableAdapter
        '
        Me.Tbl_PC_AMB_Hours_TranTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inv_Tran_DateBindingSource
        '
        Me.Tbl_Inv_Tran_DateBindingSource.DataMember = "tbl_Inv_Tran_Date"
        Me.Tbl_Inv_Tran_DateBindingSource.DataSource = Me.DSAMB
        '
        'Tbl_Inv_Tran_DateTableAdapter
        '
        Me.Tbl_Inv_Tran_DateTableAdapter.ClearBeforeFill = True
        '
        'DayNoLabel1
        '
        Me.DayNoLabel1.BackColor = System.Drawing.Color.White
        Me.DayNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DayNo", True))
        Me.DayNoLabel1.ForeColor = System.Drawing.Color.White
        Me.DayNoLabel1.Location = New System.Drawing.Point(1580, 551)
        Me.DayNoLabel1.Name = "DayNoLabel1"
        Me.DayNoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DayNoLabel1.TabIndex = 55571
        Me.DayNoLabel1.Text = "Label49"
        '
        'Tbl_PC_AMB_LineTableAdapter
        '
        Me.Tbl_PC_AMB_LineTableAdapter.ClearBeforeFill = True
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "SAMForming", True))
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(1513, 453)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(93, 20)
        Me.Label50.TabIndex = 55573
        Me.Label50.Text = "Label1"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        '
        'View_max_FromingBindingSource
        '
        Me.View_max_FromingBindingSource.DataMember = "View_max_Froming"
        Me.View_max_FromingBindingSource.DataSource = Me.DSAMB
        '
        'View_max_FromingTableAdapter
        '
        Me.View_max_FromingTableAdapter.ClearBeforeFill = True
        '
        'TranIDLabel1
        '
        Me.TranIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_max_FromingBindingSource, "TranID", True))
        Me.TranIDLabel1.ForeColor = System.Drawing.Color.White
        Me.TranIDLabel1.Location = New System.Drawing.Point(1456, 585)
        Me.TranIDLabel1.Name = "TranIDLabel1"
        Me.TranIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TranIDLabel1.TabIndex = 55575
        Me.TranIDLabel1.Text = "Label57"
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.ForeColor = System.Drawing.Color.White
        Me.Button21.Location = New System.Drawing.Point(1299, 653)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(183, 59)
        Me.Button21.TabIndex = 55576
        Me.Button21.Text = "Exit"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label63.ForeColor = System.Drawing.Color.Red
        Me.Label63.Location = New System.Drawing.Point(837, 989)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(216, 23)
        Me.Label63.TabIndex = 55577
        Me.Label63.Text = "Label63"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(659, 992)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(172, 20)
        Me.Label64.TabIndex = 55568
        Me.Label64.Text = "System Ip Address :"
        '
        'View_AMb_RepairBindingSource
        '
        Me.View_AMb_RepairBindingSource.DataMember = "View_AMb_Repair"
        Me.View_AMb_RepairBindingSource.DataSource = Me.DSAMB
        '
        'View_AMb_RepairPAssBindingSource
        '
        Me.View_AMb_RepairPAssBindingSource.DataMember = "View_AMb_RepairPAss"
        Me.View_AMb_RepairPAssBindingSource.DataSource = Me.DSAMB
        '
        'View_AMB_Incentive_RFTBindingSource
        '
        Me.View_AMB_Incentive_RFTBindingSource.DataMember = "View_AMB_Incentive_RFT"
        Me.View_AMB_Incentive_RFTBindingSource.DataSource = Me.DSAMB
        '
        'View_AMB_Incentive_RFTTableAdapter
        '
        Me.View_AMB_Incentive_RFTTableAdapter.ClearBeforeFill = True
        '
        'View_AMb_RepairTableAdapter
        '
        Me.View_AMb_RepairTableAdapter.ClearBeforeFill = True
        '
        'View_AMb_RepairPAssTableAdapter
        '
        Me.View_AMb_RepairPAssTableAdapter.ClearBeforeFill = True
        '
        'Froming_HourllyBindingSource
        '
        Me.Froming_HourllyBindingSource.DataMember = "Froming_Hourlly"
        Me.Froming_HourllyBindingSource.DataSource = Me.DSAMB
        '
        'Froming_HourllyTableAdapter
        '
        Me.Froming_HourllyTableAdapter.ClearBeforeFill = True
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Inv_Tran_DateBindingSource, "DateName", True))
        Me.Label87.ForeColor = System.Drawing.Color.White
        Me.Label87.Location = New System.Drawing.Point(1634, 440)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(45, 13)
        Me.Label87.TabIndex = 55599
        Me.Label87.Text = "Label87"
        '
        'View_Repair_QtyTableAdapter
        '
        Me.View_Repair_QtyTableAdapter.ClearBeforeFill = True
        '
        'View_Article_Wise_FailTableAdapter
        '
        Me.View_Article_Wise_FailTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(1490, 321)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(241, 72)
        Me.Button8.TabIndex = 55600
        Me.Button8.Text = "View Reports"
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(Me.Label39)
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.Label47)
        Me.Panel4.Controls.Add(Me.Label51)
        Me.Panel4.Controls.Add(Me.Label52)
        Me.Panel4.Controls.Add(Me.Label53)
        Me.Panel4.Controls.Add(Me.Label54)
        Me.Panel4.Location = New System.Drawing.Point(1106, 484)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(376, 155)
        Me.Panel4.TabIndex = 55602
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "TotalChecked", True))
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(142, 39)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 23)
        Me.Label38.TabIndex = 55598
        Me.Label38.Text = "Label38"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.White
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "Fail", True))
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(143, 118)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(93, 23)
        Me.Label39.TabIndex = 55567
        Me.Label39.Text = "Label39"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(7, 117)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(131, 25)
        Me.Label40.TabIndex = 55566
        Me.Label40.Text = "RFT:"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.SkyBlue
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label41.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(0, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(374, 34)
        Me.Label41.TabIndex = 55563
        Me.Label41.Text = "Today Output"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.White
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "Fail", True))
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label47.Location = New System.Drawing.Point(143, 91)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(93, 23)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Label47"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(7, 91)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(131, 25)
        Me.Label51.TabIndex = 4
        Me.Label51.Text = "Fail :"
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.White
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label52.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "Pass", True))
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label52.Location = New System.Drawing.Point(143, 65)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(93, 23)
        Me.Label52.TabIndex = 3
        Me.Label52.Text = "Label52"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(7, 65)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(131, 25)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Pass :"
        '
        'Label54
        '
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(7, 39)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(131, 25)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Check :"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RadioButton9)
        Me.Panel5.Controls.Add(Me.RadioButton1)
        Me.Panel5.Controls.Add(Me.RadioButton2)
        Me.Panel5.Controls.Add(Me.RadioButton3)
        Me.Panel5.Controls.Add(Me.RadioButton4)
        Me.Panel5.Controls.Add(Me.RadioButton5)
        Me.Panel5.Controls.Add(Me.RadioButton6)
        Me.Panel5.Controls.Add(Me.RadioButton7)
        Me.Panel5.Controls.Add(Me.RadioButton8)
        Me.Panel5.Location = New System.Drawing.Point(12, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1719, 69)
        Me.Panel5.TabIndex = 55603
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(1494, 10)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton9.TabIndex = 8
        Me.RadioButton9.Text = "Line 9"
        Me.RadioButton9.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(30, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Line 1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(213, 10)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Line 2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(396, 10)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Line 3"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(579, 10)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Line 4"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(762, 10)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Line 5"
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(945, 10)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Line 6"
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(1128, 10)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Line 7"
        Me.RadioButton7.UseVisualStyleBackColor = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RadioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(1311, 10)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(146, 50)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.Text = "Line 8"
        Me.RadioButton8.UseVisualStyleBackColor = False
        '
        'Button39
        '
        Me.Button39.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button39.Location = New System.Drawing.Point(1689, 611)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(85, 48)
        Me.Button39.TabIndex = 17
        Me.Button39.Text = "Line 9"
        Me.Button39.UseVisualStyleBackColor = True
        Me.Button39.Visible = False
        '
        'Button38
        '
        Me.Button38.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button38.Location = New System.Drawing.Point(1689, 611)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(85, 48)
        Me.Button38.TabIndex = 16
        Me.Button38.Text = "Line 8"
        Me.Button38.UseVisualStyleBackColor = True
        Me.Button38.Visible = False
        '
        'Button37
        '
        Me.Button37.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button37.Location = New System.Drawing.Point(1689, 611)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(85, 48)
        Me.Button37.TabIndex = 15
        Me.Button37.Text = "Line 7"
        Me.Button37.UseVisualStyleBackColor = True
        Me.Button37.Visible = False
        '
        'Button36
        '
        Me.Button36.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.Location = New System.Drawing.Point(1689, 611)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(85, 48)
        Me.Button36.TabIndex = 14
        Me.Button36.Text = "Line 6"
        Me.Button36.UseVisualStyleBackColor = True
        Me.Button36.Visible = False
        '
        'Button35
        '
        Me.Button35.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.Location = New System.Drawing.Point(1689, 611)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(85, 48)
        Me.Button35.TabIndex = 13
        Me.Button35.Text = "Line 5"
        Me.Button35.UseVisualStyleBackColor = True
        Me.Button35.Visible = False
        '
        'Button34
        '
        Me.Button34.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.Location = New System.Drawing.Point(1689, 611)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(85, 48)
        Me.Button34.TabIndex = 12
        Me.Button34.Text = "Line 4"
        Me.Button34.UseVisualStyleBackColor = True
        Me.Button34.Visible = False
        '
        'Button33
        '
        Me.Button33.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.Location = New System.Drawing.Point(1689, 611)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(85, 48)
        Me.Button33.TabIndex = 11
        Me.Button33.Text = "Line 3"
        Me.Button33.UseVisualStyleBackColor = True
        Me.Button33.Visible = False
        '
        'Button32
        '
        Me.Button32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(1689, 611)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(85, 48)
        Me.Button32.TabIndex = 10
        Me.Button32.Text = "Line 2"
        Me.Button32.UseVisualStyleBackColor = True
        Me.Button32.Visible = False
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(1689, 611)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(85, 48)
        Me.Button18.TabIndex = 9
        Me.Button18.Text = "Line 1"
        Me.Button18.UseVisualStyleBackColor = True
        Me.Button18.Visible = False
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(162, 785)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(446, 38)
        Me.Label37.TabIndex = 55604
        Me.Label37.Text = "Label37"
        '
        'View_Pro_Article_BarCodeTableAdapter
        '
        Me.View_Pro_Article_BarCodeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Pro_Article_BarCode_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AMB_Froming.DSproductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.Yellow
        Me.Button40.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.ForeColor = System.Drawing.Color.Black
        Me.Button40.Location = New System.Drawing.Point(1106, 721)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(187, 59)
        Me.Button40.TabIndex = 55605
        Me.Button40.Text = "Add Barcode"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1819, 1012)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Label69)
        Me.Controls.Add(Me.Button39)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.ClientID)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button36)
        Me.Controls.Add(Me.cuttingGroup)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.coreDefects)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button33)
        Me.Controls.Add(Me.Button32)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.printingBox)
        Me.Controls.Add(Me.Label87)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.TranIDLabel1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.DayNoLabel1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.ArtID)
        Me.Controls.Add(Me.ModelID)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LineNameComboBox)
        Me.Controls.Add(LineNameLabel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airless Mini Ball Packing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.Panel3.ResumeLayout(False)
        CType(Me.DSAMB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_Article_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.View_AMb_Article_Wise_SumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PC_AMB_LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.printingBox.ResumeLayout(False)
        CType(Me.View_AMb_FormingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSproduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Repair_QtyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Daily_SumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.View_Article_Wise_FailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PC_AMB_Hours_TranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inv_Tran_DateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_max_FromingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AMb_RepairBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AMb_RepairPAssBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AMB_Incentive_RFTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Froming_HourllyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents clock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DSAMB As DSAMB
    Friend WithEvents Tbl_Pro_ArticleBindingSource As BindingSource
    Friend WithEvents Tbl_Pro_ArticleTableAdapter As DSAMBTableAdapters.tbl_Pro_ArticleTableAdapter
    Friend WithEvents TableAdapterManager As DSAMBTableAdapters.TableAdapterManager
    Friend WithEvents ArtCodeComboBox As ComboBox
    Friend WithEvents Tbl_Pro_Article_DBindingSource As BindingSource
    Friend WithEvents Tbl_Pro_Article_DTableAdapter As DSAMBTableAdapters.tbl_Pro_Article_DTableAdapter
    Friend WithEvents ArtSizeComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Button13 As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Button17 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents View_AMb_FormingBindingSource As BindingSource
    Friend WithEvents View_AMb_FormingTableAdapter As DSAMBTableAdapters.View_AMb_FormingTableAdapter
    Friend WithEvents View_Daily_SumBindingSource As BindingSource
    Friend WithEvents View_Daily_SumTableAdapter As DSAMBTableAdapters.View_Daily_SumTableAdapter
    Friend WithEvents ModelID As Label
    Friend WithEvents ArtID As Label
    Friend WithEvents ClientID As Label
    Friend WithEvents View_AMb_Article_Wise_SumBindingSource As BindingSource
    Friend WithEvents View_AMb_Article_Wise_SumTableAdapter As DSAMBTableAdapters.View_AMb_Article_Wise_SumTableAdapter
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Tbl_PC_AMB_Hours_TranBindingSource As BindingSource
    Friend WithEvents Tbl_PC_AMB_Hours_TranTableAdapter As DSAMBTableAdapters.tbl_PC_AMB_Hours_TranTableAdapter
    Friend WithEvents Tbl_Inv_Tran_DateBindingSource As BindingSource
    Friend WithEvents Tbl_Inv_Tran_DateTableAdapter As DSAMBTableAdapters.tbl_Inv_Tran_DateTableAdapter
    Friend WithEvents DayNoLabel1 As Label
    Friend WithEvents Tbl_PC_AMB_LineBindingSource As BindingSource
    Friend WithEvents Tbl_PC_AMB_LineTableAdapter As DSAMBTableAdapters.tbl_PC_AMB_LineTableAdapter
    Friend WithEvents LineNameComboBox As ComboBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Button20 As Button
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents View_max_FromingBindingSource As BindingSource
    Friend WithEvents View_max_FromingTableAdapter As DSAMBTableAdapters.View_max_FromingTableAdapter
    Friend WithEvents TranIDLabel1 As Label
    Friend WithEvents Button21 As Button
    Friend WithEvents Label57 As Label
    Friend WithEvents Button22 As Button
    Friend WithEvents Label58 As Label
    Friend WithEvents Button23 As Button
    Friend WithEvents Label59 As Label
    Friend WithEvents Button24 As Button
    Friend WithEvents Label60 As Label
    Friend WithEvents Button25 As Button
    Friend WithEvents Label61 As Label
    Friend WithEvents Button26 As Button
    Friend WithEvents Label62 As Label
    Friend WithEvents Button27 As Button
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents printingBox As GroupBox
    Friend WithEvents cuttingGroup As GroupBox
    Friend WithEvents coreDefects As GroupBox
    Friend WithEvents Button28 As Button
    Friend WithEvents Label65 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Button29 As Button
    Friend WithEvents Label67 As Label
    Friend WithEvents Button30 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents Label68 As Label
    Friend WithEvents Button31 As Button
    Friend WithEvents View_AMB_Incentive_RFTBindingSource As BindingSource
    Friend WithEvents View_AMB_Incentive_RFTTableAdapter As DSAMBTableAdapters.View_AMB_Incentive_RFTTableAdapter
    Friend WithEvents View_AMb_RepairBindingSource As BindingSource
    Friend WithEvents View_AMb_RepairTableAdapter As DSAMBTableAdapters.View_AMb_RepairTableAdapter
    Friend WithEvents View_AMb_RepairPAssBindingSource As BindingSource
    Friend WithEvents View_AMb_RepairPAssTableAdapter As DSAMBTableAdapters.View_AMb_RepairPAssTableAdapter
    Friend WithEvents Label86 As Label
    Friend WithEvents Froming_HourllyBindingSource As BindingSource
    Friend WithEvents Froming_HourllyTableAdapter As DSAMBTableAdapters.Froming_HourllyTableAdapter
    Friend WithEvents Label87 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents View_Repair_QtyBindingSource As BindingSource
    Friend WithEvents View_Repair_QtyTableAdapter As DSAMBTableAdapters.View_Repair_QtyTableAdapter
    Friend WithEvents View_Article_Wise_FailBindingSource As BindingSource
    Friend WithEvents View_Article_Wise_FailTableAdapter As DSAMBTableAdapters.View_Article_Wise_FailTableAdapter
    Friend WithEvents Label75 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button18 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button39 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents Button36 As Button
    Friend WithEvents Label37 As Label
    Friend WithEvents DSproduction As DSproduction
    Friend WithEvents View_Pro_Article_BarCodeBindingSource As BindingSource
    Friend WithEvents View_Pro_Article_BarCodeTableAdapter As DSproductionTableAdapters.View_Pro_Article_BarCodeTableAdapter
    Friend WithEvents TableAdapterManager1 As DSproductionTableAdapters.TableAdapterManager
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label84 As Label
    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents EmpPicPictureBox As PictureBox
    Friend WithEvents Button40 As Button
End Class
