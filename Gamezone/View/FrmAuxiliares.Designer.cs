namespace Gamezone.View
{
    partial class FrmAuxiliares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuxiliares));
            this.dgPlataforma = new System.Windows.Forms.DataGridView();
            this.btnCadPlataforma = new System.Windows.Forms.Button();
            this.txtPlataforma = new System.Windows.Forms.TextBox();
            this.btnCadGenero = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.dgGenero = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadDistribuidora = new System.Windows.Forms.Button();
            this.txtDistribuidora = new System.Windows.Forms.TextBox();
            this.dgDistribuidora = new System.Windows.Forms.DataGridView();
            this.txtPesquisarPlataforma = new System.Windows.Forms.TextBox();
            this.txtPesquisarDistribuidora = new System.Windows.Forms.TextBox();
            this.txtPesquisarGenero = new System.Windows.Forms.TextBox();
            this.btnEditPlataforma = new System.Windows.Forms.Button();
            this.btnExcluirPlataforma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlataforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistribuidora)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlataforma
            // 
            this.dgPlataforma.AllowUserToAddRows = false;
            this.dgPlataforma.AllowUserToDeleteRows = false;
            this.dgPlataforma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPlataforma.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgPlataforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlataforma.Location = new System.Drawing.Point(287, 211);
            this.dgPlataforma.MultiSelect = false;
            this.dgPlataforma.Name = "dgPlataforma";
            this.dgPlataforma.ReadOnly = true;
            this.dgPlataforma.Size = new System.Drawing.Size(305, 131);
            this.dgPlataforma.TabIndex = 1;
            // 
            // btnCadPlataforma
            // 
            this.btnCadPlataforma.BackColor = System.Drawing.Color.Transparent;
            this.btnCadPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadPlataforma.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadPlataforma.Location = new System.Drawing.Point(22, 211);
            this.btnCadPlataforma.Name = "btnCadPlataforma";
            this.btnCadPlataforma.Size = new System.Drawing.Size(92, 30);
            this.btnCadPlataforma.TabIndex = 5;
            this.btnCadPlataforma.UseVisualStyleBackColor = false;
            this.btnCadPlataforma.Click += new System.EventHandler(this.btnCadPlataforma_Click);
            // 
            // txtPlataforma
            // 
            this.txtPlataforma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlataforma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlataforma.Location = new System.Drawing.Point(20, 172);
            this.txtPlataforma.Name = "txtPlataforma";
            this.txtPlataforma.Size = new System.Drawing.Size(192, 26);
            this.txtPlataforma.TabIndex = 6;
            this.txtPlataforma.TextChanged += new System.EventHandler(this.txtPlataforma_TextChanged);
            // 
            // btnCadGenero
            // 
            this.btnCadGenero.BackColor = System.Drawing.Color.Transparent;
            this.btnCadGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadGenero.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadGenero.Location = new System.Drawing.Point(608, 211);
            this.btnCadGenero.Name = "btnCadGenero";
            this.btnCadGenero.Size = new System.Drawing.Size(92, 30);
            this.btnCadGenero.TabIndex = 7;
            this.btnCadGenero.UseVisualStyleBackColor = false;
            this.btnCadGenero.Click += new System.EventHandler(this.btnCadGenero_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGenero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(605, 172);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(192, 26);
            this.txtGenero.TabIndex = 8;
            // 
            // dgGenero
            // 
            this.dgGenero.AllowUserToAddRows = false;
            this.dgGenero.AllowUserToDeleteRows = false;
            this.dgGenero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGenero.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenero.Location = new System.Drawing.Point(867, 211);
            this.dgGenero.MultiSelect = false;
            this.dgGenero.Name = "dgGenero";
            this.dgGenero.ReadOnly = true;
            this.dgGenero.Size = new System.Drawing.Size(305, 131);
            this.dgGenero.TabIndex = 9;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.ForeColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Location = new System.Drawing.Point(1012, 535);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(123, 52);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadDistribuidora
            // 
            this.btnCadDistribuidora.BackColor = System.Drawing.Color.Transparent;
            this.btnCadDistribuidora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadDistribuidora.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadDistribuidora.Location = new System.Drawing.Point(23, 455);
            this.btnCadDistribuidora.Name = "btnCadDistribuidora";
            this.btnCadDistribuidora.Size = new System.Drawing.Size(92, 30);
            this.btnCadDistribuidora.TabIndex = 11;
            this.btnCadDistribuidora.UseVisualStyleBackColor = false;
            this.btnCadDistribuidora.Click += new System.EventHandler(this.btnCadDistribuidora_Click);
            // 
            // txtDistribuidora
            // 
            this.txtDistribuidora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistribuidora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistribuidora.Location = new System.Drawing.Point(22, 417);
            this.txtDistribuidora.Name = "txtDistribuidora";
            this.txtDistribuidora.Size = new System.Drawing.Size(192, 26);
            this.txtDistribuidora.TabIndex = 12;
            // 
            // dgDistribuidora
            // 
            this.dgDistribuidora.AllowUserToAddRows = false;
            this.dgDistribuidora.AllowUserToDeleteRows = false;
            this.dgDistribuidora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDistribuidora.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDistribuidora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDistribuidora.Location = new System.Drawing.Point(287, 457);
            this.dgDistribuidora.MultiSelect = false;
            this.dgDistribuidora.Name = "dgDistribuidora";
            this.dgDistribuidora.ReadOnly = true;
            this.dgDistribuidora.Size = new System.Drawing.Size(305, 131);
            this.dgDistribuidora.TabIndex = 13;
            // 
            // txtPesquisarPlataforma
            // 
            this.txtPesquisarPlataforma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisarPlataforma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarPlataforma.Location = new System.Drawing.Point(298, 172);
            this.txtPesquisarPlataforma.Name = "txtPesquisarPlataforma";
            this.txtPesquisarPlataforma.Size = new System.Drawing.Size(192, 26);
            this.txtPesquisarPlataforma.TabIndex = 14;
            this.txtPesquisarPlataforma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarPlataforma_KeyUp);
            // 
            // txtPesquisarDistribuidora
            // 
            this.txtPesquisarDistribuidora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisarDistribuidora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarDistribuidora.Location = new System.Drawing.Point(300, 417);
            this.txtPesquisarDistribuidora.Name = "txtPesquisarDistribuidora";
            this.txtPesquisarDistribuidora.Size = new System.Drawing.Size(192, 26);
            this.txtPesquisarDistribuidora.TabIndex = 15;
            this.txtPesquisarDistribuidora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarDistribuidora_KeyUp);
            // 
            // txtPesquisarGenero
            // 
            this.txtPesquisarGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisarGenero.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarGenero.Location = new System.Drawing.Point(883, 172);
            this.txtPesquisarGenero.Name = "txtPesquisarGenero";
            this.txtPesquisarGenero.Size = new System.Drawing.Size(192, 26);
            this.txtPesquisarGenero.TabIndex = 16;
            this.txtPesquisarGenero.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisarGenero_KeyUp);
            // 
            // btnEditPlataforma
            // 
            this.btnEditPlataforma.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditPlataforma.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditPlataforma.Location = new System.Drawing.Point(118, 211);
            this.btnEditPlataforma.Name = "btnEditPlataforma";
            this.btnEditPlataforma.Size = new System.Drawing.Size(79, 30);
            this.btnEditPlataforma.TabIndex = 17;
            this.btnEditPlataforma.UseVisualStyleBackColor = false;
            this.btnEditPlataforma.Click += new System.EventHandler(this.btnEditPlataforma_Click);
            // 
            // btnExcluirPlataforma
            // 
            this.btnExcluirPlataforma.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirPlataforma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirPlataforma.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluirPlataforma.Location = new System.Drawing.Point(199, 211);
            this.btnExcluirPlataforma.Name = "btnExcluirPlataforma";
            this.btnExcluirPlataforma.Size = new System.Drawing.Size(63, 30);
            this.btnExcluirPlataforma.TabIndex = 18;
            this.btnExcluirPlataforma.UseVisualStyleBackColor = false;
            this.btnExcluirPlataforma.Click += new System.EventHandler(this.btnExcluirPlataforma_Click);
            // 
            // FrmAuxiliares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 600);
            this.Controls.Add(this.btnExcluirPlataforma);
            this.Controls.Add(this.btnEditPlataforma);
            this.Controls.Add(this.txtPesquisarGenero);
            this.Controls.Add(this.txtPesquisarDistribuidora);
            this.Controls.Add(this.txtPesquisarPlataforma);
            this.Controls.Add(this.dgDistribuidora);
            this.Controls.Add(this.txtDistribuidora);
            this.Controls.Add(this.btnCadDistribuidora);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnCadGenero);
            this.Controls.Add(this.txtPlataforma);
            this.Controls.Add(this.btnCadPlataforma);
            this.Controls.Add(this.dgPlataforma);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmAuxiliares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAuxiliares";
            this.Load += new System.EventHandler(this.FrmAuxiliares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlataforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDistribuidora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlataforma;
        private System.Windows.Forms.Button btnCadPlataforma;
        private System.Windows.Forms.TextBox txtPlataforma;
        private System.Windows.Forms.Button btnCadGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.DataGridView dgGenero;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadDistribuidora;
        private System.Windows.Forms.TextBox txtDistribuidora;
        private System.Windows.Forms.DataGridView dgDistribuidora;
        private System.Windows.Forms.TextBox txtPesquisarPlataforma;
        private System.Windows.Forms.TextBox txtPesquisarDistribuidora;
        private System.Windows.Forms.TextBox txtPesquisarGenero;
        private System.Windows.Forms.Button btnEditPlataforma;
        private System.Windows.Forms.Button btnExcluirPlataforma;
    }
}