namespace KlientForm
{
    partial class KlientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIPAdress = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.btnSänd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP-adress";
            // 
            // tbxIPAdress
            // 
            this.tbxIPAdress.Location = new System.Drawing.Point(45, 60);
            this.tbxIPAdress.Name = "tbxIPAdress";
            this.tbxIPAdress.Size = new System.Drawing.Size(211, 26);
            this.tbxIPAdress.TabIndex = 1;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(300, 60);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(129, 26);
            this.btnAnslut.TabIndex = 2;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.btnAnslut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meddelande";
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(49, 135);
            this.tbxMeddelande.Multiline = true;
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(296, 292);
            this.tbxMeddelande.TabIndex = 4;
            // 
            // btnSänd
            // 
            this.btnSänd.Location = new System.Drawing.Point(216, 453);
            this.btnSänd.Name = "btnSänd";
            this.btnSänd.Size = new System.Drawing.Size(129, 26);
            this.btnSänd.TabIndex = 5;
            this.btnSänd.Text = "Sänd";
            this.btnSänd.UseVisualStyleBackColor = true;
            this.btnSänd.Click += new System.EventHandler(this.btnSänd_Click);
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 502);
            this.Controls.Add(this.btnSänd);
            this.Controls.Add(this.tbxMeddelande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxIPAdress);
            this.Controls.Add(this.label1);
            this.Name = "KlientForm";
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIPAdress;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.Button btnSänd;
    }
}

