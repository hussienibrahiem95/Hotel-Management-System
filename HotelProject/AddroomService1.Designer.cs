namespace HotelProject
{
    partial class AddroomService1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.monoFlat_Button1 = new MonoFlat.MonoFlat_Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Name11 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Servicetype = new System.Windows.Forms.ComboBox();
            this.RoomNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.monoFlat_Button1);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Name11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Servicetype);
            this.panel1.Controls.Add(this.RoomNO);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 368);
            this.panel1.TabIndex = 1;
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(258, 273);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(179, 57);
            this.monoFlat_Button1.TabIndex = 40;
            this.monoFlat_Button1.Text = "Add ";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(258, 207);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(179, 40);
            this.amount.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number ";
            // 
            // Name11
            // 
            this.Name11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name11.FormattingEnabled = true;
            this.Name11.Location = new System.Drawing.Point(258, 154);
            this.Name11.Name = "Name11";
            this.Name11.Size = new System.Drawing.Size(179, 27);
            this.Name11.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Service Type";
            // 
            // Servicetype
            // 
            this.Servicetype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicetype.FormattingEnabled = true;
            this.Servicetype.Items.AddRange(new object[] {
            "Meal",
            "laundry",
            "Drink"});
            this.Servicetype.Location = new System.Drawing.Point(258, 92);
            this.Servicetype.Name = "Servicetype";
            this.Servicetype.Size = new System.Drawing.Size(179, 27);
            this.Servicetype.TabIndex = 14;
            // 
            // RoomNO
            // 
            this.RoomNO.Location = new System.Drawing.Point(258, 31);
            this.RoomNO.Name = "RoomNO";
            this.RoomNO.Size = new System.Drawing.Size(179, 40);
            this.RoomNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number";
            // 
            // AddroomService1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 354);
            this.Controls.Add(this.panel1);
            this.Name = "AddroomService1";
            this.Text = "AddroomService1";
            this.Load += new System.EventHandler(this.AddroomService1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MonoFlat.MonoFlat_Button monoFlat_Button1;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Name11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Servicetype;
        private System.Windows.Forms.TextBox RoomNO;
        private System.Windows.Forms.Label label1;
    }
}