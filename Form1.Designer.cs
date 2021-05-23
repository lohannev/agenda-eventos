namespace Agenda_de_eventos_aula17
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttSair = new System.Windows.Forms.Button();
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.radioD6 = new System.Windows.Forms.RadioButton();
            this.radioD5 = new System.Windows.Forms.RadioButton();
            this.radioD4 = new System.Windows.Forms.RadioButton();
            this.radioD3 = new System.Windows.Forms.RadioButton();
            this.radioD2 = new System.Windows.Forms.RadioButton();
            this.radioD1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblinicio = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblAmarelo = new System.Windows.Forms.Label();
            this.gbDatas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mês:";
            // 
            // cmbMes
            // 
            this.cmbMes.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(56, 24);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(147, 23);
            this.cmbMes.TabIndex = 1;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpar.Location = new System.Drawing.Point(266, 24);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(94, 23);
            this.bttLimpar.TabIndex = 2;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // bttSair
            // 
            this.bttSair.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSair.Location = new System.Drawing.Point(387, 24);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(94, 23);
            this.bttSair.TabIndex = 3;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // gbDatas
            // 
            this.gbDatas.Controls.Add(this.radioD6);
            this.gbDatas.Controls.Add(this.radioD5);
            this.gbDatas.Controls.Add(this.radioD4);
            this.gbDatas.Controls.Add(this.radioD3);
            this.gbDatas.Controls.Add(this.radioD2);
            this.gbDatas.Controls.Add(this.radioD1);
            this.gbDatas.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbDatas.Location = new System.Drawing.Point(72, 117);
            this.gbDatas.Name = "gbDatas";
            this.gbDatas.Size = new System.Drawing.Size(354, 177);
            this.gbDatas.TabIndex = 4;
            this.gbDatas.TabStop = false;
            this.gbDatas.Text = "Datas";
            // 
            // radioD6
            // 
            this.radioD6.AutoSize = true;
            this.radioD6.ForeColor = System.Drawing.SystemColors.Control;
            this.radioD6.Location = new System.Drawing.Point(253, 122);
            this.radioD6.Name = "radioD6";
            this.radioD6.Size = new System.Drawing.Size(69, 21);
            this.radioD6.TabIndex = 5;
            this.radioD6.TabStop = true;
            this.radioD6.Text = "10/mai";
            this.radioD6.UseVisualStyleBackColor = true;
            this.radioD6.CheckedChanged += new System.EventHandler(this.radioD6_CheckedChanged);
            // 
            // radioD5
            // 
            this.radioD5.AutoSize = true;
            this.radioD5.ForeColor = System.Drawing.SystemColors.Control;
            this.radioD5.Location = new System.Drawing.Point(253, 77);
            this.radioD5.Name = "radioD5";
            this.radioD5.Size = new System.Drawing.Size(69, 21);
            this.radioD5.TabIndex = 4;
            this.radioD5.TabStop = true;
            this.radioD5.Text = "09/mai";
            this.radioD5.UseVisualStyleBackColor = true;
            this.radioD5.CheckedChanged += new System.EventHandler(this.radioD5_CheckedChanged);
            // 
            // radioD4
            // 
            this.radioD4.AutoSize = true;
            this.radioD4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioD4.Location = new System.Drawing.Point(253, 32);
            this.radioD4.Name = "radioD4";
            this.radioD4.Size = new System.Drawing.Size(69, 21);
            this.radioD4.TabIndex = 3;
            this.radioD4.TabStop = true;
            this.radioD4.Text = "08/mai";
            this.radioD4.UseVisualStyleBackColor = true;
            this.radioD4.CheckedChanged += new System.EventHandler(this.radioD4_CheckedChanged);
            // 
            // radioD3
            // 
            this.radioD3.AutoSize = true;
            this.radioD3.ForeColor = System.Drawing.SystemColors.Control;
            this.radioD3.Location = new System.Drawing.Point(17, 122);
            this.radioD3.Name = "radioD3";
            this.radioD3.Size = new System.Drawing.Size(69, 21);
            this.radioD3.TabIndex = 2;
            this.radioD3.TabStop = true;
            this.radioD3.Text = "07/mai";
            this.radioD3.UseVisualStyleBackColor = true;
            this.radioD3.CheckedChanged += new System.EventHandler(this.radioD3_CheckedChanged);
            // 
            // radioD2
            // 
            this.radioD2.AutoSize = true;
            this.radioD2.ForeColor = System.Drawing.SystemColors.Control;
            this.radioD2.Location = new System.Drawing.Point(17, 77);
            this.radioD2.Name = "radioD2";
            this.radioD2.Size = new System.Drawing.Size(69, 21);
            this.radioD2.TabIndex = 1;
            this.radioD2.TabStop = true;
            this.radioD2.Text = "06/mai";
            this.radioD2.UseVisualStyleBackColor = true;
            this.radioD2.CheckedChanged += new System.EventHandler(this.radioD2_CheckedChanged);
            // 
            // radioD1
            // 
            this.radioD1.AutoSize = true;
            this.radioD1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioD1.Location = new System.Drawing.Point(17, 32);
            this.radioD1.Name = "radioD1";
            this.radioD1.Size = new System.Drawing.Size(69, 21);
            this.radioD1.TabIndex = 0;
            this.radioD1.TabStop = true;
            this.radioD1.Text = "05/mai";
            this.radioD1.UseVisualStyleBackColor = true;
            this.radioD1.CheckedChanged += new System.EventHandler(this.radioD1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTermino);
            this.panel1.Controls.Add(this.lblEntrada);
            this.panel1.Controls.Add(this.lblinicio);
            this.panel1.Controls.Add(this.lblLocal);
            this.panel1.Controls.Add(this.lblEvento);
            this.panel1.Controls.Add(this.lblAmarelo);
            this.panel1.Location = new System.Drawing.Point(72, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 183);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(280, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(90, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(90, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(90, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(90, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermino.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTermino.Location = new System.Drawing.Point(203, 85);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(71, 21);
            this.lblTermino.TabIndex = 4;
            this.lblTermino.Text = "Término:";
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEntrada.Location = new System.Drawing.Point(13, 121);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(71, 21);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Entrada:";
            // 
            // lblinicio
            // 
            this.lblinicio.AutoSize = true;
            this.lblinicio.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblinicio.Location = new System.Drawing.Point(14, 85);
            this.lblinicio.Name = "lblinicio";
            this.lblinicio.Size = new System.Drawing.Size(52, 21);
            this.lblinicio.TabIndex = 2;
            this.lblinicio.Text = "Início:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLocal.Location = new System.Drawing.Point(14, 49);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(51, 21);
            this.lblLocal.TabIndex = 1;
            this.lblLocal.Text = "Local:";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEvento.Location = new System.Drawing.Point(14, 13);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(63, 21);
            this.lblEvento.TabIndex = 0;
            this.lblEvento.Text = "Evento:";
            // 
            // lblAmarelo
            // 
            this.lblAmarelo.AutoSize = true;
            this.lblAmarelo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarelo.ForeColor = System.Drawing.Color.Yellow;
            this.lblAmarelo.Location = new System.Drawing.Point(0, 70);
            this.lblAmarelo.Name = "lblAmarelo";
            this.lblAmarelo.Size = new System.Drawing.Size(351, 23);
            this.lblAmarelo.TabIndex = 6;
            this.lblAmarelo.Text = "Não foram encontrados eventos nessa data!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(510, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDatas);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(528, 574);
            this.MinimumSize = new System.Drawing.Size(528, 574);
            this.Name = "Form1";
            this.Text = "Agenda de eventos.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbDatas.ResumeLayout(false);
            this.gbDatas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.GroupBox gbDatas;
        private System.Windows.Forms.RadioButton radioD6;
        private System.Windows.Forms.RadioButton radioD5;
        private System.Windows.Forms.RadioButton radioD4;
        private System.Windows.Forms.RadioButton radioD3;
        private System.Windows.Forms.RadioButton radioD2;
        private System.Windows.Forms.RadioButton radioD1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblinicio;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Label lblAmarelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

