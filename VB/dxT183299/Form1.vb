Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraScheduler


Namespace dxT183299
    Partial Public Class Form1
        Inherits XtraForm

        Private CustomResourceList As New BindingList(Of CustomResource)()
        Private CustomAppointmentList As New BindingList(Of CustomAppointment)()
        Private CustomDependencyList As New BindingList(Of CustomDependency)()
        Private nextId As Integer
        Public Sub New()
            InitializeComponent()
            schedulerControl.Start = Date.Now
            schedulerStorage.Resources.ColorSaving = ColorSavingType.Color
            AddHandler schedulerStorage.AppointmentInserting, AddressOf schedulerStorage_AppointmentInserting
        End Sub

        Private Sub schedulerStorage_AppointmentInserting(ByVal sender As Object, ByVal e As PersistentObjectCancelEventArgs)
            Me.schedulerControl.Storage.SetAppointmentId((CType(e.Object, Appointment)), nextId)
            nextId += 1
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitResources()
            InitAppointments()
            InitDependencies()
        End Sub

        Private Sub InitDependencies()
            Dim mappings As AppointmentDependencyMappingInfo = schedulerStorage.AppointmentDependencies.Mappings
            mappings.DependentId = "DependentId"
            mappings.ParentId = "ParentId"
            mappings.Type = "Type"

            CustomDependencyList.Add(New CustomDependency(1, 2, 0))
            CustomDependencyList.Add(New CustomDependency(1, 3, 0))
            CustomDependencyList.Add(New CustomDependency(3, 4, 0))

            schedulerStorage.AppointmentDependencies.DataSource = CustomDependencyList

        End Sub
        Private Sub InitResources()
            Dim mappings As ResourceMappingInfo = Me.schedulerStorage.Resources.Mappings
            mappings.Id = "ResID"
            mappings.Color = "ResColor"
            mappings.Caption = "Name"
            mappings.ParentId = "ParentId"

            CustomResourceList.Add(New CustomResource(1, "Project Deployment", Color.PowderBlue, 0))
            CustomResourceList.Add(New CustomResource(2, "Specifications", Color.PaleVioletRed, 1))
            CustomResourceList.Add(New CustomResource(3, "Spike Solution", Color.PeachPuff, 1))
            CustomResourceList.Add(New CustomResource(4, "Demos and Docs", Color.AliceBlue, 0))
            CustomResourceList.Add(New CustomResource(5, "Demos", Color.FloralWhite, 4))
            CustomResourceList.Add(New CustomResource(6, "Docs", Color.Honeydew, 4))
            Me.schedulerStorage.Resources.DataSource = CustomResourceList
        End Sub

        Private Sub InitAppointments()
            Dim mappings As AppointmentMappingInfo = Me.schedulerStorage.Appointments.Mappings
            mappings.AppointmentId = "Id"
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"
            mappings.PercentComplete = "PercentComplete"

            Dim [date] As Date = Date.Today.AddDays(2)
            CustomAppointmentList.Add(New CustomAppointment(1, "Spec", 2, 0, 1, [date], [date].AddDays(3), 100))
            CustomAppointmentList.Add(New CustomAppointment(2, "Spike", 3, 0, 2, [date].AddDays(3), [date].AddDays(5), 100))
            CustomAppointmentList.Add(New CustomAppointment(3, "Documentation-Fundamentals", 4, 0, 3, [date].AddDays(2), [date].AddDays(6), 100))
            CustomAppointmentList.Add(New CustomAppointment(4, "Documentation-Public API", 6, 0, 6, [date].AddDays(7), [date].AddDays(10), 0))
            Me.nextId = (CustomAppointmentList.Max(Function(a) a.Id)) + 1
            Me.schedulerStorage.Appointments.DataSource = CustomAppointmentList
        End Sub
    End Class
End Namespace