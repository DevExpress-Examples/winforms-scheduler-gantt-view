using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dxT183299
{
    public class CustomAppointment
    {
        private DateTime startTime;
        private DateTime endTime;
        private string subject;
        private int status;
        private string description;
        private int label;
        private string location;
        private bool allday;
        private int eventType;
        private string recurrenceInfo;
        private string reminderInfo;
        private object ownerId;
        private int id;
        private int percentComplete;


        public DateTime StartTime { get { return startTime; } set { startTime = value; } }
        public DateTime EndTime { get { return endTime; } set { endTime = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public int Status { get { return status; } set { status = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Label { get { return label; } set { label = value; } }
        public string Location { get { return location; } set { location = value; } }
        public bool AllDay { get { return allday; } set { allday = value; } }
        public int EventType { get { return eventType; } set { eventType = value; } }
        public string RecurrenceInfo { get { return recurrenceInfo; } set { recurrenceInfo = value; } }
        public string ReminderInfo { get { return reminderInfo; } set { reminderInfo = value; } }
        public object OwnerId { get { return ownerId; } set { ownerId = value; } }
        public int Id { get { return id; } set { id = value; } }
        public int PercentComplete { get { return percentComplete; } set { percentComplete = value; } }

        public CustomAppointment(){}

        public CustomAppointment(int id, string subject, object ownerId, int status, int label, DateTime startTime, DateTime endTime, int percentComplete)
        {
            this.id = id;
            this.subject = subject;
            this.ownerId = ownerId;
            this.startTime = startTime;
            this.endTime = endTime;
            this.status = status;
            this.label = label;
            this.percentComplete = percentComplete;
        }
        
    }

    public class CustomResource {
        private string name;
        private int resID;
        private Color resColor;
        private int parentId;

        public string Name { get { return name; } set { name = value; } }        
        public int ResID { get { return resID; } set { resID = value; } }
        public Color ResColor { get { return resColor; } set { resColor = value; } }
        public int ParentId { get { return parentId; } set { parentId = value; } }

        public CustomResource() 
        {
        }
        public CustomResource(int res_id, string name, Color resColor, int parentId)
        {
            this.resID = res_id;
            this.name = name;
            this.resColor = resColor;
            this.parentId = parentId;
        }
    }
    public class CustomDependency
    {
        private int dependentId;
        public int DependentId { get { return dependentId; } set { dependentId = value; } }
        private int parentId;
        public int ParentId { get { return parentId; } set { parentId = value; } }
        private int type;
        public int Type { get { return type; } set { type = value; } }


        public CustomDependency(){}
        public CustomDependency(int parentId, int dependentId, int type)
        {
            this.parentId = parentId;
            this.dependentId = dependentId;
            this.type = type;
        }
    }
}
