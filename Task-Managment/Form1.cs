using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;
using DevExpress.XtraEditors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.Xpo.DB.Helpers;
namespace Task_Managment
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private readonly string connectionString = "Data Source=.;Initial Catalog=Task_ManagmentSystem;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            LoadTeamMembers();
            this.BackColor = Color.FromArgb(227, 242, 253);
        }

        private void comboBoxTeamMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTeamMembers.SelectedValue != null)
            {
                // Cast the SelectedValue to a DataRowView
                DataRowView selectedRow = comboBoxTeamMembers.SelectedItem as DataRowView;

                // Extract the MemberId from the DataRowView
                int memberId = Convert.ToInt32(selectedRow["MemberId"]);

                LoadTasks(memberId);
            }
        }
        private DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        private void LoadTasks(int memberId)
        {
            string query = "SELECT TaskId, TaskName, Status, DueDate FROM task WHERE MemberId = @MemberId";
            SqlParameter[] parameters = { new SqlParameter("@MemberId", memberId) };
            DataTable dt = ExecuteQuery(query, parameters);

            treeListTasks.DataSource = dt;
        }



        private void treeListTasks_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void Addtask_Click(object sender, EventArgs e)
        {
            // take values from text and use it to save 
            string taskName = addtaskName.Text.Trim().ToLower();
            string taskStatus = checkedComboxAddStatus.Text.Trim();
            DateTime dueDate = AdddateTimePicker1.Value;
            int selectedMemberId = Convert.ToInt32(comboBoxaddteammember.SelectedValue);
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please enter a task name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(taskStatus))
            {
                MessageBox.Show("Please select a task status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedMemberId == null)
            {
                MessageBox.Show("Please select a valid team member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           /* if (dueDate <= DateTime.Now)
            {
                MessageBox.Show("Due date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            string query = "INSERT INTO Task (TaskName, Status, DueDate, MemberId) VALUES (@TaskName, @Status, @DueDate, @MemberId)";
            SqlParameter[] parameters = {
        new SqlParameter("@TaskName", taskName),
        new SqlParameter("@Status", taskStatus),
        new SqlParameter("@DueDate", dueDate),
        new SqlParameter("@MemberId", selectedMemberId)
    };

            ExecuteQuery(query, parameters);
            MessageBox.Show("Task added successfully!");

            LoadTasks(selectedMemberId);
        }


        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }
        // to load member names in combox
        private void LoadTeamMembers()
        {
            string query = "SELECT MemberId, MemeberName FROM TeamMembers";
            DataTable dt = ExecuteQuery(query);

            // Set the DataSource only once for each ComboBox
            comboBoxTeamMembers.DataSource = dt;
            comboBoxTeamMembers.DisplayMember = "MemeberName";
            comboBoxTeamMembers.ValueMember = "MemberId";

            comboBoxaddteammember.DataSource = dt.Copy(); 
            comboBoxaddteammember.DisplayMember = "MemeberName";
            comboBoxaddteammember.ValueMember = "MemberId";

            comboBoxaddteammember.DataSource = dt.Copy();
            comboBoxupdateteammember.DisplayMember = "MemeberName";
            comboBoxupdateteammember.ValueMember = "MemberId";
        }




        private void addtaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedComboBoxEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedComboxAddStatus_EditValueChanged(object sender, EventArgs e)
        {

        }
        // Button Get All Tasks
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadAllTasks();
        }
        private void LoadAllTasks()
        {
            string query = "SELECT t.TaskId, t.TaskName, t.Status, t.DueDate, tm.MemeberName FROM task t JOIN TeamMembers tm ON t.MemberId = tm.MemberId";
            DataTable dt = ExecuteQuery(query);

            treeList1.DataSource = dt;
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        private void comboBoxUpdatetaskName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeList1_FocusedNodeChanged_1(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            
        }

        private void AdddateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxaddteammember_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBoxupdateteammember_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletetask_Click_2(object sender, EventArgs e)
        {
            string taskName = detetetask.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please enter a task name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "delete from task where TaskName=taskName";
            SqlParameter[] parameters = {
                new SqlParameter("@TaskName", taskName)
            };
            ExecuteQuery(query, parameters);
            MessageBox.Show("Task Deleted successfully!");

        }

        private void datetetask_TextChanged(object sender, EventArgs e)
        {

        }

        private void addmember_Click_2(object sender, EventArgs e)
        {
            string memberName= membername.Text.Trim();
            if (string.IsNullOrEmpty(memberName))
            {
                MessageBox.Show("plz enter member name","Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string query = "insert into TeamMembers (MemeberName)values (@MemeberName)";
            SqlParameter[] parameters = {
        new SqlParameter("@MemeberName", memberName) };
           ExecuteQuery(query, parameters);
            MessageBox.Show("member add successfully!");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}