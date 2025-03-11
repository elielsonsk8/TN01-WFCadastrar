namespace TN01_WFCadastrar
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
            lblTelefone = new Label();
            mkdTelefone = new MaskedTextBox();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            lblEscolaridade = new Label();
            cbxEscolaridade = new ComboBox();
            gbxSexo = new GroupBox();
            rdbPrefiroNaoInformar = new RadioButton();
            rdbFeminino = new RadioButton();
            rdbMasculino = new RadioButton();
            lblRenda = new Label();
            nudRendaMensal = new NumericUpDown();
            chkPossuiFilhos = new CheckBox();
            btnSalvar = new Button();
            gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).BeginInit();
            SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(30, 43);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(318, 23);
            txtNomeCompleto.TabIndex = 1;
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Location = new Point(30, 25);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(94, 15);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "Nome completo";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(30, 92);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // mkdTelefone
            // 
            mkdTelefone.Location = new Point(30, 110);
            mkdTelefone.Mask = "(00) 90000-0000";
            mkdTelefone.Name = "mkdTelefone";
            mkdTelefone.Size = new Size(160, 23);
            mkdTelefone.TabIndex = 2;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(217, 92);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 4;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(217, 110);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(131, 23);
            dtpDataNascimento.TabIndex = 3;
            // 
            // lblEscolaridade
            // 
            lblEscolaridade.AutoSize = true;
            lblEscolaridade.Location = new Point(30, 155);
            lblEscolaridade.Name = "lblEscolaridade";
            lblEscolaridade.Size = new Size(73, 15);
            lblEscolaridade.TabIndex = 6;
            lblEscolaridade.Text = "Escolaridade";
            // 
            // cbxEscolaridade
            // 
            cbxEscolaridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEscolaridade.FormattingEnabled = true;
            cbxEscolaridade.Items.AddRange(new object[] { "Analfabeto", "Ensino Fundamental Incompleto", "Ensino Fundamental Completo", "Ensino Médio Incompleto", "Ensino Médio Completo", "Ensino Técnico Incompleto", "Ensino Técnico Completo", "Ensino Superior Incompleto", "Ensino Superior Completo", "Pós-Graduação Incompleto", "Pós-Graduação Completo" });
            cbxEscolaridade.Location = new Point(30, 180);
            cbxEscolaridade.Name = "cbxEscolaridade";
            cbxEscolaridade.Size = new Size(318, 23);
            cbxEscolaridade.TabIndex = 4;
            // 
            // gbxSexo
            // 
            gbxSexo.Controls.Add(rdbPrefiroNaoInformar);
            gbxSexo.Controls.Add(rdbFeminino);
            gbxSexo.Controls.Add(rdbMasculino);
            gbxSexo.Location = new Point(30, 229);
            gbxSexo.Name = "gbxSexo";
            gbxSexo.Size = new Size(169, 100);
            gbxSexo.TabIndex = 5;
            gbxSexo.TabStop = false;
            gbxSexo.Text = "Sexo";
            // 
            // rdbPrefiroNaoInformar
            // 
            rdbPrefiroNaoInformar.AutoSize = true;
            rdbPrefiroNaoInformar.Location = new Point(14, 66);
            rdbPrefiroNaoInformar.Name = "rdbPrefiroNaoInformar";
            rdbPrefiroNaoInformar.Size = new Size(132, 19);
            rdbPrefiroNaoInformar.TabIndex = 2;
            rdbPrefiroNaoInformar.TabStop = true;
            rdbPrefiroNaoInformar.Text = "Prefiro não informar";
            rdbPrefiroNaoInformar.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            rdbFeminino.AutoSize = true;
            rdbFeminino.Location = new Point(14, 43);
            rdbFeminino.Name = "rdbFeminino";
            rdbFeminino.Size = new Size(75, 19);
            rdbFeminino.TabIndex = 1;
            rdbFeminino.TabStop = true;
            rdbFeminino.Text = "Feminino";
            rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(14, 19);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblRenda
            // 
            lblRenda.AutoSize = true;
            lblRenda.Location = new Point(217, 228);
            lblRenda.Name = "lblRenda";
            lblRenda.Size = new Size(81, 15);
            lblRenda.TabIndex = 9;
            lblRenda.Text = "Renda Mensal";
            // 
            // nudRendaMensal
            // 
            nudRendaMensal.Location = new Point(217, 246);
            nudRendaMensal.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudRendaMensal.Name = "nudRendaMensal";
            nudRendaMensal.Size = new Size(131, 23);
            nudRendaMensal.TabIndex = 6;
            // 
            // chkPossuiFilhos
            // 
            chkPossuiFilhos.AutoSize = true;
            chkPossuiFilhos.Checked = true;
            chkPossuiFilhos.CheckState = CheckState.Indeterminate;
            chkPossuiFilhos.Location = new Point(217, 294);
            chkPossuiFilhos.Name = "chkPossuiFilhos";
            chkPossuiFilhos.Size = new Size(99, 19);
            chkPossuiFilhos.TabIndex = 7;
            chkPossuiFilhos.Text = "Possui Filhos?";
            chkPossuiFilhos.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(115, 350);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(114, 52);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 424);
            Controls.Add(btnSalvar);
            Controls.Add(chkPossuiFilhos);
            Controls.Add(nudRendaMensal);
            Controls.Add(lblRenda);
            Controls.Add(gbxSexo);
            Controls.Add(cbxEscolaridade);
            Controls.Add(lblEscolaridade);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(mkdTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(lblNomeCompleto);
            Controls.Add(txtNomeCompleto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            gbxSexo.ResumeLayout(false);
            gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRendaMensal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCompleto;
        private Label lblNomeCompleto;
        private Label lblTelefone;
        private MaskedTextBox mkdTelefone;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Label lblEscolaridade;
        private ComboBox cbxEscolaridade;
        private GroupBox gbxSexo;
        private RadioButton rdbPrefiroNaoInformar;
        private RadioButton rdbFeminino;
        private RadioButton rdbMasculino;
        private Label lblRenda;
        private NumericUpDown nudRendaMensal;
        private CheckBox chkPossuiFilhos;
        private Button btnSalvar;
    }
}