<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ReceiptDataSet = New POS.ReceiptDataSet()
        Me.QryReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QryReceiptTableAdapter = New POS.ReceiptDataSetTableAdapters.qryReceiptTableAdapter()
        Me.TableAdapterManager = New POS.ReceiptDataSetTableAdapters.TableAdapterManager()
        Me.QryReceiptBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ReceiptDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryReceiptBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReceiptDataSet
        '
        Me.ReceiptDataSet.DataSetName = "ReceiptDataSet"
        Me.ReceiptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QryReceiptBindingSource
        '
        Me.QryReceiptBindingSource.DataMember = "qryReceipt"
        Me.QryReceiptBindingSource.DataSource = Me.ReceiptDataSet
        '
        'QryReceiptTableAdapter
        '
        Me.QryReceiptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.ReceiptDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QryReceiptBindingSource1
        '
        Me.QryReceiptBindingSource1.DataMember = "qryReceipt"
        Me.QryReceiptBindingSource1.DataSource = Me.ReceiptDataSet
        '
        'frmReceiptTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 450)
        Me.Name = "frmReceiptTest"
        Me.Text = "frmReceiptTest"
        CType(Me.ReceiptDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryReceiptBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReceiptDataSet As ReceiptDataSet
    Friend WithEvents QryReceiptBindingSource As BindingSource
    Friend WithEvents QryReceiptTableAdapter As ReceiptDataSetTableAdapters.qryReceiptTableAdapter
    Friend WithEvents TableAdapterManager As ReceiptDataSetTableAdapters.TableAdapterManager
    Friend WithEvents QryReceiptBindingSource1 As BindingSource
End Class
