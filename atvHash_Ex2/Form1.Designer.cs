namespace atvHash_Ex2
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
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicacao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtOriginal.Location = new System.Drawing.Point(12, 55);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(776, 30);
            this.txtOriginal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite aqui o texto desejado:";
            // 
            // btnAplicacao
            // 
            this.btnAplicacao.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAplicacao.Location = new System.Drawing.Point(812, 55);
            this.btnAplicacao.Name = "btnAplicacao";
            this.btnAplicacao.Size = new System.Drawing.Size(160, 30);
            this.btnAplicacao.TabIndex = 2;
            this.btnAplicacao.Text = "Aplicar hash";
            this.btnAplicacao.UseVisualStyleBackColor = false;
            this.btnAplicacao.Click += new System.EventHandler(this.btnAplicacao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(15, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto criptografado (MD5):";
            // 
            // txtMD5
            // 
            this.txtMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMD5.Location = new System.Drawing.Point(16, 146);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(776, 30);
            this.txtMD5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(15, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Texto criptografado (SHA1):";
            // 
            // txtSHA1
            // 
            this.txtSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSHA1.Location = new System.Drawing.Point(16, 229);
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(776, 30);
            this.txtSHA1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 278);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.btnAplicacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSHA1;
    }
}

