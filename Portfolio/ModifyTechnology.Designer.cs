namespace Portfolio
{
    partial class ModifyTechnology
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
            this.labelSelectTechnology = new System.Windows.Forms.Label();
            this.labelNewTechnology = new System.Windows.Forms.Label();
            this.comboBoxTehnology = new System.Windows.Forms.ComboBox();
            this.textBoxTehnology = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectTechnology
            // 
            this.labelSelectTechnology.AutoSize = true;
            this.labelSelectTechnology.Location = new System.Drawing.Point(24, 36);
            this.labelSelectTechnology.Name = "labelSelectTechnology";
            this.labelSelectTechnology.Size = new System.Drawing.Size(86, 13);
            this.labelSelectTechnology.TabIndex = 0;
            this.labelSelectTechnology.Text = "Select tehnology";
            // 
            // labelNewTechnology
            // 
            this.labelNewTechnology.AutoSize = true;
            this.labelNewTechnology.Location = new System.Drawing.Point(26, 81);
            this.labelNewTechnology.Name = "labelNewTechnology";
            this.labelNewTechnology.Size = new System.Drawing.Size(84, 13);
            this.labelNewTechnology.TabIndex = 1;
            this.labelNewTechnology.Text = "New technology";
            // 
            // comboBoxTehnology
            // 
            this.comboBoxTehnology.FormattingEnabled = true;
            this.comboBoxTehnology.Location = new System.Drawing.Point(131, 33);
            this.comboBoxTehnology.Name = "comboBoxTehnology";
            this.comboBoxTehnology.Size = new System.Drawing.Size(166, 21);
            this.comboBoxTehnology.TabIndex = 2;
            this.comboBoxTehnology.SelectionChangeCommitted += new System.EventHandler(this.getIdTechnology);
            // 
            // textBoxTehnology
            // 
            this.textBoxTehnology.Location = new System.Drawing.Point(131, 78);
            this.textBoxTehnology.Name = "textBoxTehnology";
            this.textBoxTehnology.Size = new System.Drawing.Size(166, 20);
            this.textBoxTehnology.TabIndex = 3;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(59, 138);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(75, 23);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 138);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ModifyTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 193);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxTehnology);
            this.Controls.Add(this.comboBoxTehnology);
            this.Controls.Add(this.labelNewTechnology);
            this.Controls.Add(this.labelSelectTechnology);
            this.Name = "ModifyTechnology";
            this.Text = "ModifyTechnology";
            this.Load += new System.EventHandler(this.ModifyTechnology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectTechnology;
        private System.Windows.Forms.Label labelNewTechnology;
        private System.Windows.Forms.ComboBox comboBoxTehnology;
        private System.Windows.Forms.TextBox textBoxTehnology;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonCancel;
    }
}