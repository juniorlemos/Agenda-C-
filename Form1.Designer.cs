namespace Agenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Painel = new System.Windows.Forms.Label();
            this.salvar = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.selecionar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Buscar = new System.Windows.Forms.Label();
            this.pesquisa = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.CpftextBox = new System.Windows.Forms.TextBox();
            this.TelefonetextBox = new System.Windows.Forms.TextBox();
            this.SexotextBox = new System.Windows.Forms.TextBox();
            this.NometextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Painel
            // 
            this.Painel.AutoSize = true;
            this.Painel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Painel.Location = new System.Drawing.Point(314, 14);
            this.Painel.Name = "Painel";
            this.Painel.Size = new System.Drawing.Size(176, 42);
            this.Painel.TabIndex = 0;
            this.Painel.Text = "AGENDA";
            this.Painel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(29, 157);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 1;
            this.salvar.Text = "SALVAR";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(568, 72);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 2;
            this.Deletar.Text = "DELETAR";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // selecionar
            // 
            this.selecionar.Location = new System.Drawing.Point(665, 72);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(83, 23);
            this.selecionar.TabIndex = 3;
            this.selecionar.Text = "SELECIONAR";
            this.selecionar.UseVisualStyleBackColor = true;
            this.selecionar.Click += new System.EventHandler(this.Selecionar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Location = new System.Drawing.Point(134, 157);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(75, 23);
            this.atualizar.TabIndex = 4;
            this.atualizar.Text = "ATUALIZAR";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(88, 14);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(51, 20);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(49, 88);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(40, 20);
            this.CPF.TabIndex = 6;
            this.CPF.Text = "CPF";
            this.CPF.Click += new System.EventHandler(this.CPF_Click);
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(135, 88);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(71, 20);
            this.telefone.TabIndex = 7;
            this.telefone.Text = "Telefone";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo.Location = new System.Drawing.Point(260, 88);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(45, 20);
            this.Sexo.TabIndex = 8;
            this.Sexo.Text = "Sexo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Buscar);
            this.panel1.Controls.Add(this.pesquisa);
            this.panel1.Controls.Add(this.dg);
            this.panel1.Controls.Add(this.CpftextBox);
            this.panel1.Controls.Add(this.TelefonetextBox);
            this.panel1.Controls.Add(this.SexotextBox);
            this.panel1.Controls.Add(this.NometextBox);
            this.panel1.Controls.Add(this.Sexo);
            this.panel1.Controls.Add(this.telefone);
            this.panel1.Controls.Add(this.CPF);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Controls.Add(this.atualizar);
            this.panel1.Controls.Add(this.selecionar);
            this.panel1.Controls.Add(this.Deletar);
            this.panel1.Controls.Add(this.salvar);
            this.panel1.Controls.Add(this.Painel);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 383);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(586, 23);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(40, 20);
            this.Buscar.TabIndex = 15;
            this.Buscar.Text = "CPF";
            // 
            // pesquisa
            // 
            this.pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisa.Location = new System.Drawing.Point(632, 23);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(87, 22);
            this.pesquisa.TabIndex = 14;
            this.pesquisa.TextChanged += new System.EventHandler(this.Pesquisa_TextChanged);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg.DefaultCellStyle = dataGridViewCellStyle6;
            this.dg.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dg.Location = new System.Drawing.Point(224, 206);
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.Size = new System.Drawing.Size(419, 110);
            this.dg.TabIndex = 13;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_CellContentClick_1);
            // 
            // CpftextBox
            // 
            this.CpftextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpftextBox.Location = new System.Drawing.Point(22, 111);
            this.CpftextBox.Name = "CpftextBox";
            this.CpftextBox.Size = new System.Drawing.Size(87, 22);
            this.CpftextBox.TabIndex = 12;
            this.CpftextBox.TextChanged += new System.EventHandler(this.CpftextBox_TextChanged);
            // 
            // TelefonetextBox
            // 
            this.TelefonetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonetextBox.Location = new System.Drawing.Point(136, 111);
            this.TelefonetextBox.Name = "TelefonetextBox";
            this.TelefonetextBox.Size = new System.Drawing.Size(70, 22);
            this.TelefonetextBox.TabIndex = 11;
            // 
            // SexotextBox
            // 
            this.SexotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexotextBox.Location = new System.Drawing.Point(237, 111);
            this.SexotextBox.Name = "SexotextBox";
            this.SexotextBox.Size = new System.Drawing.Size(84, 22);
            this.SexotextBox.TabIndex = 10;
            // 
            // NometextBox
            // 
            this.NometextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NometextBox.Location = new System.Drawing.Point(22, 46);
            this.NometextBox.Name = "NometextBox";
            this.NometextBox.Size = new System.Drawing.Size(184, 22);
            this.NometextBox.TabIndex = 9;
            this.NometextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Painel;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CpftextBox;
        private System.Windows.Forms.TextBox TelefonetextBox;
        private System.Windows.Forms.TextBox SexotextBox;
        private System.Windows.Forms.TextBox NometextBox;
        private System.Windows.Forms.TextBox pesquisa;
        private System.Windows.Forms.Label Buscar;
        private System.Windows.Forms.DataGridView dg;
    }
}

