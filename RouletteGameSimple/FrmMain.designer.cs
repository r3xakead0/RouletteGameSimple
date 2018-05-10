namespace RouletteGameSimple
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlRoulette = new System.Windows.Forms.Panel();
            this.picRoulette = new System.Windows.Forms.PictureBox();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.picBase = new System.Windows.Forms.PictureBox();
            this.lblArrow = new System.Windows.Forms.Label();
            this.pnlRoulette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoulette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlay.Location = new System.Drawing.Point(15, 600);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(164, 58);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pnlRuleta
            // 
            this.pnlRoulette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRoulette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoulette.Controls.Add(this.picRoulette);
            this.pnlRoulette.Controls.Add(this.picArrow);
            this.pnlRoulette.Controls.Add(this.picBase);
            this.pnlRoulette.Location = new System.Drawing.Point(188, 12);
            this.pnlRoulette.Name = "pnlRoulette";
            this.pnlRoulette.Size = new System.Drawing.Size(478, 646);
            this.pnlRoulette.TabIndex = 4;
            // 
            // picRuleta
            // 
            this.picRoulette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picRoulette.BackColor = System.Drawing.Color.Transparent;
            this.picRoulette.Image = ((System.Drawing.Image)(resources.GetObject("picRuleta.Image")));
            this.picRoulette.Location = new System.Drawing.Point(6, 56);
            this.picRoulette.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.picRoulette.Name = "picRoulette";
            this.picRoulette.Size = new System.Drawing.Size(460, 460);
            this.picRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoulette.TabIndex = 0;
            this.picRoulette.TabStop = false;
            // 
            // picFlecha
            // 
            this.picArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picArrow.Image = global::RouletteGameSimple.Properties.Resources._06_Ruleta_triangulo;
            this.picArrow.Location = new System.Drawing.Point(210, 8);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(62, 48);
            this.picArrow.TabIndex = 2;
            this.picArrow.TabStop = false;
            // 
            // picBase
            // 
            this.picBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBase.Image = global::RouletteGameSimple.Properties.Resources._06_Ruleta_base;
            this.picBase.Location = new System.Drawing.Point(106, 516);
            this.picBase.Name = "picBase";
            this.picBase.Size = new System.Drawing.Size(260, 111);
            this.picBase.TabIndex = 3;
            this.picBase.TabStop = false;
            // 
            // lblFlecha
            // 
            this.lblArrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArrow.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrow.Location = new System.Drawing.Point(15, 12);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(164, 58);
            this.lblArrow.TabIndex = 5;
            this.lblArrow.Text = " ";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 671);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlRoulette);
            this.Controls.Add(this.lblArrow);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roulette Game";
            this.Load += new System.EventHandler(this.FrmJuego_Load);
            this.pnlRoulette.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRoulette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRoulette;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.PictureBox picBase;
        private System.Windows.Forms.Panel pnlRoulette;
        private System.Windows.Forms.Label lblArrow;
    }
}

