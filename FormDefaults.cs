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
    public partial class FormDefaults : Form
    {
        public FormDefaults()
        {
            InitializeComponent();
        }

        private void FormDefaults_Load(object sender, EventArgs e)
        {
            setStyles();
        }

        private void setStyles()
        {
            Control[] buttons = { button_Save, button_Cancel };

            ThemeManager.ApplyStyle(this, ThemeManager.Style.Primary);
            ThemeManager.ApplyStyle(groupBox_Defaults, ThemeManager.Style.Secondary);
            ThemeManager.ApplyStyle(buttons, ThemeManager.Style.AccentPrimary);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
