using Microsoft.Win32;
using Newtonsoft.Json;
using not_hibernating.Model;
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

namespace not_hibernating
{
    public partial class FrmMain : Form
    {
        public RegistryKey key = Registry.CurrentUser.OpenSubKey(ProgramBasic.RunKay, true);
        public string runPath = Application.StartupPath;
        public string ProConfig = "ProConfig.json";
        public const string msg = "The program is already running!, The small icon in the bottom right corner allows you to view the process";

        public object Newtonsoft { get; private set; }

        public FrmMain()
        {
            InitializeComponent();
            this.exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            this.openWindowsToolStripMenuItem.Click += OpenWindowsToolStripMenuItem_Click;
            this.Load += FrmMain_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.checkBoxAutoStartup.Click += CheckBox1_Click;
            this.checkBoxSleepPrevention.Click += CheckBox2_Click;
        }


        private void CheckBox2_Click(object sender, EventArgs e)
        {
            SetSleepPreventionFlag();

        }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            SetAutoStartFlag();
        }

        private void OpenWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 显示窗体并激活它
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Activate();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // MessageBox.Show($"{msg}", "Welcome to the tool", MessageBoxButtons.OK,MessageBoxIcon.Information);
            label1.Text = "Welcome to the tool";
            LoadConfig();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SleepPrevention.RestoreSleep();
            Environment.Exit(Environment.ExitCode);
        }

        /// <summary>
        /// 保存配方
        /// </summary>
        public void SaveConfig()
        {
            try
            {
                var config = new ConfigBasic();
                config.AutoStartFlag = checkBoxAutoStartup.Checked;
                config.EnableFlag = checkBoxSleepPrevention.Checked;
                var jsonString = JsonConvert.SerializeObject(config, Formatting.Indented);
                if (File.Exists($@"{runPath}\{ProConfig}"))
                {
                    File.Delete($@"{runPath}\{ProConfig}");
                }
                File.WriteAllText($@"{runPath}\{ProConfig}", jsonString);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// 加载配置
        /// </summary>

        public void LoadConfig()
        {
            try
            {
                if (File.Exists($@"{runPath}\{ProConfig}"))
                {
                    var ConfigString = File.ReadAllText($@"{runPath}\{ProConfig}");
                    var config = JsonConvert.DeserializeObject<ConfigBasic>(ConfigString);
                    this.checkBoxAutoStartup.Checked = config.AutoStartFlag;
                    this.checkBoxSleepPrevention.Checked = config.EnableFlag;
                    SetSleepPreventionFlag();
                    SetAutoStartFlag();
                }
            }
            catch (Exception)
            {


            }

        }

        /// <summary>
        /// 设定开机自启动
        /// </summary>
        public void SetAutoStartFlag()
        {
            if (checkBoxAutoStartup.Checked)
            {
                label1.Text = "Turn on auto startup ";
                // 检查是否需要添加到开机自启动项
                if (key.GetValue(ProgramBasic.ProgramName) == null)
                {
                    key.SetValue(ProgramBasic.ProgramName, Application.ExecutablePath.ToString());
                    //key.DeleteValue(AppName);
                }
                SaveConfig();
            }
            else
            {
                label1.Text = "Turn off auto startup ";
                if (!(key.GetValue(ProgramBasic.ProgramName) is null))
                {
                    key.DeleteValue(ProgramBasic.ProgramName);
                }
                SaveConfig();
            }
        }

        /// <summary>
        /// 设定休眠
        /// </summary>
        public void SetSleepPreventionFlag()
        {
            if (checkBoxSleepPrevention.Checked)
            {
                label1.Text = "Prevent system from sleeping";
                //设定不休眠
                SleepPrevention.PreventSleep(true);
                SaveConfig();
            }
            else
            {
                SleepPrevention.RestoreSleep();
                label1.Text = "Allow system to sleep...";
                SaveConfig();
            }
        }
    }
}
