Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace dxT183299
    Public Class CustomAppointment

        Private startTime_Renamed As Date

        Private endTime_Renamed As Date

        Private subject_Renamed As String

        Private status_Renamed As Integer

        Private description_Renamed As String

        Private label_Renamed As Integer

        Private location_Renamed As String

        Private allday_Renamed As Boolean

        Private eventType_Renamed As Integer

        Private recurrenceInfo_Renamed As String

        Private reminderInfo_Renamed As String

        Private ownerId_Renamed As Object

        Private id_Renamed As Integer

        Private percentComplete_Renamed As Integer


        Public Property StartTime() As Date
            Get
                Return startTime_Renamed
            End Get
            Set(ByVal value As Date)
                startTime_Renamed = value
            End Set
        End Property
        Public Property EndTime() As Date
            Get
                Return endTime_Renamed
            End Get
            Set(ByVal value As Date)
                endTime_Renamed = value
            End Set
        End Property
        Public Property Subject() As String
            Get
                Return subject_Renamed
            End Get
            Set(ByVal value As String)
                subject_Renamed = value
            End Set
        End Property
        Public Property Status() As Integer
            Get
                Return status_Renamed
            End Get
            Set(ByVal value As Integer)
                status_Renamed = value
            End Set
        End Property
        Public Property Description() As String
            Get
                Return description_Renamed
            End Get
            Set(ByVal value As String)
                description_Renamed = value
            End Set
        End Property
        Public Property Label() As Integer
            Get
                Return label_Renamed
            End Get
            Set(ByVal value As Integer)
                label_Renamed = value
            End Set
        End Property
        Public Property Location() As String
            Get
                Return location_Renamed
            End Get
            Set(ByVal value As String)
                location_Renamed = value
            End Set
        End Property
        Public Property AllDay() As Boolean
            Get
                Return allday_Renamed
            End Get
            Set(ByVal value As Boolean)
                allday_Renamed = value
            End Set
        End Property
        Public Property EventType() As Integer
            Get
                Return eventType_Renamed
            End Get
            Set(ByVal value As Integer)
                eventType_Renamed = value
            End Set
        End Property
        Public Property RecurrenceInfo() As String
            Get
                Return recurrenceInfo_Renamed
            End Get
            Set(ByVal value As String)
                recurrenceInfo_Renamed = value
            End Set
        End Property
        Public Property ReminderInfo() As String
            Get
                Return reminderInfo_Renamed
            End Get
            Set(ByVal value As String)
                reminderInfo_Renamed = value
            End Set
        End Property
        Public Property OwnerId() As Object
            Get
                Return ownerId_Renamed
            End Get
            Set(ByVal value As Object)
                ownerId_Renamed = value
            End Set
        End Property
        Public Property Id() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                id_Renamed = value
            End Set
        End Property
        Public Property PercentComplete() As Integer
            Get
                Return percentComplete_Renamed
            End Get
            Set(ByVal value As Integer)
                percentComplete_Renamed = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal id As Integer, ByVal subject As String, ByVal ownerId As Object, ByVal status As Integer, ByVal label As Integer, ByVal startTime As Date, ByVal endTime As Date, ByVal percentComplete As Integer)
            Me.id_Renamed = id
            Me.subject_Renamed = subject
            Me.ownerId_Renamed = ownerId
            Me.startTime_Renamed = startTime
            Me.endTime_Renamed = endTime
            Me.status_Renamed = status
            Me.label_Renamed = label
            Me.percentComplete_Renamed = percentComplete
        End Sub

    End Class

    Public Class CustomResource

        Private name_Renamed As String

        Private resID_Renamed As Integer

        Private resColor_Renamed As Color

        Private parentId_Renamed As Integer

        Public Property Name() As String
            Get
                Return name_Renamed
            End Get
            Set(ByVal value As String)
                name_Renamed = value
            End Set
        End Property
        Public Property ResID() As Integer
            Get
                Return resID_Renamed
            End Get
            Set(ByVal value As Integer)
                resID_Renamed = value
            End Set
        End Property
        Public Property ResColor() As Color
            Get
                Return resColor_Renamed
            End Get
            Set(ByVal value As Color)
                resColor_Renamed = value
            End Set
        End Property
        Public Property ParentId() As Integer
            Get
                Return parentId_Renamed
            End Get
            Set(ByVal value As Integer)
                parentId_Renamed = value
            End Set
        End Property

        Public Sub New()
        End Sub
        Public Sub New(ByVal res_id As Integer, ByVal name As String, ByVal resColor As Color, ByVal parentId As Integer)
            Me.resID_Renamed = res_id
            Me.name_Renamed = name
            Me.resColor_Renamed = resColor
            Me.parentId_Renamed = parentId
        End Sub
    End Class
    Public Class CustomDependency

        Private dependentId_Renamed As Integer
        Public Property DependentId() As Integer
            Get
                Return dependentId_Renamed
            End Get
            Set(ByVal value As Integer)
                dependentId_Renamed = value
            End Set
        End Property

        Private parentId_Renamed As Integer
        Public Property ParentId() As Integer
            Get
                Return parentId_Renamed
            End Get
            Set(ByVal value As Integer)
                parentId_Renamed = value
            End Set
        End Property

        Private type_Renamed As Integer
        Public Property Type() As Integer
            Get
                Return type_Renamed
            End Get
            Set(ByVal value As Integer)
                type_Renamed = value
            End Set
        End Property


        Public Sub New()
        End Sub
        Public Sub New(ByVal parentId As Integer, ByVal dependentId As Integer, ByVal type As Integer)
            Me.parentId_Renamed = parentId
            Me.dependentId_Renamed = dependentId
            Me.type_Renamed = type
        End Sub
    End Class
End Namespace
