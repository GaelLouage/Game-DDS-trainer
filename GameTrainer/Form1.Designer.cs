
namespace GameTrainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.lblProcess = new System.Windows.Forms.Label();
            this.btnOrderLimit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbReputation = new System.Windows.Forms.CheckBox();
            this.tbOldMarketPlace = new System.Windows.Forms.TrackBar();
            this.tbTwoTowers = new System.Windows.Forms.TrackBar();
            this.tbEastOldTown = new System.Windows.Forms.TrackBar();
            this.tbWestOldTown = new System.Windows.Forms.TrackBar();
            this.pgbOldMarketPlace = new System.Windows.Forms.ProgressBar();
            this.pgbTwoTowers = new System.Windows.Forms.ProgressBar();
            this.lblEastoldTown = new System.Windows.Forms.Label();
            this.pgBarEastOldTown = new System.Windows.Forms.ProgressBar();
            this.lblWestOldTown = new System.Windows.Forms.Label();
            this.pgBarWestOldTown = new System.Windows.Forms.ProgressBar();
            this.labelMa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlReputation = new System.Windows.Forms.Panel();
            this.lblOldMarketPlace = new System.Windows.Forms.Label();
            this.lblTwoTowers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblReputation = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.btnSkillPoints = new System.Windows.Forms.Button();
            this.txtSkillPoints = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLevelPlus = new System.Windows.Forms.Button();
            this.btnLevelMin = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMisc = new System.Windows.Forms.Label();
            this.pnlMisc = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBPOne = new System.Windows.Forms.CheckBox();
            this.cbBpFour = new System.Windows.Forms.CheckBox();
            this.cbBpTwo = new System.Windows.Forms.CheckBox();
            this.cbBpThree = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSuperJump = new System.Windows.Forms.CheckBox();
            this.lblOrderLimit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderLimit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldMarketPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTwoTowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEastOldTown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWestOldTown)).BeginInit();
            this.pnlReputation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPlayer.SuspendLayout();
            this.pnlMisc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.WorkerSupportsCancellation = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(10, 267);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(134, 15);
            this.lblProcess.TabIndex = 0;
            this.lblProcess.Text = "Process:  Niet gevonden";
            // 
            // btnOrderLimit
            // 
            this.btnOrderLimit.Location = new System.Drawing.Point(147, 40);
            this.btnOrderLimit.Name = "btnOrderLimit";
            this.btnOrderLimit.Size = new System.Drawing.Size(75, 23);
            this.btnOrderLimit.TabIndex = 5;
            this.btnOrderLimit.Text = "Submit";
            this.btnOrderLimit.UseVisualStyleBackColor = true;
            this.btnOrderLimit.Click += new System.EventHandler(this.btnOrderLimit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // cbReputation
            // 
            this.cbReputation.AutoSize = true;
            this.cbReputation.Location = new System.Drawing.Point(17, 179);
            this.cbReputation.Name = "cbReputation";
            this.cbReputation.Size = new System.Drawing.Size(110, 19);
            this.cbReputation.TabIndex = 20;
            this.cbReputation.Text = "Max Reputation";
            this.cbReputation.UseVisualStyleBackColor = true;
            // 
            // tbOldMarketPlace
            // 
            this.tbOldMarketPlace.Location = new System.Drawing.Point(329, 139);
            this.tbOldMarketPlace.Maximum = 1000;
            this.tbOldMarketPlace.Name = "tbOldMarketPlace";
            this.tbOldMarketPlace.Size = new System.Drawing.Size(200, 45);
            this.tbOldMarketPlace.TabIndex = 19;
            this.tbOldMarketPlace.Scroll += new System.EventHandler(this.tbOldMarketPlace_Scroll);
            // 
            // tbTwoTowers
            // 
            this.tbTwoTowers.Location = new System.Drawing.Point(329, 96);
            this.tbTwoTowers.Maximum = 1000;
            this.tbTwoTowers.Name = "tbTwoTowers";
            this.tbTwoTowers.Size = new System.Drawing.Size(200, 45);
            this.tbTwoTowers.TabIndex = 18;
            this.tbTwoTowers.Scroll += new System.EventHandler(this.tbTwoTowers_Scroll);
            // 
            // tbEastOldTown
            // 
            this.tbEastOldTown.Location = new System.Drawing.Point(329, 49);
            this.tbEastOldTown.Maximum = 1000;
            this.tbEastOldTown.Name = "tbEastOldTown";
            this.tbEastOldTown.Size = new System.Drawing.Size(200, 45);
            this.tbEastOldTown.TabIndex = 17;
            this.tbEastOldTown.Scroll += new System.EventHandler(this.tbEastOldTown_Scroll);
            // 
            // tbWestOldTown
            // 
            this.tbWestOldTown.Location = new System.Drawing.Point(329, 7);
            this.tbWestOldTown.Maximum = 1000;
            this.tbWestOldTown.Name = "tbWestOldTown";
            this.tbWestOldTown.Size = new System.Drawing.Size(200, 45);
            this.tbWestOldTown.TabIndex = 16;
            this.tbWestOldTown.Scroll += new System.EventHandler(this.tbWestOldTown_Scroll);
            // 
            // pgbOldMarketPlace
            // 
            this.pgbOldMarketPlace.Location = new System.Drawing.Point(122, 142);
            this.pgbOldMarketPlace.Maximum = 1000;
            this.pgbOldMarketPlace.Name = "pgbOldMarketPlace";
            this.pgbOldMarketPlace.Size = new System.Drawing.Size(200, 18);
            this.pgbOldMarketPlace.TabIndex = 14;
            // 
            // pgbTwoTowers
            // 
            this.pgbTwoTowers.Location = new System.Drawing.Point(123, 99);
            this.pgbTwoTowers.Maximum = 1000;
            this.pgbTwoTowers.Name = "pgbTwoTowers";
            this.pgbTwoTowers.Size = new System.Drawing.Size(200, 18);
            this.pgbTwoTowers.TabIndex = 12;
            // 
            // lblEastoldTown
            // 
            this.lblEastoldTown.AutoSize = true;
            this.lblEastoldTown.BackColor = System.Drawing.Color.Transparent;
            this.lblEastoldTown.Location = new System.Drawing.Point(535, 49);
            this.lblEastoldTown.Name = "lblEastoldTown";
            this.lblEastoldTown.Size = new System.Drawing.Size(13, 15);
            this.lblEastoldTown.TabIndex = 11;
            this.lblEastoldTown.Text = "0";
            // 
            // pgBarEastOldTown
            // 
            this.pgBarEastOldTown.Location = new System.Drawing.Point(123, 56);
            this.pgBarEastOldTown.Maximum = 1000;
            this.pgBarEastOldTown.Name = "pgBarEastOldTown";
            this.pgBarEastOldTown.Size = new System.Drawing.Size(200, 18);
            this.pgBarEastOldTown.TabIndex = 10;
            // 
            // lblWestOldTown
            // 
            this.lblWestOldTown.AutoSize = true;
            this.lblWestOldTown.BackColor = System.Drawing.Color.Transparent;
            this.lblWestOldTown.Location = new System.Drawing.Point(535, 7);
            this.lblWestOldTown.Name = "lblWestOldTown";
            this.lblWestOldTown.Size = new System.Drawing.Size(13, 15);
            this.lblWestOldTown.TabIndex = 9;
            this.lblWestOldTown.Text = "0";
            // 
            // pgBarWestOldTown
            // 
            this.pgBarWestOldTown.Location = new System.Drawing.Point(123, 17);
            this.pgBarWestOldTown.Maximum = 1000;
            this.pgBarWestOldTown.Name = "pgBarWestOldTown";
            this.pgBarWestOldTown.Size = new System.Drawing.Size(200, 18);
            this.pgBarWestOldTown.Step = 1;
            this.pgBarWestOldTown.TabIndex = 8;
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Location = new System.Drawing.Point(15, 142);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(98, 15);
            this.labelMa.TabIndex = 3;
            this.labelMa.Text = "Old MartketPlace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Two Towers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "East Old Town";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "West Old Town";
            // 
            // pnlReputation
            // 
            this.pnlReputation.Controls.Add(this.cbReputation);
            this.pnlReputation.Controls.Add(this.label2);
            this.pnlReputation.Controls.Add(this.tbOldMarketPlace);
            this.pnlReputation.Controls.Add(this.label3);
            this.pnlReputation.Controls.Add(this.tbTwoTowers);
            this.pnlReputation.Controls.Add(this.label4);
            this.pnlReputation.Controls.Add(this.tbEastOldTown);
            this.pnlReputation.Controls.Add(this.labelMa);
            this.pnlReputation.Controls.Add(this.tbWestOldTown);
            this.pnlReputation.Controls.Add(this.pgBarWestOldTown);
            this.pnlReputation.Controls.Add(this.lblOldMarketPlace);
            this.pnlReputation.Controls.Add(this.lblWestOldTown);
            this.pnlReputation.Controls.Add(this.pgbOldMarketPlace);
            this.pnlReputation.Controls.Add(this.pgBarEastOldTown);
            this.pnlReputation.Controls.Add(this.lblTwoTowers);
            this.pnlReputation.Controls.Add(this.lblEastoldTown);
            this.pnlReputation.Controls.Add(this.pgbTwoTowers);
            this.pnlReputation.Location = new System.Drawing.Point(0, 36);
            this.pnlReputation.Name = "pnlReputation";
            this.pnlReputation.Size = new System.Drawing.Size(589, 213);
            this.pnlReputation.TabIndex = 7;
            // 
            // lblOldMarketPlace
            // 
            this.lblOldMarketPlace.AutoSize = true;
            this.lblOldMarketPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblOldMarketPlace.Location = new System.Drawing.Point(535, 142);
            this.lblOldMarketPlace.Name = "lblOldMarketPlace";
            this.lblOldMarketPlace.Size = new System.Drawing.Size(13, 15);
            this.lblOldMarketPlace.TabIndex = 15;
            this.lblOldMarketPlace.Text = "0";
            // 
            // lblTwoTowers
            // 
            this.lblTwoTowers.AutoSize = true;
            this.lblTwoTowers.BackColor = System.Drawing.Color.Transparent;
            this.lblTwoTowers.Location = new System.Drawing.Point(535, 96);
            this.lblTwoTowers.Name = "lblTwoTowers";
            this.lblTwoTowers.Size = new System.Drawing.Size(13, 15);
            this.lblTwoTowers.TabIndex = 13;
            this.lblTwoTowers.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblReputation
            // 
            this.lblReputation.BackColor = System.Drawing.Color.DimGray;
            this.lblReputation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReputation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReputation.Location = new System.Drawing.Point(106, 2);
            this.lblReputation.Name = "lblReputation";
            this.lblReputation.Size = new System.Drawing.Size(106, 31);
            this.lblReputation.TabIndex = 9;
            this.lblReputation.Text = "Reputation";
            this.lblReputation.Click += new System.EventHandler(this.lblReputation_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.DimGray;
            this.lblPlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer.Location = new System.Drawing.Point(3, 2);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(95, 31);
            this.lblPlayer.TabIndex = 10;
            this.lblPlayer.Text = "Player";
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.Controls.Add(this.btnSkillPoints);
            this.pnlPlayer.Controls.Add(this.txtSkillPoints);
            this.pnlPlayer.Controls.Add(this.label7);
            this.pnlPlayer.Controls.Add(this.btnLevelPlus);
            this.pnlPlayer.Controls.Add(this.btnLevelMin);
            this.pnlPlayer.Controls.Add(this.lblLevel);
            this.pnlPlayer.Controls.Add(this.label6);
            this.pnlPlayer.Location = new System.Drawing.Point(0, 37);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(372, 192);
            this.pnlPlayer.TabIndex = 11;
            // 
            // btnSkillPoints
            // 
            this.btnSkillPoints.Location = new System.Drawing.Point(145, 81);
            this.btnSkillPoints.Name = "btnSkillPoints";
            this.btnSkillPoints.Size = new System.Drawing.Size(53, 23);
            this.btnSkillPoints.TabIndex = 6;
            this.btnSkillPoints.Text = "Add";
            this.btnSkillPoints.UseVisualStyleBackColor = true;
            this.btnSkillPoints.Click += new System.EventHandler(this.btnSkillPoints_Click);
            // 
            // txtSkillPoints
            // 
            this.txtSkillPoints.Location = new System.Drawing.Point(24, 81);
            this.txtSkillPoints.Name = "txtSkillPoints";
            this.txtSkillPoints.Size = new System.Drawing.Size(100, 23);
            this.txtSkillPoints.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Skillpoints";
            // 
            // btnLevelPlus
            // 
            this.btnLevelPlus.Location = new System.Drawing.Point(192, 19);
            this.btnLevelPlus.Name = "btnLevelPlus";
            this.btnLevelPlus.Size = new System.Drawing.Size(53, 23);
            this.btnLevelPlus.TabIndex = 3;
            this.btnLevelPlus.Text = "+";
            this.btnLevelPlus.UseVisualStyleBackColor = true;
            this.btnLevelPlus.Click += new System.EventHandler(this.btnLevelPlus_Click);
            // 
            // btnLevelMin
            // 
            this.btnLevelMin.Location = new System.Drawing.Point(64, 19);
            this.btnLevelMin.Name = "btnLevelMin";
            this.btnLevelMin.Size = new System.Drawing.Size(53, 23);
            this.btnLevelMin.TabIndex = 2;
            this.btnLevelMin.Text = "-";
            this.btnLevelMin.UseVisualStyleBackColor = true;
            this.btnLevelMin.Click += new System.EventHandler(this.btnLevelMin_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(145, 23);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(13, 15);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Level";
            // 
            // lblMisc
            // 
            this.lblMisc.BackColor = System.Drawing.Color.DimGray;
            this.lblMisc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMisc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMisc.Location = new System.Drawing.Point(234, 2);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(112, 31);
            this.lblMisc.TabIndex = 12;
            this.lblMisc.Text = "Misc";
            this.lblMisc.Click += new System.EventHandler(this.lblMisc_Click);
            // 
            // pnlMisc
            // 
            this.pnlMisc.Controls.Add(this.groupBox2);
            this.pnlMisc.Controls.Add(this.groupBox1);
            this.pnlMisc.Controls.Add(this.cbSuperJump);
            this.pnlMisc.Controls.Add(this.lblOrderLimit);
            this.pnlMisc.Controls.Add(this.label5);
            this.pnlMisc.Controls.Add(this.txtOrderLimit);
            this.pnlMisc.Controls.Add(this.btnOrderLimit);
            this.pnlMisc.Location = new System.Drawing.Point(1, 34);
            this.pnlMisc.Name = "pnlMisc";
            this.pnlMisc.Size = new System.Drawing.Size(577, 217);
            this.pnlMisc.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBPOne);
            this.groupBox2.Controls.Add(this.cbBpFour);
            this.groupBox2.Controls.Add(this.cbBpTwo);
            this.groupBox2.Controls.Add(this.cbBpThree);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BackPack item one";
            // 
            // cbBPOne
            // 
            this.cbBPOne.AutoSize = true;
            this.cbBPOne.Location = new System.Drawing.Point(28, 31);
            this.cbBPOne.Name = "cbBPOne";
            this.cbBPOne.Size = new System.Drawing.Size(44, 19);
            this.cbBPOne.TabIndex = 18;
            this.cbBPOne.Text = "100";
            this.cbBPOne.UseVisualStyleBackColor = true;
            this.cbBPOne.CheckedChanged += new System.EventHandler(this.cbBPOne_CheckedChanged);
            // 
            // cbBpFour
            // 
            this.cbBpFour.AutoSize = true;
            this.cbBpFour.Location = new System.Drawing.Point(118, 57);
            this.cbBpFour.Name = "cbBpFour";
            this.cbBpFour.Size = new System.Drawing.Size(56, 19);
            this.cbBpFour.TabIndex = 21;
            this.cbBpFour.Text = "10000";
            this.cbBpFour.UseVisualStyleBackColor = true;
            this.cbBpFour.CheckedChanged += new System.EventHandler(this.cbBpFour_CheckedChanged);
            // 
            // cbBpTwo
            // 
            this.cbBpTwo.AutoSize = true;
            this.cbBpTwo.Location = new System.Drawing.Point(28, 57);
            this.cbBpTwo.Name = "cbBpTwo";
            this.cbBpTwo.Size = new System.Drawing.Size(44, 19);
            this.cbBpTwo.TabIndex = 19;
            this.cbBpTwo.Text = "500";
            this.cbBpTwo.UseVisualStyleBackColor = true;
            this.cbBpTwo.CheckedChanged += new System.EventHandler(this.cbBpTwo_CheckedChanged);
            // 
            // cbBpThree
            // 
            this.cbBpThree.AutoSize = true;
            this.cbBpThree.Location = new System.Drawing.Point(118, 31);
            this.cbBpThree.Name = "cbBpThree";
            this.cbBpThree.Size = new System.Drawing.Size(50, 19);
            this.cbBpThree.TabIndex = 20;
            this.cbBpThree.Text = "1000";
            this.cbBpThree.UseVisualStyleBackColor = true;
            this.cbBpThree.CheckedChanged += new System.EventHandler(this.cbBpThree_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(273, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 184);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teleport";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(154, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "F4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "F3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "F2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "F1  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kennel";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "West Old Town";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Jamies shop  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "House        ";
            // 
            // cbSuperJump
            // 
            this.cbSuperJump.AutoSize = true;
            this.cbSuperJump.Location = new System.Drawing.Point(14, 79);
            this.cbSuperJump.Name = "cbSuperJump";
            this.cbSuperJump.Size = new System.Drawing.Size(85, 19);
            this.cbSuperJump.TabIndex = 15;
            this.cbSuperJump.Text = "SuperJump";
            this.cbSuperJump.UseVisualStyleBackColor = true;
            // 
            // lblOrderLimit
            // 
            this.lblOrderLimit.AutoSize = true;
            this.lblOrderLimit.Location = new System.Drawing.Point(231, 44);
            this.lblOrderLimit.Name = "lblOrderLimit";
            this.lblOrderLimit.Size = new System.Drawing.Size(13, 15);
            this.lblOrderLimit.TabIndex = 14;
            this.lblOrderLimit.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Order limit:";
            // 
            // txtOrderLimit
            // 
            this.txtOrderLimit.Location = new System.Drawing.Point(14, 40);
            this.txtOrderLimit.Name = "txtOrderLimit";
            this.txtOrderLimit.Size = new System.Drawing.Size(127, 23);
            this.txtOrderLimit.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 290);
            this.Controls.Add(this.pnlMisc);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblReputation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlReputation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProcess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = " ";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.tbOldMarketPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTwoTowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEastOldTown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWestOldTown)).EndInit();
            this.pnlReputation.ResumeLayout(false);
            this.pnlReputation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPlayer.ResumeLayout(false);
            this.pnlPlayer.PerformLayout();
            this.pnlMisc.ResumeLayout(false);
            this.pnlMisc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Button btnOrderLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label lblWestOldTown;
        private System.Windows.Forms.ProgressBar pgBarWestOldTown;
        private System.Windows.Forms.ProgressBar pgBarEastOldTown;
        private System.Windows.Forms.Label lblEastoldTown;
        private System.Windows.Forms.ProgressBar pgbOldMarketPlace;
        private System.Windows.Forms.ProgressBar pgbTwoTowers;
        private System.Windows.Forms.TrackBar tbOldMarketPlace;
        private System.Windows.Forms.TrackBar tbTwoTowers;
        private System.Windows.Forms.TrackBar tbEastOldTown;
        private System.Windows.Forms.TrackBar tbWestOldTown;
        private System.Windows.Forms.CheckBox cbReputation;
        private System.Windows.Forms.Panel pnlReputation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblReputation;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label lblOldMarketPlace;
        private System.Windows.Forms.Label lblTwoTowers;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.Panel pnlMisc;
        private System.Windows.Forms.Label lblOrderLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderLimit;
        private System.Windows.Forms.CheckBox cbSuperJump;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLevelPlus;
        private System.Windows.Forms.Button btnLevelMin;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbBPOne;
        private System.Windows.Forms.CheckBox cbBpFour;
        private System.Windows.Forms.CheckBox cbBpTwo;
        private System.Windows.Forms.CheckBox cbBpThree;
        private System.Windows.Forms.Button btnSkillPoints;
        private System.Windows.Forms.TextBox txtSkillPoints;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

