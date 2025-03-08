using Moon.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Asg8_Defaults
{
    public partial class FormTenant : Form
    {
        public Tenant Tenant { get => tenant; }

        private Tenant tenant;

        // default constructor, called when creating a new Tenant.
        //  sets this Tenant to a new tenant object. 
        public FormTenant()
        {
            InitializeComponent();
            this.tenant = new Tenant();
            initializeFields();
        }

        // parameter constructor, called when editing an existing Tenant.
        //  sets this Tenant to an existing tenant.
        public FormTenant(Tenant tenant)
        {
            InitializeComponent();
            this.tenant = tenant;
            initializeFields();
        }

        private void initializeFields()
        {
            if (tenant.ID > 0)
                textBox_Id.Text = tenant.ID.ToString();
            else textBox_Id.Text = string.Empty;

            textBox_FirstName.Text = tenant.FirstName ?? string.Empty;
            textBox_LastName.Text = tenant.LastName ?? string.Empty;
            textBox_City.Text = tenant.City;
            textBox_State.Text = tenant.State;
            textBox_Zip.Text = tenant.Zip;

            if (tenant.DateAdded.ToShortDateString() == "1/1/0001")
                textBox_DateAdded.Text = string.Empty;
            else textBox_DateAdded.Text = tenant.DateAdded.ToShortDateString();

            if (tenant.DateUpdated.ToShortDateString() == "1/1/0001")
                textBox_DateUpdated.Text = string.Empty;
            else textBox_DateUpdated.Text = tenant.DateUpdated.ToShortDateString();
        }

        private void FormTenant_Load(object sender, EventArgs e)
        {
            // set the theme
            Control[] buttons = { button_Save, button_Cancel };

            ThemeManager.ApplyStyle(this, ThemeManager.Style.Primary);
            ThemeManager.ApplyStyle(groupBox_Tenant, ThemeManager.Style.Secondary);
            ThemeManager.ApplyStyle(buttons, ThemeManager.Style.AccentPrimary);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_FirstName.Text))
                alert("Please enter a value for First Name.");
            else if (string.IsNullOrEmpty(textBox_LastName.Text))
                alert("Please enter a value for Last Name.");
            else if (string.IsNullOrEmpty(textBox_City.Text))
                alert("Please enter a value for City.");
            else if (string.IsNullOrEmpty(textBox_State.Text))
                alert("Please enter a value for State.");
            else if (string.IsNullOrEmpty(textBox_Zip.Text))
                alert("Please enter a value for Zip.");
            else
            {
                // update tenant values from form fields
                tenant.FirstName = textBox_FirstName.Text;
                tenant.LastName = textBox_LastName.Text;
                tenant.City = textBox_City.Text;
                tenant.State = textBox_State.Text;
                tenant.Zip = textBox_Zip.Text;

                // set DialogResult and close form
                this.DialogResult = DialogResult.OK;
            }
        }

        private void alert(string msg)
        {
            MessageBox.Show(msg, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
