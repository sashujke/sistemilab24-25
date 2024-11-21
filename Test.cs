namespace ComponentiBase
{
    partial class FormInputOutputt
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.gbxTipoDiPizza = new System.Windows.Forms.GroupBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTipoDiPizza = new System.Windows.Forms.ComboBox();
            this.lblTipoPizza = new System.Windows.Forms.Label();
            this.gbxGusti = new System.Windows.Forms.GroupBox();
            this.cbxOrdinaPizza = new System.Windows.Forms.ComboBox();
            this.lblOrdinaPizze = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.rbnOlive = new System.Windows.Forms.RadioButton();
            this.rbnFunghi = new System.Windows.Forms.RadioButton();
            this.rbnSalame = new System.Windows.Forms.RadioButton();
            this.gbxReplogoOrdine = new System.Windows.Forms.GroupBox();
            this.lblTipoPizzaReplogo = new System.Windows.Forms.Label();
            this.panelPizza = new System.Windows.Forms.Label();
            this.lblCognomeOrdine = new System.Windows.Forms.Label();
            this.lblNomeOrdine = new System.Windows.Forms.Label();
            this.gbxIngredientiTotale = new System.Windows.Forms.GroupBox();
            this.lblIngredientiReplogo = new System.Windows.Forms.Label();
            this.pnlPizza = new System.Windows.Forms.Panel();
            this.btnDisegnaPizza = new System.Windows.Forms.Button();
            this.rbnIntegrale = new System.Windows.Forms.RadioButton();
            this.lblIntregraleReplogo = new System.Windows.Forms.Label();
            this.gbxTipoDiPizza.SuspendLayout();
            this.gbxGusti.SuspendLayout();
            this.gbxReplogoOrdine.SuspendLayout();
            this.gbxIngredientiTotale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(12, 79);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(52, 13);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(12, 116);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(211, 20);
            this.txtCognome.TabIndex = 3;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(11, 178);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(92, 178);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 5;
            this.btnEsci.Text = "Esci";
            this.btnEsci.UseVisualStyleBackColor = true;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(173, 178);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(75, 23);
            this.btnOrdina.TabIndex = 6;
            this.btnOrdina.Text = "Ordina";
            this.btnOrdina.UseVisualStyleBackColor = true;
            this.btnOrdina.Click += new System.EventHandler(this.btnOrdina_Click);
            // 
            // gbxTipoDiPizza
            // 
            this.gbxTipoDiPizza.Controls.Add(this.rbnIntegrale);
            this.gbxTipoDiPizza.Controls.Add(this.btnInvia);
            this.gbxTipoDiPizza.Controls.Add(this.label1);
            this.gbxTipoDiPizza.Controls.Add(this.cbxTipoDiPizza);
            this.gbxTipoDiPizza.Controls.Add(this.lblTipoPizza);
            this.gbxTipoDiPizza.Location = new System.Drawing.Point(12, 229);
            this.gbxTipoDiPizza.Name = "gbxTipoDiPizza";
            this.gbxTipoDiPizza.Size = new System.Drawing.Size(246, 185);
            this.gbxTipoDiPizza.TabIndex = 7;
            this.gbxTipoDiPizza.TabStop = false;
            this.gbxTipoDiPizza.Text = "Tipo Pizza";
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(133, 146);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(75, 23);
            this.btnInvia.TabIndex = 4;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Impianto integrale";
            // 
            // cbxTipoDiPizza
            // 
            this.cbxTipoDiPizza.FormattingEnabled = true;
            this.cbxTipoDiPizza.Items.AddRange(new object[] {
            "Rossa",
            "Bianca"});
            this.cbxTipoDiPizza.Location = new System.Drawing.Point(6, 51);
            this.cbxTipoDiPizza.Name = "cbxTipoDiPizza";
            this.cbxTipoDiPizza.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoDiPizza.TabIndex = 1;
            // 
            // lblTipoPizza
            // 
            this.lblTipoPizza.AutoSize = true;
            this.lblTipoPizza.Location = new System.Drawing.Point(6, 26);
            this.lblTipoPizza.Name = "lblTipoPizza";
            this.lblTipoPizza.Size = new System.Drawing.Size(94, 13);
            this.lblTipoPizza.TabIndex = 0;
            this.lblTipoPizza.Text = "Tipo Pizza (Scegli)";
            // 
            // gbxGusti
            // 
            this.gbxGusti.Controls.Add(this.cbxOrdinaPizza);
            this.gbxGusti.Controls.Add(this.lblOrdinaPizze);
            this.gbxGusti.Controls.Add(this.btnConferma);
            this.gbxGusti.Controls.Add(this.rbnOlive);
            this.gbxGusti.Controls.Add(this.rbnFunghi);
            this.gbxGusti.Controls.Add(this.rbnSalame);
            this.gbxGusti.Location = new System.Drawing.Point(12, 420);
            this.gbxGusti.Name = "gbxGusti";
            this.gbxGusti.Size = new System.Drawing.Size(246, 215);
            this.gbxGusti.TabIndex = 8;
            this.gbxGusti.TabStop = false;
            this.gbxGusti.Text = "Gusti";
            // 
            // cbxOrdinaPizza
            // 
            this.cbxOrdinaPizza.FormattingEnabled = true;
            this.cbxOrdinaPizza.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxOrdinaPizza.Location = new System.Drawing.Point(102, 54);
            this.cbxOrdinaPizza.Name = "cbxOrdinaPizza";
            this.cbxOrdinaPizza.Size = new System.Drawing.Size(121, 21);
            this.cbxOrdinaPizza.TabIndex = 6;
            // 
            // lblOrdinaPizze
            // 
            this.lblOrdinaPizze.AutoSize = true;
            this.lblOrdinaPizze.Location = new System.Drawing.Point(99, 26);
            this.lblOrdinaPizze.Name = "lblOrdinaPizze";
            this.lblOrdinaPizze.Size = new System.Drawing.Size(127, 13);
            this.lblOrdinaPizze.TabIndex = 5;
            this.lblOrdinaPizze.Text = "Quante pizze voi ordinare";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(151, 174);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 4;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // rbnOlive
            // 
            this.rbnOlive.AutoSize = true;
            this.rbnOlive.Location = new System.Drawing.Point(9, 106);
            this.rbnOlive.Name = "rbnOlive";
            this.rbnOlive.Size = new System.Drawing.Size(49, 17);
            this.rbnOlive.TabIndex = 2;
            this.rbnOlive.TabStop = true;
            this.rbnOlive.Text = "Olive";
            this.rbnOlive.UseVisualStyleBackColor = true;
            // 
            // rbnFunghi
            // 
            this.rbnFunghi.AutoSize = true;
            this.rbnFunghi.Location = new System.Drawing.Point(9, 71);
            this.rbnFunghi.Name = "rbnFunghi";
            this.rbnFunghi.Size = new System.Drawing.Size(57, 17);
            this.rbnFunghi.TabIndex = 1;
            this.rbnFunghi.TabStop = true;
            this.rbnFunghi.Text = "Funghi";
            this.rbnFunghi.UseVisualStyleBackColor = true;
            // 
            // rbnSalame
            // 
            this.rbnSalame.AutoSize = true;
            this.rbnSalame.Location = new System.Drawing.Point(9, 35);
            this.rbnSalame.Name = "rbnSalame";
            this.rbnSalame.Size = new System.Drawing.Size(60, 17);
            this.rbnSalame.TabIndex = 0;
            this.rbnSalame.TabStop = true;
            this.rbnSalame.Text = "Salame";
            this.rbnSalame.UseVisualStyleBackColor = true;
            // 
            // gbxReplogoOrdine
            // 
            this.gbxReplogoOrdine.Controls.Add(this.btnDisegnaPizza);
            this.gbxReplogoOrdine.Controls.Add(this.gbxIngredientiTotale);
            this.gbxReplogoOrdine.Controls.Add(this.lblIntregraleReplogo);
            this.gbxReplogoOrdine.Controls.Add(this.lblTipoPizzaReplogo);
            this.gbxReplogoOrdine.Controls.Add(this.panelPizza);
            this.gbxReplogoOrdine.Controls.Add(this.lblCognomeOrdine);
            this.gbxReplogoOrdine.Controls.Add(this.lblNomeOrdine);
            this.gbxReplogoOrdine.Location = new System.Drawing.Point(274, 12);
            this.gbxReplogoOrdine.Name = "gbxReplogoOrdine";
            this.gbxReplogoOrdine.Size = new System.Drawing.Size(344, 376);
            this.gbxReplogoOrdine.TabIndex = 9;
            this.gbxReplogoOrdine.TabStop = false;
            this.gbxReplogoOrdine.Text = "Replogo Ordine";
            // 
            // lblTipoPizzaReplogo
            // 
            this.lblTipoPizzaReplogo.AutoSize = true;
            this.lblTipoPizzaReplogo.Location = new System.Drawing.Point(18, 104);
            this.lblTipoPizzaReplogo.Name = "lblTipoPizzaReplogo";
            this.lblTipoPizzaReplogo.Size = new System.Drawing.Size(109, 13);
            this.lblTipoPizzaReplogo.TabIndex = 3;
            this.lblTipoPizzaReplogo.Text = "Pizza Bianca/Rossa: ";
            // 
            // panelPizza
            // 
            this.panelPizza.AutoSize = true;
            this.panelPizza.Location = new System.Drawing.Point(18, 67);
            this.panelPizza.Name = "panelPizza";
            this.panelPizza.Size = new System.Drawing.Size(71, 13);
            this.panelPizza.TabIndex = 2;
            this.panelPizza.Text = "Pizze Totale: ";
            // 
            // lblCognomeOrdine
            // 
            this.lblCognomeOrdine.AutoSize = true;
            this.lblCognomeOrdine.Location = new System.Drawing.Point(106, 32);
            this.lblCognomeOrdine.Name = "lblCognomeOrdine";
            this.lblCognomeOrdine.Size = new System.Drawing.Size(55, 13);
            this.lblCognomeOrdine.TabIndex = 1;
            this.lblCognomeOrdine.Text = "Cognome:";
            this.lblCognomeOrdine.Click += new System.EventHandler(this.lblCognomeOrdine_Click);
            // 
            // lblNomeOrdine
            // 
            this.lblNomeOrdine.AutoSize = true;
            this.lblNomeOrdine.Location = new System.Drawing.Point(18, 32);
            this.lblNomeOrdine.Name = "lblNomeOrdine";
            this.lblNomeOrdine.Size = new System.Drawing.Size(41, 13);
            this.lblNomeOrdine.TabIndex = 0;
            this.lblNomeOrdine.Text = "Nome: ";
            this.lblNomeOrdine.Click += new System.EventHandler(this.lblNomeOrdine_Click);
            // 
            // gbxIngredientiTotale
            // 
            this.gbxIngredientiTotale.Controls.Add(this.lblIngredientiReplogo);
            this.gbxIngredientiTotale.Location = new System.Drawing.Point(21, 147);
            this.gbxIngredientiTotale.Name = "gbxIngredientiTotale";
            this.gbxIngredientiTotale.Size = new System.Drawing.Size(217, 151);
            this.gbxIngredientiTotale.TabIndex = 5;
            this.gbxIngredientiTotale.TabStop = false;
            this.gbxIngredientiTotale.Text = "Ingredienti";
            // 
            // lblIngredientiReplogo
            // 
            this.lblIngredientiReplogo.AutoSize = true;
            this.lblIngredientiReplogo.Location = new System.Drawing.Point(17, 29);
            this.lblIngredientiReplogo.Name = "lblIngredientiReplogo";
            this.lblIngredientiReplogo.Size = new System.Drawing.Size(62, 13);
            this.lblIngredientiReplogo.TabIndex = 0;
            this.lblIngredientiReplogo.Text = "ingrediernte";
            // 
            // pnlPizza
            // 
            this.pnlPizza.Location = new System.Drawing.Point(624, 37);
            this.pnlPizza.Name = "pnlPizza";
            this.pnlPizza.Size = new System.Drawing.Size(430, 351);
            this.pnlPizza.TabIndex = 10;
            this.pnlPizza.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPizza_Paint);
            // 
            // btnDisegnaPizza
            // 
            this.btnDisegnaPizza.Location = new System.Drawing.Point(194, 328);
            this.btnDisegnaPizza.Name = "btnDisegnaPizza";
            this.btnDisegnaPizza.Size = new System.Drawing.Size(122, 23);
            this.btnDisegnaPizza.TabIndex = 6;
            this.btnDisegnaPizza.Text = "Disegna Pizza";
            this.btnDisegnaPizza.UseVisualStyleBackColor = true;
            this.btnDisegnaPizza.Click += new System.EventHandler(this.btnDisegnaPizza_Click);
            // 
            // rbnIntegrale
            // 
            this.rbnIntegrale.AutoSize = true;
            this.rbnIntegrale.Location = new System.Drawing.Point(11, 114);
            this.rbnIntegrale.Name = "rbnIntegrale";
            this.rbnIntegrale.Size = new System.Drawing.Size(66, 17);
            this.rbnIntegrale.TabIndex = 5;
            this.rbnIntegrale.TabStop = true;
            this.rbnIntegrale.Text = "Integrale";
            this.rbnIntegrale.UseVisualStyleBackColor = true;
            // 
            // lblIntregraleReplogo
            // 
            this.lblIntregraleReplogo.AutoSize = true;
            this.lblIntregraleReplogo.Location = new System.Drawing.Point(161, 104);
            this.lblIntregraleReplogo.Name = "lblIntregraleReplogo";
            this.lblIntregraleReplogo.Size = new System.Drawing.Size(92, 13);
            this.lblIntregraleReplogo.TabIndex = 4;
            this.lblIntregraleReplogo.Text = "Integrale/Normale";
            // 
            // FormInputOutputt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 647);
            this.Controls.Add(this.pnlPizza);
            this.Controls.Add(this.gbxReplogoOrdine);
            this.Controls.Add(this.gbxGusti);
            this.Controls.Add(this.gbxTipoDiPizza);
            this.Controls.Add(this.btnOrdina);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Name = "FormInputOutputt";
            this.Text = "FormInputOutputt";
            this.gbxTipoDiPizza.ResumeLayout(false);
            this.gbxTipoDiPizza.PerformLayout();
            this.gbxGusti.ResumeLayout(false);
            this.gbxGusti.PerformLayout();
            this.gbxReplogoOrdine.ResumeLayout(false);
            this.gbxReplogoOrdine.PerformLayout();
            this.gbxIngredientiTotale.ResumeLayout(false);
            this.gbxIngredientiTotale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.GroupBox gbxTipoDiPizza;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTipoDiPizza;
        private System.Windows.Forms.Label lblTipoPizza;
        private System.Windows.Forms.GroupBox gbxGusti;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.RadioButton rbnOlive;
        private System.Windows.Forms.RadioButton rbnFunghi;
        private System.Windows.Forms.RadioButton rbnSalame;
        private System.Windows.Forms.GroupBox gbxReplogoOrdine;
        private System.Windows.Forms.Label lblCognomeOrdine;
        private System.Windows.Forms.Label lblNomeOrdine;
        private System.Windows.Forms.ComboBox cbxOrdinaPizza;
        private System.Windows.Forms.Label lblOrdinaPizze;
        private System.Windows.Forms.Label panelPizza;
        private System.Windows.Forms.Label lblTipoPizzaReplogo;
        private System.Windows.Forms.GroupBox gbxIngredientiTotale;
        private System.Windows.Forms.Label lblIngredientiReplogo;
        private System.Windows.Forms.Panel pnlPizza;
        private System.Windows.Forms.Button btnDisegnaPizza;
        private System.Windows.Forms.RadioButton rbnIntegrale;
        private System.Windows.Forms.Label lblIntregraleReplogo;
    }
}
