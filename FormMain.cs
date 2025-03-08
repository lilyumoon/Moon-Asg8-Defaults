using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moon.Utility;

namespace Moon_Asg8_Defaults
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // TODO: configure VS to not create an event handler when double-selecting a control... :(

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadTenantListbox();
            setStyles();
        }

        private void setStyles()
        {
            ThemeManager.ApplyStyle(this, ThemeManager.Style.Primary);

            ThemeManager.ApplyStyle(groupBox_Navigation, ThemeManager.Style.Secondary);
            ThemeManager.ApplyStyle(listBox_Tenant, ThemeManager.Style.Secondary);

            ThemeManager.ApplyStyle(button_Defaults, ThemeManager.Style.AccentPrimary);
            ThemeManager.ApplyStyle(button_AddTenant, ThemeManager.Style.AccentPrimary);
            ThemeManager.ApplyStyle(button_EditTenant, ThemeManager.Style.AccentPrimary);
        }

        private void loadTenantListbox()
        {
            // clear any existing listbox items
            listBox_Tenant.Items.Clear();

            // retrieve the list of tenants from the DB
            List<Tenant> tenants = new List<Tenant>();
            tenants = SLRStaticDB.getTenants();

            // add each tenant object to the listbox as listbox items
            foreach (Tenant t in tenants)
            {
                listBox_Tenant.Items.Add(t);
            }
        }

        private void button_AddTenant_Click(object sender, EventArgs e)
        {
            // create a FormTenant form and show it modally
            FormTenant formTenant = new FormTenant();
            formTenant.ShowDialog();

            // when FormTenant form closes, if it contains data that should be saved,
            //  add the (new) tenant to the DB
            if (formTenant.DialogResult == DialogResult.OK)
            {
                SLRStaticDB.addTenant(formTenant.Tenant);

                // reload the tenant listbox because a new tenant was added to the DB
                loadTenantListbox();
            }
        }

        private void button_EditTenant_Click(object sender, EventArgs e)
        {
            // check if there is a listbox item selected
            if (listBox_Tenant.SelectedIndex > -1)
            {
                // extract tenant object from listbox selected item
                Tenant tenant = (Tenant)listBox_Tenant.SelectedItem;

                // create a FormTenant form, feed it the tenant, and show it modally
                FormTenant formTenant = new FormTenant(tenant);
                formTenant.ShowDialog();

                // when FormTenant form closes, if it contains data that should be saved,
                //  update the tenant in the DB
                if (formTenant.DialogResult == DialogResult.OK)
                {
                    SLRStaticDB.updateTenant(formTenant.Tenant);

                    // reload the tenant listbox because data may have been modified
                    loadTenantListbox();
                }
            }
        }

        private void button_Defaults_Click(object sender, EventArgs e)
        {
            FormDefaults formDefaults = new FormDefaults();
            formDefaults.ShowDialog();

            if (formDefaults.DialogResult == DialogResult.OK)
            {
                // save default settings
            }
        }
    }
}
