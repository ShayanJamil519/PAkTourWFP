
namespace PakistanTour
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
            this.buttonBalochistan = new System.Windows.Forms.Button();
            this.buttonPunjab = new System.Windows.Forms.Button();
            this.buttonSindh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKhyberPakhtunKhuwa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBalochistan
            // 
            this.buttonBalochistan.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonBalochistan.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBalochistan.ForeColor = System.Drawing.Color.White;
            this.buttonBalochistan.Location = new System.Drawing.Point(461, 368);
            this.buttonBalochistan.Name = "buttonBalochistan";
            this.buttonBalochistan.Size = new System.Drawing.Size(228, 94);
            this.buttonBalochistan.TabIndex = 17;
            this.buttonBalochistan.Text = "Balochistan";
            this.buttonBalochistan.UseVisualStyleBackColor = false;
            this.buttonBalochistan.Click += new System.EventHandler(this.buttonBalochistan_Click);
            // 
            // buttonPunjab
            // 
            this.buttonPunjab.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonPunjab.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPunjab.ForeColor = System.Drawing.Color.White;
            this.buttonPunjab.Location = new System.Drawing.Point(461, 201);
            this.buttonPunjab.Name = "buttonPunjab";
            this.buttonPunjab.Size = new System.Drawing.Size(228, 94);
            this.buttonPunjab.TabIndex = 16;
            this.buttonPunjab.Text = "Punjab";
            this.buttonPunjab.UseVisualStyleBackColor = false;
            this.buttonPunjab.Click += new System.EventHandler(this.buttonPunjab_Click);
            // 
            // buttonSindh
            // 
            this.buttonSindh.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSindh.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSindh.ForeColor = System.Drawing.Color.White;
            this.buttonSindh.Location = new System.Drawing.Point(108, 201);
            this.buttonSindh.Name = "buttonSindh";
            this.buttonSindh.Size = new System.Drawing.Size(223, 94);
            this.buttonSindh.TabIndex = 15;
            this.buttonSindh.Text = "Sindh";
            this.buttonSindh.UseVisualStyleBackColor = false;
            this.buttonSindh.Click += new System.EventHandler(this.buttonSindh_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(81, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 96);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pakistan Tour";
            // 
            // buttonKhyberPakhtunKhuwa
            // 
            this.buttonKhyberPakhtunKhuwa.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonKhyberPakhtunKhuwa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhyberPakhtunKhuwa.ForeColor = System.Drawing.Color.White;
            this.buttonKhyberPakhtunKhuwa.Location = new System.Drawing.Point(108, 359);
            this.buttonKhyberPakhtunKhuwa.Name = "buttonKhyberPakhtunKhuwa";
            this.buttonKhyberPakhtunKhuwa.Size = new System.Drawing.Size(223, 94);
            this.buttonKhyberPakhtunKhuwa.TabIndex = 18;
            this.buttonKhyberPakhtunKhuwa.Text = "Khyber Pakhtun Khuwa";
            this.buttonKhyberPakhtunKhuwa.UseVisualStyleBackColor = false;
            this.buttonKhyberPakhtunKhuwa.Click += new System.EventHandler(this.buttonKhyberPakhtunKhuwa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::PakistanTour.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 534);
            this.Controls.Add(this.buttonKhyberPakhtunKhuwa);
            this.Controls.Add(this.buttonBalochistan);
            this.Controls.Add(this.buttonPunjab);
            this.Controls.Add(this.buttonSindh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBalochistan;
        private System.Windows.Forms.Button buttonPunjab;
        private System.Windows.Forms.Button buttonSindh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKhyberPakhtunKhuwa;
    }
}

