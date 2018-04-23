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

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("dxT183299")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("dxT183299")>
<Assembly: AssemblyCopyright("Copyright ©  2014")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>
' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>
' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("1d20fa16-7243-4727-8e7a-50fa389e4eeb")>
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
