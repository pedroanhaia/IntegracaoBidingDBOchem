namespace IntegracaoBindingBD
{
    partial class Navegador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegador));
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            this.CaminhoURLTextBox = new System.Windows.Forms.TextBox();
            this.IR = new System.Windows.Forms.Button();
            this.CaminhoURLLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(-2, 32);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(899, 532);
            this.webView2.Source = new System.Uri("https://ochem.eu/login/show.do", System.UriKind.Absolute);
            this.webView2.TabIndex = 0;
            this.webView2.ZoomFactor = 1D;
            this.webView2.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView2_NavigationCompleted);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(558, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Google";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CaminhoURLTextBox
            // 
            this.CaminhoURLTextBox.Location = new System.Drawing.Point(46, 6);
            this.CaminhoURLTextBox.Name = "CaminhoURLTextBox";
            this.CaminhoURLTextBox.Size = new System.Drawing.Size(457, 20);
            this.CaminhoURLTextBox.TabIndex = 3;
            // 
            // IR
            // 
            this.IR.BackColor = System.Drawing.SystemColors.Control;
            this.IR.Image = ((System.Drawing.Image)(resources.GetObject("IR.Image")));
            this.IR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IR.Location = new System.Drawing.Point(509, 3);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(45, 23);
            this.IR.TabIndex = 4;
            this.IR.Text = "IR";
            this.IR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IR.UseVisualStyleBackColor = true;
            this.IR.Click += new System.EventHandler(this.IR_Click);
            // 
            // CaminhoURLLabel
            // 
            this.CaminhoURLLabel.AutoSize = true;
            this.CaminhoURLLabel.Location = new System.Drawing.Point(5, 10);
            this.CaminhoURLLabel.Name = "CaminhoURLLabel";
            this.CaminhoURLLabel.Size = new System.Drawing.Size(32, 13);
            this.CaminhoURLLabel.TabIndex = 5;
            this.CaminhoURLLabel.Text = "URL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(646, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desenvolvido por: ADA Tecnologia 4.0";
            // 
            // Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaminhoURLLabel);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.CaminhoURLTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navegador";
            this.Text = "Navegador";
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.RichTextBox ScriptrichTextBox;
        private System.Windows.Forms.TextBox CaminhoURLTextBox;
        private System.Windows.Forms.Button IR;
        private System.Windows.Forms.Label CaminhoURLLabel;
        private System.Windows.Forms.Label label1;
    }
}