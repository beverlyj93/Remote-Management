namespace Remote_Management
{
    partial class frmDialog
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.NewHire = new MetroFramework.Controls.MetroTabPage();
            this.Termination = new MetroFramework.Controls.MetroTabPage();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.txtLastName = new MetroFramework.Controls.MetroTextBox();
            this.cbDomains = new MetroFramework.Controls.MetroComboBox();
            this.cbTitle = new MetroFramework.Controls.MetroComboBox();
            this.cbProperty = new MetroFramework.Controls.MetroComboBox();
            this.btnHire = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.NewHire.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.NewHire);
            this.metroTabControl1.Controls.Add(this.Termination);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(252, 236);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // NewHire
            // 
            this.NewHire.Controls.Add(this.btnHire);
            this.NewHire.Controls.Add(this.cbProperty);
            this.NewHire.Controls.Add(this.cbTitle);
            this.NewHire.Controls.Add(this.cbDomains);
            this.NewHire.Controls.Add(this.txtLastName);
            this.NewHire.Controls.Add(this.txtFirstName);
            this.NewHire.HorizontalScrollbarBarColor = true;
            this.NewHire.HorizontalScrollbarHighlightOnWheel = false;
            this.NewHire.HorizontalScrollbarSize = 10;
            this.NewHire.Location = new System.Drawing.Point(4, 38);
            this.NewHire.Name = "NewHire";
            this.NewHire.Size = new System.Drawing.Size(244, 194);
            this.NewHire.TabIndex = 0;
            this.NewHire.Text = "New Hire";
            this.NewHire.VerticalScrollbarBarColor = true;
            this.NewHire.VerticalScrollbarHighlightOnWheel = false;
            this.NewHire.VerticalScrollbarSize = 10;
            // 
            // Termination
            // 
            this.Termination.HorizontalScrollbarBarColor = true;
            this.Termination.HorizontalScrollbarHighlightOnWheel = false;
            this.Termination.HorizontalScrollbarSize = 10;
            this.Termination.Location = new System.Drawing.Point(4, 38);
            this.Termination.Name = "Termination";
            this.Termination.Size = new System.Drawing.Size(752, 328);
            this.Termination.TabIndex = 1;
            this.Termination.Text = "Termination";
            this.Termination.VerticalScrollbarBarColor = true;
            this.Termination.VerticalScrollbarHighlightOnWheel = false;
            this.Termination.VerticalScrollbarSize = 10;
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(3, 3);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PromptText = "First Name";
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.ShortcutsEnabled = true;
            this.txtFirstName.Size = new System.Drawing.Size(231, 23);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMark = "First Name";
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLastName
            // 
            // 
            // 
            // 
            this.txtLastName.CustomButton.Image = null;
            this.txtLastName.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtLastName.CustomButton.Name = "";
            this.txtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName.CustomButton.TabIndex = 1;
            this.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName.CustomButton.UseSelectable = true;
            this.txtLastName.CustomButton.Visible = false;
            this.txtLastName.Lines = new string[0];
            this.txtLastName.Location = new System.Drawing.Point(3, 32);
            this.txtLastName.MaxLength = 32767;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PromptText = "Last Name";
            this.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.ShortcutsEnabled = true;
            this.txtLastName.Size = new System.Drawing.Size(231, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.UseSelectable = true;
            this.txtLastName.WaterMark = "Last Name";
            this.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbDomains
            // 
            this.cbDomains.FormattingEnabled = true;
            this.cbDomains.ItemHeight = 23;
            this.cbDomains.Location = new System.Drawing.Point(3, 61);
            this.cbDomains.Name = "cbDomains";
            this.cbDomains.PromptText = "Domain";
            this.cbDomains.Size = new System.Drawing.Size(231, 29);
            this.cbDomains.TabIndex = 4;
            this.cbDomains.UseSelectable = true;
            // 
            // cbTitle
            // 
            this.cbTitle.DisplayMember = "(none)";
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.ItemHeight = 23;
            this.cbTitle.Items.AddRange(new object[] {
            "Regional Manager",
            "General Manager",
            "Marketing Manager",
            "Area Marketing Manager",
            "Leasing Manager",
            "Resident Services Manager",
            "Housing Consultant",
            "Maintenance Technician",
            "Maintenance Supervisor"});
            this.cbTitle.Location = new System.Drawing.Point(3, 96);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.PromptText = "Title";
            this.cbTitle.Size = new System.Drawing.Size(231, 29);
            this.cbTitle.TabIndex = 5;
            this.cbTitle.UseSelectable = true;
            // 
            // cbProperty
            // 
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.ItemHeight = 23;
            this.cbProperty.Location = new System.Drawing.Point(3, 131);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.PromptText = "Property";
            this.cbProperty.Size = new System.Drawing.Size(231, 29);
            this.cbProperty.TabIndex = 6;
            this.cbProperty.UseSelectable = true;
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(3, 166);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(231, 23);
            this.btnHire.TabIndex = 7;
            this.btnHire.Text = "Hire Employee";
            this.btnHire.UseSelectable = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 316);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmDialog";
            this.Text = "Remote Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDialog_FormClosing);
            this.Load += new System.EventHandler(this.frmDialog_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.NewHire.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage NewHire;
        private MetroFramework.Controls.MetroTabPage Termination;
        private MetroFramework.Controls.MetroButton btnHire;
        private MetroFramework.Controls.MetroComboBox cbProperty;
        private MetroFramework.Controls.MetroComboBox cbTitle;
        private MetroFramework.Controls.MetroComboBox cbDomains;
        private MetroFramework.Controls.MetroTextBox txtLastName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
    }
}

