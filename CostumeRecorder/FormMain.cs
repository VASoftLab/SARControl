using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CostumeRecorder.Core;
using CostumeRecorder.Enums;
using CostumeRecorder.Extensions;
using System.Net;
using System.Net.Sockets;

using RoboKinematics;

namespace CostumeRecorder
{
    public partial class FormMain : Form
    {
        #region Глобальные переменные "кушки"
        double QLShoulderF;
        double QLShoulderS;
        double QLElbowR;
        double QLElbow;
        double QLWristR;
        double QLWristF;
        double QLWristS;

        double QRShoulderF;
        double QRShoulderS;
        double QRElbowR;
        double QRElbow;
        double QRWristR;
        double QRWristF;
        double QRWristS;

        Robot robot;
        #endregion

        #region Переменные для работы с симулятором
        private bool isConnected = false;
        private TcpClient tcpClient = null;
        private NetworkStream networkStream = null;
        private StreamReader streamReader = null;
        private bool isReset = false;
        #endregion

        private bool _collision = false;

        Dictionary<string, string> JointHints; // Словарь подсказок для joints
        AppSettings appSet; // Настройки приложения
        ConnectionStatus costumeConnection = ConnectionStatus.Disconnected;

        Costume _Costume;

        bool _IsServerConnected = false;

        TcpClient client;
        Byte[] data;
        string message;
        NetworkStream stream;

        public FormMain()
        {
            InitializeComponent();

            appSet = new AppSettings();
            _Costume = new Costume();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            #region Инициализация объекта Робот
            var leftArmWorldFrame = new double[,] { { 0, 0, 1, 0.23 }, { 0, 1, 0, 0 }, { -1, 0, 0, 0 }, { 0, 0, 0, 1 } };
            var rightArmWorldFrame = new double[,] { { 0, 0, 1, -0.23 }, { 0, 1, 0, 0 }, { -1, 0, 0, 0 }, { 0, 0, 0, 1 } };

            var leftArm = new SerialLink(leftArmWorldFrame);
            var rightArm = new SerialLink(rightArmWorldFrame);

            leftArm.AddJoint(0, 0.0, 1.5708, 0, -1.5740, 0.002, "L.ShoulderF");
            leftArm.AddJoint(0, 0, 1.5708, -1.5708, -0.001, 1.4, "L.ShoulderS");
            leftArm.AddJoint(0, -0.30, 1.5708, -1.5708, -0.7, 0.7, "L.ElbowR");
            leftArm.AddJoint(0, 0, 1.5708, 3.14, -1.90, 0.01, "L.Elbow");
            leftArm.AddJoint(0, -0.30, 1.5708, 3.14, -1.4, 1.4, "L.WristR");
            leftArm.AddJoint(-0.24, 0, 0, 1.5708, -0.17, 0.17, "L.WristF");

            rightArm.AddJoint(0, -0.0, 1.5708, 0, -1.5740, 0.002, "R.ShoulderF");
            rightArm.AddJoint(0, 0, 1.5708, -1.5708, -1.4, 0.001, "R.ShoulderS");
            rightArm.AddJoint(0, -0.30, 1.5708, -1.5708, -0.7, 0.7, "R.ElbowR");
            rightArm.AddJoint(0, 0, 1.5708, 3.14, -1.90, 0.001, "R.Elbow");
            rightArm.AddJoint(0, -0.30, 1.5708, 3.14, -1.4, 1.4, "R.WristR");
            rightArm.AddJoint(-0.24, 0, 0, 1.5708, -0.17, 0.17, "R.WristF");


            robot = new Robot(leftArm, rightArm, "127.0.0.1", 10099);
            #endregion
            #region Инициализация словарей
            JointHintsInitialization();
            #endregion

            // Инициализация GUI
            GUIInitialization();

            // Загрузка настроек приложения
            appSet.Load();

            // Загрузка конфига костюма
            if (File.Exists(appSet.PathToCostumeConfig))
                _Costume.Initialize(appSet.PathToCostumeConfig);

            if (_Costume.Initialized)
            {
                _Costume.DataChanged += _Costume_DataChanged;
                //LabelCostumeIP.Content = $"IP: {_Costume.Address}";
                //LabelCostumeStatus.Content = "Состояние: Готов";

                //DataGridJoints.ItemsSource = Costume.Joints;
                //AppLog.Write($"Настройки костюма загружены.");
            }
            else
            {
                //AppLog.Write($"Не удалось загрузить настройки костюма. Проверьте файл настроек.");
            }

            // Визуализация настроек на главной форме
            AppSettingsToGUI();
        }

