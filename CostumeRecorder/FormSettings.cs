using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CostumeRecorder.Extensions;

namespace CostumeRecorder
{
    public partial class FormSettings : Form
    {
        AppSettings appSet;
        public FormSettings(AppSettings appSettings)
        {
            InitializeComponent();
            
            this.appSet = appSettings;
        }

        public string IP { get { return appSet.IP; } }
        public int Port { get { return appSet.Port; } }
        public int PPS { get { return appSet.PPS; } }

        public string ServerIP { get { return appSet.ServerIP; } }
        public int ServerPort { get { return appSet.ServerPort; } }

        public bool ConverToRadians { get { return appSet.ConverToRadians; } }
        public double CollisionK { get { return appSet.CollisionK; } }
        public bool CheckCollision { get { return appSet.CheckCollision; } }

        public string RobotIP { get { return appSet.RobotIP; } }
        public int RobotPort { get { return appSet.RobotPort; } }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Актуализируем настройки
            appSet.IP = tbIP.Text;
            int.TryParse(tbPort.Text, out int Port);
            appSet.Port = Port;
            int.TryParse(tbPPS.Text, out int PPS);
            appSet.PPS = PPS;

            appSet.ServerIP = tbServerIP.Text;
            int.TryParse(tbServerPort.Text, out int ServerPort);
            appSet.ServerPort = ServerPort;

            appSet.PathToCostumeConfig = tbPathToConfig.Text;

            appSet.ConverToRadians = cbConverToRadians.Checked;
            Double.TryParse(tbCollisionK.Text, out double K);
            appSet.CollisionK = K;

            appSet.CheckCollision = cbCheckCollision.Checked;

            appSet.RobotIP = tbRobotIP.Text;
            int.TryParse(tbRobotPort.Text, out int RobotPort);
            appSet.RobotPort = RobotPort;

            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            GUIInitialization();
        }

        public void GUIInitialization()
        {
            // Перенос настроек на форму
            if (appSet != null)
            {
                tbIP.Text = appSet.IP;
                tbPort.Text = appSet.Port.ToString();
                tbPPS.Text = appSet.PPS.ToString();

                tbServerIP.Text = appSet.ServerIP.ToString();
                tbServerPort.Text = appSet.ServerPort.ToString();

                tbPathToConfig.Text = appSet.PathToCostumeConfig;
                cbConverToRadians.Checked = appSet.ConverToRadians;
                tbCollisionK.Text = appSet.CollisionK.ToString();
                cbCheckCollision.Checked = appSet.CheckCollision;

                tbRobotIP.Text = appSet.RobotIP.ToString();
                tbRobotPort.Text = appSet.RobotPort.ToString();            }
        }
    }
}
