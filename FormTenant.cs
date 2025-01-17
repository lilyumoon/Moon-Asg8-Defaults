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
        private Tenant tenant;

        public FormTenant()
        {
            InitializeComponent();
        }

        public FormTenant(Tenant tenant)
        {
            InitializeComponent();
            this.tenant = tenant;
        }

        private void FormTenant_Load(object sender, EventArgs e)
        {
            Control[] buttons = { button_Save, button_Cancel };

            ThemeManager.ApplyStyle(this, ThemeManager.Style.Primary);
            ThemeManager.ApplyStyle(groupBox_Tenant, ThemeManager.Style.Secondary);
            ThemeManager.ApplyStyle(buttons, ThemeManager.Style.AccentPrimary);
        }

    }
}
