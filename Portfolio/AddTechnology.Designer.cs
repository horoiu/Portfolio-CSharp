namespace Portfolio
{
    partial class AddTechnology
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
            this.labelTechnology = new System.Windows.Forms.Label();
            this.textBoxTechnology = new System.Windows.Forms.TextBox();
            this.buttonAddTehnology = new System.Windows.Forms.Button();
            this.buttonCancelTechnology = new System.Windows.Forms.Button();
            this.listBoxTechnologies = new System.Windows.Forms.ListBox();
            this.labelTechnologiesList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTechnology
            // 
            this.labelTechnology.AutoSize = true;
            this.labelTechnology.Location = new System.Drawing.Point(36, 254);
            this.labelTechnology.Name = "labelTechnology";
            this.labelTechnology.Size = new System.Drawing.Size(63, 13);
            this.labelTechnology.TabIndex = 0;
            this.labelTechnology.Text = "Technology";
            // 
            // textBoxTechnology
            // 
            this.textBoxTechnology.Location = new System.Drawing.Point(114, 251);
            this.textBoxTechnology.Name = "textBoxTechnology";
            this.textBoxTechnology.Size = new System.Drawing.Size(157, 20);
            this.textBoxTechnology.TabIndex = 1;
            // 
            // buttonAddTehnology
            // 
            this.buttonAddTehnology.Location = new System.Drawing.Point(49, 294);
            this.buttonAddTehnology.Name = "buttonAddTehnology";
            this.buttonAddTehnology.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTehnology.TabIndex = 2;
            this.buttonAddTehnology.Text = "Add";
            this.buttonAddTehnology.UseVisualStyleBackColor = true;
            // 
            // buttonCancelTechnology
            // 
            this.buttonCancelTechnology.Location = new System.Drawing.Point(168, 293);
            this.buttonCancelTechnology.Name = "buttonCancelTechnology";
            this.buttonCancelTechnology.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTechnology.TabIndex = 3;
            this.buttonCancelTechnology.Text = "Cancel";
            this.buttonCancelTechnology.UseVisualStyleBackColor = true;
            // 
            // listBoxTechnologies
            // 
            this.listBoxTechnologies.FormattingEnabled = true;
            this.listBoxTechnologies.Location = new System.Drawing.Point(39, 33);
            this.listBoxTechnologies.Name = "listBoxTechnologies";
            this.listBoxTechnologies.Size = new System.Drawing.Size(232, 173);
            this.listBoxTechnologies.TabIndex = 4;
            // 
            // labelTechnologiesList
            // 
            this.labelTechnologiesList.AutoSize = true;
            this.labelTechnologiesList.Location = new System.Drawing.Point(36, 9);
            this.labelTechnologiesList.Name = "labelTechnologiesList";
            this.labelTechnologiesList.Size = new System.Drawing.Size(121, 13);
            this.labelTechnologiesList.TabIndex = 5;
            this.labelTechnologiesList.Text = "Present technologies list";
            // 
            // AddTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 348);
            this.Controls.Add(this.labelTechnologiesList);
            this.Controls.Add(this.listBoxTechnologies);
            this.Controls.Add(this.buttonCancelTechnology);
            this.Controls.Add(this.buttonAddTehnology);
            this.Controls.Add(this.textBoxTechnology);
            this.Controls.Add(this.labelTechnology);
            this.Name = "AddTechnology";
            this.Text = "Add New Technology";
            this.Load += new System.EventHandler(this.AddTechnology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTechnology;
        private System.Windows.Forms.TextBox textBoxTechnology;
        private System.Windows.Forms.Button buttonAddTehnology;
        private System.Windows.Forms.Button buttonCancelTechnology;
        private System.Windows.Forms.ListBox listBoxTechnologies;
        private System.Windows.Forms.Label labelTechnologiesList;
    }
}