        private void _Costume_DataChanged()
        {
            if (costumeConnection == ConnectionStatus.Disconnected)
                return;

            tbVoltage.Invoke((MethodInvoker)delegate
            {
                tbVoltage.Text = String.Format("{0:0.00}", _Costume.Voltage.Value);
            });

            tbLShoulderF.Invoke((MethodInvoker)delegate
            {
                QLShoulderF = _Costume.Joints.Where(j => j.Name == "L.ShoulderF").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLShoulderF = Utils.DegreesToRadians(QLShoulderF);
                tbLShoulderF.Text = String.Format("{0:0.00}", QLShoulderF);
            });

            tbLShoulderS.Invoke((MethodInvoker)delegate
            {
                QLShoulderS = _Costume.Joints.Where(j => j.Name == "L.ShoulderS").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLShoulderS = Utils.DegreesToRadians(QLShoulderS);
                tbLShoulderS.Text = String.Format("{0:0.00}", QLShoulderS);
            });

            tbLElbowR.Invoke((MethodInvoker)delegate
            {
                QLElbowR = _Costume.Joints.Where(j => j.Name == "L.ElbowR").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLElbowR = Utils.DegreesToRadians(QLElbowR);
                tbLElbowR.Text = String.Format("{0:0.00}", QLElbowR);
            });

            tbLElbow.Invoke((MethodInvoker)delegate
            {
                QLElbow = _Costume.Joints.Where(j => j.Name == "L.Elbow").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLElbow = Utils.DegreesToRadians(QLElbow);
                tbLElbow.Text = String.Format("{0:0.00}", QLElbow);
            });

            tbLWristR.Invoke((MethodInvoker)delegate
            {
                QLWristR = _Costume.Joints.Where(j => j.Name == "L.WristR").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLWristR = Utils.DegreesToRadians(QLWristR);
                tbLWristR.Text = String.Format("{0:0.00}", QLWristR);
            });

            tbLWristF.Invoke((MethodInvoker)delegate
            {
                QLWristF = _Costume.Joints.Where(j => j.Name == "L.WristF").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLWristF = Utils.DegreesToRadians(QLWristF);
                tbLWristF.Text = String.Format("{0:0.00}", QLWristF);
            });

            tbLWristS.Invoke((MethodInvoker)delegate
            {
                QLWristS = _Costume.Joints.Where(j => j.Name == "L.WristS").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QLWristS = Utils.DegreesToRadians(QLWristS);

                tbLWristS.Text = String.Format("{0:0.00}", _Costume.Joints.Where(j => j.Name == "L.WristS").FirstOrDefault().Value);
            });            

            //tbLClavicle.Invoke((MethodInvoker)delegate {
            //    tbLClavicle.Text = _Costume.Joints.Where(j => j.Name == "L.Clavicle").FirstOrDefault().Value.ToString();
            //});

            tbRShoulderF.Invoke((MethodInvoker)delegate
            {
                QRShoulderF = _Costume.Joints.Where(j => j.Name == "R.ShoulderF").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRShoulderF = Utils.DegreesToRadians(QRShoulderF);
                tbRShoulderF.Text = String.Format("{0:0.00}", QRShoulderF);
            });

            tbRShoulderS.Invoke((MethodInvoker)delegate
            {
                QRShoulderS = _Costume.Joints.Where(j => j.Name == "R.ShoulderS").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRShoulderS = Utils.DegreesToRadians(QRShoulderS);
                tbRShoulderS.Text = String.Format("{0:0.00}", QRShoulderS);
            });

            tbRElbow.Invoke((MethodInvoker)delegate
            {
                QRElbow = _Costume.Joints.Where(j => j.Name == "R.Elbow").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRElbow = Utils.DegreesToRadians(QRElbow);
                tbRElbow.Text = String.Format("{0:0.00}", QRElbow);
            });

            tbRElbowR.Invoke((MethodInvoker)delegate
            {
                QRElbowR = _Costume.Joints.Where(j => j.Name == "R.ElbowR").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRElbowR = Utils.DegreesToRadians(QRElbowR);
                tbRElbowR.Text = String.Format("{0:0.00}", QRElbowR);
            });

            tbRWristR.Invoke((MethodInvoker)delegate
            {
                QRWristR = _Costume.Joints.Where(j => j.Name == "R.WristR").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRWristR = Utils.DegreesToRadians(QRWristR);
                tbRWristR.Text = String.Format("{0:0.00}", _Costume.Joints.Where(j => j.Name == "R.WristR").FirstOrDefault().Value);
            });

            tbRWristF.Invoke((MethodInvoker)delegate
            {
                QRWristF = _Costume.Joints.Where(j => j.Name == "R.WristF").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRWristF = Utils.DegreesToRadians(QRWristF);
                tbRWristF.Text = String.Format("{0:0.00}", QRWristF);
            });

            tbRWristS.Invoke((MethodInvoker)delegate
            {
                QRWristS = _Costume.Joints.Where(j => j.Name == "R.WristS").FirstOrDefault().Value;
                if (appSet.ConverToRadians)
                    QRWristS = Utils.DegreesToRadians(QRWristS);

                tbRWristS.Text = String.Format("{0:0.00}", QRWristS);
            });            

            //tbRClavicle.Invoke((MethodInvoker)delegate {
            //    tbRClavicle.Text = _Costume.Joints.Where(j => j.Name == "R.Clavicle").FirstOrDefault().Value.ToString();
            //});
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть приложение?", "Подтверждение закрытия программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void AppSettingsToGUI()
        {
            if (appSet != null)
            {
                slIP.Text = $"IP: {appSet.IP}";
                slPort.Text = $"Port: {appSet.Port}";
                slPPS.Text = $"PPS: {appSet.PPS}";
            }
        }

        public void JointHintsInitialization()
        {
            JointHints = new Dictionary<string, string>
            {
                { "L.ShoulderF", "Движение левого плечевого сустава вперед" },
                { "R.ShoulderF", "Движение правого плечевого сустава вперед" },
                { "L.ShoulderS", "Движение левого плечевого сустава в сторону" },
                { "R.ShoulderS", "Движение правого плечевого сустава в сторону" },
                { "L.Elbow", "Сгиб левого локтя" },
                { "R.Elbow", "Сгиб правого локтя" },
                { "L.ElbowR", "Вращение левого локтя" },
                { "R.ElbowR", "Вращение правого локтя" },
                { "L.WristF", "Движение левой кисти вперед" },
                { "R.WristF", "Движение правой кисти вперед" },
                { "L.WristS", "Движение левой кисти в сторону" },
                { "R.WristS", "Движение правой кисти в сторону" },
                { "L.WristR", "Вращение левой кисти в сторону" },
                { "R.WristR", "Вращение правой кисти в сторону" },
                { "L.Clavicle", "Движение левой ключицы" },
                { "R.Clavicle", "Движение правой ключицы" }
            };
        }

        public void GUIInitialization()
        {
            #region Узлы левой стороны
            lbLShoulderF.MouseHover += On_MouseHover;
            lbLShoulderF.MouseLeave += On_MouseLeave;
            tbLShoulderF.MouseHover += On_MouseHover;
            tbLShoulderF.MouseLeave += On_MouseLeave;

            lbLShoulderS.MouseHover += On_MouseHover;
            lbLShoulderS.MouseLeave += On_MouseLeave;
            tbLShoulderS.MouseHover += On_MouseHover;
            tbLShoulderS.MouseLeave += On_MouseLeave;

            lbLElbow.MouseHover += On_MouseHover;
            lbLElbow.MouseLeave += On_MouseLeave;
            tbLElbow.MouseHover += On_MouseHover;
            tbLElbow.MouseLeave += On_MouseLeave;

            lbLElbowR.MouseHover += On_MouseHover;
            lbLElbowR.MouseLeave += On_MouseLeave;
            tbLElbowR.MouseHover += On_MouseHover;
            tbLElbowR.MouseLeave += On_MouseLeave;

            lbLWristF.MouseHover += On_MouseHover;
            lbLWristF.MouseLeave += On_MouseLeave;
            tbLWristF.MouseHover += On_MouseHover;
            tbLWristF.MouseLeave += On_MouseLeave;

            lbLWristS.MouseHover += On_MouseHover;
            lbLWristS.MouseLeave += On_MouseLeave;
            tbLWristS.MouseHover += On_MouseHover;
            tbLWristS.MouseLeave += On_MouseLeave;

            lbLWristR.MouseHover += On_MouseHover;
            lbLWristR.MouseLeave += On_MouseLeave;
            tbLWristR.MouseHover += On_MouseHover;
            tbLWristR.MouseLeave += On_MouseLeave;

            lbLClavicle.MouseHover += On_MouseHover;
            lbLClavicle.MouseLeave += On_MouseLeave;
            tbLClavicle.MouseHover += On_MouseHover;
            tbLClavicle.MouseLeave += On_MouseLeave;
            #endregion

            #region Узлы правой стороны
            lbRShoulderF.MouseHover += On_MouseHover;
            lbRShoulderF.MouseLeave += On_MouseLeave;
            tbRShoulderF.MouseHover += On_MouseHover;
            tbRShoulderF.MouseLeave += On_MouseLeave;

            lbRShoulderS.MouseHover += On_MouseHover;
            lbRShoulderS.MouseLeave += On_MouseLeave;
            tbRShoulderS.MouseHover += On_MouseHover;
            tbRShoulderS.MouseLeave += On_MouseLeave;

            lbRElbow.MouseHover += On_MouseHover;
            lbRElbow.MouseLeave += On_MouseLeave;
            tbRElbow.MouseHover += On_MouseHover;
            tbRElbow.MouseLeave += On_MouseLeave;

            lbRElbowR.MouseHover += On_MouseHover;
            lbRElbowR.MouseLeave += On_MouseLeave;
            tbRElbowR.MouseHover += On_MouseHover;
            tbRElbowR.MouseLeave += On_MouseLeave;

            lbRWristF.MouseHover += On_MouseHover;
            lbRWristF.MouseLeave += On_MouseLeave;
            tbRWristF.MouseHover += On_MouseHover;
            tbRWristF.MouseLeave += On_MouseLeave;

            lbRWristS.MouseHover += On_MouseHover;
            lbRWristS.MouseLeave += On_MouseLeave;
            tbRWristS.MouseHover += On_MouseHover;
            tbRWristS.MouseLeave += On_MouseLeave;

            lbRWristR.MouseHover += On_MouseHover;
            lbRWristR.MouseLeave += On_MouseLeave;
            tbRWristR.MouseHover += On_MouseHover;
            tbRWristR.MouseLeave += On_MouseLeave;

            lbRClavicle.MouseHover += On_MouseHover;
            lbRClavicle.MouseLeave += On_MouseLeave;
            tbRClavicle.MouseHover += On_MouseHover;
            tbRClavicle.MouseLeave += On_MouseLeave;
            #endregion
        }

        #region Отображение подсказок для компонентов
        private void On_MouseLeave(object sender, EventArgs e)
        {
            //tbDiagnostic.Text = string.Empty;
        }

        private void On_MouseHover(object sender, EventArgs e)
        {
            //if ((sender as Control).Tag != null)
            //{
            //    string tagValue = (sender as Control).Tag.ToString();
            //    if (JointHints.ContainsKey(tagValue))
            //        tbDiagnostic.Text = JointHints[tagValue];
            //    else
            //        tbDiagnostic.Text = string.Empty;
            //}
        }
        #endregion

        public void GUIUpdateCostumeConnection(ConnectionStatus costumeConnection)
        {
            switch (costumeConnection)
            {
                case ConnectionStatus.Connected:
                    slConnectionStatus.Text = "СОЕДИНЕНИЕ С КОСТЮМОМ УСТАНОВЛЕНО";
                    btCostumeConnection.Text = "РАЗРЫВ СОЕДИНЕНИЯ";
                    pbCostumeConnectionStatus.Image = Properties.Resources.circle_green;
                    slConnectionStatus.ForeColor = Color.Green;
                    break;
                case ConnectionStatus.Disconnected:
                    slConnectionStatus.Text = "СОЕДИНЕНИЕ С КОСТЮМОМ ОТСУТСВУЕТ";
                    btCostumeConnection.Text = "СОЕДИНЕНИЕ С КОСТЮМОМ";
                    pbCostumeConnectionStatus.Image = Properties.Resources.circle_grey;
                    slConnectionStatus.ForeColor = Color.Gray;
                    break;
            }
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            FormSettings frmSettings = new FormSettings(appSet);
            if (frmSettings.ShowDialog() == DialogResult.OK)
            {
                appSet.IP = frmSettings.IP;
                appSet.Port = frmSettings.Port;
                appSet.PPS = frmSettings.PPS;

                appSet.ServerIP = frmSettings.ServerIP;
                appSet.ServerPort = frmSettings.ServerPort;

                appSet.ConverToRadians = frmSettings.ConverToRadians;
                appSet.CollisionK = frmSettings.CollisionK;
                appSet.CheckCollision = frmSettings.CheckCollision;

                appSet.RobotIP = frmSettings.RobotIP;
                appSet.RobotPort = frmSettings.RobotPort;

                AppSettingsToGUI();
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // При выходе сохраняем настройки
            if (appSet != null)
                appSet.Save();
            // Разрыв соединения
            _Costume.DisposeA(true);
        }

        private void btCostumeConnection_Click(object sender, EventArgs e)
        {
            if (costumeConnection == ConnectionStatus.Disconnected)
            {
                _Costume.Connect();
                // Устанавливаем соединение
                costumeConnection = ConnectionStatus.Connected;
                if (!tmCheckCollision.Enabled)
                    tmCheckCollision.Start();

                tbDiagnostic.Text = String.Empty;
                tbDiagnostic.ForeColor = System.Drawing.Color.Red;

                robot.Connect();
            }
            else if (costumeConnection == ConnectionStatus.Connected)
            {
                // Разрываем соединение
                costumeConnection = ConnectionStatus.Disconnected;
                if (tmCheckCollision.Enabled)
                    tmCheckCollision.Stop();

                tbDiagnostic.Text = "Диагностическая информация";
                tbDiagnostic.ForeColor = System.Drawing.Color.AliceBlue;

                robot.Disconnect();
            }

            // Обновляем GUI
            GUIUpdateCostumeConnection(costumeConnection);
        }

        private void btRecordControl_Click(object sender, EventArgs e)
        {

        }

        private void btTest_Click(object sender, EventArgs e)
        {
            // var Voltage = _Costume.Voltage.Value;
            // tbVoltage.Text = Voltage.ToString();

            //_Costume.Joints.Value;

            message = $"R;-0.5;0;0;0;0;0";
            data = System.Text.Encoding.ASCII.GetBytes(message + Environment.NewLine);

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            if (client != null)
            {
                #region ЗАПИСЬ ДАННЫХ
                if (client.Connected)
                {
                    stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    #endregion

                    #region ОТВЕТ СЕРВЕРА                    
                    data = new Byte[256];
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    //stream.Close();
                    #endregion
                }
                else
                    MessageBox.Show("Сервер не подключен!");
            }
            else
                MessageBox.Show("Объект подключения к серверу не создан!");

            slServerAnswer.Text = $"ОТВЕТ СЕРВЕРА: {responseData.ToUpper()}";
        }

        private void btReset_Click(object sender, EventArgs e)
        {

        }

        private void btConnectToServer_Click(object sender, EventArgs e)
        {
            if ((client != null) && !client.Connected/*_IsServerConnected*/)
            {
                btConnectToServer.Text = "ПОДКЛЮЧИТЬСЯ К СЕРВЕРУ";
                _IsServerConnected = false;
                slServerStatus.Text = "СТАТУС СЕРВЕРА: OFF";
                if (client != null)
                {
                    client.Close();
                    client.Dispose();
                }
            }
            else
            {
                // Создаем подключение к серверу
                try
                {
                    client = new TcpClient(appSet.ServerIP, appSet.ServerPort);

                    //if (!client.Connected)
                    //    client.Connect(appSettings.ServerIP, appSettings.ServerPort);

                    if (client.Connected)
                    {
                        btConnectToServer.Text = "ОТКЛЮЧИТЬСЯ ОТ СЕРВЕРА";
                        _IsServerConnected = true;
                        slServerStatus.Text = "СТАТУС СЕРВЕРА: ON";
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void tmCheckCollision_Tick(object sender, EventArgs e)
        {
            if (appSet.CheckCollision)
            {
                double[] qCurrentL = new double[6];
                qCurrentL[0] = QLShoulderF;
                qCurrentL[1] = QLShoulderS;
                qCurrentL[2] = QLElbowR;
                qCurrentL[3] = QLElbow;
                qCurrentL[4] = QLWristR;
                qCurrentL[5] = QLWristF;

                double[] qCurrentR = new double[6];
                qCurrentR[0] = QRShoulderF;
                qCurrentR[1] = QRShoulderS;
                qCurrentR[2] = QRElbowR;
                qCurrentR[3] = QRElbow;
                qCurrentR[4] = QRWristR;
                qCurrentR[5] = QRWristF;                

                var positionLCurent = robot.LeftArm.FK(qCurrentL);
                var positionRCurent = robot.RightArm.FK(qCurrentR);

                bool collision = Collision(positionLCurent, positionRCurent);
                if (!collision)
                {
                    // Передача сигналов на робота
                    robot.LeftArm.SetJointAngles(qCurrentL);

                    robot.RightArm.SetJointAngles(qCurrentR);
                }                

            }
        }

        private bool Collision(ArmPosition positionL, ArmPosition positionR)
        {
            var points = positionL.X.Zip(positionL.Y, (x, y) => new PointF((float)x, (float)y)).ToArray();
            bool collision = Collide.ArmToArm(positionL, positionR, appSet.CollisionK, out double[] _, out double[] _);

            if (_collision != collision)
            {
                _collision = collision;
                
                if (tbDiagnostic.InvokeRequired)
                {
                    if (collision)
                        tbDiagnostic.BeginInvoke(new Action(() => {
                            tbDiagnostic.BackColor = Color.Red;
                            tbDiagnostic.ForeColor = Color.White;
                            tbDiagnostic.Text = "Угроза столкновения!";
                        }));
                    else
                        tbDiagnostic.BeginInvoke(new Action(() => {
                            tbDiagnostic.BackColor = Color.White;
                            tbDiagnostic.ForeColor = Color.Red;
                            tbDiagnostic.Text = String.Empty;
                        }));
                }
                else
                {
                    if (collision)
                        tbDiagnostic.Text = "Угроза столкновения!";
                    else
                        tbDiagnostic.Text = String.Empty;
                }
            }            

            return collision;
        }

        private void btRobotConnection_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            String IP = appSet.RobotIP;
            Int32 Port = appSet.RobotPort;

            btRobotConnection.Enabled = false;

            try
            {
                if (!isConnected)
                {
                    // CONNECT
                    tcpClient = new TcpClient();
                    tcpClient.Connect(IPAddress.Parse(IP), (short)Port);
                    tcpClient.Client.DontFragment = true;
                    tcpClient.NoDelay = true;
                    tcpClient.Client.NoDelay = true;
                    tcpClient.ReceiveTimeout = 5000;

                    if (tcpClient.Connected)
                    {
                        networkStream = tcpClient.GetStream();
                        streamReader = new StreamReader((Stream)networkStream);
                        isConnected = true;
                    }
                    else
                    {
                        isConnected = false;
                        if (networkStream != null)
                            networkStream.Dispose();
                        if (streamReader != null)
                            streamReader.Dispose();
                    }
                }
                else
                {
                    // DISCONNECT
                    // TODO:
                    // 1. Разобраться какой из методов нужно использовать для закрытия соединения
                    // 2. Разобраться почему рвется соединение
                    // 3. Разобраться как передавать время выполения программы

                    // tcpClient.GetStream().Close();
                    // tcpClient.Client.Disconnect(true);

                    tcpClient.Client.Disconnect(true);
                    tcpClient.Close();

                    if (networkStream != null)
                        networkStream.Dispose();
                    if (streamReader != null)
                        streamReader.Dispose();
                }

                if ((tcpClient.Client != null) && (tcpClient.Connected))
                    isConnected = true;
                else
                    isConnected = false;

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                isConnected = false;
            }

            btRobotConnection.Enabled = true;
            btRobotConnection.Focus();

            Cursor.Current = Cursors.Default;

            if (isConnected)
            {
                tsRobotConnectionStatus.Text = "SAR-400 Connected";
                tsRobotConnectionStatus.ForeColor = Color.Green;
                btRobotConnection.Text = "РАЗОРВАТЬ СОЕДИНЕНИЕ";
            }
            else
            {
                tsRobotConnectionStatus.Text = "SAR-400 Disconnected";
                tsRobotConnectionStatus.ForeColor = Color.Red;
                btRobotConnection.Text = "СОЕДИНЕНИЕ С РОБОТОМ";
            }
        }
    }
}
