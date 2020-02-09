namespace Portfolio
{
    partial class DeleteTechnology
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
            this.labelDeleteTechnologies = new System.Windows.Forms.Label();
            this.buttonDeleteTechnologies = new System.Windows.Forms.Button();
            this.buttonCancelTechnologies = new System.Windows.Forms.Button();
            this.checkedListBoxDeleteTechnologies = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelDeleteTechnologies
            // 
            this.labelDeleteTechnologies.AutoSize = true;
            this.labelDeleteTechnologies.Location = new System.Drawing.Point(26, 24);
            this.labelDeleteTechnologies.Name = "labelDeleteTechnologies";
            this.labelDeleteTechnologies.Size = new System.Drawing.Size(121, 13);
            this.labelDeleteTechnologies.TabIndex = 0;
            this.labelDeleteTechnologies.Text = "Present technologies list";
            // 
            // buttonDeleteTechnologies
            // 
            this.buttonDeleteTechnologies.Location = new System.Drawing.Point(29, 263);
            this.buttonDeleteTechnologies.Name = "buttonDeleteTechnologies";
            this.buttonDeleteTechnologies.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTechnologies.TabIndex = 2;
            this.buttonDeleteTechnologies.Text = "Delete";
            this.buttonDeleteTechnologies.UseVisualStyleBackColor = true;
            this.buttonDeleteTechnologies.Click += new System.EventHandler(this.buttonDeleteTechnologies_Click);
            // 
            // buttonCancelTechnologies
            // 
            this.buttonCancelTechnologies.Location = new System.Drawing.Point(151, 262);
            this.buttonCancelTechnologies.Name = "buttonCancelTechnologies";
            this.buttonCancelTechnologies.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelTechnologies.TabIndex = 3;
            this.buttonCancelTechnologies.Text = "Cancel";
            this.buttonCancelTechnologies.UseVisualStyleBackColor = true;
            this.buttonCancelTechnologies.Click += new System.EventHandler(this.buttonCancelTechnologies_Click);
            // 
            // checkedListBoxDeleteTechnologies
            // 
            this.checkedListBoxDeleteTechnologies.FormattingEnabled = true;
            this.checkedListBoxDeleteTechnologies.Location = new System.Drawing.Point(29, 49);
            this.checkedListBoxDeleteTechnologies.Name = "checkedListBoxDeleteTechnologies";
            this.checkedListBoxDeleteTechnologies.Size = new System.Drawing.Size(198, 169);
            this.checkedListBoxDeleteTechnologies.TabIndex = 1;
            // 
            // DeleteTechnology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 308);
            this.Controls.Add(this.buttonCancelTechnologies);
            this.Controls.Add(this.buttonDeleteTechnologies);
            this.Controls.Add(this.checkedListBoxDeleteTechnologies);
            this.Controls.Add(this.labelDeleteTechnologies);
            this.Name = "DeleteTechnology";
            this.Text = "DeleteTechnology";
            this.Load += new System.EventHandler(this.DeleteTechnology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeleteTechnologies;
        private System.Windows.Forms.Button buttonDeleteTechnologies;
        private System.Windows.Forms.Button buttonCancelTechnologies;
        private System.Windows.Forms.CheckedListBox checkedListBoxDeleteTechnologies;
    }
}