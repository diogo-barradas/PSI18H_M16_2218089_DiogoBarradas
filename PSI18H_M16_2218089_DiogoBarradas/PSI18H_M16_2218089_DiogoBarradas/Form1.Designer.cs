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
            this.Inicio = new System.Windows.Forms.Panel();
            this.MinimizarApp = new System.Windows.Forms.PictureBox();
            this.MaximizarApp = new System.Windows.Forms.PictureBox();
            this.FecharApp = new System.Windows.Forms.PictureBox();
            this.Inicio2 = new System.Windows.Forms.Panel();
            this.Data = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BankCapa = new System.Windows.Forms.PictureBox();
            this.Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FecharApp)).BeginInit();
            this.Inicio2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloCapa
            // 
            this.TituloCapa.AutoSize = true;
            this.TituloCapa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TituloCapa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TituloCapa.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloCapa.ForeColor = System.Drawing.Color.White;
            this.TituloCapa.Location = new System.Drawing.Point(240, 247);
            this.TituloCapa.Name = "TituloCapa";
            this.TituloCapa.Size = new System.Drawing.Size(160, 30);
            this.TituloCapa.TabIndex = 1;
            this.TituloCapa.Text = "Bank$Acc";
            this.TituloCapa.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.Inicio.Controls.Add(this.MinimizarApp);
            this.Inicio.Controls.Add(this.MaximizarApp);
            this.Inicio.Controls.Add(this.FecharApp);
            this.Inicio.Location = new System.Drawing.Point(-4, 0);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(633, 28);
            this.Inicio.TabIndex = 5;
            // 
            // MinimizarApp
            // 
            this.MinimizarApp.Image = global::PSI18H_M16_2218089_DiogoBarradas.Properties.Resources.icons8_minimize_window_100__1_;
            this.MinimizarApp.Location = new System.Drawing.Point(549, 3);
            this.MinimizarApp.Name = "MinimizarApp";
            this.MinimizarApp.Size = new System.Drawing.Size(21, 21);
            this.MinimizarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizarApp.TabIndex = 0;
            this.MinimizarApp.TabStop = false;
            this.MinimizarApp.Click += new System.EventHandler(this.MinimizarApp_Click);
            // 
            // MaximizarApp
            // 
            this.MaximizarApp.Image = global::PSI18H_M16_2218089_DiogoBarradas.Properties.Resources.icons8_maximize_window_100__1_;
            this.MaximizarApp.Location = new System.Drawing.Point(576, 3);
            this.MaximizarApp.Name = "MaximizarApp";
            this.MaximizarApp.Size = new System.Drawing.Size(21, 21);
            this.MaximizarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizarApp.TabIndex = 1;
            this.MaximizarApp.TabStop = false;
            this.MaximizarApp.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // FecharApp
            // 
            this.FecharApp.Image = global::PSI18H_M16_2218089_DiogoBarradas.Properties.Resources.icons8_close_window_100;
            this.FecharApp.Location = new System.Drawing.Point(603, 3);
            this.FecharApp.Name = "FecharApp";
            this.FecharApp.Size = new System.Drawing.Size(21, 21);
            this.FecharApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FecharApp.TabIndex = 2;
            this.FecharApp.TabStop = false;
            this.FecharApp.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // Inicio2
            // 
            this.Inicio2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(164)))), ((int)(((byte)(93)))));
            this.Inicio2.Controls.Add(this.Data);
            this.Inicio2.Location = new System.Drawing.Point(-4, 326);
            this.Inicio2.Name = "Inicio2";
            this.Inicio2.Size = new System.Drawing.Size(633, 28);
            this.Inicio2.TabIndex = 6;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Transparent;
            this.Data.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.White;
            this.Data.Location = new System.Drawing.Point(455, 5);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(40, 17);
            this.Data.TabIndex = 7;
            this.Data.Text = "Time";
            this.Data.Click += new System.EventHandler(this.labeltime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BankCapa
            // 
            this.BankCapa.Image = global::PSI18H_M16_2218089_DiogoBarradas.Properties.Resources.Bank;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(46)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(626, 354);
            this.Controls.Add(this.Inicio2);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.TituloCapa);
            this.Controls.Add(this.BankCapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizarApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FecharApp)).EndInit();
            this.Inicio2.ResumeLayout(false);
            this.Inicio2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BankCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BankCapa;
        private System.Windows.Forms.Label TituloCapa;
        private System.Windows.Forms.Panel Inicio;
        private System.Windows.Forms.Panel Inicio2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.PictureBox MinimizarApp;
        private System.Windows.Forms.PictureBox MaximizarApp;
        private System.Windows.Forms.PictureBox FecharApp;
    }
}

