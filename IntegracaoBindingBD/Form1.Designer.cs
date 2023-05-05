namespace IntegracaoBindingBD
{
    partial class Integracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Integracao));
            this.DadosBiding = new System.Windows.Forms.DataGridView();
            this.affinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affinity_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monomerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhibitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanimoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busca_TargetByCompound = new System.Windows.Forms.Button();
            this.buscar_getLigandsByUniprot = new System.Windows.Forms.Button();
            this.buscar_getLigandsByUniprots = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.param2UniprotLabel = new System.Windows.Forms.Label();
            this.param1UniprotLabel = new System.Windows.Forms.Label();
            this.param2UniprotstextBox = new System.Windows.Forms.TextBox();
            this.param1UnitprottextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.param2Comlabel1 = new System.Windows.Forms.Label();
            this.param1Comlabel = new System.Windows.Forms.Label();
            this.param2ComptextBox = new System.Windows.Forms.TextBox();
            this.param1ComptextBox = new System.Windows.Forms.TextBox();
            this.DeletaLinha = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.Senhalabel = new System.Windows.Forms.Label();
            this.SenhatextBox = new System.Windows.Forms.TextBox();
            this.NomeArqlabel = new System.Windows.Forms.Label();
            this.NomeArqtextBox = new System.Windows.Forms.TextBox();
            this.CarregaAutcheckBox = new System.Windows.Forms.CheckBox();
            this.ApendaBuscacheckBox = new System.Windows.Forms.CheckBox();
            this.oSeccionaArqlabel = new System.Windows.Forms.Label();
            this.oSeccionaArqnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DadosBiding)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSeccionaArqnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DadosBiding
            // 
            this.DadosBiding.AllowDrop = true;
            this.DadosBiding.AllowUserToOrderColumns = true;
            this.DadosBiding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DadosBiding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DadosBiding.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.affinity,
            this.affinity_type,
            this.monomerid,
            this.smiles,
            this.inchi,
            this.inhibitor,
            this.species,
            this.tanimoto,
            this.target});
            this.DadosBiding.Location = new System.Drawing.Point(2, 150);
            this.DadosBiding.Name = "DadosBiding";
            this.DadosBiding.Size = new System.Drawing.Size(948, 298);
            this.DadosBiding.TabIndex = 2;
            // 
            // affinity
            // 
            this.affinity.HeaderText = "affinity";
            this.affinity.Name = "affinity";
            // 
            // affinity_type
            // 
            this.affinity_type.HeaderText = "affinity_type";
            this.affinity_type.Name = "affinity_type";
            // 
            // monomerid
            // 
            this.monomerid.HeaderText = "monomerid";
            this.monomerid.Name = "monomerid";
            // 
            // smiles
            // 
            this.smiles.HeaderText = "smiles";
            this.smiles.Name = "smiles";
            // 
            // inchi
            // 
            this.inchi.HeaderText = "inchi";
            this.inchi.Name = "inchi";
            // 
            // inhibitor
            // 
            this.inhibitor.HeaderText = "inhibitor";
            this.inhibitor.Name = "inhibitor";
            // 
            // species
            // 
            this.species.HeaderText = "species";
            this.species.Name = "species";
            // 
            // tanimoto
            // 
            this.tanimoto.HeaderText = "tanimoto";
            this.tanimoto.Name = "tanimoto";
            // 
            // target
            // 
            this.target.HeaderText = "target";
            this.target.Name = "target";
            // 
            // busca_TargetByCompound
            // 
            this.busca_TargetByCompound.Image = ((System.Drawing.Image)(resources.GetObject("busca_TargetByCompound.Image")));
            this.busca_TargetByCompound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.busca_TargetByCompound.Location = new System.Drawing.Point(2, 120);
            this.busca_TargetByCompound.Name = "busca_TargetByCompound";
            this.busca_TargetByCompound.Size = new System.Drawing.Size(173, 24);
            this.busca_TargetByCompound.TabIndex = 3;
            this.busca_TargetByCompound.Text = "getTargetByCompound";
            this.busca_TargetByCompound.UseVisualStyleBackColor = true;
            this.busca_TargetByCompound.Click += new System.EventHandler(this.buscar_Click);
            // 
            // buscar_getLigandsByUniprot
            // 
            this.buscar_getLigandsByUniprot.Image = ((System.Drawing.Image)(resources.GetObject("buscar_getLigandsByUniprot.Image")));
            this.buscar_getLigandsByUniprot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscar_getLigandsByUniprot.Location = new System.Drawing.Point(181, 121);
            this.buscar_getLigandsByUniprot.Name = "buscar_getLigandsByUniprot";
            this.buscar_getLigandsByUniprot.Size = new System.Drawing.Size(173, 23);
            this.buscar_getLigandsByUniprot.TabIndex = 4;
            this.buscar_getLigandsByUniprot.Text = "getLigandsByUniprot";
            this.buscar_getLigandsByUniprot.UseVisualStyleBackColor = true;
            this.buscar_getLigandsByUniprot.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buscar_getLigandsByUniprots
            // 
            this.buscar_getLigandsByUniprots.Enabled = false;
            this.buscar_getLigandsByUniprots.Location = new System.Drawing.Point(360, 121);
            this.buscar_getLigandsByUniprots.Name = "buscar_getLigandsByUniprots";
            this.buscar_getLigandsByUniprots.Size = new System.Drawing.Size(173, 23);
            this.buscar_getLigandsByUniprots.TabIndex = 5;
            this.buscar_getLigandsByUniprots.Text = "getLigandsByUniprots";
            this.buscar_getLigandsByUniprots.UseVisualStyleBackColor = true;
            this.buscar_getLigandsByUniprots.Visible = false;
            this.buscar_getLigandsByUniprots.Click += new System.EventHandler(this.buscargetLigandsByUniprot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-113, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "getLigandsByUniprots";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.param2UniprotLabel);
            this.groupBox1.Controls.Add(this.param1UniprotLabel);
            this.groupBox1.Controls.Add(this.param2UniprotstextBox);
            this.groupBox1.Controls.Add(this.param1UnitprottextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 44);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uniprot";
            // 
            // param2UniprotLabel
            // 
            this.param2UniprotLabel.AutoSize = true;
            this.param2UniprotLabel.Location = new System.Drawing.Point(430, 26);
            this.param2UniprotLabel.Name = "param2UniprotLabel";
            this.param2UniprotLabel.Size = new System.Drawing.Size(38, 13);
            this.param2UniprotLabel.TabIndex = 13;
            this.param2UniprotLabel.Text = "Cutoff:";
            // 
            // param1UniprotLabel
            // 
            this.param1UniprotLabel.AutoSize = true;
            this.param1UniprotLabel.Location = new System.Drawing.Point(18, 22);
            this.param1UniprotLabel.Name = "param1UniprotLabel";
            this.param1UniprotLabel.Size = new System.Drawing.Size(44, 13);
            this.param1UniprotLabel.TabIndex = 12;
            this.param1UniprotLabel.Text = "Uniprot:";
            // 
            // param2UniprotstextBox
            // 
            this.param2UniprotstextBox.Location = new System.Drawing.Point(474, 19);
            this.param2UniprotstextBox.Name = "param2UniprotstextBox";
            this.param2UniprotstextBox.Size = new System.Drawing.Size(162, 20);
            this.param2UniprotstextBox.TabIndex = 11;
            this.param2UniprotstextBox.Text = "1000";
            this.param2UniprotstextBox.TextChanged += new System.EventHandler(this.param2UniprotstextBox_TextChanged);
            // 
            // param1UnitprottextBox
            // 
            this.param1UnitprottextBox.Location = new System.Drawing.Point(71, 19);
            this.param1UnitprottextBox.Name = "param1UnitprottextBox";
            this.param1UnitprottextBox.Size = new System.Drawing.Size(162, 20);
            this.param1UnitprottextBox.TabIndex = 10;
            this.param1UnitprottextBox.Text = "P35355";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.param2Comlabel1);
            this.groupBox2.Controls.Add(this.param1Comlabel);
            this.groupBox2.Controls.Add(this.param2ComptextBox);
            this.groupBox2.Controls.Add(this.param1ComptextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 48);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compound";
            // 
            // param2Comlabel1
            // 
            this.param2Comlabel1.AutoSize = true;
            this.param2Comlabel1.Location = new System.Drawing.Point(420, 26);
            this.param2Comlabel1.Name = "param2Comlabel1";
            this.param2Comlabel1.Size = new System.Drawing.Size(38, 13);
            this.param2Comlabel1.TabIndex = 18;
            this.param2Comlabel1.Text = "Cutoff:";
            // 
            // param1Comlabel
            // 
            this.param1Comlabel.AutoSize = true;
            this.param1Comlabel.Location = new System.Drawing.Point(17, 22);
            this.param1Comlabel.Name = "param1Comlabel";
            this.param1Comlabel.Size = new System.Drawing.Size(35, 13);
            this.param1Comlabel.TabIndex = 17;
            this.param1Comlabel.Text = "Smile:";
            // 
            // param2ComptextBox
            // 
            this.param2ComptextBox.Location = new System.Drawing.Point(464, 19);
            this.param2ComptextBox.Name = "param2ComptextBox";
            this.param2ComptextBox.Size = new System.Drawing.Size(162, 20);
            this.param2ComptextBox.TabIndex = 16;
            this.param2ComptextBox.Text = "0.9";
            // 
            // param1ComptextBox
            // 
            this.param1ComptextBox.Location = new System.Drawing.Point(61, 19);
            this.param1ComptextBox.Name = "param1ComptextBox";
            this.param1ComptextBox.Size = new System.Drawing.Size(353, 20);
            this.param1ComptextBox.TabIndex = 15;
            this.param1ComptextBox.Text = "CN(c1cccc(F)c1)c1cc(nc(N)n1)-c1c[nH]c2ncc(cc12)-c1cnn(C)c1";
            // 
            // DeletaLinha
            // 
            this.DeletaLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletaLinha.Image = ((System.Drawing.Image)(resources.GetObject("DeletaLinha.Image")));
            this.DeletaLinha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletaLinha.Location = new System.Drawing.Point(777, 121);
            this.DeletaLinha.Name = "DeletaLinha";
            this.DeletaLinha.Size = new System.Drawing.Size(173, 23);
            this.DeletaLinha.TabIndex = 19;
            this.DeletaLinha.Text = "Deleta Linha";
            this.DeletaLinha.UseVisualStyleBackColor = true;
            this.DeletaLinha.Click += new System.EventHandler(this.DeletaLinha_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(875, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Integrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogintextBox
            // 
            this.LogintextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogintextBox.Location = new System.Drawing.Point(757, 34);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(115, 20);
            this.LogintextBox.TabIndex = 21;
            // 
            // Loginlabel
            // 
            this.Loginlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Location = new System.Drawing.Point(699, 41);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(36, 13);
            this.Loginlabel.TabIndex = 22;
            this.Loginlabel.Text = "Login:";
            // 
            // Senhalabel
            // 
            this.Senhalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Senhalabel.AutoSize = true;
            this.Senhalabel.Location = new System.Drawing.Point(699, 73);
            this.Senhalabel.Name = "Senhalabel";
            this.Senhalabel.Size = new System.Drawing.Size(41, 13);
            this.Senhalabel.TabIndex = 24;
            this.Senhalabel.Text = "Senha:";
            // 
            // SenhatextBox
            // 
            this.SenhatextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SenhatextBox.Location = new System.Drawing.Point(757, 66);
            this.SenhatextBox.Name = "SenhatextBox";
            this.SenhatextBox.Size = new System.Drawing.Size(115, 20);
            this.SenhatextBox.TabIndex = 23;
            this.SenhatextBox.UseSystemPasswordChar = true;
            // 
            // NomeArqlabel
            // 
            this.NomeArqlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeArqlabel.AutoSize = true;
            this.NomeArqlabel.Location = new System.Drawing.Point(680, 101);
            this.NomeArqlabel.Name = "NomeArqlabel";
            this.NomeArqlabel.Size = new System.Drawing.Size(60, 13);
            this.NomeArqlabel.TabIndex = 26;
            this.NomeArqlabel.Text = "Nome Arq.:";
            // 
            // NomeArqtextBox
            // 
            this.NomeArqtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NomeArqtextBox.Location = new System.Drawing.Point(757, 95);
            this.NomeArqtextBox.Name = "NomeArqtextBox";
            this.NomeArqtextBox.Size = new System.Drawing.Size(115, 20);
            this.NomeArqtextBox.TabIndex = 25;
            // 
            // CarregaAutcheckBox
            // 
            this.CarregaAutcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CarregaAutcheckBox.AutoSize = true;
            this.CarregaAutcheckBox.Checked = true;
            this.CarregaAutcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CarregaAutcheckBox.Location = new System.Drawing.Point(875, 73);
            this.CarregaAutcheckBox.Name = "CarregaAutcheckBox";
            this.CarregaAutcheckBox.Size = new System.Drawing.Size(84, 17);
            this.CarregaAutcheckBox.TabIndex = 27;
            this.CarregaAutcheckBox.Text = "Carrega aut.";
            this.CarregaAutcheckBox.UseVisualStyleBackColor = true;
            // 
            // ApendaBuscacheckBox
            // 
            this.ApendaBuscacheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApendaBuscacheckBox.AutoSize = true;
            this.ApendaBuscacheckBox.Checked = true;
            this.ApendaBuscacheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ApendaBuscacheckBox.Location = new System.Drawing.Point(677, 127);
            this.ApendaBuscacheckBox.Name = "ApendaBuscacheckBox";
            this.ApendaBuscacheckBox.Size = new System.Drawing.Size(95, 17);
            this.ApendaBuscacheckBox.TabIndex = 28;
            this.ApendaBuscacheckBox.Text = "Apenda busca";
            this.ApendaBuscacheckBox.UseVisualStyleBackColor = true;
            // 
            // oSeccionaArqlabel
            // 
            this.oSeccionaArqlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oSeccionaArqlabel.AutoSize = true;
            this.oSeccionaArqlabel.Location = new System.Drawing.Point(533, 131);
            this.oSeccionaArqlabel.Name = "oSeccionaArqlabel";
            this.oSeccionaArqlabel.Size = new System.Drawing.Size(76, 13);
            this.oSeccionaArqlabel.TabIndex = 30;
            this.oSeccionaArqlabel.Text = "Secciona arq.:";
            this.oSeccionaArqlabel.Visible = false;
            // 
            // oSeccionaArqnumericUpDown
            // 
            this.oSeccionaArqnumericUpDown.Location = new System.Drawing.Point(615, 126);
            this.oSeccionaArqnumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.oSeccionaArqnumericUpDown.Name = "oSeccionaArqnumericUpDown";
            this.oSeccionaArqnumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.oSeccionaArqnumericUpDown.TabIndex = 31;
            this.oSeccionaArqnumericUpDown.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Desenvolvido por: ADA Tecnologia 4.0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(700, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Dados OCHEM:";
            // 
            // Integracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oSeccionaArqnumericUpDown);
            this.Controls.Add(this.oSeccionaArqlabel);
            this.Controls.Add(this.ApendaBuscacheckBox);
            this.Controls.Add(this.CarregaAutcheckBox);
            this.Controls.Add(this.NomeArqlabel);
            this.Controls.Add(this.NomeArqtextBox);
            this.Controls.Add(this.Senhalabel);
            this.Controls.Add(this.SenhatextBox);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DeletaLinha);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buscar_getLigandsByUniprots);
            this.Controls.Add(this.buscar_getLigandsByUniprot);
            this.Controls.Add(this.busca_TargetByCompound);
            this.Controls.Add(this.DadosBiding);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(978, 491);
            this.Name = "Integracao";
            this.Text = "Integração BidenDB OCHEM";
            ((System.ComponentModel.ISupportInitialize)(this.DadosBiding)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oSeccionaArqnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DadosBiding;
        private System.Windows.Forms.Button busca_TargetByCompound;
        private System.Windows.Forms.Button buscar_getLigandsByUniprot;
        private System.Windows.Forms.Button buscar_getLigandsByUniprots;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn affinity;
        private System.Windows.Forms.DataGridViewTextBoxColumn affinity_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn monomerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn smiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn inchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn inhibitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn species;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanimoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn target;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label param2UniprotLabel;
        private System.Windows.Forms.Label param1UniprotLabel;
        private System.Windows.Forms.TextBox param2UniprotstextBox;
        private System.Windows.Forms.TextBox param1UnitprottextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label param2Comlabel1;
        private System.Windows.Forms.Label param1Comlabel;
        private System.Windows.Forms.TextBox param2ComptextBox;
        private System.Windows.Forms.TextBox param1ComptextBox;
        private System.Windows.Forms.Button DeletaLinha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Senhalabel;
        private System.Windows.Forms.TextBox SenhatextBox;
        private System.Windows.Forms.Label NomeArqlabel;
        private System.Windows.Forms.TextBox NomeArqtextBox;
        private System.Windows.Forms.CheckBox CarregaAutcheckBox;
        private System.Windows.Forms.CheckBox ApendaBuscacheckBox;
        private System.Windows.Forms.Label oSeccionaArqlabel;
        private System.Windows.Forms.NumericUpDown oSeccionaArqnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

