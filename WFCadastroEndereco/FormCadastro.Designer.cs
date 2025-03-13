namespace WFCadastroEndereco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            txtNomeCompleto = new TextBox();
            lblNomeCompleto = new Label();
            btnSalvar = new Button();
            lblCep = new Label();
            lblLinha = new Label();
            mkdCep = new MaskedTextBox();
            lblLograduro = new Label();
            txtLogradouro = new TextBox();
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblComplemento = new Label();
            txtComplemento = new TextBox();
            lblBairro = new Label();
            txtBairro = new TextBox();
            lblCidade = new Label();
            textBox1 = new TextBox();
            lblUf = new Label();
            cbxUf = new ComboBox();
            chkTemNumero = new CheckBox();
            SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(19, 44);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(319, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(19, 26);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(94, 15);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "Nome completo";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(134, 337);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 52);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(19, 98);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 9;
            lblCep.Text = "CPF";
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.FixedSingle;
            lblLinha.Location = new Point(19, 83);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(319, 1);
            lblLinha.TabIndex = 11;
            // 
            // mkdCep
            // 
            mkdCep.Location = new Point(19, 116);
            mkdCep.Mask = "00000-999";
            mkdCep.Name = "mkdCep";
            mkdCep.Size = new Size(100, 23);
            mkdCep.TabIndex = 18;
            // 
            // lblLograduro
            // 
            lblLograduro.AutoSize = true;
            lblLograduro.Location = new Point(19, 151);
            lblLograduro.Name = "lblLograduro";
            lblLograduro.Size = new Size(69, 15);
            lblLograduro.TabIndex = 19;
            lblLograduro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(19, 169);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(134, 23);
            txtLogradouro.TabIndex = 20;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(181, 151);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 21;
            lblNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(181, 169);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(157, 23);
            txtNumero.TabIndex = 22;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(19, 218);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 23;
            lblComplemento.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(19, 236);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(134, 23);
            txtComplemento.TabIndex = 24;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(180, 218);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 25;
            lblBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(180, 236);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(158, 23);
            txtBairro.TabIndex = 26;
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(19, 272);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 27;
            lblCidade.Text = "Cidade";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 28;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Location = new Point(180, 272);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 29;
            lblUf.Text = "UF";
            // 
            // cbxUf
            // 
            cbxUf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxUf.FormattingEnabled = true;
            cbxUf.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cbxUf.Location = new Point(181, 290);
            cbxUf.Name = "cbxUf";
            cbxUf.Size = new Size(51, 23);
            cbxUf.TabIndex = 30;
            // 
            // chkTemNumero
            // 
            chkTemNumero.AutoSize = true;
            chkTemNumero.Location = new Point(244, 292);
            chkTemNumero.Name = "chkTemNumero";
            chkTemNumero.Size = new Size(93, 19);
            chkTemNumero.TabIndex = 31;
            chkTemNumero.Text = "Tem numero";
            chkTemNumero.UseVisualStyleBackColor = true;
            chkTemNumero.CheckedChanged += chkTemNumero_CheckedChanged;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 424);
            Controls.Add(chkTemNumero);
            Controls.Add(cbxUf);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(textBox1);
            Controls.Add(lblBairro);
            Controls.Add(txtBairro);
            Controls.Add(lblComplemento);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(lblLograduro);
            Controls.Add(txtLogradouro);
            Controls.Add(mkdCep);
            Controls.Add(lblLinha);
            Controls.Add(lblCep);
            Controls.Add(btnSalvar);
            Controls.Add(lblNomeCompleto);
            Controls.Add(txtNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCompleto;
        private Label lblNomeCompleto;
        private Button btnSalvar;
        private Label lblCep;
        private Label lblLinha;
        private MaskedTextBox mkdCep;
        private Label lblLograduro;
        private TextBox txtLogradouro;
        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtComplemento;
        private Label lblBairro;
        private TextBox txtBairro;
        private Label lblCidade;
        private TextBox textBox1;
        private Label lblUf;
        private ComboBox cbxUf;
        private CheckBox chkTemNumero;
    }
}