<!-- default file list -->
*Files to look at*:

* [CustomObjects.cs](./CS/dxT183299/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/dxT183299/CustomObjects.vb))
* [Form1.cs](./CS/dxT183299/Form1.cs) (VB: [Form1.vb](./VB/dxT183299/Form1.vb))
* [Program.cs](./CS/dxT183299/Program.cs) (VB: [Program.vb](./VB/dxT183299/Program.vb))
<!-- default file list end -->
# How to enable Gantt view for the SchedulerControl bound to collection of business objects


<p>This is a simple example of XtraScheduler bound to collection of custom <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument9606">business objects</a> displaying <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument10698">Gantt view</a>. This project also utilizes the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument10685">ResourcesTree control</a> to display a hierarchy of resources and the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsSplitContainerControltopic">SplitContainer control</a> to allow resizing of Scheduler and ResourceTree controls.</p>
<p>To accomplish this task, you should have three collections - for appointments, for resources and for appointments dependencies. All collections should implement the <strong>IBindingList</strong> interface. You can implement this interface manually in your custom collection, but we recommend you use the <strong>System.ComponentModel.BindingList<T></strong> collection.<br /><br />Additionally, your business objects should have properties suitable for <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument15468">mapping </a>to the corresponding properties of XtraScheduler appointments, resources and appointments dependencies.<br /><br /><strong>See also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/E750">How to bind the SchedulerControl to a collection of custom objects</a><br /><a href="https://www.devexpress.com/Support/Center/p/E3574">How to enable Gantt view for the XtraScheduler bound to MS SQL Server database</a></p>

<br/>


