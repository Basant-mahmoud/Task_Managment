namespace Task_Managment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxTeamMembers = new System.Windows.Forms.ComboBox();
            this.treeListTasks = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.Addtask = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateStatus = new DevExpress.XtraEditors.SimpleButton();
            this.addtaskName = new System.Windows.Forms.TextBox();
            this.AdddateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxaddteammember = new System.Windows.Forms.ComboBox();
            this.checkedComboxAddStatus = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedComboBoxUpdateStutes = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.UpdatedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxupdateteammember = new System.Windows.Forms.ComboBox();
            this.Get = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.teammember = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.treeListTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboxAddStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxUpdateStutes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTeamMembers
            // 
            this.comboBoxTeamMembers.FormattingEnabled = true;
            this.comboBoxTeamMembers.Location = new System.Drawing.Point(4, 24);
            this.comboBoxTeamMembers.Name = "comboBoxTeamMembers";
            this.comboBoxTeamMembers.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTeamMembers.TabIndex = 0;
            this.comboBoxTeamMembers.SelectedIndexChanged += new System.EventHandler(this.comboBoxTeamMembers_SelectedIndexChanged);
            // 
            // treeListTasks
            // 
            this.treeListTasks.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeListTasks.CustomizationFormBounds = new System.Drawing.Rectangle(477, 254, 321, 331);
            this.treeListTasks.Location = new System.Drawing.Point(131, 24);
            this.treeListTasks.Name = "treeListTasks";
            this.treeListTasks.Size = new System.Drawing.Size(596, 94);
            this.treeListTasks.TabIndex = 1;
            this.treeListTasks.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeListTasks_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Task Name";
            this.treeListColumn1.FieldName = "TaskName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Status";
            this.treeListColumn2.FieldName = "Status";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "DueDate";
            this.treeListColumn3.FieldName = "DueDate";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // Addtask
            // 
            this.Addtask.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.Addtask.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Addtask.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Addtask.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Addtask.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Addtask.Appearance.Options.UseBackColor = true;
            this.Addtask.Appearance.Options.UseBorderColor = true;
            this.Addtask.Appearance.Options.UseFont = true;
            this.Addtask.Appearance.Options.UseForeColor = true;
            this.Addtask.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtask.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.Addtask.AppearanceDisabled.Options.UseFont = true;
            this.Addtask.AppearanceDisabled.Options.UseForeColor = true;
            this.Addtask.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Addtask.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.Addtask.AppearanceHovered.Options.UseBackColor = true;
            this.Addtask.AppearanceHovered.Options.UseForeColor = true;
            this.Addtask.Location = new System.Drawing.Point(3, 147);
            this.Addtask.Name = "Addtask";
            this.Addtask.Size = new System.Drawing.Size(130, 29);
            this.Addtask.TabIndex = 2;
            this.Addtask.Text = "Add Task";
            this.Addtask.Click += new System.EventHandler(this.Addtask_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateStatus.Appearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdateStatus.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStatus.Appearance.Options.UseBackColor = true;
            this.btnUpdateStatus.Appearance.Options.UseBorderColor = true;
            this.btnUpdateStatus.Appearance.Options.UseFont = true;
            this.btnUpdateStatus.Appearance.Options.UseForeColor = true;
            this.btnUpdateStatus.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUpdateStatus.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.AppearanceDisabled.Options.UseFont = true;
            this.btnUpdateStatus.AppearanceDisabled.Options.UseForeColor = true;
            this.btnUpdateStatus.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateStatus.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdateStatus.AppearanceHovered.Options.UseForeColor = true;
            this.btnUpdateStatus.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateStatus.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.AppearancePressed.Options.UseBackColor = true;
            this.btnUpdateStatus.AppearancePressed.Options.UseForeColor = true;
            this.btnUpdateStatus.Location = new System.Drawing.Point(4, 223);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(129, 29);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "Update Status ";
            this.btnUpdateStatus.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // addtaskName
            // 
            this.addtaskName.Location = new System.Drawing.Point(139, 152);
            this.addtaskName.Name = "addtaskName";
            this.addtaskName.Size = new System.Drawing.Size(145, 23);
            this.addtaskName.TabIndex = 4;
            this.addtaskName.TextChanged += new System.EventHandler(this.addtaskName_TextChanged);
            // 
            // AdddateTimePicker1
            // 
            this.AdddateTimePicker1.Location = new System.Drawing.Point(430, 151);
            this.AdddateTimePicker1.Name = "AdddateTimePicker1";
            this.AdddateTimePicker1.Size = new System.Drawing.Size(184, 23);
            this.AdddateTimePicker1.TabIndex = 6;
            this.AdddateTimePicker1.ValueChanged += new System.EventHandler(this.AdddateTimePicker1_ValueChanged);
            // 
            // comboBoxaddteammember
            // 
            this.comboBoxaddteammember.FormattingEnabled = true;
            this.comboBoxaddteammember.Location = new System.Drawing.Point(622, 152);
            this.comboBoxaddteammember.Name = "comboBoxaddteammember";
            this.comboBoxaddteammember.Size = new System.Drawing.Size(103, 24);
            this.comboBoxaddteammember.TabIndex = 7;
            this.comboBoxaddteammember.SelectedIndexChanged += new System.EventHandler(this.comboBoxaddteammember_SelectedIndexChanged);
            // 
            // checkedComboxAddStatus
            // 
            this.checkedComboxAddStatus.EditValue = "";
            this.checkedComboxAddStatus.Location = new System.Drawing.Point(299, 152);
            this.checkedComboxAddStatus.Name = "checkedComboxAddStatus";
            this.checkedComboxAddStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboxAddStatus.Properties.DropDownRows = 2;
            this.checkedComboxAddStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Complete"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Inprogress")});
            this.checkedComboxAddStatus.Properties.SelectAllItemVisible = false;
            this.checkedComboxAddStatus.Properties.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.checkedComboxAddStatus.Size = new System.Drawing.Size(125, 22);
            this.checkedComboxAddStatus.TabIndex = 8;
            this.checkedComboxAddStatus.EditValueChanged += new System.EventHandler(this.checkedComboxAddStatus_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "     Task Name         ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "          Status       ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "   Due Date  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = " Team Member";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkedComboBoxUpdateStutes
            // 
            this.checkedComboBoxUpdateStutes.EditValue = "";
            this.checkedComboBoxUpdateStutes.Location = new System.Drawing.Point(299, 224);
            this.checkedComboBoxUpdateStutes.Name = "checkedComboBoxUpdateStutes";
            this.checkedComboBoxUpdateStutes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxUpdateStutes.Properties.DropDownRows = 2;
            this.checkedComboBoxUpdateStutes.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Complete"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Inprogress")});
            this.checkedComboBoxUpdateStutes.Properties.SelectAllItemVisible = false;
            this.checkedComboBoxUpdateStutes.Properties.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.checkedComboBoxUpdateStutes.Size = new System.Drawing.Size(125, 22);
            this.checkedComboBoxUpdateStutes.TabIndex = 14;
            this.checkedComboBoxUpdateStutes.EditValueChanged += new System.EventHandler(this.checkedComboBoxEdit2_EditValueChanged);
            // 
            // UpdatedateTimePicker2
            // 
            this.UpdatedateTimePicker2.Location = new System.Drawing.Point(430, 223);
            this.UpdatedateTimePicker2.Name = "UpdatedateTimePicker2";
            this.UpdatedateTimePicker2.Size = new System.Drawing.Size(184, 23);
            this.UpdatedateTimePicker2.TabIndex = 16;
            // 
            // comboBoxupdateteammember
            // 
            this.comboBoxupdateteammember.FormattingEnabled = true;
            this.comboBoxupdateteammember.Location = new System.Drawing.Point(622, 222);
            this.comboBoxupdateteammember.Name = "comboBoxupdateteammember";
            this.comboBoxupdateteammember.Size = new System.Drawing.Size(103, 24);
            this.comboBoxupdateteammember.TabIndex = 17;
            this.comboBoxupdateteammember.SelectedIndexChanged += new System.EventHandler(this.comboBoxupdateteammember_SelectedIndexChanged);
            // 
            // Get
            // 
            this.Get.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Get.Appearance.BorderColor = System.Drawing.Color.Black;
            this.Get.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Get.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.Get.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Get.Appearance.Options.UseBackColor = true;
            this.Get.Appearance.Options.UseBorderColor = true;
            this.Get.Appearance.Options.UseFont = true;
            this.Get.Appearance.Options.UseForeColor = true;
            this.Get.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Get.AppearanceDisabled.ForeColor = System.Drawing.Color.White;
            this.Get.AppearanceDisabled.Options.UseFont = true;
            this.Get.AppearanceDisabled.Options.UseForeColor = true;
            this.Get.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Get.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.Get.AppearanceHovered.Options.UseBackColor = true;
            this.Get.AppearanceHovered.Options.UseForeColor = true;
            this.Get.Location = new System.Drawing.Point(3, 284);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(130, 29);
            this.Get.TabIndex = 20;
            this.Get.Text = "Get ALL Task";
            this.Get.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = " Team Member";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.teammember});
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(477, 254, 321, 331);
            this.treeList1.Location = new System.Drawing.Point(139, 284);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(596, 107);
            this.treeList1.TabIndex = 22;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged_1);
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Task Name";
            this.treeListColumn4.FieldName = "TaskName";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 1;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Status";
            this.treeListColumn5.FieldName = "Status";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 2;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "DueDate";
            this.treeListColumn6.FieldName = "DueDate";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            // 
            // teammember
            // 
            this.teammember.Caption = "Team Member";
            this.teammember.FieldName = "MemeberName";
            this.teammember.Name = "teammember";
            this.teammember.Visible = true;
            this.teammember.VisibleIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 390);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.comboBoxupdateteammember);
            this.Controls.Add(this.UpdatedateTimePicker2);
            this.Controls.Add(this.checkedComboBoxUpdateStutes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedComboxAddStatus);
            this.Controls.Add(this.comboBoxaddteammember);
            this.Controls.Add(this.AdddateTimePicker1);
            this.Controls.Add(this.addtaskName);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.Addtask);
            this.Controls.Add(this.treeListTasks);
            this.Controls.Add(this.comboBoxTeamMembers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeListTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboxAddStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxUpdateStutes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeamMembers;
        private DevExpress.XtraTreeList.TreeList treeListTasks;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton Addtask;
        private DevExpress.XtraEditors.SimpleButton btnUpdateStatus;
        private System.Windows.Forms.TextBox addtaskName;
        private System.Windows.Forms.DateTimePicker AdddateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxaddteammember;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboxAddStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxUpdateStutes;
        private System.Windows.Forms.DateTimePicker UpdatedateTimePicker2;
        private System.Windows.Forms.ComboBox comboBoxupdateteammember;
        private DevExpress.XtraEditors.SimpleButton Get;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn teammember;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

