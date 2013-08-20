using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ControlsDesigns.BL;

namespace ControlsDesigns.UI
{
    public partial class NewEntry : Form
    {
        DataTable m_dtRole;
        DataTable m_dtDept;
        DataTable m_dtManager;
        public NewEntry()
        {
            InitializeComponent();
        }
        public void Execute()
        {
            Show();
        }
      
        private void btnOk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.Compare(txtName.Text.Trim(), "", false) == 0)
            {
                MessageBox.Show("Enter User ", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
                return;
            }
            else if (cboDept.EditValue == null)
            {
                MessageBox.Show("Select Department", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cboDept.Focus();
                return;
            }
            else if (ccboRole.EditValue == null)
            {
                MessageBox.Show("Select Department", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                ccboRole.Focus();
                return;
            }
            else if (String.Compare(txtSalary.Text.Trim(), "", false) == 0)
            {
                MessageBox.Show("Enter Password", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
                return;
            }

            else if (String.Compare(txtSalary.Text.Trim(), "", false) == 0)
            {
                MessageBox.Show("Enter Password", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtName.Focus();
                return;
            }
          
            else if (dtDob.EditValue == null)
            {
                MessageBox.Show("Select Date Of Birth", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                dtDob.Focus();
                return;
            }
          


            ConBL.Name = txtName.Text.Trim().ToString();
            ConBL.Dept = Convert.ToInt32(cboDept.EditValue);
            ConBL.Role = Convert.ToString(ccboRole.Text);
            ConBL.sex = Convert.ToInt32(rdoSex.SelectedIndex);
            ConBL.Salary = Convert.ToDecimal(txtSalary.Text);
            ConBL.Dob = Convert.ToDateTime(dtDob.EditValue);
            ConBL.Manager = Convert.ToInt32(cboManager.EditValue);
            if (ConBL.Insert_User() == true)
            {
                Clear_Controls();
                Fill_Manager();
                Fill_Dept();
                Fill_Role();
            }
        }
        public void Clear_Controls()
        {
            txtName.Text = "";
            dtDob.Text = "";
            txtSalary.Text = "";
            cboDept.EditValue = null;
            ccboRole.EditValue = null;
            cboManager.EditValue = null;
            Fill_Manager();
            Fill_Role();
            Fill_Dept();
            
        }

        private void Fill_Dept()
        {
            m_dtDept = new DataTable();
            m_dtDept = ConBL.Get_Dept();

            cboDept.Properties.DataSource = null;
            cboDept.Properties.Columns.Clear();

            cboDept.Properties.NullText = "--Select Department--";
            cboDept.Properties.DataSource = m_dtDept;
            cboDept.Properties.ForceInitialize();
            cboDept.Properties.PopulateColumns();
            cboDept.Properties.DisplayMember = "DepartmentName";
            cboDept.Properties.ValueMember = "DepartmentId";
            cboDept.Properties.Columns["DepartmentId"].Visible = false;
            cboDept.Properties.Columns["DepartmentName"].Visible = true;
        }
        private void Fill_Role()
        {
            m_dtRole = new DataTable();
            m_dtRole = ConBL.Get_Role();

            ccboRole.Properties.DataSource = null;
            //ccboRole.Properties.ForceUpdateEditValue();

            ccboRole.Properties.NullText = "--Select Role--";
            ccboRole.Properties.DataSource = m_dtRole;
           

            ccboRole.Properties.ValueMember = "Role";
           
        }
        private void Fill_Manager()
        {
            m_dtManager = new DataTable();
            m_dtManager = ConBL.Get_Manager();

            cboManager.Properties.DataSource = null;
            cboManager.Properties.Columns.Clear();

            cboManager.Properties.NullText = "--Select Manager--";
            cboManager.Properties.DataSource = m_dtManager;
            cboManager.Properties.ForceInitialize();
            cboManager.Properties.PopulateColumns();
            cboManager.Properties.DisplayMember = "Name";
            cboManager.Properties.ValueMember = "EmployeeId";
            cboManager.Properties.Columns["EmployeeId"].Visible = false;
            cboManager.Properties.Columns["Name"].Visible = true;
        }

        private void NewEntry_Load(object sender, EventArgs e)
        {
            Fill_Dept();
            Fill_Role();
            Fill_Manager();
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Clear_Controls();
            Fill_Manager();
            Fill_Dept();
            Fill_Role();
        }
       
    }
}
