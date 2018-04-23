﻿' Developer Express Code Central Example:
' How to enable Gantt view for the SchedulerControl bound to collection of business objects
' 
' This is a simple example of XtraScheduler bound to collection of custom business
' objects (https://documentation.devexpress.com/#WindowsForms/CustomDocument9606)
' displaying Gantt view
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10698). This
' project also utilizes the ResourcesTree control
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10685) to
' display a hierarchy of resources and the SplitContainer control
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSplitContainerControltopic)
' to allow resizing of Scheduler and ResourceTree controls.
' 
' To accomplish this
' task, you should have three collections - for appointments, for resources and
' for appointments dependencies. All collections should implement the IBindingList
' interface. You can implement this interface manually in your custom collection,
' but we recommend you use the System.ComponentModel.BindingList<T>
' collection.
' 
' Additionally, your business objects should have properties
' suitable for mapping
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument15468)to the
' corresponding properties of XtraScheduler appointments, resources and
' appointments dependencies.
' 
' See
' also:
' http://www.devexpress.com/scid=E750
' http://www.devexpress.com/scid=E3574
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T185539

Imports System

' Developer Express Code Central Example:
' How to enable Gantt view for the SchedulerControl bound to collection of business objects
' 
' This is a simple example of XtraScheduler bound to collection of custom business
' objects (https://documentation.devexpress.com/#WindowsForms/CustomDocument9606)
' displaying Gantt view
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10698). This
' project also utilizes the ResourcesTree control
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument10685) to
' display a hierarchy of resources and the SplitContainer control
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSplitContainerControltopic)
' to allow resizing of Scheduler and ResourceTree controls.
' 
' To accomplish this
' task, you should have three collections - for appointments, for resources and
' for appointments dependencies. All collections should implement the IBindingList
' interface. You can implement this interface manually in your custom collection,
' but we recommend you use the System.ComponentModel.BindingList<T>
' collection.
' 
' Additionally, your business objects should have properties
' suitable for mapping
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument15468)to the
' corresponding properties of XtraScheduler appointments, resources and
' appointments dependencies.
' 
' See
' also:
' http://www.devexpress.com/scid=E750
' http://www.devexpress.com/scid=E3574
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T185539

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34011
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
    End Module
End Namespace