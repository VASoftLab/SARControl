namespace CostumeRecorder
{
    partial class FormMain
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
            this.plLeft = new System.Windows.Forms.Panel();
            this.plCostume = new System.Windows.Forms.Panel();
            this.tbVoltage = new System.Windows.Forms.TextBox();
            this.lbCostume = new System.Windows.Forms.Label();
            this.pbCostumeConnectionStatus = new System.Windows.Forms.PictureBox();
            this.tbDiagnostic = new System.Windows.Forms.TextBox();
            this.lbRClavicle = new System.Windows.Forms.Label();
            this.tbRClavicle = new System.Windows.Forms.TextBox();
            this.lbRWristR = new System.Windows.Forms.Label();
            this.tbRWristR = new System.Windows.Forms.TextBox();
            this.lbRWristS = new System.Windows.Forms.Label();
            this.tbRWristS = new System.Windows.Forms.TextBox();
            this.lbRWristF = new System.Windows.Forms.Label();
            this.tbRWristF = new System.Windows.Forms.TextBox();
            this.lbRElbowR = new System.Windows.Forms.Label();
            this.tbRElbowR = new System.Windows.Forms.TextBox();
            this.lbRElbow = new System.Windows.Forms.Label();
            this.tbRElbow = new System.Windows.Forms.TextBox();
            this.lbRShoulderS = new System.Windows.Forms.Label();
            this.tbRShoulderS = new System.Windows.Forms.TextBox();
            this.lbRShoulderF = new System.Windows.Forms.Label();
            this.tbRShoulderF = new System.Windows.Forms.TextBox();
            this.lbLClavicle = new System.Windows.Forms.Label();
            this.tbLClavicle = new System.Windows.Forms.TextBox();
            this.lbLWristR = new System.Windows.Forms.Label();
            this.tbLWristR = new System.Windows.Forms.TextBox();
            this.lbLWristS = new System.Windows.Forms.Label();
            this.tbLWristS = new System.Windows.Forms.TextBox();
            this.lbLWristF = new System.Windows.Forms.Label();
            this.tbLWristF = new System.Windows.Forms.TextBox();
            this.lbLElbowR = new System.Windows.Forms.Label();
            this.tbLElbowR = new System.Windows.Forms.TextBox();
            this.lbLElbow = new System.Windows.Forms.Label();
            this.tbLElbow = new System.Windows.Forms.TextBox();
            this.lbLShoulderS = new System.Windows.Forms.Label();
            this.tbLShoulderS = new System.Windows.Forms.TextBox();
            this.lbLShoulderF = new System.Windows.Forms.Label();
            this.tbLShoulderF = new System.Windows.Forms.TextBox();
            this.pbCostume = new System.Windows.Forms.PictureBox();
            this.plControl = new System.Windows.Forms.Panel();
            this.btReset = new System.Windows.Forms.Button();
            this.btProgramSelector = new System.Windows.Forms.Button();
            this.btPlayControl = new System.Windows.Forms.Button();
            this.btRobotConnection = new System.Windows.Forms.Button();
            this.btRecordControl = new System.Windows.Forms.Button();
            this.lbControl = new System.Windows.Forms.Label();
            this.btCostumeConnection = new System.Windows.Forms.Button();
            this.plDown = new System.Windows.Forms.Panel();
            this.btConnectToServer = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.btSettings = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.plRight = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.slIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.slPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.slPPS = new System.Windows.Forms.ToolStripStatusLabel();
            this.slConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.slServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.slServerAnswer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsRobotConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmCheckCollision = new System.Windows.Forms.Timer(this.components);
            this.plLeft.SuspendLayout();
            this.plCostume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCostumeConnectionStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCostume)).BeginInit();
            this.plControl.SuspendLayout();
            this.plDown.SuspendLayout();
            this.plRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLeft
            // 
            this.plLeft.Controls.Add(this.plCostume);
            this.plLeft.Controls.Add(this.plControl);
            this.plLeft.Controls.Add(this.plDown);
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(7, 6);
            this.plLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(985, 602);
            this.plLeft.TabIndex = 1;
            // 
            // plCostume
            // 
            this.plCostume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plCostume.Controls.Add(this.tbVoltage);
            this.plCostume.Controls.Add(this.lbCostume);
            this.plCostume.Controls.Add(this.pbCostumeConnectionStatus);
            this.plCostume.Controls.Add(this.tbDiagnostic);
            this.plCostume.Controls.Add(this.lbRClavicle);
            this.plCostume.Controls.Add(this.tbRClavicle);
            this.plCostume.Controls.Add(this.lbRWristR);
            this.plCostume.Controls.Add(this.tbRWristR);
            this.plCostume.Controls.Add(this.lbRWristS);
            this.plCostume.Controls.Add(this.tbRWristS);
            this.plCostume.Controls.Add(this.lbRWristF);
            this.plCostume.Controls.Add(this.tbRWristF);
            this.plCostume.Controls.Add(this.lbRElbowR);
            this.plCostume.Controls.Add(this.tbRElbowR);
            this.plCostume.Controls.Add(this.lbRElbow);
            this.plCostume.Controls.Add(this.tbRElbow);
            this.plCostume.Controls.Add(this.lbRShoulderS);
            this.plCostume.Controls.Add(this.tbRShoulderS);
            this.plCostume.Controls.Add(this.lbRShoulderF);
            this.plCostume.Controls.Add(this.tbRShoulderF);
            this.plCostume.Controls.Add(this.lbLClavicle);
            this.plCostume.Controls.Add(this.tbLClavicle);
            this.plCostume.Controls.Add(this.lbLWristR);
            this.plCostume.Controls.Add(this.tbLWristR);
            this.plCostume.Controls.Add(this.lbLWristS);
            this.plCostume.Controls.Add(this.tbLWristS);
            this.plCostume.Controls.Add(this.lbLWristF);
            this.plCostume.Controls.Add(this.tbLWristF);
            this.plCostume.Controls.Add(this.lbLElbowR);
            this.plCostume.Controls.Add(this.tbLElbowR);
            this.plCostume.Controls.Add(this.lbLElbow);
            this.plCostume.Controls.Add(this.tbLElbow);
            this.plCostume.Controls.Add(this.lbLShoulderS);
            this.plCostume.Controls.Add(this.tbLShoulderS);
            this.plCostume.Controls.Add(this.lbLShoulderF);
            this.plCostume.Controls.Add(this.tbLShoulderF);
            this.plCostume.Controls.Add(this.pbCostume);
            this.plCostume.Dock = System.Windows.Forms.DockStyle.Left;
            this.plCostume.Location = new System.Drawing.Point(266, 0);
            this.plCostume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plCostume.Name = "plCostume";
            this.plCostume.Size = new System.Drawing.Size(719, 559);
            this.plCostume.TabIndex = 5;
            // 
            // tbVoltage
            // 
            this.tbVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbVoltage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbVoltage.Location = new System.Drawing.Point(181, 38);
            this.tbVoltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVoltage.Multiline = true;
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.Size = new System.Drawing.Size(83, 31);
            this.tbVoltage.TabIndex = 37;
            this.tbVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVoltage.WordWrap = false;
            // 
            // lbCostume
            // 
            this.lbCostume.AutoSize = true;
            this.lbCostume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCostume.Location = new System.Drawing.Point(229, 15);
            this.lbCostume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCostume.Name = "lbCostume";
            this.lbCostume.Size = new System.Drawing.Size(227, 20);
            this.lbCostume.TabIndex = 36;
            this.lbCostume.Tag = "";
            this.lbCostume.Text = "КОПИРУЮЩИЙ КОСТЮМ";
            // 
            // pbCostumeConnectionStatus
            // 
            this.pbCostumeConnectionStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCostumeConnectionStatus.Image = global::CostumeRecorder.Properties.Resources.circle_grey;
            this.pbCostumeConnectionStatus.Location = new System.Drawing.Point(480, 38);
            this.pbCostumeConnectionStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCostumeConnectionStatus.Name = "pbCostumeConnectionStatus";
            this.pbCostumeConnectionStatus.Size = new System.Drawing.Size(43, 41);
            this.pbCostumeConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCostumeConnectionStatus.TabIndex = 35;
            this.pbCostumeConnectionStatus.TabStop = false;
            // 
            // tbDiagnostic
            // 
            this.tbDiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDiagnostic.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbDiagnostic.Location = new System.Drawing.Point(181, 476);
            this.tbDiagnostic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDiagnostic.Multiline = true;
            this.tbDiagnostic.Name = "tbDiagnostic";
            this.tbDiagnostic.Size = new System.Drawing.Size(341, 75);
            this.tbDiagnostic.TabIndex = 34;
            this.tbDiagnostic.Text = "Диагностическая информация";
            this.tbDiagnostic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRClavicle
            // 
            this.lbRClavicle.AutoSize = true;
            this.lbRClavicle.Enabled = false;
            this.lbRClavicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRClavicle.Location = new System.Drawing.Point(564, 480);
            this.lbRClavicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRClavicle.Name = "lbRClavicle";
            this.lbRClavicle.Size = new System.Drawing.Size(94, 20);
            this.lbRClavicle.TabIndex = 33;
            this.lbRClavicle.Tag = "R.Clavicle";
            this.lbRClavicle.Text = "R.Clavicle";
            // 
            // tbRClavicle
            // 
            this.tbRClavicle.Enabled = false;
            this.tbRClavicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRClavicle.Location = new System.Drawing.Point(568, 503);
            this.tbRClavicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRClavicle.Name = "tbRClavicle";
            this.tbRClavicle.Size = new System.Drawing.Size(132, 30);
            this.tbRClavicle.TabIndex = 32;
            this.tbRClavicle.Tag = "R.Clavicle";
            this.tbRClavicle.Text = "0.00";
            this.tbRClavicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRWristR
            // 
            this.lbRWristR.AutoSize = true;
            this.lbRWristR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRWristR.Location = new System.Drawing.Point(564, 414);
            this.lbRWristR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRWristR.Name = "lbRWristR";
            this.lbRWristR.Size = new System.Drawing.Size(85, 20);
            this.lbRWristR.TabIndex = 31;
            this.lbRWristR.Tag = "R.WristR";
            this.lbRWristR.Text = "R.WristR";
            // 
            // tbRWristR
            // 
            this.tbRWristR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRWristR.Location = new System.Drawing.Point(564, 437);
            this.tbRWristR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRWristR.Name = "tbRWristR";
            this.tbRWristR.Size = new System.Drawing.Size(132, 30);
            this.tbRWristR.TabIndex = 30;
            this.tbRWristR.Tag = "R.WristR";
            this.tbRWristR.Text = "0.00";
            this.tbRWristR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRWristS
            // 
            this.lbRWristS.AutoSize = true;
            this.lbRWristS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRWristS.Location = new System.Drawing.Point(564, 347);
            this.lbRWristS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRWristS.Name = "lbRWristS";
            this.lbRWristS.Size = new System.Drawing.Size(84, 20);
            this.lbRWristS.TabIndex = 29;
            this.lbRWristS.Tag = "R.WristS";
            this.lbRWristS.Text = "R.WristS";
            // 
            // tbRWristS
            // 
            this.tbRWristS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRWristS.Location = new System.Drawing.Point(564, 370);
            this.tbRWristS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRWristS.Name = "tbRWristS";
            this.tbRWristS.Size = new System.Drawing.Size(132, 30);
            this.tbRWristS.TabIndex = 28;
            this.tbRWristS.Tag = "R.WristS";
            this.tbRWristS.Text = "0.00";
            this.tbRWristS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRWristF
            // 
            this.lbRWristF.AutoSize = true;
            this.lbRWristF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRWristF.Location = new System.Drawing.Point(564, 281);
            this.lbRWristF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRWristF.Name = "lbRWristF";
            this.lbRWristF.Size = new System.Drawing.Size(83, 20);
            this.lbRWristF.TabIndex = 27;
            this.lbRWristF.Tag = "R.WristF";
            this.lbRWristF.Text = "R.WristF";
            // 
            // tbRWristF
            // 
            this.tbRWristF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRWristF.Location = new System.Drawing.Point(564, 304);
            this.tbRWristF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRWristF.Name = "tbRWristF";
            this.tbRWristF.Size = new System.Drawing.Size(132, 30);
            this.tbRWristF.TabIndex = 26;
            this.tbRWristF.Tag = "R.WristF";
            this.tbRWristF.Text = "0.00";
            this.tbRWristF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRElbowR
            // 
            this.lbRElbowR.AutoSize = true;
            this.lbRElbowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRElbowR.Location = new System.Drawing.Point(564, 214);
            this.lbRElbowR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRElbowR.Name = "lbRElbowR";
            this.lbRElbowR.Size = new System.Drawing.Size(90, 20);
            this.lbRElbowR.TabIndex = 25;
            this.lbRElbowR.Tag = "R.ElbowR";
            this.lbRElbowR.Text = "R.ElbowR";
            // 
            // tbRElbowR
            // 
            this.tbRElbowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRElbowR.Location = new System.Drawing.Point(564, 238);
            this.tbRElbowR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRElbowR.Name = "tbRElbowR";
            this.tbRElbowR.Size = new System.Drawing.Size(132, 30);
            this.tbRElbowR.TabIndex = 24;
            this.tbRElbowR.Tag = "R.ElbowR";
            this.tbRElbowR.Text = "0.00";
            this.tbRElbowR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRElbow
            // 
            this.lbRElbow.AutoSize = true;
            this.lbRElbow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRElbow.Location = new System.Drawing.Point(564, 148);
            this.lbRElbow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRElbow.Name = "lbRElbow";
            this.lbRElbow.Size = new System.Drawing.Size(77, 20);
            this.lbRElbow.TabIndex = 23;
            this.lbRElbow.Tag = "R.Elbow";
            this.lbRElbow.Text = "R.Elbow";
            // 
            // tbRElbow
            // 
            this.tbRElbow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRElbow.Location = new System.Drawing.Point(564, 171);
            this.tbRElbow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRElbow.Name = "tbRElbow";
            this.tbRElbow.Size = new System.Drawing.Size(132, 30);
            this.tbRElbow.TabIndex = 22;
            this.tbRElbow.Tag = "R.Elbow";
            this.tbRElbow.Text = "0.00";
            this.tbRElbow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRShoulderS
            // 
            this.lbRShoulderS.AutoSize = true;
            this.lbRShoulderS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRShoulderS.Location = new System.Drawing.Point(564, 81);
            this.lbRShoulderS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRShoulderS.Name = "lbRShoulderS";
            this.lbRShoulderS.Size = new System.Drawing.Size(113, 20);
            this.lbRShoulderS.TabIndex = 21;
            this.lbRShoulderS.Text = "R.ShoulderS";
            // 
            // tbRShoulderS
            // 
            this.tbRShoulderS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRShoulderS.Location = new System.Drawing.Point(564, 105);
            this.tbRShoulderS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRShoulderS.Name = "tbRShoulderS";
            this.tbRShoulderS.Size = new System.Drawing.Size(132, 30);
            this.tbRShoulderS.TabIndex = 20;
            this.tbRShoulderS.Tag = "R.ShoulderS";
            this.tbRShoulderS.Text = "0.00";
            this.tbRShoulderS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbRShoulderF
            // 
            this.lbRShoulderF.AutoSize = true;
            this.lbRShoulderF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRShoulderF.Location = new System.Drawing.Point(564, 15);
            this.lbRShoulderF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRShoulderF.Name = "lbRShoulderF";
            this.lbRShoulderF.Size = new System.Drawing.Size(112, 20);
            this.lbRShoulderF.TabIndex = 19;
            this.lbRShoulderF.Tag = "R.ShoulderF";
            this.lbRShoulderF.Text = "R.ShoulderF";
            // 
            // tbRShoulderF
            // 
            this.tbRShoulderF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRShoulderF.Location = new System.Drawing.Point(564, 38);
            this.tbRShoulderF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRShoulderF.Name = "tbRShoulderF";
            this.tbRShoulderF.Size = new System.Drawing.Size(132, 30);
            this.tbRShoulderF.TabIndex = 18;
            this.tbRShoulderF.Tag = "R.ShoulderF";
            this.tbRShoulderF.Text = "0.00";
            this.tbRShoulderF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLClavicle
            // 
            this.lbLClavicle.AutoSize = true;
            this.lbLClavicle.Enabled = false;
            this.lbLClavicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLClavicle.Location = new System.Drawing.Point(13, 480);
            this.lbLClavicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLClavicle.Name = "lbLClavicle";
            this.lbLClavicle.Size = new System.Drawing.Size(92, 20);
            this.lbLClavicle.TabIndex = 17;
            this.lbLClavicle.Tag = "L.Clavicle";
            this.lbLClavicle.Text = "L.Clavicle";
            // 
            // tbLClavicle
            // 
            this.tbLClavicle.Enabled = false;
            this.tbLClavicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLClavicle.Location = new System.Drawing.Point(17, 503);
            this.tbLClavicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLClavicle.Name = "tbLClavicle";
            this.tbLClavicle.Size = new System.Drawing.Size(132, 30);
            this.tbLClavicle.TabIndex = 16;
            this.tbLClavicle.Tag = "L.Clavicle";
            this.tbLClavicle.Text = "0.00";
            this.tbLClavicle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLWristR
            // 
            this.lbLWristR.AutoSize = true;
            this.lbLWristR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLWristR.Location = new System.Drawing.Point(13, 414);
            this.lbLWristR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLWristR.Name = "lbLWristR";
            this.lbLWristR.Size = new System.Drawing.Size(83, 20);
            this.lbLWristR.TabIndex = 15;
            this.lbLWristR.Tag = "L.WristR";
            this.lbLWristR.Text = "L.WristR";
            // 
            // tbLWristR
            // 
            this.tbLWristR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLWristR.Location = new System.Drawing.Point(13, 437);
            this.tbLWristR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLWristR.Name = "tbLWristR";
            this.tbLWristR.Size = new System.Drawing.Size(132, 30);
            this.tbLWristR.TabIndex = 14;
            this.tbLWristR.Tag = "L.WristR";
            this.tbLWristR.Text = "0.00";
            this.tbLWristR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLWristS
            // 
            this.lbLWristS.AutoSize = true;
            this.lbLWristS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLWristS.Location = new System.Drawing.Point(13, 347);
            this.lbLWristS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLWristS.Name = "lbLWristS";
            this.lbLWristS.Size = new System.Drawing.Size(82, 20);
            this.lbLWristS.TabIndex = 13;
            this.lbLWristS.Tag = "L.WristS";
            this.lbLWristS.Text = "L.WristS";
            // 
            // tbLWristS
            // 
            this.tbLWristS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLWristS.Location = new System.Drawing.Point(13, 370);
            this.tbLWristS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLWristS.Name = "tbLWristS";
            this.tbLWristS.Size = new System.Drawing.Size(132, 30);
            this.tbLWristS.TabIndex = 12;
            this.tbLWristS.Tag = "L.WristS";
            this.tbLWristS.Text = "0.00";
            this.tbLWristS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLWristF
            // 
            this.lbLWristF.AutoSize = true;
            this.lbLWristF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLWristF.Location = new System.Drawing.Point(13, 281);
            this.lbLWristF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLWristF.Name = "lbLWristF";
            this.lbLWristF.Size = new System.Drawing.Size(81, 20);
            this.lbLWristF.TabIndex = 11;
            this.lbLWristF.Tag = "L.WristF";
            this.lbLWristF.Text = "L.WristF";
            // 
            // tbLWristF
            // 
            this.tbLWristF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLWristF.Location = new System.Drawing.Point(13, 304);
            this.tbLWristF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLWristF.Name = "tbLWristF";
            this.tbLWristF.Size = new System.Drawing.Size(132, 30);
            this.tbLWristF.TabIndex = 10;
            this.tbLWristF.Tag = "L.WristF";
            this.tbLWristF.Text = "0.00";
            this.tbLWristF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLElbowR
            // 
            this.lbLElbowR.AutoSize = true;
            this.lbLElbowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLElbowR.Location = new System.Drawing.Point(13, 214);
            this.lbLElbowR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLElbowR.Name = "lbLElbowR";
            this.lbLElbowR.Size = new System.Drawing.Size(88, 20);
            this.lbLElbowR.TabIndex = 9;
            this.lbLElbowR.Tag = "L.ElbowR";
            this.lbLElbowR.Text = "L.ElbowR";
            // 
            // tbLElbowR
            // 
            this.tbLElbowR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLElbowR.Location = new System.Drawing.Point(13, 238);
            this.tbLElbowR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLElbowR.Name = "tbLElbowR";
            this.tbLElbowR.Size = new System.Drawing.Size(132, 30);
            this.tbLElbowR.TabIndex = 8;
            this.tbLElbowR.Tag = "L.ElbowR";
            this.tbLElbowR.Text = "0.00";
            this.tbLElbowR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLElbow
            // 
            this.lbLElbow.AutoSize = true;
            this.lbLElbow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLElbow.Location = new System.Drawing.Point(13, 148);
            this.lbLElbow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLElbow.Name = "lbLElbow";
            this.lbLElbow.Size = new System.Drawing.Size(75, 20);
            this.lbLElbow.TabIndex = 7;
            this.lbLElbow.Tag = "L.Elbow";
            this.lbLElbow.Text = "L.Elbow";
            // 
            // tbLElbow
            // 
            this.tbLElbow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLElbow.Location = new System.Drawing.Point(13, 171);
            this.tbLElbow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLElbow.Name = "tbLElbow";
            this.tbLElbow.Size = new System.Drawing.Size(132, 30);
            this.tbLElbow.TabIndex = 6;
            this.tbLElbow.Tag = "L.Elbow";
            this.tbLElbow.Text = "0.00";
            this.tbLElbow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLShoulderS
            // 
            this.lbLShoulderS.AutoSize = true;
            this.lbLShoulderS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLShoulderS.Location = new System.Drawing.Point(13, 81);
            this.lbLShoulderS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLShoulderS.Name = "lbLShoulderS";
            this.lbLShoulderS.Size = new System.Drawing.Size(111, 20);
            this.lbLShoulderS.TabIndex = 5;
            this.lbLShoulderS.Tag = "L.ShoulderS";
            this.lbLShoulderS.Text = "L.ShoulderS";
            // 
            // tbLShoulderS
            // 
            this.tbLShoulderS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLShoulderS.Location = new System.Drawing.Point(13, 105);
            this.tbLShoulderS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLShoulderS.Name = "tbLShoulderS";
            this.tbLShoulderS.Size = new System.Drawing.Size(132, 30);
            this.tbLShoulderS.TabIndex = 4;
            this.tbLShoulderS.Tag = "L.ShoulderS";
            this.tbLShoulderS.Text = "0.00";
            this.tbLShoulderS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLShoulderF
            // 
            this.lbLShoulderF.AutoSize = true;
            this.lbLShoulderF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLShoulderF.Location = new System.Drawing.Point(13, 15);
            this.lbLShoulderF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLShoulderF.Name = "lbLShoulderF";
            this.lbLShoulderF.Size = new System.Drawing.Size(110, 20);
            this.lbLShoulderF.TabIndex = 3;
            this.lbLShoulderF.Tag = "L.ShoulderF";
            this.lbLShoulderF.Text = "L.ShoulderF";
            // 
            // tbLShoulderF
            // 
            this.tbLShoulderF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLShoulderF.Location = new System.Drawing.Point(13, 38);
            this.tbLShoulderF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLShoulderF.Name = "tbLShoulderF";
            this.tbLShoulderF.Size = new System.Drawing.Size(132, 30);
            this.tbLShoulderF.TabIndex = 1;
            this.tbLShoulderF.Tag = "L.ShoulderF";
            this.tbLShoulderF.Text = "0.00";
            this.tbLShoulderF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbCostume
            // 
            this.pbCostume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCostume.Image = global::CostumeRecorder.Properties.Resources.costume;
            this.pbCostume.Location = new System.Drawing.Point(181, 38);
            this.pbCostume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCostume.Name = "pbCostume";
            this.pbCostume.Size = new System.Drawing.Size(342, 430);
            this.pbCostume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCostume.TabIndex = 0;
            this.pbCostume.TabStop = false;
            // 
            // plControl
            // 
            this.plControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plControl.Controls.Add(this.btReset);
            this.plControl.Controls.Add(this.btProgramSelector);
            this.plControl.Controls.Add(this.btPlayControl);
            this.plControl.Controls.Add(this.btRobotConnection);
            this.plControl.Controls.Add(this.btRecordControl);
            this.plControl.Controls.Add(this.lbControl);
            this.plControl.Controls.Add(this.btCostumeConnection);
            this.plControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.plControl.Location = new System.Drawing.Point(0, 0);
            this.plControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(266, 559);
            this.plControl.TabIndex = 0;
            // 
            // btReset
            // 
            this.btReset.Enabled = false;
            this.btReset.Location = new System.Drawing.Point(7, 107);
            this.btReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(253, 28);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "СБРОС";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btProgramSelector
            // 
            this.btProgramSelector.Enabled = false;
            this.btProgramSelector.Location = new System.Drawing.Point(7, 470);
            this.btProgramSelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btProgramSelector.Name = "btProgramSelector";
            this.btProgramSelector.Size = new System.Drawing.Size(253, 28);
            this.btProgramSelector.TabIndex = 8;
            this.btProgramSelector.Text = "ВЫБОР ПРОГРАММЫ УПР-Я";
            this.btProgramSelector.UseVisualStyleBackColor = true;
            // 
            // btPlayControl
            // 
            this.btPlayControl.Enabled = false;
            this.btPlayControl.Location = new System.Drawing.Point(7, 506);
            this.btPlayControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPlayControl.Name = "btPlayControl";
            this.btPlayControl.Size = new System.Drawing.Size(253, 28);
            this.btPlayControl.TabIndex = 7;
            this.btPlayControl.Text = "ВОСПРОИЗВЕСТИ ПРОГРАММУ";
            this.btPlayControl.UseVisualStyleBackColor = true;
            // 
            // btRobotConnection
            // 
            this.btRobotConnection.Location = new System.Drawing.Point(7, 434);
            this.btRobotConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRobotConnection.Name = "btRobotConnection";
            this.btRobotConnection.Size = new System.Drawing.Size(253, 28);
            this.btRobotConnection.TabIndex = 6;
            this.btRobotConnection.Text = "СОЕДИНЕНИЕ С РОБОТОМ";
            this.btRobotConnection.UseVisualStyleBackColor = true;
            this.btRobotConnection.Click += new System.EventHandler(this.btRobotConnection_Click);
            // 
            // btRecordControl
            // 
            this.btRecordControl.Enabled = false;
            this.btRecordControl.Location = new System.Drawing.Point(7, 71);
            this.btRecordControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRecordControl.Name = "btRecordControl";
            this.btRecordControl.Size = new System.Drawing.Size(253, 28);
            this.btRecordControl.TabIndex = 5;
            this.btRecordControl.Text = "НАЧАТЬ ЗАПИСЬ";
            this.btRecordControl.UseVisualStyleBackColor = true;
            this.btRecordControl.Click += new System.EventHandler(this.btRecordControl_Click);
            // 
            // lbControl
            // 
            this.lbControl.AutoSize = true;
            this.lbControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbControl.Location = new System.Drawing.Point(57, 14);
            this.lbControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbControl.Name = "lbControl";
            this.lbControl.Size = new System.Drawing.Size(138, 20);
            this.lbControl.TabIndex = 4;
            this.lbControl.Tag = "";
            this.lbControl.Text = "УПРАЛВЕНИЕ";
            // 
            // btCostumeConnection
            // 
            this.btCostumeConnection.Location = new System.Drawing.Point(7, 37);
            this.btCostumeConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCostumeConnection.Name = "btCostumeConnection";
            this.btCostumeConnection.Size = new System.Drawing.Size(253, 28);
            this.btCostumeConnection.TabIndex = 0;
            this.btCostumeConnection.Text = "СОЕДИНЕНИЕ С КОСТЮМОМ";
            this.btCostumeConnection.UseVisualStyleBackColor = true;
            this.btCostumeConnection.Click += new System.EventHandler(this.btCostumeConnection_Click);
            // 
            // plDown
            // 
            this.plDown.Controls.Add(this.btConnectToServer);
            this.plDown.Controls.Add(this.btTest);
            this.plDown.Controls.Add(this.btSettings);
            this.plDown.Controls.Add(this.btClose);
            this.plDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plDown.Location = new System.Drawing.Point(0, 559);
            this.plDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plDown.Name = "plDown";
            this.plDown.Size = new System.Drawing.Size(985, 43);
            this.plDown.TabIndex = 4;
            // 
            // btConnectToServer
            // 
            this.btConnectToServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConnectToServer.Location = new System.Drawing.Point(448, 7);
            this.btConnectToServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConnectToServer.Name = "btConnectToServer";
            this.btConnectToServer.Size = new System.Drawing.Size(343, 28);
            this.btConnectToServer.TabIndex = 3;
            this.btConnectToServer.Text = "ПОДКЛЮЧИТЬСЯ К СЕРВЕРУ";
            this.btConnectToServer.UseVisualStyleBackColor = true;
            this.btConnectToServer.Click += new System.EventHandler(this.btConnectToServer_Click);
            // 
            // btTest
            // 
            this.btTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTest.Location = new System.Drawing.Point(284, 7);
            this.btTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(133, 28);
            this.btTest.TabIndex = 2;
            this.btTest.Text = "ТЕСТ";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btSettings
            // 
            this.btSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSettings.Location = new System.Drawing.Point(4, 7);
            this.btSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(263, 28);
            this.btSettings.TabIndex = 1;
            this.btSettings.Text = "НАСТРОЙКИ";
            this.btSettings.UseVisualStyleBackColor = true;
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(835, 7);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(133, 28);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "ВЫХОД";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // plRight
            // 
            this.plRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plRight.Controls.Add(this.dgvData);
            this.plRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plRight.Location = new System.Drawing.Point(992, 6);
            this.plRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plRight.Name = "plRight";
            this.plRight.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plRight.Size = new System.Drawing.Size(345, 602);
            this.plRight.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 2);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.Size = new System.Drawing.Size(337, 596);
            this.dgvData.TabIndex = 0;
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slIP,
            this.slPort,
            this.slPPS,
            this.slConnectionStatus,
            this.slServerStatus,
            this.slServerAnswer,
            this.tsRobotConnectionStatus});
            this.ssMain.Location = new System.Drawing.Point(7, 608);
            this.ssMain.Name = "ssMain";
            this.ssMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMain.Size = new System.Drawing.Size(1330, 30);
            this.ssMain.TabIndex = 3;
            this.ssMain.Text = "statusStrip1";
            // 
            // slIP
            // 
            this.slIP.Name = "slIP";
            this.slIP.Size = new System.Drawing.Size(24, 24);
            this.slIP.Text = "IP:";
            // 
            // slPort
            // 
            this.slPort.Name = "slPort";
            this.slPort.Size = new System.Drawing.Size(38, 24);
            this.slPort.Text = "Port:";
            // 
            // slPPS
            // 
            this.slPPS.Name = "slPPS";
            this.slPPS.Size = new System.Drawing.Size(36, 24);
            this.slPPS.Text = "PPS:";
            // 
            // slConnectionStatus
            // 
            this.slConnectionStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.slConnectionStatus.ForeColor = System.Drawing.Color.Gray;
            this.slConnectionStatus.Name = "slConnectionStatus";
            this.slConnectionStatus.Size = new System.Drawing.Size(143, 24);
            this.slConnectionStatus.Text = "НЕТ СОЕДИНЕНИЯ";
            // 
            // slServerStatus
            // 
            this.slServerStatus.Name = "slServerStatus";
            this.slServerStatus.Size = new System.Drawing.Size(158, 24);
            this.slServerStatus.Text = "СТАТУС СЕРВЕРА: OFF";
            // 
            // slServerAnswer
            // 
            this.slServerAnswer.Name = "slServerAnswer";
            this.slServerAnswer.Size = new System.Drawing.Size(120, 24);
            this.slServerAnswer.Text = "ОТВЕТ СЕРВЕРА:";
            // 
            // tsRobotConnectionStatus
            // 
            this.tsRobotConnectionStatus.Name = "tsRobotConnectionStatus";
            this.tsRobotConnectionStatus.Size = new System.Drawing.Size(198, 24);
            this.tsRobotConnectionStatus.Text = "СОЕДИНЕНИЕ С РОБОТОМ:";
            // 
            // tmCheckCollision
            // 
            this.tmCheckCollision.Interval = 10;
            this.tmCheckCollision.Tick += new System.EventHandler(this.tmCheckCollision_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 644);
            this.Controls.Add(this.plRight);
            this.Controls.Add(this.plLeft);
            this.Controls.Add(this.ssMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа работы с копирующим костюмом";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.plLeft.ResumeLayout(false);
            this.plCostume.ResumeLayout(false);
            this.plCostume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCostumeConnectionStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCostume)).EndInit();
            this.plControl.ResumeLayout(false);
            this.plControl.PerformLayout();
            this.plDown.ResumeLayout(false);
            this.plRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.Panel plRight;
        private System.Windows.Forms.Panel plCostume;
        private System.Windows.Forms.TextBox tbDiagnostic;
        private System.Windows.Forms.Label lbRClavicle;
        private System.Windows.Forms.TextBox tbRClavicle;
        private System.Windows.Forms.Label lbRWristR;
        private System.Windows.Forms.TextBox tbRWristR;
        private System.Windows.Forms.Label lbRWristS;
        private System.Windows.Forms.TextBox tbRWristS;
        private System.Windows.Forms.Label lbRWristF;
        private System.Windows.Forms.TextBox tbRWristF;
        private System.Windows.Forms.Label lbRElbowR;
        private System.Windows.Forms.TextBox tbRElbowR;
        private System.Windows.Forms.Label lbRElbow;
        private System.Windows.Forms.TextBox tbRElbow;
        private System.Windows.Forms.Label lbRShoulderS;
        private System.Windows.Forms.TextBox tbRShoulderS;
        private System.Windows.Forms.Label lbRShoulderF;
        private System.Windows.Forms.TextBox tbRShoulderF;
        private System.Windows.Forms.Label lbLClavicle;
        private System.Windows.Forms.TextBox tbLClavicle;
        private System.Windows.Forms.Label lbLWristR;
        private System.Windows.Forms.TextBox tbLWristR;
        private System.Windows.Forms.Label lbLWristS;
        private System.Windows.Forms.TextBox tbLWristS;
        private System.Windows.Forms.Label lbLWristF;
        private System.Windows.Forms.TextBox tbLWristF;
        private System.Windows.Forms.Label lbLElbowR;
        private System.Windows.Forms.TextBox tbLElbowR;
        private System.Windows.Forms.Label lbLElbow;
        private System.Windows.Forms.TextBox tbLElbow;
        private System.Windows.Forms.Label lbLShoulderS;
        private System.Windows.Forms.TextBox tbLShoulderS;
        private System.Windows.Forms.Label lbLShoulderF;
        private System.Windows.Forms.TextBox tbLShoulderF;
        private System.Windows.Forms.PictureBox pbCostume;
        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Panel plDown;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSettings;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel slIP;
        private System.Windows.Forms.ToolStripStatusLabel slPort;
        private System.Windows.Forms.ToolStripStatusLabel slPPS;
        private System.Windows.Forms.ToolStripStatusLabel slConnectionStatus;
        private System.Windows.Forms.Button btProgramSelector;
        private System.Windows.Forms.Button btPlayControl;
        private System.Windows.Forms.Button btRobotConnection;
        private System.Windows.Forms.Button btRecordControl;
        private System.Windows.Forms.Label lbControl;
        private System.Windows.Forms.Button btCostumeConnection;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.PictureBox pbCostumeConnectionStatus;
        private System.Windows.Forms.Label lbCostume;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.TextBox tbVoltage;
        private System.Windows.Forms.Button btConnectToServer;
        private System.Windows.Forms.ToolStripStatusLabel slServerStatus;
        private System.Windows.Forms.ToolStripStatusLabel slServerAnswer;
        private System.Windows.Forms.Timer tmCheckCollision;
        private System.Windows.Forms.ToolStripStatusLabel tsRobotConnectionStatus;
    }
}

