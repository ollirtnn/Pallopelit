
namespace Harjoitustyo_Olli_Rautiainen
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
            this.components = new System.ComponentModel.Container();
            this.cbJoukkue1 = new System.Windows.Forms.ComboBox();
            this.cbJoukkue2 = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnKelaa = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblKoti = new System.Windows.Forms.Label();
            this.lblVieras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEra = new System.Windows.Forms.Label();
            this.lblEraAika = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKokonaisaika = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMaaliJoukkue = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMaalintekijaEtunimi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMaaliAika = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbMaalintekijaSukunimi = new System.Windows.Forms.TextBox();
            this.tbMaalintekijaNro = new System.Windows.Forms.TextBox();
            this.tbSyottaja1Nro = new System.Windows.Forms.TextBox();
            this.tbSyottaja1Sukunimi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbSyottaja1Etunimi = new System.Windows.Forms.TextBox();
            this.tbSyottaja2Nro = new System.Windows.Forms.TextBox();
            this.tbSyottaja2Sukunimi = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbSyottaja2Etunimi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSalibandy = new System.Windows.Forms.RadioButton();
            this.rbtnJaakiekko = new System.Windows.Forms.RadioButton();
            this.rbtnJalkapallo = new System.Windows.Forms.RadioButton();
            this.lblMaalitKoti = new System.Windows.Forms.Label();
            this.lblMaalitVieras = new System.Windows.Forms.Label();
            this.btnTallenna = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aloitaUusiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aloitaUusiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lopetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSyotaTilasto = new System.Windows.Forms.Button();
            this.btnSyottaja1 = new System.Windows.Forms.Button();
            this.btnSyottaja2 = new System.Windows.Forms.Button();
            this.btnPeruuta = new System.Windows.Forms.Button();
            this.tabTilastot = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvOttelu = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTilastot = new System.Windows.Forms.DataGridView();
            this.dtpAloitusAika = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabTilastot.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOttelu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTilastot)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbJoukkue1
            // 
            this.cbJoukkue1.Enabled = false;
            this.cbJoukkue1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoukkue1.FormattingEnabled = true;
            this.cbJoukkue1.Items.AddRange(new object[] {
            "Kalpa",
            "HIFK",
            "Lukko",
            "Inter",
            "Kups",
            "Raiku",
            "Kieku",
            "SbSavo",
            "Sählypojat"});
            this.cbJoukkue1.Location = new System.Drawing.Point(350, 68);
            this.cbJoukkue1.Name = "cbJoukkue1";
            this.cbJoukkue1.Size = new System.Drawing.Size(156, 24);
            this.cbJoukkue1.TabIndex = 1;
            this.cbJoukkue1.Text = "Valitse joukkue";
            this.cbJoukkue1.TextChanged += new System.EventHandler(this.cbJoukkueet_TextChanged);
            // 
            // cbJoukkue2
            // 
            this.cbJoukkue2.Enabled = false;
            this.cbJoukkue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoukkue2.FormattingEnabled = true;
            this.cbJoukkue2.Items.AddRange(new object[] {
            "Kalpa",
            "HIFK",
            "Lukko",
            "Inter",
            "Kups",
            "Raiku",
            "Kieku",
            "SbSavo",
            "Sählypojat"});
            this.cbJoukkue2.Location = new System.Drawing.Point(911, 68);
            this.cbJoukkue2.Name = "cbJoukkue2";
            this.cbJoukkue2.Size = new System.Drawing.Size(173, 24);
            this.cbJoukkue2.TabIndex = 2;
            this.cbJoukkue2.Text = "Valitse joukkue";
            this.cbJoukkue2.TextChanged += new System.EventHandler(this.cbJoukkueet_TextChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(512, 118);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 47);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(616, 118);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 47);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "||";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnKelaa
            // 
            this.btnKelaa.BackColor = System.Drawing.SystemColors.Control;
            this.btnKelaa.Enabled = false;
            this.btnKelaa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKelaa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKelaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelaa.Location = new System.Drawing.Point(725, 118);
            this.btnKelaa.Name = "btnKelaa";
            this.btnKelaa.Size = new System.Drawing.Size(79, 47);
            this.btnKelaa.TabIndex = 5;
            this.btnKelaa.Text = "Normaali nopeus";
            this.btnKelaa.UseVisualStyleBackColor = false;
            this.btnKelaa.Click += new System.EventHandler(this.btnKelaa_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Enabled = false;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(834, 118);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 47);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblKoti
            // 
            this.lblKoti.AutoSize = true;
            this.lblKoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKoti.Location = new System.Drawing.Point(522, 50);
            this.lblKoti.Name = "lblKoti";
            this.lblKoti.Size = new System.Drawing.Size(30, 16);
            this.lblKoti.TabIndex = 9;
            this.lblKoti.Text = "Koti";
            // 
            // lblVieras
            // 
            this.lblVieras.AutoSize = true;
            this.lblVieras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVieras.Location = new System.Drawing.Point(841, 50);
            this.lblVieras.Name = "lblVieras";
            this.lblVieras.Size = new System.Drawing.Size(47, 16);
            this.lblVieras.TabIndex = 10;
            this.lblVieras.Text = "Vieras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Erä";
            // 
            // lblEra
            // 
            this.lblEra.AutoSize = true;
            this.lblEra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEra.Location = new System.Drawing.Point(602, 72);
            this.lblEra.Name = "lblEra";
            this.lblEra.Size = new System.Drawing.Size(15, 16);
            this.lblEra.TabIndex = 13;
            this.lblEra.Text = "0";
            // 
            // lblEraAika
            // 
            this.lblEraAika.AutoSize = true;
            this.lblEraAika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEraAika.Location = new System.Drawing.Point(663, 72);
            this.lblEraAika.Name = "lblEraAika";
            this.lblEraAika.Size = new System.Drawing.Size(39, 16);
            this.lblEraAika.TabIndex = 14;
            this.lblEraAika.Text = "00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(725, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kokonaisaika";
            // 
            // lblKokonaisaika
            // 
            this.lblKokonaisaika.AutoSize = true;
            this.lblKokonaisaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKokonaisaika.Location = new System.Drawing.Point(741, 72);
            this.lblKokonaisaika.Name = "lblKokonaisaika";
            this.lblKokonaisaika.Size = new System.Drawing.Size(39, 16);
            this.lblKokonaisaika.TabIndex = 19;
            this.lblKokonaisaika.Text = "00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Joukkue";
            // 
            // cbMaaliJoukkue
            // 
            this.cbMaaliJoukkue.Enabled = false;
            this.cbMaaliJoukkue.FormattingEnabled = true;
            this.cbMaaliJoukkue.Location = new System.Drawing.Point(132, 224);
            this.cbMaaliJoukkue.Name = "cbMaaliJoukkue";
            this.cbMaaliJoukkue.Size = new System.Drawing.Size(121, 21);
            this.cbMaaliJoukkue.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Maalintekijä";
            // 
            // tbMaalintekijaEtunimi
            // 
            this.tbMaalintekijaEtunimi.Enabled = false;
            this.tbMaalintekijaEtunimi.Location = new System.Drawing.Point(132, 284);
            this.tbMaalintekijaEtunimi.Name = "tbMaalintekijaEtunimi";
            this.tbMaalintekijaEtunimi.Size = new System.Drawing.Size(121, 20);
            this.tbMaalintekijaEtunimi.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Aika";
            // 
            // tbMaaliAika
            // 
            this.tbMaaliAika.Enabled = false;
            this.tbMaaliAika.Location = new System.Drawing.Point(215, 198);
            this.tbMaaliAika.Name = "tbMaaliAika";
            this.tbMaaliAika.Size = new System.Drawing.Size(38, 20);
            this.tbMaaliAika.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(54, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "Etunimi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Sukunimi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(52, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 16);
            this.label16.TabIndex = 31;
            this.label16.Text = "Pelinumero";
            // 
            // tbMaalintekijaSukunimi
            // 
            this.tbMaalintekijaSukunimi.Enabled = false;
            this.tbMaalintekijaSukunimi.Location = new System.Drawing.Point(132, 310);
            this.tbMaalintekijaSukunimi.Name = "tbMaalintekijaSukunimi";
            this.tbMaalintekijaSukunimi.Size = new System.Drawing.Size(121, 20);
            this.tbMaalintekijaSukunimi.TabIndex = 32;
            // 
            // tbMaalintekijaNro
            // 
            this.tbMaalintekijaNro.Enabled = false;
            this.tbMaalintekijaNro.Location = new System.Drawing.Point(215, 336);
            this.tbMaalintekijaNro.Name = "tbMaalintekijaNro";
            this.tbMaalintekijaNro.Size = new System.Drawing.Size(38, 20);
            this.tbMaalintekijaNro.TabIndex = 33;
            // 
            // tbSyottaja1Nro
            // 
            this.tbSyottaja1Nro.Enabled = false;
            this.tbSyottaja1Nro.Location = new System.Drawing.Point(215, 440);
            this.tbSyottaja1Nro.Name = "tbSyottaja1Nro";
            this.tbSyottaja1Nro.Size = new System.Drawing.Size(38, 20);
            this.tbSyottaja1Nro.TabIndex = 40;
            // 
            // tbSyottaja1Sukunimi
            // 
            this.tbSyottaja1Sukunimi.Enabled = false;
            this.tbSyottaja1Sukunimi.Location = new System.Drawing.Point(132, 414);
            this.tbSyottaja1Sukunimi.Name = "tbSyottaja1Sukunimi";
            this.tbSyottaja1Sukunimi.Size = new System.Drawing.Size(121, 20);
            this.tbSyottaja1Sukunimi.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 440);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 38;
            this.label18.Text = "Pelinumero";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(52, 414);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 16);
            this.label19.TabIndex = 37;
            this.label19.Text = "Sukunimi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(54, 388);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 16);
            this.label20.TabIndex = 36;
            this.label20.Text = "Etunimi";
            // 
            // tbSyottaja1Etunimi
            // 
            this.tbSyottaja1Etunimi.Enabled = false;
            this.tbSyottaja1Etunimi.Location = new System.Drawing.Point(132, 388);
            this.tbSyottaja1Etunimi.Name = "tbSyottaja1Etunimi";
            this.tbSyottaja1Etunimi.Size = new System.Drawing.Size(121, 20);
            this.tbSyottaja1Etunimi.TabIndex = 35;
            // 
            // tbSyottaja2Nro
            // 
            this.tbSyottaja2Nro.Enabled = false;
            this.tbSyottaja2Nro.Location = new System.Drawing.Point(215, 544);
            this.tbSyottaja2Nro.Name = "tbSyottaja2Nro";
            this.tbSyottaja2Nro.Size = new System.Drawing.Size(38, 20);
            this.tbSyottaja2Nro.TabIndex = 47;
            // 
            // tbSyottaja2Sukunimi
            // 
            this.tbSyottaja2Sukunimi.Enabled = false;
            this.tbSyottaja2Sukunimi.Location = new System.Drawing.Point(131, 518);
            this.tbSyottaja2Sukunimi.Name = "tbSyottaja2Sukunimi";
            this.tbSyottaja2Sukunimi.Size = new System.Drawing.Size(122, 20);
            this.tbSyottaja2Sukunimi.TabIndex = 46;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(55, 544);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 16);
            this.label21.TabIndex = 45;
            this.label21.Text = "Pelinumero";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(54, 518);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 16);
            this.label22.TabIndex = 44;
            this.label22.Text = "Sukunimi";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(55, 492);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 16);
            this.label23.TabIndex = 43;
            this.label23.Text = "Etunimi";
            // 
            // tbSyottaja2Etunimi
            // 
            this.tbSyottaja2Etunimi.Enabled = false;
            this.tbSyottaja2Etunimi.Location = new System.Drawing.Point(131, 492);
            this.tbSyottaja2Etunimi.Name = "tbSyottaja2Etunimi";
            this.tbSyottaja2Etunimi.Size = new System.Drawing.Size(122, 20);
            this.tbSyottaja2Etunimi.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSalibandy);
            this.groupBox1.Controls.Add(this.rbtnJaakiekko);
            this.groupBox1.Controls.Add(this.rbtnJalkapallo);
            this.groupBox1.Location = new System.Drawing.Point(58, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VALITSE LAJI";
            // 
            // rbtnSalibandy
            // 
            this.rbtnSalibandy.AutoSize = true;
            this.rbtnSalibandy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSalibandy.Location = new System.Drawing.Point(7, 66);
            this.rbtnSalibandy.Name = "rbtnSalibandy";
            this.rbtnSalibandy.Size = new System.Drawing.Size(87, 20);
            this.rbtnSalibandy.TabIndex = 2;
            this.rbtnSalibandy.TabStop = true;
            this.rbtnSalibandy.Text = "Salibandy";
            this.rbtnSalibandy.UseVisualStyleBackColor = true;
            this.rbtnSalibandy.CheckedChanged += new System.EventHandler(this.rbtnLaji_CheckedChanged);
            // 
            // rbtnJaakiekko
            // 
            this.rbtnJaakiekko.AutoSize = true;
            this.rbtnJaakiekko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJaakiekko.Location = new System.Drawing.Point(7, 44);
            this.rbtnJaakiekko.Name = "rbtnJaakiekko";
            this.rbtnJaakiekko.Size = new System.Drawing.Size(89, 20);
            this.rbtnJaakiekko.TabIndex = 1;
            this.rbtnJaakiekko.TabStop = true;
            this.rbtnJaakiekko.Text = "Jääkiekko";
            this.rbtnJaakiekko.UseVisualStyleBackColor = true;
            this.rbtnJaakiekko.CheckedChanged += new System.EventHandler(this.rbtnLaji_CheckedChanged);
            // 
            // rbtnJalkapallo
            // 
            this.rbtnJalkapallo.AutoSize = true;
            this.rbtnJalkapallo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJalkapallo.Location = new System.Drawing.Point(6, 20);
            this.rbtnJalkapallo.Name = "rbtnJalkapallo";
            this.rbtnJalkapallo.Size = new System.Drawing.Size(89, 20);
            this.rbtnJalkapallo.TabIndex = 0;
            this.rbtnJalkapallo.TabStop = true;
            this.rbtnJalkapallo.Text = "Jalkapallo";
            this.rbtnJalkapallo.UseVisualStyleBackColor = true;
            this.rbtnJalkapallo.CheckedChanged += new System.EventHandler(this.rbtnLaji_CheckedChanged);
            // 
            // lblMaalitKoti
            // 
            this.lblMaalitKoti.AutoSize = true;
            this.lblMaalitKoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaalitKoti.Location = new System.Drawing.Point(533, 71);
            this.lblMaalitKoti.Name = "lblMaalitKoti";
            this.lblMaalitKoti.Size = new System.Drawing.Size(19, 20);
            this.lblMaalitKoti.TabIndex = 49;
            this.lblMaalitKoti.Text = "0";
            // 
            // lblMaalitVieras
            // 
            this.lblMaalitVieras.AutoSize = true;
            this.lblMaalitVieras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaalitVieras.Location = new System.Drawing.Point(844, 71);
            this.lblMaalitVieras.Name = "lblMaalitVieras";
            this.lblMaalitVieras.Size = new System.Drawing.Size(19, 20);
            this.lblMaalitVieras.TabIndex = 50;
            this.lblMaalitVieras.Text = "0";
            // 
            // btnTallenna
            // 
            this.btnTallenna.Enabled = false;
            this.btnTallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTallenna.Location = new System.Drawing.Point(165, 577);
            this.btnTallenna.Name = "btnTallenna";
            this.btnTallenna.Size = new System.Drawing.Size(75, 23);
            this.btnTallenna.TabIndex = 51;
            this.btnTallenna.Text = "Tallenna";
            this.btnTallenna.UseVisualStyleBackColor = true;
            this.btnTallenna.Click += new System.EventHandler(this.btnTallenna_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aloitaUusiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aloitaUusiToolStripMenuItem
            // 
            this.aloitaUusiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aloitaUusiToolStripMenuItem1,
            this.lopetaToolStripMenuItem});
            this.aloitaUusiToolStripMenuItem.Name = "aloitaUusiToolStripMenuItem";
            this.aloitaUusiToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.aloitaUusiToolStripMenuItem.Text = "Valikko";
            // 
            // aloitaUusiToolStripMenuItem1
            // 
            this.aloitaUusiToolStripMenuItem1.Name = "aloitaUusiToolStripMenuItem1";
            this.aloitaUusiToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.aloitaUusiToolStripMenuItem1.Text = "Aloita uusi";
            this.aloitaUusiToolStripMenuItem1.Click += new System.EventHandler(this.aloitaUusiToolStripMenuItem1_Click);
            // 
            // lopetaToolStripMenuItem
            // 
            this.lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            this.lopetaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.lopetaToolStripMenuItem.Text = "Sulje";
            this.lopetaToolStripMenuItem.Click += new System.EventHandler(this.lopetaToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSyotaTilasto
            // 
            this.btnSyotaTilasto.Enabled = false;
            this.btnSyotaTilasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyotaTilasto.Location = new System.Drawing.Point(101, 168);
            this.btnSyotaTilasto.Name = "btnSyotaTilasto";
            this.btnSyotaTilasto.Size = new System.Drawing.Size(103, 24);
            this.btnSyotaTilasto.TabIndex = 53;
            this.btnSyotaTilasto.Text = "Syötä tilasto";
            this.btnSyotaTilasto.UseVisualStyleBackColor = true;
            this.btnSyotaTilasto.Click += new System.EventHandler(this.btnMaalinTiedot_Click);
            // 
            // btnSyottaja1
            // 
            this.btnSyottaja1.Enabled = false;
            this.btnSyottaja1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyottaja1.Location = new System.Drawing.Point(101, 362);
            this.btnSyottaja1.Name = "btnSyottaja1";
            this.btnSyottaja1.Size = new System.Drawing.Size(103, 23);
            this.btnSyottaja1.TabIndex = 54;
            this.btnSyottaja1.Text = "Lisää syöttäjä";
            this.btnSyottaja1.UseVisualStyleBackColor = true;
            this.btnSyottaja1.Click += new System.EventHandler(this.btnSyottaja1_Click);
            // 
            // btnSyottaja2
            // 
            this.btnSyottaja2.Enabled = false;
            this.btnSyottaja2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyottaja2.Location = new System.Drawing.Point(101, 466);
            this.btnSyottaja2.Name = "btnSyottaja2";
            this.btnSyottaja2.Size = new System.Drawing.Size(103, 23);
            this.btnSyottaja2.TabIndex = 55;
            this.btnSyottaja2.Text = "2. syöttäjä";
            this.btnSyottaja2.UseVisualStyleBackColor = true;
            this.btnSyottaja2.Click += new System.EventHandler(this.btnSyottaja2_Click);
            // 
            // btnPeruuta
            // 
            this.btnPeruuta.Enabled = false;
            this.btnPeruuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeruuta.Location = new System.Drawing.Point(57, 577);
            this.btnPeruuta.Name = "btnPeruuta";
            this.btnPeruuta.Size = new System.Drawing.Size(75, 23);
            this.btnPeruuta.TabIndex = 56;
            this.btnPeruuta.Text = "Peruuta";
            this.btnPeruuta.UseVisualStyleBackColor = true;
            this.btnPeruuta.Click += new System.EventHandler(this.btnPeruuta_Click);
            // 
            // tabTilastot
            // 
            this.tabTilastot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTilastot.Controls.Add(this.tabPage1);
            this.tabTilastot.Controls.Add(this.tabPage2);
            this.tabTilastot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTilastot.Location = new System.Drawing.Point(350, 212);
            this.tabTilastot.Name = "tabTilastot";
            this.tabTilastot.SelectedIndex = 0;
            this.tabTilastot.Size = new System.Drawing.Size(740, 398);
            this.tabTilastot.TabIndex = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvOttelu);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ottelutilastot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOttelu
            // 
            this.dgvOttelu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOttelu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOttelu.Location = new System.Drawing.Point(0, 0);
            this.dgvOttelu.MultiSelect = false;
            this.dgvOttelu.Name = "dgvOttelu";
            this.dgvOttelu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOttelu.Size = new System.Drawing.Size(732, 369);
            this.dgvOttelu.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTilastot);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Joukkuetilastot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTilastot
            // 
            this.dgvTilastot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTilastot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTilastot.Location = new System.Drawing.Point(0, 0);
            this.dgvTilastot.Name = "dgvTilastot";
            this.dgvTilastot.Size = new System.Drawing.Size(732, 369);
            this.dgvTilastot.TabIndex = 1;
            // 
            // dtpAloitusAika
            // 
            this.dtpAloitusAika.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAloitusAika.Location = new System.Drawing.Point(57, 26);
            this.dtpAloitusAika.Name = "dtpAloitusAika";
            this.dtpAloitusAika.Size = new System.Drawing.Size(147, 20);
            this.dtpAloitusAika.TabIndex = 59;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 625);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1112, 22);
            this.statusStrip1.TabIndex = 60;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatuslbl
            // 
            this.tsStatuslbl.Name = "tsStatuslbl";
            this.tsStatuslbl.Size = new System.Drawing.Size(41, 17);
            this.tsStatuslbl.Text = "Valmis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 647);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtpAloitusAika);
            this.Controls.Add(this.tabTilastot);
            this.Controls.Add(this.btnPeruuta);
            this.Controls.Add(this.btnSyottaja2);
            this.Controls.Add(this.btnSyottaja1);
            this.Controls.Add(this.btnSyotaTilasto);
            this.Controls.Add(this.btnTallenna);
            this.Controls.Add(this.lblMaalitVieras);
            this.Controls.Add(this.lblMaalitKoti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSyottaja2Nro);
            this.Controls.Add(this.tbSyottaja2Sukunimi);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tbSyottaja2Etunimi);
            this.Controls.Add(this.tbSyottaja1Nro);
            this.Controls.Add(this.tbSyottaja1Sukunimi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbSyottaja1Etunimi);
            this.Controls.Add(this.tbMaalintekijaNro);
            this.Controls.Add(this.tbMaalintekijaSukunimi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbMaaliAika);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbMaalintekijaEtunimi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMaaliJoukkue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblKokonaisaika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEraAika);
            this.Controls.Add(this.lblEra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVieras);
            this.Controls.Add(this.lblKoti);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnKelaa);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbJoukkue2);
            this.Controls.Add(this.cbJoukkue1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1128, 686);
            this.Name = "Form1";
            this.Text = "Harjoitustyö";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabTilastot.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOttelu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTilastot)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbJoukkue1;
        private System.Windows.Forms.ComboBox cbJoukkue2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnKelaa;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblKoti;
        private System.Windows.Forms.Label lblVieras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEra;
        private System.Windows.Forms.Label lblEraAika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKokonaisaika;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaaliJoukkue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbMaalintekijaEtunimi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMaaliAika;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMaalintekijaSukunimi;
        private System.Windows.Forms.TextBox tbMaalintekijaNro;
        private System.Windows.Forms.TextBox tbSyottaja1Nro;
        private System.Windows.Forms.TextBox tbSyottaja1Sukunimi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbSyottaja1Etunimi;
        private System.Windows.Forms.TextBox tbSyottaja2Nro;
        private System.Windows.Forms.TextBox tbSyottaja2Sukunimi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbSyottaja2Etunimi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSalibandy;
        private System.Windows.Forms.RadioButton rbtnJaakiekko;
        private System.Windows.Forms.RadioButton rbtnJalkapallo;
        private System.Windows.Forms.Label lblMaalitKoti;
        private System.Windows.Forms.Label lblMaalitVieras;
        private System.Windows.Forms.Button btnTallenna;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem aloitaUusiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aloitaUusiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lopetaToolStripMenuItem;
        private System.Windows.Forms.Button btnSyotaTilasto;
        private System.Windows.Forms.Button btnSyottaja1;
        private System.Windows.Forms.Button btnSyottaja2;
        private System.Windows.Forms.Button btnPeruuta;
        private System.Windows.Forms.TabControl tabTilastot;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvOttelu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTilastot;
        private System.Windows.Forms.DateTimePicker dtpAloitusAika;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatuslbl;
    }
}

