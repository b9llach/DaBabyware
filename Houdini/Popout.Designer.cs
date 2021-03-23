namespace Houdini
{
    partial class Popout
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
            this.weapon_label = new System.Windows.Forms.Label();
            this.scope_label = new System.Windows.Forms.Label();
            this.a_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.active_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weapon_label
            // 
            this.weapon_label.AutoSize = true;
            this.weapon_label.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.weapon_label.ForeColor = System.Drawing.Color.White;
            this.weapon_label.Location = new System.Drawing.Point(3, 6);
            this.weapon_label.Name = "weapon_label";
            this.weapon_label.Size = new System.Drawing.Size(62, 15);
            this.weapon_label.TabIndex = 0;
            this.weapon_label.Text = "Weapon: ";
            this.weapon_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // scope_label
            // 
            this.scope_label.AutoSize = true;
            this.scope_label.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.scope_label.ForeColor = System.Drawing.Color.White;
            this.scope_label.Location = new System.Drawing.Point(3, 28);
            this.scope_label.Name = "scope_label";
            this.scope_label.Size = new System.Drawing.Size(49, 15);
            this.scope_label.TabIndex = 1;
            this.scope_label.Text = "Scope: ";
            this.scope_label.Click += new System.EventHandler(this.scope_label_Click);
            // 
            // a_label
            // 
            this.a_label.AutoSize = true;
            this.a_label.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.a_label.ForeColor = System.Drawing.Color.White;
            this.a_label.Location = new System.Drawing.Point(3, 50);
            this.a_label.Name = "a_label";
            this.a_label.Size = new System.Drawing.Size(82, 15);
            this.a_label.TabIndex = 2;
            this.a_label.Text = "Attachment: ";
            this.a_label.Click += new System.EventHandler(this.a_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Houdini.Properties.Resources.dababy_darker;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.active_label);
            this.panel1.Controls.Add(this.a_label);
            this.panel1.Controls.Add(this.weapon_label);
            this.panel1.Controls.Add(this.scope_label);
            this.panel1.Location = new System.Drawing.Point(-2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 120);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blatant: ";
            // 
            // active_label
            // 
            this.active_label.AutoSize = true;
            this.active_label.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.active_label.ForeColor = System.Drawing.Color.White;
            this.active_label.Location = new System.Drawing.Point(3, 71);
            this.active_label.Name = "active_label";
            this.active_label.Size = new System.Drawing.Size(49, 15);
            this.active_label.TabIndex = 3;
            this.active_label.Text = "Active: ";
            // 
            // Popout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(212, 124);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Popout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Popout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Popout_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Popout_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Popout_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Popout_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label weapon_label;
        public System.Windows.Forms.Label scope_label;
        public System.Windows.Forms.Label a_label;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label active_label;
    }
}