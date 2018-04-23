Namespace dxT183299
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
            Me.resourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree()
            Me.colResID = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.colDescription = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.schedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            DirectCast(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.schedulerSplitContainerControl.SuspendLayout()
            DirectCast(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerSplitContainerControl
            ' 
            Me.schedulerSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerSplitContainerControl.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.schedulerSplitContainerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerSplitContainerControl.Name = "schedulerSplitContainerControl"
            Me.schedulerSplitContainerControl.Panel1.Controls.Add(Me.resourcesTree1)
            Me.schedulerSplitContainerControl.Panel1.Text = "Panel1"
            Me.schedulerSplitContainerControl.Panel2.Controls.Add(Me.schedulerControl)
            Me.schedulerSplitContainerControl.Panel2.Text = "Panel2"
            Me.schedulerSplitContainerControl.Size = New System.Drawing.Size(1100, 700)
            Me.schedulerSplitContainerControl.SplitterPosition = 828
            Me.schedulerSplitContainerControl.TabIndex = 2
            Me.schedulerSplitContainerControl.Text = "splitContainerControl1"
            ' 
            ' resourcesTree1
            ' 
            Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colResID, Me.colDescription})
            Me.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.resourcesTree1.Location = New System.Drawing.Point(0, 0)
            Me.resourcesTree1.Name = "resourcesTree1"
            Me.resourcesTree1.OptionsBehavior.Editable = False
            Me.resourcesTree1.SchedulerControl = Me.schedulerControl
            Me.resourcesTree1.Size = New System.Drawing.Size(267, 700)
            Me.resourcesTree1.TabIndex = 1
            ' 
            ' colResID
            ' 
            Me.colResID.Caption = "resourceTreeColumn1"
            Me.colResID.FieldName = "ResID"
            Me.colResID.Name = "colResID"
            ' 
            ' colDescription
            ' 
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Name"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 0
            ' 
            ' schedulerControl
            ' 
            Me.schedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
            Me.schedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl.Location = New System.Drawing.Point(0, 0)
            Me.schedulerControl.Name = "schedulerControl"
            Me.schedulerControl.Size = New System.Drawing.Size(828, 700)
            Me.schedulerControl.Start = New Date(2014, 12, 5, 0, 0, 0, 0)
            Me.schedulerControl.Storage = Me.schedulerStorage
            Me.schedulerControl.TabIndex = 0
            Me.schedulerControl.Text = "schedulerControl1"
            Me.schedulerControl.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1100, 700)
            Me.Controls.Add(Me.schedulerSplitContainerControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.schedulerSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.schedulerSplitContainerControl.ResumeLayout(False)
            DirectCast(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private schedulerSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
        Private schedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
        Private resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
        Private schedulerControl As DevExpress.XtraScheduler.SchedulerControl
        Private colResID As DevExpress.XtraScheduler.Native.ResourceTreeColumn
        Private colDescription As DevExpress.XtraScheduler.Native.ResourceTreeColumn

    End Class
End Namespace
