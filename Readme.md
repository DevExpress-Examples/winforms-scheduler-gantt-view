<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128634788/14.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T185539)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Scheduler - Enable the Gantt View

In this example, the Scheduler control is bound to a collection of [custom objects](https://docs.devexpress.com/WindowsForms/9606/controls-and-libraries/scheduler/data-binding/data-sources/business-objects) and displays appointments in a Gantt View. The example also uses the [Resources Tree](https://docs.devexpress.com/WindowsForms/10685/controls-and-libraries/scheduler/visual-elements/resources-tree) to display a resource hierarchy.

![](https://raw.githubusercontent.com/DevExpress-Examples/how-to-enable-gantt-view-for-the-schedulercontrol-bound-to-collection-of-business-objects-t185539/14.2.7%2B/media/winforms-ascheduler-gantt-view.png)

### Implementation Details

To display appointments in a Gantt View, you should have three collections that implement the `IBindingList` interface (we recommend you use `System.ComponentModel.BindingList<T>`):

* Appointments
* Resources
* Appointments dependencies.

Business objects should have specific properties for [mapping](https://docs.devexpress.com/WindowsForms/15468/controls-and-libraries/scheduler/data-binding/mappings) to the corresponding properties of Scheduler appointments, resources, and appointments dependencies.


> **Note**
>
> You can also use the [WinForms Gantt Control](https://docs.devexpress.com/WindowsForms/401173/controls-and-libraries/gantt-control/gantt-control) designed to address your project planning requirements regardless of dataset size and information complexity..


## Files to Review

* [CustomObjects.cs](./CS/dxT183299/CustomObjects.cs) (VB: [CustomObjects.vb](./VB/dxT183299/CustomObjects.vb))
* [Form1.cs](./CS/dxT183299/Form1.cs) (VB: [Form1.vb](./VB/dxT183299/Form1.vb))


## Documentation

* [Gantt View - WinForms Scheduler](https://docs.devexpress.com/WindowsForms/10698/controls-and-libraries/scheduler/views/gantt-view)


## See Also

* [How to bind the SchedulerControl to a collection of custom objects](https://supportcenter.devexpress.com/ticket/details/e750/winforms-scheduler-bind-to-a-collection-of-custom-appointments)
* [How to enable Gantt view for the XtraScheduler bound to MS SQL Server database](https://supportcenter.devexpress.com/ticket/details/e3574/winforms-scheduler-create-gantt-chart-bound-to-ms-sql-server-database)
