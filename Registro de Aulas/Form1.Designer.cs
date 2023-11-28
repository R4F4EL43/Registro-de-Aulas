namespace Registro_de_Aulas {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.fld1_Aulas = new System.Windows.Forms.OpenFileDialog();
            this.tbc_Aulas = new System.Windows.Forms.TabControl();
            this.tbp_RegistoAulas = new System.Windows.Forms.TabPage();
            this.chk1_Faltou = new System.Windows.Forms.CheckBox();
            this.chk1_Docente = new System.Windows.Forms.CheckBox();
            this.chk1_Disciplina = new System.Windows.Forms.CheckBox();
            this.chk1_Turma = new System.Windows.Forms.CheckBox();
            this.lbl1_File = new System.Windows.Forms.Label();
            this.lvw1_Registo = new System.Windows.Forms.ListView();
            this.ch1_Turma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Disciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Duracao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Docente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Modulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Turno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch1_Faltou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mns1_Navegacao = new System.Windows.Forms.MenuStrip();
            this.tsi1_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi1_GenerateCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi1_GenerateJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.tbp_Plano = new System.Windows.Forms.TabPage();
            this.txt2_Search = new System.Windows.Forms.TextBox();
            this.lbl2_File = new System.Windows.Forms.Label();
            this.mns2_Execucao = new System.Windows.Forms.MenuStrip();
            this.tsi2_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi2_GenerateXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi2_GenerateBIN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsi2_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.lvw2_Plano = new System.Windows.Forms.ListView();
            this.ch2_Turma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2_Disciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2_HorasAnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2_HorasAt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2_TotalHoras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fld2_Plano = new System.Windows.Forms.OpenFileDialog();
            this.tbp_ReadFiles = new System.Windows.Forms.TabPage();
            this.tbc_Aulas.SuspendLayout();
            this.tbp_RegistoAulas.SuspendLayout();
            this.mns1_Navegacao.SuspendLayout();
            this.tbp_Plano.SuspendLayout();
            this.mns2_Execucao.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld1_Aulas
            // 
            this.fld1_Aulas.DefaultExt = "Ambiente de trabalho";
            this.fld1_Aulas.FileOk += new System.ComponentModel.CancelEventHandler(this.fld1_Aulas_FileOk);
            // 
            // tbc_Aulas
            // 
            this.tbc_Aulas.Controls.Add(this.tbp_RegistoAulas);
            this.tbc_Aulas.Controls.Add(this.tbp_Plano);
            this.tbc_Aulas.Controls.Add(this.tbp_ReadFiles);
            this.tbc_Aulas.Location = new System.Drawing.Point(12, 13);
            this.tbc_Aulas.Name = "tbc_Aulas";
            this.tbc_Aulas.SelectedIndex = 0;
            this.tbc_Aulas.Size = new System.Drawing.Size(1422, 586);
            this.tbc_Aulas.TabIndex = 0;
            // 
            // tbp_RegistoAulas
            // 
            this.tbp_RegistoAulas.Controls.Add(this.chk1_Faltou);
            this.tbp_RegistoAulas.Controls.Add(this.chk1_Docente);
            this.tbp_RegistoAulas.Controls.Add(this.chk1_Disciplina);
            this.tbp_RegistoAulas.Controls.Add(this.chk1_Turma);
            this.tbp_RegistoAulas.Controls.Add(this.lbl1_File);
            this.tbp_RegistoAulas.Controls.Add(this.lvw1_Registo);
            this.tbp_RegistoAulas.Controls.Add(this.mns1_Navegacao);
            this.tbp_RegistoAulas.Location = new System.Drawing.Point(4, 29);
            this.tbp_RegistoAulas.Name = "tbp_RegistoAulas";
            this.tbp_RegistoAulas.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_RegistoAulas.Size = new System.Drawing.Size(1414, 553);
            this.tbp_RegistoAulas.TabIndex = 0;
            this.tbp_RegistoAulas.Text = "Aulas";
            this.tbp_RegistoAulas.UseVisualStyleBackColor = true;
            // 
            // chk1_Faltou
            // 
            this.chk1_Faltou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk1_Faltou.AutoSize = true;
            this.chk1_Faltou.Location = new System.Drawing.Point(1249, 165);
            this.chk1_Faltou.Name = "chk1_Faltou";
            this.chk1_Faltou.Size = new System.Drawing.Size(80, 24);
            this.chk1_Faltou.TabIndex = 18;
            this.chk1_Faltou.Text = "Faltou";
            this.chk1_Faltou.UseVisualStyleBackColor = true;
            this.chk1_Faltou.CheckedChanged += new System.EventHandler(this.chk1_Faltou_CheckedChanged);
            // 
            // chk1_Docente
            // 
            this.chk1_Docente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk1_Docente.AutoSize = true;
            this.chk1_Docente.Location = new System.Drawing.Point(1249, 125);
            this.chk1_Docente.Name = "chk1_Docente";
            this.chk1_Docente.Size = new System.Drawing.Size(96, 24);
            this.chk1_Docente.TabIndex = 17;
            this.chk1_Docente.Text = "Docente";
            this.chk1_Docente.UseVisualStyleBackColor = true;
            this.chk1_Docente.CheckedChanged += new System.EventHandler(this.chk1_Docente_CheckedChanged);
            // 
            // chk1_Disciplina
            // 
            this.chk1_Disciplina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk1_Disciplina.AutoSize = true;
            this.chk1_Disciplina.Location = new System.Drawing.Point(1249, 84);
            this.chk1_Disciplina.Name = "chk1_Disciplina";
            this.chk1_Disciplina.Size = new System.Drawing.Size(102, 24);
            this.chk1_Disciplina.TabIndex = 16;
            this.chk1_Disciplina.Text = "Disciplina";
            this.chk1_Disciplina.UseVisualStyleBackColor = true;
            this.chk1_Disciplina.CheckedChanged += new System.EventHandler(this.chk1_Disciplina_CheckedChanged);
            // 
            // chk1_Turma
            // 
            this.chk1_Turma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk1_Turma.AutoSize = true;
            this.chk1_Turma.Location = new System.Drawing.Point(1249, 43);
            this.chk1_Turma.Name = "chk1_Turma";
            this.chk1_Turma.Size = new System.Drawing.Size(117, 24);
            this.chk1_Turma.TabIndex = 15;
            this.chk1_Turma.Text = "Cód. Turma";
            this.chk1_Turma.UseVisualStyleBackColor = true;
            this.chk1_Turma.CheckedChanged += new System.EventHandler(this.chk1_Turma_CheckedChanged);
            // 
            // lbl1_File
            // 
            this.lbl1_File.AutoSize = true;
            this.lbl1_File.Location = new System.Drawing.Point(5, 124);
            this.lbl1_File.Name = "lbl1_File";
            this.lbl1_File.Size = new System.Drawing.Size(0, 20);
            this.lbl1_File.TabIndex = 14;
            // 
            // lvw1_Registo
            // 
            this.lvw1_Registo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1_Turma,
            this.ch1_Disciplina,
            this.ch1_Data,
            this.ch1_Duracao,
            this.ch1_Docente,
            this.ch1_Modulo,
            this.ch1_Turno,
            this.ch1_Faltou});
            this.lvw1_Registo.HideSelection = false;
            this.lvw1_Registo.Location = new System.Drawing.Point(6, 219);
            this.lvw1_Registo.Name = "lvw1_Registo";
            this.lvw1_Registo.Size = new System.Drawing.Size(1394, 328);
            this.lvw1_Registo.TabIndex = 13;
            this.lvw1_Registo.UseCompatibleStateImageBehavior = false;
            this.lvw1_Registo.View = System.Windows.Forms.View.Details;
            // 
            // ch1_Turma
            // 
            this.ch1_Turma.Text = "Cód. Turma";
            this.ch1_Turma.Width = 130;
            // 
            // ch1_Disciplina
            // 
            this.ch1_Disciplina.Text = "Nome Disciplina";
            this.ch1_Disciplina.Width = 130;
            // 
            // ch1_Data
            // 
            this.ch1_Data.Text = "Data";
            this.ch1_Data.Width = 130;
            // 
            // ch1_Duracao
            // 
            this.ch1_Duracao.Text = "Duração Aula";
            this.ch1_Duracao.Width = 110;
            // 
            // ch1_Docente
            // 
            this.ch1_Docente.Text = "Nome Docente";
            this.ch1_Docente.Width = 130;
            // 
            // ch1_Modulo
            // 
            this.ch1_Modulo.Text = "Num. Modulo";
            this.ch1_Modulo.Width = 110;
            // 
            // ch1_Turno
            // 
            this.ch1_Turno.Text = "Cod. Turno";
            this.ch1_Turno.Width = 110;
            // 
            // ch1_Faltou
            // 
            this.ch1_Faltou.Text = "Docente Faltou";
            this.ch1_Faltou.Width = 130;
            // 
            // mns1_Navegacao
            // 
            this.mns1_Navegacao.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mns1_Navegacao.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns1_Navegacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi1_Open,
            this.tsi1_GenerateCSV,
            this.tsi1_GenerateJSON});
            this.mns1_Navegacao.Location = new System.Drawing.Point(3, 3);
            this.mns1_Navegacao.Name = "mns1_Navegacao";
            this.mns1_Navegacao.Size = new System.Drawing.Size(1408, 33);
            this.mns1_Navegacao.TabIndex = 20;
            this.mns1_Navegacao.Text = "menuStrip1";
            // 
            // tsi1_Open
            // 
            this.tsi1_Open.Name = "tsi1_Open";
            this.tsi1_Open.Size = new System.Drawing.Size(72, 29);
            this.tsi1_Open.Text = "Open";
            this.tsi1_Open.Click += new System.EventHandler(this.tsi1_Open_Click);
            // 
            // tsi1_GenerateCSV
            // 
            this.tsi1_GenerateCSV.Name = "tsi1_GenerateCSV";
            this.tsi1_GenerateCSV.Size = new System.Drawing.Size(142, 29);
            this.tsi1_GenerateCSV.Text = "Generate (.csv)";
            this.tsi1_GenerateCSV.Click += new System.EventHandler(this.tsi1_GenerateCSV_Click);
            // 
            // tsi1_GenerateJSON
            // 
            this.tsi1_GenerateJSON.Name = "tsi1_GenerateJSON";
            this.tsi1_GenerateJSON.Size = new System.Drawing.Size(150, 29);
            this.tsi1_GenerateJSON.Text = "Generate (.json)";
            this.tsi1_GenerateJSON.Click += new System.EventHandler(this.tsi1_GenerateJSON_Click);
            // 
            // tbp_Plano
            // 
            this.tbp_Plano.Controls.Add(this.txt2_Search);
            this.tbp_Plano.Controls.Add(this.lbl2_File);
            this.tbp_Plano.Controls.Add(this.mns2_Execucao);
            this.tbp_Plano.Controls.Add(this.lvw2_Plano);
            this.tbp_Plano.Location = new System.Drawing.Point(4, 29);
            this.tbp_Plano.Name = "tbp_Plano";
            this.tbp_Plano.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Plano.Size = new System.Drawing.Size(1414, 553);
            this.tbp_Plano.TabIndex = 1;
            this.tbp_Plano.Text = "Plano Curricular";
            this.tbp_Plano.UseVisualStyleBackColor = true;
            // 
            // txt2_Search
            // 
            this.txt2_Search.Location = new System.Drawing.Point(1213, 39);
            this.txt2_Search.Name = "txt2_Search";
            this.txt2_Search.Size = new System.Drawing.Size(184, 26);
            this.txt2_Search.TabIndex = 23;
            this.txt2_Search.TextChanged += new System.EventHandler(this.txt2_Search_TextChanged);
            // 
            // lbl2_File
            // 
            this.lbl2_File.AutoSize = true;
            this.lbl2_File.Location = new System.Drawing.Point(5, 124);
            this.lbl2_File.Name = "lbl2_File";
            this.lbl2_File.Size = new System.Drawing.Size(0, 20);
            this.lbl2_File.TabIndex = 22;
            // 
            // mns2_Execucao
            // 
            this.mns2_Execucao.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mns2_Execucao.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mns2_Execucao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsi2_Open,
            this.tsi2_GenerateXML,
            this.tsi2_GenerateBIN,
            this.tsi2_Update});
            this.mns2_Execucao.Location = new System.Drawing.Point(3, 3);
            this.mns2_Execucao.Name = "mns2_Execucao";
            this.mns2_Execucao.Size = new System.Drawing.Size(1408, 33);
            this.mns2_Execucao.TabIndex = 21;
            this.mns2_Execucao.Text = "menuStrip1";
            // 
            // tsi2_Open
            // 
            this.tsi2_Open.Name = "tsi2_Open";
            this.tsi2_Open.Size = new System.Drawing.Size(72, 29);
            this.tsi2_Open.Text = "Open";
            this.tsi2_Open.Click += new System.EventHandler(this.tsi2_Open_Click);
            // 
            // tsi2_GenerateXML
            // 
            this.tsi2_GenerateXML.Name = "tsi2_GenerateXML";
            this.tsi2_GenerateXML.Size = new System.Drawing.Size(145, 29);
            this.tsi2_GenerateXML.Text = "Generate (.xml)";
            this.tsi2_GenerateXML.Click += new System.EventHandler(this.tsi2_GenerateXML_Click);
            // 
            // tsi2_GenerateBIN
            // 
            this.tsi2_GenerateBIN.Name = "tsi2_GenerateBIN";
            this.tsi2_GenerateBIN.Size = new System.Drawing.Size(138, 29);
            this.tsi2_GenerateBIN.Text = "Generate (bin)";
            this.tsi2_GenerateBIN.Click += new System.EventHandler(this.tsi2_GenerateBIN_Click);
            // 
            // tsi2_Update
            // 
            this.tsi2_Update.Name = "tsi2_Update";
            this.tsi2_Update.Size = new System.Drawing.Size(86, 29);
            this.tsi2_Update.Text = "Update";
            this.tsi2_Update.Click += new System.EventHandler(this.tsi2_Update_Click);
            // 
            // lvw2_Plano
            // 
            this.lvw2_Plano.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch2_Turma,
            this.ch2_Disciplina,
            this.ch2_HorasAnt,
            this.ch2_HorasAt,
            this.ch2_TotalHoras});
            this.lvw2_Plano.HideSelection = false;
            this.lvw2_Plano.Location = new System.Drawing.Point(6, 219);
            this.lvw2_Plano.Name = "lvw2_Plano";
            this.lvw2_Plano.Size = new System.Drawing.Size(1391, 328);
            this.lvw2_Plano.TabIndex = 14;
            this.lvw2_Plano.UseCompatibleStateImageBehavior = false;
            this.lvw2_Plano.View = System.Windows.Forms.View.Details;
            // 
            // ch2_Turma
            // 
            this.ch2_Turma.Text = "Cód. Turma";
            this.ch2_Turma.Width = 180;
            // 
            // ch2_Disciplina
            // 
            this.ch2_Disciplina.Text = "Nome Disciplina";
            this.ch2_Disciplina.Width = 180;
            // 
            // ch2_HorasAnt
            // 
            this.ch2_HorasAnt.Text = "Horas Anteriores";
            this.ch2_HorasAnt.Width = 130;
            // 
            // ch2_HorasAt
            // 
            this.ch2_HorasAt.Text = "Horas AnoLetivo";
            this.ch2_HorasAt.Width = 110;
            // 
            // ch2_TotalHoras
            // 
            this.ch2_TotalHoras.Text = "Total de Horas";
            this.ch2_TotalHoras.Width = 130;
            // 
            // fld2_Plano
            // 
            this.fld2_Plano.FileOk += new System.ComponentModel.CancelEventHandler(this.fld2_Plano_FileOk);
            // 
            // tbp_ReadFiles
            // 
            this.tbp_ReadFiles.Location = new System.Drawing.Point(4, 29);
            this.tbp_ReadFiles.Name = "tbp_ReadFiles";
            this.tbp_ReadFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ReadFiles.Size = new System.Drawing.Size(1414, 553);
            this.tbp_ReadFiles.TabIndex = 2;
            this.tbp_ReadFiles.Text = "Ler Ficheiros";
            this.tbp_ReadFiles.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 611);
            this.Controls.Add(this.tbc_Aulas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mns1_Navegacao;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Registo de Faltas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbc_Aulas.ResumeLayout(false);
            this.tbp_RegistoAulas.ResumeLayout(false);
            this.tbp_RegistoAulas.PerformLayout();
            this.mns1_Navegacao.ResumeLayout(false);
            this.mns1_Navegacao.PerformLayout();
            this.tbp_Plano.ResumeLayout(false);
            this.tbp_Plano.PerformLayout();
            this.mns2_Execucao.ResumeLayout(false);
            this.mns2_Execucao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog fld1_Aulas;
        private System.Windows.Forms.TabControl tbc_Aulas;
        private System.Windows.Forms.TabPage tbp_RegistoAulas;
        private System.Windows.Forms.CheckBox chk1_Faltou;
        private System.Windows.Forms.CheckBox chk1_Docente;
        private System.Windows.Forms.CheckBox chk1_Disciplina;
        private System.Windows.Forms.CheckBox chk1_Turma;
        private System.Windows.Forms.Label lbl1_File;
        private System.Windows.Forms.ListView lvw1_Registo;
        private System.Windows.Forms.ColumnHeader ch1_Turma;
        private System.Windows.Forms.ColumnHeader ch1_Disciplina;
        private System.Windows.Forms.ColumnHeader ch1_Data;
        private System.Windows.Forms.ColumnHeader ch1_Duracao;
        private System.Windows.Forms.ColumnHeader ch1_Docente;
        private System.Windows.Forms.ColumnHeader ch1_Modulo;
        private System.Windows.Forms.ColumnHeader ch1_Turno;
        private System.Windows.Forms.ColumnHeader ch1_Faltou;
        private System.Windows.Forms.TabPage tbp_Plano;
        private System.Windows.Forms.ListView lvw2_Plano;
        private System.Windows.Forms.ColumnHeader ch2_Turma;
        private System.Windows.Forms.ColumnHeader ch2_Disciplina;
        private System.Windows.Forms.ColumnHeader ch2_HorasAnt;
        private System.Windows.Forms.ColumnHeader ch2_HorasAt;
        private System.Windows.Forms.ColumnHeader ch2_TotalHoras;
        private System.Windows.Forms.MenuStrip mns2_Execucao;
        private System.Windows.Forms.ToolStripMenuItem tsi2_Open;
        private System.Windows.Forms.ToolStripMenuItem tsi2_GenerateXML;
        private System.Windows.Forms.OpenFileDialog fld2_Plano;
        private System.Windows.Forms.MenuStrip mns1_Navegacao;
        private System.Windows.Forms.ToolStripMenuItem tsi1_Open;
        private System.Windows.Forms.ToolStripMenuItem tsi1_GenerateCSV;
        private System.Windows.Forms.ToolStripMenuItem tsi2_Update;
        private System.Windows.Forms.Label lbl2_File;
        private System.Windows.Forms.ToolStripMenuItem tsi1_GenerateJSON;
        private System.Windows.Forms.TextBox txt2_Search;
        private System.Windows.Forms.ToolStripMenuItem tsi2_GenerateBIN;
        private System.Windows.Forms.TabPage tbp_ReadFiles;
    }
}

