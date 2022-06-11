<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepairBalance
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DSAMB = New AMB_Froming.DSAMB()
        Me.View_AMb_FormingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_AMb_FormingTableAdapter = New AMB_Froming.DSAMBTableAdapters.View_AMb_FormingTableAdapter()
        Me.TableAdapterManager = New AMB_Froming.DSAMBTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DSAMB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AMb_FormingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(108, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(557, 74)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(724, 155)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Your Remaning  Repair Ball :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(827, 40)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "AMB Repair Balance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSAMB
        '
        Me.DSAMB.DataSetName = "DSAMB"
        Me.DSAMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_AMb_FormingBindingSource
        '
        Me.View_AMb_FormingBindingSource.DataMember = "View_AMb_Forming"
        Me.View_AMb_FormingBindingSource.DataSource = Me.DSAMB
        '
        'View_AMb_FormingTableAdapter
        '
        Me.View_AMb_FormingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Inv_Tran_DateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PC_AMB_Hours_TranTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PC_AMB_LineTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AMB_Froming.DSAMBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "RCheck", True))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(412, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_AMb_FormingBindingSource, "RPass", True))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(457, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(357, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 135)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RepairBalance
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(827, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "RepairBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DSAMB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AMb_FormingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DSAMB As DSAMB
    Friend WithEvents View_AMb_FormingBindingSource As BindingSource
    Friend WithEvents View_AMb_FormingTableAdapter As DSAMBTableAdapters.View_AMb_FormingTableAdapter
    Friend WithEvents TableAdapterManager As DSAMBTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
