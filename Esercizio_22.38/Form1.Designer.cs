namespace Esercizio_22._38
{
    partial class Form1
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
            this.txtTesto1 = new System.Windows.Forms.TextBox();
            this.txtTesto2 = new System.Windows.Forms.TextBox();
            this.btnSomma = new System.Windows.Forms.Button();
            this.btnSottrazione = new System.Windows.Forms.Button();
            this.btnDivisione = new System.Windows.Forms.Button();
            this.btnMoltiplicazione = new System.Windows.Forms.Button();
            this.lstRisultati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTesto1
            // 
            this.txtTesto1.Location = new System.Drawing.Point(67, 39);
            this.txtTesto1.Name = "txtTesto1";
            this.txtTesto1.Size = new System.Drawing.Size(100, 20);
            this.txtTesto1.TabIndex = 0;
            // 
            // txtTesto2
            // 
            this.txtTesto2.Location = new System.Drawing.Point(67, 84);
            this.txtTesto2.Name = "txtTesto2";
            this.txtTesto2.Size = new System.Drawing.Size(100, 20);
            this.txtTesto2.TabIndex = 1;
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(79, 125);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(75, 23);
            this.btnSomma.TabIndex = 2;
            this.btnSomma.Text = "+";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // btnSottrazione
            // 
            this.btnSottrazione.Location = new System.Drawing.Point(79, 168);
            this.btnSottrazione.Name = "btnSottrazione";
            this.btnSottrazione.Size = new System.Drawing.Size(75, 23);
            this.btnSottrazione.TabIndex = 3;
            this.btnSottrazione.Text = "-";
            this.btnSottrazione.UseVisualStyleBackColor = true;
            this.btnSottrazione.Click += new System.EventHandler(this.btnSottrazione_Click);
            // 
            // btnDivisione
            // 
            this.btnDivisione.Location = new System.Drawing.Point(79, 207);
            this.btnDivisione.Name = "btnDivisione";
            this.btnDivisione.Size = new System.Drawing.Size(75, 23);
            this.btnDivisione.TabIndex = 4;
            this.btnDivisione.Text = "/";
            this.btnDivisione.UseVisualStyleBackColor = true;
            this.btnDivisione.Click += new System.EventHandler(this.btnDivisione_Click);
            // 
            // btnMoltiplicazione
            // 
            this.btnMoltiplicazione.Location = new System.Drawing.Point(79, 249);
            this.btnMoltiplicazione.Name = "btnMoltiplicazione";
            this.btnMoltiplicazione.Size = new System.Drawing.Size(75, 23);
            this.btnMoltiplicazione.TabIndex = 5;
            this.btnMoltiplicazione.Text = "*";
            this.btnMoltiplicazione.UseVisualStyleBackColor = true;
            this.btnMoltiplicazione.Click += new System.EventHandler(this.btnMoltiplicazione_Click);
            // 
            // lstRisultati
            // 
            this.lstRisultati.FormattingEnabled = true;
            this.lstRisultati.Location = new System.Drawing.Point(272, 36);
            this.lstRisultati.Name = "lstRisultati";
            this.lstRisultati.Size = new System.Drawing.Size(335, 238);
            this.lstRisultati.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRisultati);
            this.Controls.Add(this.btnMoltiplicazione);
            this.Controls.Add(this.btnDivisione);
            this.Controls.Add(this.btnSottrazione);
            this.Controls.Add(this.btnSomma);
            this.Controls.Add(this.txtTesto2);
            this.Controls.Add(this.txtTesto1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTesto1;
        private System.Windows.Forms.TextBox txtTesto2;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.Button btnSottrazione;
        private System.Windows.Forms.Button btnDivisione;
        private System.Windows.Forms.Button btnMoltiplicazione;
        private System.Windows.Forms.ListBox lstRisultati;
    }
}

