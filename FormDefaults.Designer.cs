namespace Moon_Asg8_Defaults
{
    partial class FormDefaults
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
            this.groupBox_Defaults = new System.Windows.Forms.GroupBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_State = new System.Windows.Forms.TextBox();
            this.textBox_Zip = new System.Windows.Forms.TextBox();
            this.textBox_ApiKey = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_City = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.label_Zip = new System.Windows.Forms.Label();
            this.label_ApiKey = new System.Windows.Forms.Label();
            this.groupBox_Defaults.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Defaults
            // 
            this.groupBox_Defaults.Controls.Add(this.label_ApiKey);
            this.groupBox_Defaults.Controls.Add(this.label_Zip);
            this.groupBox_Defaults.Controls.Add(this.label_State);
            this.groupBox_Defaults.Controls.Add(this.label_City);
            this.groupBox_Defaults.Controls.Add(this.textBox_ApiKey);
            this.groupBox_Defaults.Controls.Add(this.textBox_Zip);
            this.groupBox_Defaults.Controls.Add(this.textBox_State);
            this.groupBox_Defaults.Controls.Add(this.textBox_City);
            this.groupBox_Defaults.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Defaults.Name = "groupBox_Defaults";
            this.groupBox_Defaults.Size = new System.Drawing.Size(309, 229);
            this.groupBox_Defaults.TabIndex = 0;
            this.groupBox_Defaults.TabStop = false;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(91, 32);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(200, 20);
            this.textBox_City.TabIndex = 0;
            // 
            // textBox_State
            // 
            this.textBox_State.Location = new System.Drawing.Point(91, 78);
            this.textBox_State.Name = "textBox_State";
            this.textBox_State.Size = new System.Drawing.Size(200, 20);
            this.textBox_State.TabIndex = 1;
            // 
            // textBox_Zip
            // 
            this.textBox_Zip.Location = new System.Drawing.Point(91, 125);
            this.textBox_Zip.Name = "textBox_Zip";
            this.textBox_Zip.Size = new System.Drawing.Size(200, 20);
            this.textBox_Zip.TabIndex = 2;
            // 
            // textBox_ApiKey
            // 
            this.textBox_ApiKey.Location = new System.Drawing.Point(91, 175);
            this.textBox_ApiKey.Name = "textBox_ApiKey";
            this.textBox_ApiKey.Size = new System.Drawing.Size(200, 20);
            this.textBox_ApiKey.TabIndex = 3;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(241, 249);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(160, 249);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(58, 35);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(27, 13);
            this.label_City.TabIndex = 4;
            this.label_City.Text = "City:";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(50, 78);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(35, 13);
            this.label_State.TabIndex = 5;
            this.label_State.Text = "State:";
            // 
            // label_Zip
            // 
            this.label_Zip.AutoSize = true;
            this.label_Zip.Location = new System.Drawing.Point(60, 125);
            this.label_Zip.Name = "label_Zip";
            this.label_Zip.Size = new System.Drawing.Size(25, 13);
            this.label_Zip.TabIndex = 6;
            this.label_Zip.Text = "Zip:";
            // 
            // label_ApiKey
            // 
            this.label_ApiKey.AutoSize = true;
            this.label_ApiKey.Location = new System.Drawing.Point(37, 178);
            this.label_ApiKey.Name = "label_ApiKey";
            this.label_ApiKey.Size = new System.Drawing.Size(48, 13);
            this.label_ApiKey.TabIndex = 7;
            this.label_ApiKey.Text = "API Key:";
            // 
            // FormDefaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 283);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.groupBox_Defaults);
            this.Controls.Add(this.button_Save);
            this.Name = "FormDefaults";
            this.Text = "Default Values";
            this.Load += new System.EventHandler(this.FormDefaults_Load);
            this.groupBox_Defaults.ResumeLayout(false);
            this.groupBox_Defaults.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Defaults;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_ApiKey;
        private System.Windows.Forms.TextBox textBox_Zip;
        private System.Windows.Forms.TextBox textBox_State;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label label_ApiKey;
        private System.Windows.Forms.Label label_Zip;
        private System.Windows.Forms.Label label_State;
    }
}