namespace Portfolio
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTechnologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTechnologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTechnologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PortfolioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProjectsToolStripMenuItem,
            this.PortfolioToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ProjectsToolStripMenuItem
            // 
            this.ProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTechnologyToolStripMenuItem,
            this.addProjectToolStripMenuItem,
            this.modifyTechnologyToolStripMenuItem,
            this.modifyProjectToolStripMenuItem,
            this.deleteTechnologyToolStripMenuItem,
            this.deleteProjectToolStripMenuItem});
            this.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem";
            this.ProjectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ProjectsToolStripMenuItem.Text = "Projects";
            // 
            // addTechnologyToolStripMenuItem
            // 
            this.addTechnologyToolStripMenuItem.Name = "addTechnologyToolStripMenuItem";
            this.addTechnologyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTechnologyToolStripMenuItem.Text = "Add technology";
            this.addTechnologyToolStripMenuItem.Click += new System.EventHandler(this.addTechnologyToolStripMenuItem_Click_1);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProjectToolStripMenuItem.Text = "Add project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click_1);
            // 
            // modifyTechnologyToolStripMenuItem
            // 
            this.modifyTechnologyToolStripMenuItem.Name = "modifyTechnologyToolStripMenuItem";
            this.modifyTechnologyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyTechnologyToolStripMenuItem.Text = "Modify technology";
            this.modifyTechnologyToolStripMenuItem.Click += new System.EventHandler(this.modifyTechnologyToolStripMenuItem_Click);
            // 
            // modifyProjectToolStripMenuItem
            // 
            this.modifyProjectToolStripMenuItem.Name = "modifyProjectToolStripMenuItem";
            this.modifyProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyProjectToolStripMenuItem.Text = "Modify project";
            this.modifyProjectToolStripMenuItem.Click += new System.EventHandler(this.modifyProjectToolStripMenuItem_Click);
            // 
            // deleteTechnologyToolStripMenuItem
            // 
            this.deleteTechnologyToolStripMenuItem.Name = "deleteTechnologyToolStripMenuItem";
            this.deleteTechnologyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteTechnologyToolStripMenuItem.Text = "Delete technology";
            this.deleteTechnologyToolStripMenuItem.Click += new System.EventHandler(this.deleteTechnologyToolStripMenuItem_Click);
            // 
            // deleteProjectToolStripMenuItem
            // 
            this.deleteProjectToolStripMenuItem.Name = "deleteProjectToolStripMenuItem";
            this.deleteProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteProjectToolStripMenuItem.Text = "Delete project";
            this.deleteProjectToolStripMenuItem.Click += new System.EventHandler(this.deleteProjectToolStripMenuItem_Click);
            // 
            // PortfolioToolStripMenuItem
            // 
            this.PortfolioToolStripMenuItem.Name = "PortfolioToolStripMenuItem";
            this.PortfolioToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.PortfolioToolStripMenuItem.Text = "Portfolio";
            this.PortfolioToolStripMenuItem.Click += new System.EventHandler(this.PortfolioToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.iesireToolStripMenuItem.Text = "Exit";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(135, 64);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 20);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(135, 96);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 206);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Portfolio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PortfolioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTechnologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem modifyTechnologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTechnologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProjectToolStripMenuItem;
    }
}

