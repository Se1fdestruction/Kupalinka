namespace Kupalinka
{
    partial class Form_Naimenovanieizd
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
            this.lb_naimizd = new System.Windows.Forms.ListBox();
            this.lb_ni1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_searh = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_naimizd
            // 
            this.lb_naimizd.FormattingEnabled = true;
            this.lb_naimizd.Location = new System.Drawing.Point(2, 72);
            this.lb_naimizd.Name = "lb_naimizd";
            this.lb_naimizd.Size = new System.Drawing.Size(335, 472);
            this.lb_naimizd.TabIndex = 0;
            this.lb_naimizd.SelectedIndexChanged += new System.EventHandler(this.Lb_naimizd_SelectedIndexChanged);
            // 
            // lb_ni1
            // 
            this.lb_ni1.Location = new System.Drawing.Point(2, 550);
            this.lb_ni1.Name = "lb_ni1";
            this.lb_ni1.Size = new System.Drawing.Size(335, 20);
            this.lb_ni1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(46, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lb_searh
            // 
            this.lb_searh.Location = new System.Drawing.Point(0, 19);
            this.lb_searh.Name = "lb_searh";
            this.lb_searh.Size = new System.Drawing.Size(321, 20);
            this.lb_searh.TabIndex = 3;
            this.lb_searh.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lb_searh);
            this.groupBox1.Location = new System.Drawing.Point(2, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Первая буква в поиске \"Заглавная\"!!!";
            // 
            // Form_Naimenovanieizd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_ni1);
            this.Controls.Add(this.lb_naimizd);
            this.Name = "Form_Naimenovanieizd";
            this.Text = "Наименование изделия";
            this.Load += new System.EventHandler(this.Naimenovanieizd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_naimizd;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox lb_ni1;
        private System.Windows.Forms.TextBox lb_searh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}