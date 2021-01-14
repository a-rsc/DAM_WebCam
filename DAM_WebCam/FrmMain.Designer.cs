namespace DAM_WebCam
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtCam = new System.Windows.Forms.Button();
            this.ImgCam = new Emgu.CV.UI.ImageBox();
            this.TmCam = new System.Windows.Forms.Timer(this.components);
            this.TbTextQR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCam)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCam
            // 
            this.BtCam.BackColor = System.Drawing.Color.YellowGreen;
            this.BtCam.Location = new System.Drawing.Point(12, 387);
            this.BtCam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtCam.Name = "BtCam";
            this.BtCam.Size = new System.Drawing.Size(459, 33);
            this.BtCam.TabIndex = 4;
            this.BtCam.Text = "Iniciar càmera";
            this.BtCam.UseVisualStyleBackColor = false;
            this.BtCam.Click += new System.EventHandler(this.btCam_Click);
            // 
            // ImgCam
            // 
            this.ImgCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgCam.Location = new System.Drawing.Point(12, 12);
            this.ImgCam.Name = "ImgCam";
            this.ImgCam.Size = new System.Drawing.Size(459, 341);
            this.ImgCam.TabIndex = 2;
            this.ImgCam.TabStop = false;
            // 
            // TmCam
            // 
            this.TmCam.Tick += new System.EventHandler(this.TmCam_Tick);
            // 
            // TbTextQR
            // 
            this.TbTextQR.Enabled = false;
            this.TbTextQR.Location = new System.Drawing.Point(12, 359);
            this.TbTextQR.Name = "TbTextQR";
            this.TbTextQR.Size = new System.Drawing.Size(459, 22);
            this.TbTextQR.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 431);
            this.Controls.Add(this.TbTextQR);
            this.Controls.Add(this.BtCam);
            this.Controls.Add(this.ImgCam);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmMain";
            this.Text = "WebCam ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtCam;
        private Emgu.CV.UI.ImageBox ImgCam;
        private System.Windows.Forms.Timer TmCam;
        private System.Windows.Forms.TextBox TbTextQR;
    }
}

