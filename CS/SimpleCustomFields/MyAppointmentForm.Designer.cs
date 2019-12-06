namespace SimpleCustomFields
{
    partial class MyAppointmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAmount = new DevExpress.XtraEditors.LabelControl();
            this.calcAmount = new DevExpress.XtraEditors.CalcEdit();
            this.mruEdit1 = new DevExpress.XtraEditors.MRUEdit();
            this.tbContact = new DevExpress.XtraEditors.MemoEdit();
            this.lblContactInfo = new DevExpress.XtraEditors.LabelControl();
            this.carsDBDataSet = new SimpleCustomFields.CarsDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            this.progressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabel
            // 
            this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.Appearance.Options.UseBackColor = true;
            // 
            // chkAllDay
            // 
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(24, 572);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(156, 572);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 572);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // btnRecurrence
            // 
            this.btnRecurrence.Location = new System.Drawing.Point(420, 572);
            this.btnRecurrence.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // edtStartDate
            // 
            this.edtStartDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartDate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtStartDate.Size = new System.Drawing.Size(189, 30);
            // 
            // edtEndDate
            // 
            this.edtEndDate.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndDate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.edtEndDate.Size = new System.Drawing.Size(189, 30);
            // 
            // edtStartTime
            // 
            this.edtStartTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtStartTime.Location = new System.Drawing.Point(345, 128);
            this.edtStartTime.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // edtEndTime
            // 
            this.edtEndTime.EditValue = new System.DateTime(2005, 3, 31, 0, 0, 0, 0);
            this.edtEndTime.Location = new System.Drawing.Point(345, 166);
            this.edtEndTime.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            // 
            // edtLabel
            // 
            this.edtLabel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.edtLabel.Size = new System.Drawing.Size(168, 30);
            // 
            // edtShowTimeAs
            // 
            this.edtShowTimeAs.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.edtShowTimeAs.Size = new System.Drawing.Size(333, 30);
            // 
            // tbSubject
            // 
            this.tbSubject.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbSubject.Size = new System.Drawing.Size(633, 30);
            // 
            // edtResource
            // 
            this.edtResource.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.edtResource.Size = new System.Drawing.Size(168, 30);
            // 
            // edtResources
            // 
            // 
            // 
            // 
            this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
            this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
            this.edtResources.ResourcesCheckedListBoxControl.Name = "";
            this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
            this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
            // 
            // chkReminder
            // 
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(24, 452);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbDescription.Size = new System.Drawing.Size(744, 90);
            // 
            // cbReminder
            // 
            // 
            // tbLocation
            // 
            this.tbLocation.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tbLocation.Size = new System.Drawing.Size(333, 30);
            // 
            // tbProgress
            // 
            this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbProgress.Size = new System.Drawing.Size(580, 81);
            // 
            // lblPercentComplete
            // 
            this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentComplete.Appearance.Options.UseBackColor = true;
            // 
            // lblPercentCompleteValue
            // 
            this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentCompleteValue.Appearance.Options.UseBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(24, 296);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(59, 21);
            this.lblAmount.TabIndex = 37;
            this.lblAmount.Text = "Amount:";
            // 
            // calcAmount
            // 
            this.calcAmount.Location = new System.Drawing.Point(144, 291);
            this.calcAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calcAmount.Name = "calcAmount";
            this.calcAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcAmount.Size = new System.Drawing.Size(150, 30);
            this.calcAmount.TabIndex = 38;
            this.calcAmount.EditValueChanged += new System.EventHandler(this.calcAmount_EditValueChanged);
            // 
            // mruEdit1
            // 
            this.mruEdit1.Location = new System.Drawing.Point(528, 501);
            this.mruEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mruEdit1.Name = "mruEdit1";
            this.mruEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mruEdit1.Size = new System.Drawing.Size(12, 30);
            this.mruEdit1.TabIndex = 39;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(495, 313);
            this.tbContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(273, 66);
            this.tbContact.TabIndex = 40;
            this.tbContact.EditValueChanged += new System.EventHandler(this.tbContact_EditValueChanged);
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.Location = new System.Drawing.Point(495, 281);
            this.lblContactInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(87, 21);
            this.lblContactInfo.TabIndex = 41;
            this.lblContactInfo.Text = "Contact Info:";
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MyAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 617);
            this.Controls.Add(this.mruEdit1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.calcAmount);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MinimumSize = new System.Drawing.Size(506, 294);
            this.Name = "MyAppointmentForm";
            this.Text = "MyAppointmentForm";
            this.Controls.SetChildIndex(this.calcAmount, 0);
            this.Controls.SetChildIndex(this.tbContact, 0);
            this.Controls.SetChildIndex(this.lblContactInfo, 0);
            this.Controls.SetChildIndex(this.lblAmount, 0);
            this.Controls.SetChildIndex(this.mruEdit1, 0);
            this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
            this.Controls.SetChildIndex(this.edtEndTime, 0);
            this.Controls.SetChildIndex(this.edtEndDate, 0);
            this.Controls.SetChildIndex(this.btnRecurrence, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
            this.Controls.SetChildIndex(this.lblEndTime, 0);
            this.Controls.SetChildIndex(this.tbLocation, 0);
            this.Controls.SetChildIndex(this.lblSubject, 0);
            this.Controls.SetChildIndex(this.lblLocation, 0);
            this.Controls.SetChildIndex(this.tbSubject, 0);
            this.Controls.SetChildIndex(this.lblStartTime, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.edtStartDate, 0);
            this.Controls.SetChildIndex(this.edtStartTime, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.progressPanel, 0);
            this.Controls.SetChildIndex(this.tbDescription, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chkAllDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtEndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtShowTimeAs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResource.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtResources.ResourcesCheckedListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbReminder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.progressPanel.ResumeLayout(false);
            this.progressPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mruEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblAmount;
        private DevExpress.XtraEditors.CalcEdit calcAmount;
        private DevExpress.XtraEditors.MRUEdit mruEdit1;
        private DevExpress.XtraEditors.MemoEdit tbContact;
        private DevExpress.XtraEditors.LabelControl lblContactInfo;
        private CarsDBDataSet carsDBDataSet;
    }
}