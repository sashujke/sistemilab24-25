using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
   
 
    {
        public partial class Form1 : Form
        {
            private int velocita = 1;
            private bool bonusAttivo = false;
            private Timer timer;
        private object pictureBoxAereo;

        public Aereo()
            {
                InitializeComponent();

                // Imposta il timer per il movimento automatico
                timer = new Timer();
                timer.Interval = 100; // Velocità del timer, minore è più veloce
                timer.Tick += Timer_Tick;
            }

            // Evento per il movimento verso l'alto
            private void btnSu_Click(object sender, EventArgs e)
            {
                pictureBoxAereo.Top -= velocita;
            }

            // Evento per il movimento verso il basso
            private void btnGiu_Click(object sender, EventArgs e)
            {
                pictureBoxAereo.Top += velocita;
            }

            // Evento per il movimento verso sinistra
            private void btnSinistra_Click(object sender, EventArgs e)
            {
                pictureBoxAereo.Left -= velocita;
            }

            // Evento per il movimento verso destra
            private void btnDestra_Click(object sender, EventArgs e)
            {
                pictureBoxAereo.Left += velocita;
            }

            // Evento per cambiare la velocità con la TrackBar
            private void trackBarVelocita_Scroll(object sender, EventArgs e)
            {
                velocita = trackBarVelocita.Value;
            }

            // Evento per attivare/disattivare il bonus di velocità
            private void checkBoxBonus_CheckedChanged(object sender, EventArgs e)
            {
                bonusAttivo = checkBoxBonus.Checked;
                if (bonusAttivo)
                {
                    velocita += 5;
                }
                else
                {
                    velocita -= 5;
                }
            }

            // Evento per il pulsante Start/Stop
            private void btnStartStop_Click(object sender, EventArgs e)
            {
                if (timer.Enabled)
                {
                    timer.Stop();  // Ferma il movimento automatico
                }
                else
                {
                    timer.Start();  // Avvia il movimento automatico
                }
            }

            // Evento del timer per muovere automaticamente l'aereo verso l'alto
            private void Timer_Tick(object sender, EventArgs e)
            {
                pictureBoxAereo.Top -= velocita;  // Movimento automatico verso l'alto
            }

            // Evento per il pulsante Reset per riportare l'aereo alla posizione iniziale
            private void btnReset_Click(object sender, EventArgs e)
            {
                pictureBoxAereo.Location = new Point(150, 150);  // Posizione di reset
                timer.Stop();  // Ferma il timer in caso di reset
            }
        }


    namespace GiocoAereo
    {
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Button btnSu;
            private System.Windows.Forms.Button btnGiu;
            private System.Windows.Forms.Button btnSinistra;
            private System.Windows.Forms.Button btnDestra;
            private System.Windows.Forms.TrackBar trackBarVelocita;
            private System.Windows.Forms.CheckBox checkBoxBonus;
            private System.Windows.Forms.Button btnStartStop;
            private System.Windows.Forms.Button btnReset;
            private System.Windows.Forms.PictureBox pictureBoxAereo;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            private void InitializeComponent()
            {
                this.btnSu = new System.Windows.Forms.Button();
                this.btnGiu = new System.Windows.Forms.Button();
                this.btnSinistra = new System.Windows.Forms.Button();
                this.btnDestra = new System.Windows.Forms.Button();
                this.trackBarVelocita = new System.Windows.Forms.TrackBar();
                this.checkBoxBonus = new System.Windows.Forms.CheckBox();
                this.btnStartStop = new System.Windows.Forms.Button();
                this.btnReset = new System.Windows.Forms.Button();
                this.pictureBoxAereo = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAereo)).BeginInit();
                this.SuspendLayout();

                // Impostazioni del PictureBox (aereo)
                this.pictureBoxAereo.Image = ... // Aggiungi qui l'immagine dell'aereo (puoi usare il file caricato)
            this.pictureBoxAereo.Location = new System.Drawing.Point(150, 150);
                this.pictureBoxAereo.Size = new System.Drawing.Size(50, 50);
                this.pictureBoxAereo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                // Impostazioni dei pulsanti di direzione
                this.btnSu.Text = "Su";
                this.btnSu.Location = new System.Drawing.Point(50, 50);
                this.btnSu.Click += new System.EventHandler(this.btnSu_Click);

                this.btnGiu.Text = "Giu";
                this.btnGiu.Location = new System.Drawing.Point(50, 150);
                this.btnGiu.Click += new System.EventHandler(this.btnGiu_Click);

                this.btnSinistra.Text = "Sinistra";
                this.btnSinistra.Location = new System.Drawing.Point(10, 100);
                this.btnSinistra.Click += new System.EventHandler(this.btnSinistra_Click);

                this.btnDestra.Text = "Destra";
                this.btnDestra.Location = new System.Drawing.Point(90, 100);
                this.btnDestra.Click += new System.EventHandler(this.btnDestra_Click);

                // Impostazioni del TrackBar (Velocità)
                this.trackBarVelocita.Location = new System.Drawing.Point(200, 50);
                this.trackBarVelocita.Minimum = 1;
                this.trackBarVelocita.Maximum = 10;
                this.trackBarVelocita.Scroll += new System.EventHandler(this.trackBarVelocita_Scroll);

                // Impostazioni della CheckBox (Bonus Velocità)
                this.checkBoxBonus.Text = "Bonus (+5)";
                this.checkBoxBonus.Location = new System.Drawing.Point(200, 150);
                this.checkBoxBonus.CheckedChanged += new System.EventHandler(this.checkBoxBonus_CheckedChanged);

                // Impostazioni del pulsante Start/Stop
                this.btnStartStop.Text = "Start / Stop";
                this.btnStartStop.Location = new System.Drawing.Point(300, 50);
                this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);

                // Impostazioni del pulsante Reset
                this.btnReset.Text = "Reset";
                this.btnReset.Location = new System.Drawing.Point(300, 100);
                this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

                // Aggiungi i controlli alla Form
                this.Controls.Add(this.btnSu);
                this.Controls.Add(this.btnGiu);
                this.Controls.Add(this.btnSinistra);
                this.Controls.Add(this.btnDestra);
                this.Controls.Add(this.trackBarVelocita);
                this.Controls.Add(this.checkBoxBonus);
                this.Controls.Add(this.btnStartStop);
                this.Controls.Add(this.btnReset);
                this.Controls.Add(this.pictureBoxAereo);

                this.Text = "Gioco Aereo";
                this.ClientSize = new System.Drawing.Size(400, 300);
                ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAereo)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }

}


