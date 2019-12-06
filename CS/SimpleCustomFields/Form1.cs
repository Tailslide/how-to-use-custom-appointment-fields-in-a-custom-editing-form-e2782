using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
#region #usings
using DevExpress.XtraScheduler;
using System.Linq;
using static SimpleCustomFields.CarsDBDataSet;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors.Repository;
using System.Diagnostics;
#endregion #usings

namespace SimpleCustomFields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            schedulerDataStorage1.AppointmentInserting += SchedulerStorage1_AppointmentInserting;
            schedulerDataStorage1.AppointmentsInserted += new PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            schedulerDataStorage1.AppointmentChanging += SchedulerStorage1_AppointmentChanging;
            schedulerDataStorage1.AppointmentsChanged += new PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);
            schedulerDataStorage1.AppointmentsDeleted += new PersistentObjectsEventHandler(this.OnApptChangedInsertedDeleted);

            this.schedulerControl1.Start = new DateTime(2010, 07, 01);
        }

        #region SeatTypeLookupRepository


                private static RepositoryItemSearchLookUpEdit CreateLookupRepo(DataTable data, string displayField)
        {
            var repoToCreate = new RepositoryItemSearchLookUpEdit
            {
                AllowNullInput = DevExpress.Utils.DefaultBoolean.True,
                DataSource = data,
                DisplayMember = displayField,
                ValueMember = "Id",
                NullText = ""
            };
            repoToCreate.PopulateViewColumns();
            repoToCreate.View.Columns["Id"].Visible = false;

            return repoToCreate;
        }


                // Lookup controls
        private static RepositoryItemSearchLookUpEdit seatRepo;
        internal static RepositoryItemSearchLookUpEdit SeatsLookup
        {
            get
            {
                if (seatRepo == null)
                {
                    var seatData = new DataTable();
                    
                    seatData.Columns.Add("Id", typeof(int));
                    seatData.Columns.Add("Name", typeof(string));
                    var rw =seatData.NewRow();
                    rw["Id"]  = 1;
                    rw["Name"] = "Bucket";
                    seatData.Rows.Add(rw);
                    var rw2 =seatData.NewRow();
                    rw2["Id"]  = 2;
                    rw2["Name"] = "Bench";
                    seatData.Rows.Add(rw2);
                    seatRepo = CreateLookupRepo(seatData, "Name");
                }
                return seatRepo;
            }
        }
        #endregion

        #region Mcars and MyCarSchedules POCO classes

        private BindingList<Car> MyCars = null;
        private BindingList<CarSchedule> MyCarSchedules = null;

        private class Car
        {
            public int Id {get; set;}
            public string Trademark { get; set;}
            public string Model {get; set;}
            public int HP {get; set;}
            public double Liter { get; set;}
            public byte Cyl {get; set;}
            public byte TransmissSpeedCount {get; set;}
            public string TransmissAutomatic {get; set;}
            public byte MPG_City {get; set;}
            public byte MPG_Highway {get; set;}
            public string Category { get; set;}
            public string Description {get; set;}
            public string Hyperlink {get; set;}
            public byte[] Picture {get; set;}
            public decimal Amount {get; set;}
            public string RtfContent {get; set;}

        }

        private class CarSchedule
        {
            public int ID {get; set;}
            public int CarId {get; set;}
            public int UserId {get;set;}
            public int Status {get;set;}
            public string Subject {get;set;}
            public string Description {get;set;}
            public string Label{get;set;}
            public DateTime StartTime {get; set;}
            public DateTime EndTime {get;set;}
            public string Location {get;set;}
            public bool AllDay {get;set;}
            public int EventType {get;set;}
            public string RecurrenceInfo {get;set;}
            public string ReminderInfo {get;set;}
            public decimal Price {get;set;}
            public string ContactInfo {get;set;}
            public int Amount {get;set;}
            public int LookupSeatId {get; set;}
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

            // build POCO from framework class so we are testing something that is the same 
            // as my problem project
            //
            MyCars=new BindingList<Car>(this.carsDBDataSet.Cars.Select(x=>new Car() { 
                Amount=x.Amount, Category= x.Category, Cyl = x.Cyl, Description = x.Description, HP = x.HP,
                Hyperlink = x.Hyperlink, Id = x.ID, Liter = x.Liter, Model = x.Model , MPG_City = x.MPG_City,
                MPG_Highway = x.MPG_Highway , Picture = x.Picture , RtfContent = x.RtfContent, Trademark = x.Trademark,
                TransmissAutomatic = x.TransmissAutomatic, TransmissSpeedCount = x.TransmissSpeedCount }).ToList());

            MyCarSchedules = new BindingList<CarSchedule>(this.carsDBDataSet.CarScheduling.Select(x=>new CarSchedule() {
                AllDay = x.AllDay, Amount = x.Amount , CarId = x.CarId , ContactInfo = x.ContactInfo,
                Description = x.Description, EndTime = x.EndTime, EventType = x.EventType, ID= x.ID,
                Label = x.Label, Location = x.Location, Price = x.Price, RecurrenceInfo = x.RecurrenceInfo,
                ReminderInfo = x.ReminderInfo, StartTime = x.StartTime, Status = x.Status, Subject = x.Subject,
                UserId = x.UserId, LookupSeatId = 1
            }).ToList());
            InitResourceMapping();
            InitAppointmentMapping();
            schedulerStorage1.Appointments.DataSource = MyCarSchedules;
            schedulerStorage1.Resources.DataSource = MyCars;
            filterControl1.SourceControl = schedulerStorage1.Appointments;
            InitializeFilter();
        }


        private void InitResourceMapping()
        {
            ResourceMappingInfo mappings = this.schedulerStorage1.Resources.Mappings;
            mappings.Id = "Id";
            mappings.Caption = "Model";
        }

        private string curResource = "CarId";

        private void InitAppointmentMapping(string resourceField = "CarId")
        {
            AppointmentMappingInfo mappings = this.schedulerStorage1.Appointments.Mappings;
            mappings.AppointmentId = "ID";
            mappings.Start = "StartTime";
            mappings.Type="AppointmentType";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.AllDay = "AllDay";
            mappings.ResourceId = resourceField;
            mappings.Status = "Status";


            if (!schedulerStorage1.Appointments.CustomFieldMappings.CheckMappings(new[] { "LookupSeatId" }))
                schedulerStorage1.Appointments.CustomFieldMappings.Add(
                    new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("LookupSeatId", "LookupSeatId", FieldValueType.Integer)
                );
        }

         private void ChangeAppointmentMapping(string resourceField = "CarId")
        {
            AppointmentMappingInfo mappings = this.schedulerStorage1.Appointments.Mappings;
            mappings.ResourceId = resourceField;
        }

        private void InitializeFilter()
        {
            if (filterControl1.FilterColumns["LookupSeatId"]!= null) 
            {
               filterControl1.FilterColumns.Remove(filterControl1.FilterColumns["LookupSeatId"]); // remove dumb editor
               filterControl1.FilterColumns.Add(new UnboundFilterColumn("Seat Type", "LookupSeatId", typeof(int), SeatsLookup, FilterColumnClauseClass.Lookup));
            }
        }


        #region dataupdates

        private void OnApptChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            carSchedulingTableAdapter.Update(carsDBDataSet);
            carsDBDataSet.AcceptChanges();
        }

        private void carSchedulingTableAdapter_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY",
                    carSchedulingTableAdapter.Connection))
                {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["ID"] = id;
            }
        }
        #endregion

        #region #EditAppointmentFormShowing
        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            MyAppointmentForm form = new MyAppointmentForm(sender as SchedulerControl, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }
        }
        #endregion #EditAppointmentFormShowing

        #region #InitNewAppointment
        private void schedulerControl1_InitNewAppointment(object sender, DevExpress.XtraScheduler.AppointmentEventArgs e)
        {
            e.Appointment.Description += "Created at runtime at " + String.Format("{0:g}", DateTime.Now);
            e.Appointment.CustomFields["Amount"] = 00.01d;
            e.Appointment.CustomFields["ContactInfo"] = "someone@somecompany.com";
        }
        #endregion #InitNewAppointment
        #region #AppointmentInserting
        private void SchedulerStorage1_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e) {
            if (((Appointment)e.Object).Start < DateTime.Now) e.Cancel = true;
        }
        #endregion #AppointmentInserting
        #region #AppointmentChanging
        private void SchedulerStorage1_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e) {
            object busyKey = schedulerDataStorage1.Appointments.Statuses.GetByType(AppointmentStatusType.Busy).Id;
            if (((Appointment)e.Object).StatusKey == busyKey) e.Cancel = true;
        }
        #endregion #AppointmentChanging

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            schedulerStorage1.Appointments.Filter = filterControl1.FilterString;
        }

        private void btnChangeResourceMapping_Click(object sender, EventArgs e)
        {
            if (curResource == "CarId")
                ChangeAppointmentMapping("HP");
            else
                ChangeAppointmentMapping("CarId");
            /// do something here to fix state of filter???
        }

        private void btnReinitializeFilter_Click(object sender, EventArgs e)
        {
            InitializeFilter();    
            filterControl1.Focus();
            SendKeys.Send("{INS}{DEL}");
        }
    }
}