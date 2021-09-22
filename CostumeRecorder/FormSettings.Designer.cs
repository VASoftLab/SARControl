namespace CostumeRecorder
{
    partial class FormSettings
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
            this.plUp = new System.Windows.Forms.Panel();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpCostume = new System.Windows.Forms.TabPage();
            this.cbCheckCollision = new System.Windows.Forms.CheckBox();
            this.tbCollisionK = new System.Windows.Forms.TextBox();
            this.lbCollisionK = new System.Windows.Forms.Label();
            this.cbConverToRadians = new System.Windows.Forms.CheckBox();
            this.lbPathToConfig = new System.Windows.Forms.Label();
            this.tbPathToConfig = new System.Windows.Forms.TextBox();
            this.tbPPS = new System.Windows.Forms.TextBox();
            this.lbPPS = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.tpRobot = new System.Windows.Forms.TabPage();
            this.tpDB = new System.Windows.Forms.TabPage();
            this.tpServer = new System.Windows.Forms.TabPage();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.lbServerPort = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.lbServerIP = new System.Windows.Forms.Label();
            this.plDown = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.tbRobotPort = new System.Windows.Forms.TextBox();
            this.lbRobotPort = new System.Windows.Forms.Label();
            this.tbRobotIP = new System.Windows.Forms.TextBox();
            this.lbRobotIP = new System.Windows.Forms.Label();
            this.plUp.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpCostume.SuspendLayout();
            this.tpRobot.SuspendLayout();
            this.tpServer.SuspendLayout();
            this.plDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // plUp
            // 
            this.plUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plUp.Controls.Add(this.tcSettings);
            this.plUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plUp.Location = new System.Drawing.Point(7, 6);
            this.plUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plUp.Name = "plUp";
            this.plUp.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.plUp.Size = new System.Drawing.Size(498, 266);
            this.plUp.TabIndex = 0;
            // 
            // tcSettings
            // 
            this.tcSettings.Controls.Add(this.tpCostume);
            this.tcSettings.Controls.Add(this.tpRobot);
            this.tcSettings.Controls.Add(this.tpDB);
            this.tcSettings.Controls.Add(this.tpServer);
            this.tcSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSettings.Location = new System.Drawing.Point(13, 12);
            this.tcSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(470, 240);
            this.tcSettings.TabIndex = 0;
            // 
            // tpCostume
            // 
            this.tpCostume.Controls.Add(this.cbCheckCollision);
            this.tpCostume.Controls.Add(this.tbCollisionK);
            this.tpCostume.Controls.Add(this.lbCollisionK);
            this.tpCostume.Controls.Add(this.cbConverToRadians);
            this.tpCostume.Controls.Add(this.lbPathToConfig);
            this.tpCostume.Controls.Add(this.tbPathToConfig);
            this.tpCostume.Controls.Add(this.tbPPS);
            this.tpCostume.Controls.Add(this.lbPPS);
            this.tpCostume.Controls.Add(this.tbPort);
            this.tpCostume.Controls.Add(this.lbPort);
            this.tpCostume.Controls.Add(this.tbIP);
            this.tpCostume.Controls.Add(this.lbIP);
            this.tpCostume.Location = new System.Drawing.Point(4, 25);
            this.tpCostume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpCostume.Name = "tpCostume";
            this.tpCostume.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tpCostume.Size = new System.Drawing.Size(462, 211);
            this.tpCostume.TabIndex = 0;
            this.tpCostume.Text = "Костюм";
            this.tpCostume.UseVisualStyleBackColor = true;
            // 
            // cbCheckCollision
            // 
            this.cbCheckCollision.AutoSize = true;
            this.cbCheckCollision.Location = new System.Drawing.Point(21, 161);
            this.cbCheckCollision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCheckCollision.Name = "cbCheckCollision";
            this.cbCheckCollision.Size = new System.Drawing.Size(123, 21);
            this.cbCheckCollision.TabIndex = 11;
            this.cbCheckCollision.Text = "Check collision";
            this.cbCheckCollision.UseVisualStyleBackColor = true;
            // 
            // tbCollisionK
            // 
            this.tbCollisionK.Location = new System.Drawing.Point(304, 159);
            this.tbCollisionK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCollisionK.Name = "tbCollisionK";
            this.tbCollisionK.Size = new System.Drawing.Size(132, 22);
            this.tbCollisionK.TabIndex = 10;
            // 
            // lbCollisionK
            // 
            this.lbCollisionK.AutoSize = true;
            this.lbCollisionK.Location = new System.Drawing.Point(300, 139);
            this.lbCollisionK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCollisionK.Name = "lbCollisionK";
            this.lbCollisionK.Size = new System.Drawing.Size(73, 17);
            this.lbCollisionK.TabIndex = 9;
            this.lbCollisionK.Text = "Collision K";
            // 
            // cbConverToRadians
            // 
            this.cbConverToRadians.AutoSize = true;
            this.cbConverToRadians.Location = new System.Drawing.Point(21, 139);
            this.cbConverToRadians.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbConverToRadians.Name = "cbConverToRadians";
            this.cbConverToRadians.Size = new System.Drawing.Size(146, 21);
            this.cbConverToRadians.TabIndex = 8;
            this.cbConverToRadians.Text = "Convert to radians";
            this.cbConverToRadians.UseVisualStyleBackColor = true;
            // 
            // lbPathToConfig
            // 
            this.lbPathToConfig.AutoSize = true;
            this.lbPathToConfig.Location = new System.Drawing.Point(17, 70);
            this.lbPathToConfig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPathToConfig.Name = "lbPathToConfig";
            this.lbPathToConfig.Size = new System.Drawing.Size(20, 17);
            this.lbPathToConfig.TabIndex = 7;
            this.lbPathToConfig.Text = "IP";
            // 
            // tbPathToConfig
            // 
            this.tbPathToConfig.Location = new System.Drawing.Point(21, 90);
            this.tbPathToConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPathToConfig.Name = "tbPathToConfig";
            this.tbPathToConfig.Size = new System.Drawing.Size(415, 22);
            this.tbPathToConfig.TabIndex = 6;
            // 
            // tbPPS
            // 
            this.tbPPS.Location = new System.Drawing.Point(304, 32);
            this.tbPPS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPPS.Name = "tbPPS";
            this.tbPPS.Size = new System.Drawing.Size(132, 22);
            this.tbPPS.TabIndex = 5;
            // 
            // lbPPS
            // 
            this.lbPPS.AutoSize = true;
            this.lbPPS.Location = new System.Drawing.Point(300, 12);
            this.lbPPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPPS.Name = "lbPPS";
            this.lbPPS.Size = new System.Drawing.Size(35, 17);
            this.lbPPS.TabIndex = 4;
            this.lbPPS.Text = "PPS";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(163, 32);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(132, 22);
            this.tbPort.TabIndex = 3;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(159, 12);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 17);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(21, 32);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(132, 22);
            this.tbIP.TabIndex = 1;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(17, 12);
            this.lbIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(20, 17);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP";
            // 
            // tpRobot
            // 
            this.tpRobot.Controls.Add(this.tbRobotPort);
            this.tpRobot.Controls.Add(this.lbRobotPort);
            this.tpRobot.Controls.Add(this.tbRobotIP);
            this.tpRobot.Controls.Add(this.lbRobotIP);
            this.tpRobot.Location = new System.Drawing.Point(4, 25);
            this.tpRobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpRobot.Name = "tpRobot";
            this.tpRobot.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tpRobot.Size = new System.Drawing.Size(462, 211);
            this.tpRobot.TabIndex = 1;
            this.tpRobot.Text = "Робот";
            this.tpRobot.UseVisualStyleBackColor = true;
            // 
            // tpDB
            // 
            this.tpDB.Location = new System.Drawing.Point(4, 25);
            this.tpDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpDB.Name = "tpDB";
            this.tpDB.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tpDB.Size = new System.Drawing.Size(461, 210);
            this.tpDB.TabIndex = 2;
            this.tpDB.Text = "База";
            this.tpDB.UseVisualStyleBackColor = true;
            // 
            // tpServer
            // 
            this.tpServer.Controls.Add(this.tbServerPort);
            this.tpServer.Controls.Add(this.lbServerPort);
            this.tpServer.Controls.Add(this.tbServerIP);
            this.tpServer.Controls.Add(this.lbServerIP);
            this.tpServer.Location = new System.Drawing.Point(4, 25);
            this.tpServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpServer.Name = "tpServer";
            this.tpServer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpServer.Size = new System.Drawing.Size(461, 210);
            this.tpServer.TabIndex = 3;
            this.tpServer.Text = "Сервер";
            this.tpServer.UseVisualStyleBackColor = true;
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(163, 32);
            this.tbServerPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(132, 22);
            this.tbServerPort.TabIndex = 7;
            // 
            // lbServerPort
            // 
            this.lbServerPort.AutoSize = true;
            this.lbServerPort.Location = new System.Drawing.Point(159, 12);
            this.lbServerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServerPort.Name = "lbServerPort";
            this.lbServerPort.Size = new System.Drawing.Size(34, 17);
            this.lbServerPort.TabIndex = 6;
            this.lbServerPort.Text = "Port";
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(21, 32);
            this.tbServerIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(132, 22);
            this.tbServerIP.TabIndex = 5;
            // 
            // lbServerIP
            // 
            this.lbServerIP.AutoSize = true;
            this.lbServerIP.Location = new System.Drawing.Point(17, 12);
            this.lbServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServerIP.Name = "lbServerIP";
            this.lbServerIP.Size = new System.Drawing.Size(20, 17);
            this.lbServerIP.TabIndex = 4;
            this.lbServerIP.Text = "IP";
            // 
            // plDown
            // 
            this.plDown.Controls.Add(this.btCancel);
            this.plDown.Controls.Add(this.btOK);
            this.plDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plDown.Location = new System.Drawing.Point(7, 272);
            this.plDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plDown.Name = "plDown";
            this.plDown.Size = new System.Drawing.Size(498, 43);
            this.plDown.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(387, 7);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 28);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "ОТМЕНА";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(279, 7);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 28);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // tbRobotPort
            // 
            this.tbRobotPort.Location = new System.Drawing.Point(163, 32);
            this.tbRobotPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbRobotPort.Name = "tbRobotPort";
            this.tbRobotPort.Size = new System.Drawing.Size(132, 22);
            this.tbRobotPort.TabIndex = 7;
            // 
            // lbRobotPort
            // 
            this.lbRobotPort.AutoSize = true;
            this.lbRobotPort.Location = new System.Drawing.Point(163, 12);
            this.lbRobotPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRobotPort.Name = "lbRobotPort";
            this.lbRobotPort.Size = new System.Drawing.Size(34, 17);
            this.lbRobotPort.TabIndex = 6;
            this.lbRobotPort.Text = "Port";
            // 
            // tbRobotIP
            // 
            this.tbRobotIP.Location = new System.Drawing.Point(21, 32);
            this.tbRobotIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbRobotIP.Name = "tbRobotIP";
            this.tbRobotIP.Size = new System.Drawing.Size(132, 22);
            this.tbRobotIP.TabIndex = 5;
            // 
            // lbRobotIP
            // 
            this.lbRobotIP.AutoSize = true;
            this.lbRobotIP.Location = new System.Drawing.Point(17, 12);
            this.lbRobotIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRobotIP.Name = "lbRobotIP";
            this.lbRobotIP.Size = new System.Drawing.Size(20, 17);
            this.lbRobotIP.TabIndex = 4;
            this.lbRobotIP.Text = "IP";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 321);
            this.Controls.Add(this.plUp);
            this.Controls.Add(this.plDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.plUp.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpCostume.ResumeLayout(false);
            this.tpCostume.PerformLayout();
            this.tpRobot.ResumeLayout(false);
            this.tpRobot.PerformLayout();
            this.tpServer.ResumeLayout(false);
            this.tpServer.PerformLayout();
            this.plDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plUp;
        private System.Windows.Forms.Panel plDown;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpCostume;
        private System.Windows.Forms.TabPage tpRobot;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbPPS;
        private System.Windows.Forms.Label lbPPS;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.TabPage tpDB;
        private System.Windows.Forms.Label lbPathToConfig;
        private System.Windows.Forms.TextBox tbPathToConfig;
        private System.Windows.Forms.TabPage tpServer;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.Label lbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label lbServerIP;
        private System.Windows.Forms.CheckBox cbConverToRadians;
        private System.Windows.Forms.TextBox tbCollisionK;
        private System.Windows.Forms.Label lbCollisionK;
        private System.Windows.Forms.CheckBox cbCheckCollision;
        private System.Windows.Forms.TextBox tbRobotPort;
        private System.Windows.Forms.Label lbRobotPort;
        private System.Windows.Forms.TextBox tbRobotIP;
        private System.Windows.Forms.Label lbRobotIP;
    }
}