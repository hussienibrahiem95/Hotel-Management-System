namespace HotelProject
{
    partial class SystemLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.miniTimer_HeaderLabel1 = new MiniTimer_Theme.MiniTimer_HeaderLabel();
            this.monoFlat_Label2 = new MonoFlat.MonoFlat_Label();
            this.monoFlat_Label1 = new MonoFlat.MonoFlat_Label();
            this.username = new MonoFlat.MonoFlat_TextBox();
            this.password = new MonoFlat.MonoFlat_TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(196, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Login);
            // 
            // miniTimer_HeaderLabel1
            // 
            this.miniTimer_HeaderLabel1.AutoSize = true;
            this.miniTimer_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.miniTimer_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniTimer_HeaderLabel1.ForeColor = System.Drawing.Color.Gray;
            this.miniTimer_HeaderLabel1.Location = new System.Drawing.Point(126, 20);
            this.miniTimer_HeaderLabel1.Name = "miniTimer_HeaderLabel1";
            this.miniTimer_HeaderLabel1.Size = new System.Drawing.Size(246, 40);
            this.miniTimer_HeaderLabel1.TabIndex = 12;
            this.miniTimer_HeaderLabel1.Text = "IMPERIAL HOTEL";
            // 
            // monoFlat_Label2
            // 
            this.monoFlat_Label2.AutoSize = true;
            this.monoFlat_Label2.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.monoFlat_Label2.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label2.Location = new System.Drawing.Point(20, 171);
            this.monoFlat_Label2.Name = "monoFlat_Label2";
            this.monoFlat_Label2.Size = new System.Drawing.Size(129, 37);
            this.monoFlat_Label2.TabIndex = 5;
            this.monoFlat_Label2.Text = "Password";
            // 
            // monoFlat_Label1
            // 
            this.monoFlat_Label1.AutoSize = true;
            this.monoFlat_Label1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.monoFlat_Label1.ForeColor = System.Drawing.Color.White;
            this.monoFlat_Label1.Location = new System.Drawing.Point(20, 109);
            this.monoFlat_Label1.Name = "monoFlat_Label1";
            this.monoFlat_Label1.Size = new System.Drawing.Size(136, 37);
            this.monoFlat_Label1.TabIndex = 4;
            this.monoFlat_Label1.Text = "Username";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Window;
            this.username.BackgroundImage = global::HotelProject.Properties.Resources.lock_xxl;
            this.username.Font = new System.Drawing.Font("Tahoma", 11F);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Image = global::HotelProject.Properties.Resources.user_icom_by_adeptusmagos_d4o017u;
            this.username.Location = new System.Drawing.Point(167, 109);
            this.username.MaxLength = 32767;
            this.username.Multiline = false;
            this.username.Name = "username";
            this.username.ReadOnly = false;
            this.username.Size = new System.Drawing.Size(172, 41);
            this.username.TabIndex = 1;
            this.username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.username.UseSystemPasswordChar = false;
            // 
            // password
            // 
            this.password.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("Tahoma", 11F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Image = global::HotelProject.Properties.Resources.lock_xxl;
            this.password.Location = new System.Drawing.Point(167, 171);
            this.password.MaxLength = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.ReadOnly = false;
            this.password.Size = new System.Drawing.Size(172, 41);
            this.password.TabIndex = 2;
            this.password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.UseSystemPasswordChar = true;
            // 
            // SystemLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::HotelProject.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(481, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.miniTimer_HeaderLabel1);
            this.Controls.Add(this.monoFlat_Label2);
            this.Controls.Add(this.monoFlat_Label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.DoubleBuffered = true;
            this.Name = "SystemLogin";
            this.Text = "IMPERIAL HOTEL";
            this.Load += new System.EventHandler(this.SystemLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonoFlat.MonoFlat_TextBox password;
        private MonoFlat.MonoFlat_TextBox username;
        private MonoFlat.MonoFlat_Label monoFlat_Label1;
        private MonoFlat.MonoFlat_Label monoFlat_Label2;
        private System.Windows.Forms.Button button1;
        private MiniTimer_Theme.MiniTimer_HeaderLabel miniTimer_HeaderLabel1;
    }
}

