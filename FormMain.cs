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
            listBox_Tenant.Items.Clear();

            List<Tenant> tenants = new List<Tenant>();
            tenants = SLRStaticDB.getTenants();

            foreach (Tenant t in tenants)
            {
                listBox_Tenant.Items.Add(t);
            }
        }

        private void button_AddTenant_Click(object sender, EventArgs e)
        {

        }

        private void button_EditTenant_Click(object sender, EventArgs e)
        {

        }
    }
}
