<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBarCode
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim ArtCodeLabel As System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ArtCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Pro_ArticleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAMB = New AMB_Froming.DSAMB()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tbl_Pro_ArticleTableAdapter = New AMB_Froming.DSAMBTableAdapters.tbl_Pro_ArticleTableAdapter()
        Me.TableAdapterManager = New AMB_Froming.DSAMBTableAdapters.TableAdapterManager()
        Me.DSproduction = New AMB_Froming.DSproduction()
        Me.View_Pro_Article_BarCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Pro_Article_BarCodeTableAdapter = New AMB_Froming.DSproductionTableAdapters.View_Pro_Article_BarCodeTableAdapter()
        Me.TableAdapterManager1 = New AMB_Froming.DSproductionTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Pro_Article_BarCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Pro_Article_BarCodeTableAdapter = New AMB_Froming.DSproductionTableAdapters.tbl_Pro_Article_BarCodeTableAdapter()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        ArtCodeLabel = New System.Windows.Forms.Label()
        Me.Panel9.SuspendLayout()
        CType(Me.Tbl_Pro_ArticleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAMB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSproduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(309, 120)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(141, 25)
        Label4.TabIndex = 55641
        Label4.Text = "Select Type :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(310, 76)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(135, 25)
        Label3.TabIndex = 55639
        Label3.Text = "Select Size :"
        '
        'ArtCodeLabel
        '
        ArtCodeLabel.AutoSize = True
        ArtCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArtCodeLabel.Location = New System.Drawing.Point(35, 77)
        ArtCodeLabel.Name = "ArtCodeLabel"
        ArtCodeLabel.Size = New System.Drawing.Size(105, 25)
        ArtCodeLabel.TabIndex = 55636
        ArtCodeLabel.Text = "Art Code:"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label84)
        Me.Panel9.Controls.Add(Me.txtCardNo)
        Me.Panel9.Location = New System.Drawing.Point(46, 169)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(525, 73)
        Me.Panel9.TabIndex = 55595
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.DarkCyan
        Me.Label84.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.SystemColors.Control
        Me.Label84.Location = New System.Drawing.Point(0, 0)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(523, 20)
        Me.Label84.TabIndex = 2
        Me.Label84.Text = "Barcode Terminal"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCardNo
        '
        Me.txtCardNo.BackColor = System.Drawing.SystemColors.Control
        Me.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCardNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo.Location = New System.Drawing.Point(3, 37)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCardNo.Size = New System.Drawing.Size(517, 23)
        Me.txtCardNo.TabIndex = 0
        Me.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(426, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 77)
        Me.Button1.TabIndex = 55630
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"U", "E"})
        Me.ComboBox2.Location = New System.Drawing.Point(450, 118)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox2.TabIndex = 55640
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"3", "4", "5", "6"})
        Me.ComboBox1.Location = New System.Drawing.Point(451, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox1.TabIndex = 55638
        '
        'ArtCodeComboBox
        '
        Me.ArtCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ArtCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ArtCodeComboBox.DataSource = Me.Tbl_Pro_ArticleBindingSource
        Me.ArtCodeComboBox.DisplayMember = "ArtCode"
        Me.ArtCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtCodeComboBox.FormattingEnabled = True
        Me.ArtCodeComboBox.Location = New System.Drawing.Point(146, 74)
        Me.ArtCodeComboBox.Name = "ArtCodeComboBox"
        Me.ArtCodeComboBox.Size = New System.Drawing.Size(158, 33)
        Me.ArtCodeComboBox.TabIndex = 55637
        Me.ArtCodeComboBox.ValueMember = "ArtID"
        '
        'Tbl_Pro_ArticleBindingSource
        '
        Me.Tbl_Pro_ArticleBindingSource.DataMember = "tbl_Pro_Article"
        Me.Tbl_Pro_ArticleBindingSource.DataSource = Me.DSAMB
        '
        'DSAMB
        '
        Me.DSAMB.DataSetName = "DSAMB"
        Me.DSAMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Turquoise
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(609, 53)
        Me.Label5.TabIndex = 55642
        Me.Label5.Text = "Add Bar Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'DSproduction
        '
        Me.DSproduction.DataSetName = "DSproduction"
        Me.DSproduction.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Pro_Article_BarCodeBindingSource
        '
        Me.View_Pro_Article_BarCodeBindingSource.DataMember = "View_Pro_Article_BarCode"
        Me.View_Pro_Article_BarCodeBindingSource.DataSource = Me.DSproduction
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
        Me.TableAdapterManager1.tbl_Pro_Article_BarCodeTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AMB_Froming.DSproductionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ClientID", True))
        Me.Label1.Location = New System.Drawing.Point(299, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 55643
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Pro_ArticleBindingSource, "ModelID", True))
        Me.Label2.Location = New System.Drawing.Point(406, 401)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 55644
        Me.Label2.Text = "Label2"
        '
        'Tbl_Pro_Article_BarCodeBindingSource
        '
        Me.Tbl_Pro_Article_BarCodeBindingSource.DataMember = "tbl_Pro_Article_BarCode"
        Me.Tbl_Pro_Article_BarCodeBindingSource.DataSource = Me.DSproduction
        '
        'Tbl_Pro_Article_BarCodeTableAdapter
        '
        Me.Tbl_Pro_Article_BarCodeTableAdapter.ClearBeforeFill = True
        '
        'AddBarCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(609, 363)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(ArtCodeLabel)
        Me.Controls.Add(Me.ArtCodeComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel9)
        Me.Name = "AddBarCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.Tbl_Pro_ArticleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAMB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSproduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Pro_Article_BarCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label84 As Label
    Friend WithEvents txtCardNo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ArtCodeComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Tbl_Pro_ArticleBindingSource As BindingSource
    Friend WithEvents DSAMB As DSAMB
    Friend WithEvents Tbl_Pro_ArticleTableAdapter As DSAMBTableAdapters.tbl_Pro_ArticleTableAdapter
    Friend WithEvents TableAdapterManager As DSAMBTableAdapters.TableAdapterManager
    Friend WithEvents DSproduction As DSproduction
    Friend WithEvents View_Pro_Article_BarCodeBindingSource As BindingSource
    Friend WithEvents View_Pro_Article_BarCodeTableAdapter As DSproductionTableAdapters.View_Pro_Article_BarCodeTableAdapter
    Friend WithEvents TableAdapterManager1 As DSproductionTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tbl_Pro_Article_BarCodeBindingSource As BindingSource
    Friend WithEvents Tbl_Pro_Article_BarCodeTableAdapter As DSproductionTableAdapters.tbl_Pro_Article_BarCodeTableAdapter
End Class
