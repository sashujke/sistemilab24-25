using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        private int velocita = 1;
        private bool bonusAttivo = false;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            pictureBoxAereo.Top -= velocita;
        }

        private void btnGiu_Click(object sender, EventArgs e)
        {
            pictureBoxAereo.Top += velocita;
        }

        private void btnSinistra_Click(object sender, EventArgs e)
        {
            pictureBoxAereo.Left -= velocita;
        }

        private void btnDestra_Click(object sender, EventArgs e)
        {
            pictureBoxAereo.Left += velocita;
        }

        private void trackBarVelocita_Scroll(object sender, EventArgs e)
        {
            velocita = trackBarVelocita.Value;
        }

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

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            pictureBoxAereo.Top -= velocita;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBoxAereo.Location = new Point(150, 150);
            timer.Stop();
        }
    }

    namespace GiocoAereo
    {
        partial class Form1
        {
            private System.ComponentModel.IContainer components = null;
            private Button btnSu;
            private Button btnGiu;
            private Button btnSinistra;
            private Button btnDestra;
            private TrackBar trackBarVelocita;
            private CheckBox checkBoxBonus;
            private Button btnStartStop;
            private Button btnReset;
            private PictureBox pictureBoxAereo;

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
                this.btnSu = new Button();
                this.btnGiu = new Button();
                this.btnSinistra = new Button();
                this.btnDestra = new Button();
                this.trackBarVelocita = new TrackBar();
                this.checkBoxBonus = new CheckBox();
                this.btnStartStop = new Button();
                this.btnReset = new Button();
                this.pictureBoxAereo = new PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAereo)).BeginInit();
                this.SuspendLayout();

                this.pictureBoxAereo.Image = // Inserisci qui l'immagine dell'aereo
                this.pictureBoxAereo.Location = new Point(150, 150);
                this.pictureBoxAereo.Size = new Size(50, 50);
                this.pictureBoxAereo.SizeMode = PictureBoxSizeMode.StretchImage;

                this.btnSu.Text = "Su";
                this.btnSu.Location = new Point(50, 50);
                this.btnSu.Click += new EventHandler(this.btnSu_Click);

                this.btnGiu.Text = "Giu";
                this.btnGiu.Location = new Point(50, 150);
                this.btnGiu.Click += new EventHandler(this.btnGiu_Click);

                this.btnSinistra.Text = "Sinistra";
                this.btnSinistra.Location = new Point(10, 100);
                this.btnSinistra.Click += new EventHandler(this.btnSinistra_Click);

                this.btnDestra.Text = "Destra";
                this.btnDestra.Location = new Point(90, 100);
                this.btnDestra.Click += new EventHandler(this.btnDestra_Click);

                this.trackBarVelocita.Location = new Point(200, 50);
                this.trackBarVelocita.Minimum = 1;
                this.trackBarVelocita.Maximum = 10;
                this.trackBarVelocita.Scroll += new EventHandler(this.trackBarVelocita_Scroll);

                this.checkBoxBonus.Text = "Bonus (+5)";
                this.checkBoxBonus.Location = new Point(200, 150);
                this.checkBoxBonus.CheckedChanged += new EventHandler(this.checkBoxBonus_CheckedChanged);

                this.btnStartStop.Text = "Start / Stop";
                this.btnStartStop.Location = new Point(300, 50);
                this.btnStartStop.Click += new EventHandler(this.btnStartStop_Click);

                this.btnReset.Text = "Reset";
                this.btnReset.Location = new Point(300, 100);
                this.btnReset.Click += new EventHandler(this.btnReset_Click);

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
                this.ClientSize = new Size(400, 300);
                ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocita)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAereo)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }
}
