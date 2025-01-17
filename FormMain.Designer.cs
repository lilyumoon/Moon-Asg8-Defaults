namespace Moon_Asg8_Defaults
{
    partial class FormMain
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
            this.listBox_Tenant = new System.Windows.Forms.ListBox();
            this.button_Defaults = new System.Windows.Forms.Button();
            this.button_AddTenant = new System.Windows.Forms.Button();
            this.button_EditTenant = new System.Windows.Forms.Button();
            this.groupBox_Navigation = new System.Windows.Forms.GroupBox();
            this.groupBox_Navigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Tenant
            // 
            this.listBox_Tenant.FormattingEnabled = true;
            this.listBox_Tenant.Location = new System.Drawing.Point(179, 55);
            this.listBox_Tenant.Name = "listBox_Tenant";
            this.listBox_Tenant.Size = new System.Drawing.Size(267, 303);
            this.listBox_Tenant.TabIndex = 0;
            // 
            // button_Defaults
            // 
            this.button_Defaults.Location = new System.Drawing.Point(14, 139);
            this.button_Defaults.Name = "button_Defaults";
            this.button_Defaults.Size = new System.Drawing.Size(100, 40);
            this.button_Defaults.TabIndex = 1;
            this.button_Defaults.Text = "Defaults";
            this.button_Defaults.UseVisualStyleBackColor = true;
            // 
            // button_AddTenant
            // 
            this.button_AddTenant.Location = new System.Drawing.Point(14, 78);
            this.button_AddTenant.Name = "button_AddTenant";
            this.button_AddTenant.Size = new System.Drawing.Size(100, 40);
            this.button_AddTenant.TabIndex = 2;
            this.button_AddTenant.Text = "Add Tenant";
            this.button_AddTenant.UseVisualStyleBackColor = true;
            this.button_AddTenant.Click += new System.EventHandler(this.button_AddTenant_Click);
            // 
            // button_EditTenant
            // 
            this.button_EditTenant.Location = new System.Drawing.Point(14, 19);
            this.button_EditTenant.Name = "button_EditTenant";
            this.button_EditTenant.Size = new System.Drawing.Size(100, 40);
            this.button_EditTenant.TabIndex = 3;
            this.button_EditTenant.Text = "Edit Tenant";
            this.button_EditTenant.UseVisualStyleBackColor = true;
            this.button_EditTenant.Click += new System.EventHandler(this.button_EditTenant_Click);
            // 
            // groupBox_Navigation
            // 
            this.groupBox_Navigation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox_Navigation.Controls.Add(this.button_AddTenant);
            this.groupBox_Navigation.Controls.Add(this.button_EditTenant);
            this.groupBox_Navigation.Controls.Add(this.button_Defaults);
            this.groupBox_Navigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_Navigation.Location = new System.Drawing.Point(16, 48);
            this.groupBox_Navigation.Name = "groupBox_Navigation";
            this.groupBox_Navigation.Size = new System.Drawing.Size(128, 200);
            this.groupBox_Navigation.TabIndex = 4;
            this.groupBox_Navigation.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Navigation);
            this.Controls.Add(this.listBox_Tenant);
            this.Name = "FormMain";
            this.Text = "Moon Defaults Demo";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_Navigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Tenant;
        private System.Windows.Forms.Button button_Defaults;
        private System.Windows.Forms.Button button_AddTenant;
        private System.Windows.Forms.Button button_EditTenant;
        private System.Windows.Forms.GroupBox groupBox_Navigation;
    }
}

