namespace WinFormsApp2
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            lblNome = new Label();
            lblPreco = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtNome.Location = new Point(170, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(459, 30);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtPreco.Location = new Point(170, 132);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(459, 30);
            txtPreco.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = SystemColors.Window;
            lblNome.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblNome.Location = new Point(92, 74);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 24);
            lblNome.TabIndex = 2;
            lblNome.Text = "NOME";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = SystemColors.Window;
            lblPreco.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblPreco.Location = new Point(82, 135);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(80, 24);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "PREÇO";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.MenuBar;
            btnSalvar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnSalvar.Location = new Point(244, 188);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(272, 54);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Label lblNome;
        private Label lblPreco;
        private Button btnSalvar;
    }
}