namespace Gamezone.View
{
    partial class FrmMenuEstoque
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
            this.btnJogo = new System.Windows.Forms.Button();
            this.btnAuxiliares = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogo
            // 
            this.btnJogo.BackColor = System.Drawing.Color.Transparent;
            this.btnJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogo.ForeColor = System.Drawing.Color.Transparent;
            this.btnJogo.Location = new System.Drawing.Point(108, 234);
            this.btnJogo.Name = "btnJogo";
            this.btnJogo.Size = new System.Drawing.Size(138, 155);
            this.btnJogo.TabIndex = 1;
            this.btnJogo.UseVisualStyleBackColor = false;
            this.btnJogo.Click += new System.EventHandler(this.btnJogo_Click);
            // 
            // btnAuxiliares
            // 
            this.btnAuxiliares.BackColor = System.Drawing.Color.Transparent;
            this.btnAuxiliares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuxiliares.ForeColor = System.Drawing.Color.Transparent;
            this.btnAuxiliares.Location = new System.Drawing.Point(295, 234);
            this.btnAuxiliares.Name = "btnAuxiliares";
            this.btnAuxiliares.Size = new System.Drawing.Size(138, 155);
            this.btnAuxiliares.TabIndex = 2;
            this.btnAuxiliares.UseVisualStyleBackColor = false;
            this.btnAuxiliares.Click += new System.EventHandler(this.btnAuxiliares_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(480, 234);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 155);
            this.btnSair.TabIndex = 3;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMenuEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gamezone.Properties.Resources.telaMenuEstoque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAuxiliares);
            this.Controls.Add(this.btnJogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenuEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuEstoque";
            this.Load += new System.EventHandler(this.FrmMenuEstoque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogo;
        private System.Windows.Forms.Button btnAuxiliares;
        private System.Windows.Forms.Button btnSair;
    }
}