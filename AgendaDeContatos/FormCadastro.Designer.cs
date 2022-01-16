namespace AgendaDeContatos
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
            this.pDados = new System.Windows.Forms.Panel();
            this.txtCombo = new System.Windows.Forms.ComboBox();
            this.txtCheck = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelAtivo = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.LabelFone = new System.Windows.Forms.Label();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.pDados.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDados
            // 
            this.pDados.Controls.Add(this.txtCombo);
            this.pDados.Controls.Add(this.txtCheck);
            this.pDados.Controls.Add(this.txtEmail);
            this.pDados.Controls.Add(this.txtTel);
            this.pDados.Controls.Add(this.txtNome);
            this.pDados.Controls.Add(this.labelAtivo);
            this.pDados.Controls.Add(this.labelCat);
            this.pDados.Controls.Add(this.LabelFone);
            this.pDados.Controls.Add(this.LabelEmail);
            this.pDados.Controls.Add(this.labelName);
            this.pDados.Location = new System.Drawing.Point(7, 12);
            this.pDados.Name = "pDados";
            this.pDados.Size = new System.Drawing.Size(781, 209);
            this.pDados.TabIndex = 0;
            // 
            // txtCombo
            // 
            this.txtCombo.FormattingEnabled = true;
            this.txtCombo.Items.AddRange(new object[] {
            "Ouro",
            "Prata",
            "Bronze",
            "Nenhuma Categoria"});
            this.txtCombo.Location = new System.Drawing.Point(418, 116);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(121, 23);
            this.txtCombo.TabIndex = 9;
            this.txtCombo.Text = "Categoria";
            // 
            // txtCheck
            // 
            this.txtCheck.AutoSize = true;
            this.txtCheck.Location = new System.Drawing.Point(638, 116);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(15, 14);
            this.txtCheck.TabIndex = 8;
            this.txtCheck.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(418, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(324, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(15, 116);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(324, 23);
            this.txtTel.TabIndex = 6;
            this.txtTel.UseWaitCursor = true;
            // 
            // txtNome
            // 
            this.txtNome.AcceptsTab = true;
            this.txtNome.Location = new System.Drawing.Point(15, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 23);
            this.txtNome.TabIndex = 5;
            // 
            // labelAtivo
            // 
            this.labelAtivo.AutoSize = true;
            this.labelAtivo.Location = new System.Drawing.Point(628, 84);
            this.labelAtivo.Name = "labelAtivo";
            this.labelAtivo.Size = new System.Drawing.Size(35, 15);
            this.labelAtivo.TabIndex = 4;
            this.labelAtivo.Text = "Ativo";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(418, 84);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(58, 15);
            this.labelCat.TabIndex = 3;
            this.labelCat.Text = "Categoria";
            // 
            // LabelFone
            // 
            this.LabelFone.AutoSize = true;
            this.LabelFone.Location = new System.Drawing.Point(15, 84);
            this.LabelFone.Name = "LabelFone";
            this.LabelFone.Size = new System.Drawing.Size(51, 15);
            this.LabelFone.TabIndex = 2;
            this.LabelFone.Text = "Telefone";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(418, 13);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(41, 15);
            this.LabelEmail.TabIndex = 1;
            this.LabelEmail.Text = "E-mail";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(40, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome";
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnExcluir);
            this.pMenu.Controls.Add(this.btnGravar);
            this.pMenu.Controls.Add(this.btnVoltar);
            this.pMenu.Controls.Add(this.btnCriar);
            this.pMenu.Location = new System.Drawing.Point(7, 259);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(784, 164);
            this.pMenu.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(696, 65);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(154, 65);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 35);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(264, 65);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 35);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(15, 65);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(104, 35);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Novo Registro";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pDados);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Editar";
            this.Load += new System.EventHandler(this.FormCadastro_Load);
            this.pDados.ResumeLayout(false);
            this.pDados.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pDados;
        private Panel pMenu;
        private Button btnExcluir;
        private Button btnGravar;
        private Button btnVoltar;
        private Button btnCriar;
        private Label labelAtivo;
        private Label labelCat;
        private Label LabelFone;
        private Label LabelEmail;
        private Label labelName;
        private CheckBox txtCheck;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtNome;
        private ComboBox txtCombo;
    }
}