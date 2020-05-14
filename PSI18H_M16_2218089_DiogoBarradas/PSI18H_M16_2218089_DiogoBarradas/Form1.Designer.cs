namespace PSI18H_M16_2218089_DiogoBarradas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TituloCapa = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BankCapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BankCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloCapa
            // 
            this.TituloCapa.AutoSize = true;
            this.TituloCapa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TituloCapa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TituloCapa.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloCapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.TituloCapa.Location = new System.Drawing.Point(241, 242);
            this.TituloCapa.Name = "TituloCapa";
            this.TituloCapa.Size = new System.Drawing.Size(160, 30);
            this.TituloCapa.TabIndex = 1;
            this.TituloCapa.Text = "Bank$Acc";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.Data.Location = new System.Drawing.Point(458, 328);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(40, 17);
            this.Data.TabIndex = 7;
            this.Data.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BankCapa
            // 
            this.BankCapa.Image = global::PSI18H_M16_2218089_DiogoBarradas.Properties.Resources.Logo;
            this.BankCapa.Location = new System.Drawing.Point(210, 42);
            this.BankCapa.Name = "BankCapa";
            this.BankCapa.Size = new System.Drawing.Size(204, 200);
            this.BankCapa.TabIndex = 0;
            this.BankCapa.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 354);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.TituloCapa);
            this.Controls.Add(this.BankCapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BankCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BankCapa;
        private System.Windows.Forms.Label TituloCapa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Data;
    }
}

