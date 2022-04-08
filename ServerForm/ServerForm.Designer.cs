namespace ServerForm
{
    partial class ServerForm
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
            this.btnStarta = new System.Windows.Forms.Button();
            this.tbxInkorg = new System.Windows.Forms.TextBox();
            this.btnTaEmot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inkorg";
            // 
            // btnStarta
            // 
            this.btnStarta.Location = new System.Drawing.Point(237, 21);
            this.btnStarta.Name = "btnStarta";
            this.btnStarta.Size = new System.Drawing.Size(107, 27);
            this.btnStarta.TabIndex = 1;
            this.btnStarta.Text = "Starta";
            this.btnStarta.UseVisualStyleBackColor = true;
            this.btnStarta.Click += new System.EventHandler(this.btnStarta_Click);
            // 
            // tbxInkorg
            // 
            this.tbxInkorg.Location = new System.Drawing.Point(31, 77);
            this.tbxInkorg.Multiline = true;
            this.tbxInkorg.Name = "tbxInkorg";
            this.tbxInkorg.Size = new System.Drawing.Size(313, 189);
            this.tbxInkorg.TabIndex = 2;
            // 
            // btnTaEmot
            // 
            this.btnTaEmot.Location = new System.Drawing.Point(31, 284);
            this.btnTaEmot.Name = "btnTaEmot";
            this.btnTaEmot.Size = new System.Drawing.Size(313, 36);
            this.btnTaEmot.TabIndex = 3;
            this.btnTaEmot.Text = "Ta emot meddelande";
            this.btnTaEmot.UseVisualStyleBackColor = true;
            this.btnTaEmot.Click += new System.EventHandler(this.btnTaEmot_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 332);
            this.Controls.Add(this.btnTaEmot);
            this.Controls.Add(this.tbxInkorg);
            this.Controls.Add(this.btnStarta);
            this.Controls.Add(this.label1);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStarta;
        private System.Windows.Forms.TextBox tbxInkorg;
        private System.Windows.Forms.Button btnTaEmot;
    }
}

