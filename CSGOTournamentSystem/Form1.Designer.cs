namespace CSGOTournamentSystem
{
    partial class CTM
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTM));
            this.CSGOName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alert = new System.Windows.Forms.Label();
            this.panelTab = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CSGOName
            // 
            this.CSGOName.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CSGOName.ForeColor = System.Drawing.Color.White;
            this.CSGOName.Location = new System.Drawing.Point(28, 16);
            this.CSGOName.Name = "CSGOName";
            this.CSGOName.Size = new System.Drawing.Size(388, 78);
            this.CSGOName.TabIndex = 7;
            this.CSGOName.Text = "CSGO Tournament";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1509, 84);
            this.panel1.TabIndex = 8;
            // 
            // btnActive
            // 
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActive.ForeColor = System.Drawing.Color.White;
            this.btnActive.Image = ((System.Drawing.Image)(resources.GetObject("btnActive.Image")));
            this.btnActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActive.Location = new System.Drawing.Point(877, 0);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(217, 84);
            this.btnActive.TabIndex = 9;
            this.btnActive.Text = "Active";
            this.btnActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(1100, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(177, 84);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(445, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(209, 84);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(660, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(211, 84);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.CSGOName);
            this.panel2.Location = new System.Drawing.Point(-10, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 91);
            this.panel2.TabIndex = 6;
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.ForeColor = System.Drawing.Color.White;
            this.alert.Location = new System.Drawing.Point(319, 285);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(180, 23);
            this.alert.TabIndex = 6;
            this.alert.Text = "Invalid Username";
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTab.Location = new System.Drawing.Point(445, 82);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(209, 10);
            this.panelTab.TabIndex = 9;
            // 
            // CTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1509, 636);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.alert);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CTM";
            this.Text = "CSGO Tournament Maker";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label CSGOName;
        private Panel panel1;
        private Panel panel2;
        private Button btnHome;
        private Button btnCreate;
        private Button btnInfo;
        private Button btnActive;
        private Label alert;
        private Panel panelTab;
    }
}