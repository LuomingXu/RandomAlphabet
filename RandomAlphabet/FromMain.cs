using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Media;
using System.Runtime.InteropServices;
using LibBgm;

namespace RandomAlphabet
{
    public partial class FromMain : Form
    {
        SoundPlayer wavPlayer = new SoundPlayer(Properties.Resources.TickTock);
        SoundPlayer wavBgm = new SoundPlayer(Properties.Resources.Moby___Extreme_Ways__Jason_Bourne_);

        private string BgmPath = "C:\\Users\\xjy46\\Desktop\\WAV\\StayWithMe.mp3";

        public FromMain()
        {
            InitializeComponent();
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            PlayBgm();
            CmbTimeChoose.SelectedIndex = 4;
            TimeChoose();
            ShowLetter();
        }

        /// <summary>
        /// 重新随机一个声母
        /// </summary>
        private void ShowLetter()
        {
            Random RdNum = new Random();
            int intRdNum = 0;
            intRdNum = RdNum.Next() % 26 + 65;

            if (intRdNum == 73 || intRdNum == 85 || intRdNum == 86)
            {
                ShowLetter();
                return;
            }

            LblAlphabet.Text = Convert.ToString(Convert.ToChar(intRdNum));
        }

        /// <summary>
        /// 将comboBox的值赋到label
        /// </summary>
        private void TimeChoose()
        {
            LblTmr.Text = CmbTimeChoose.SelectedItem.ToString();
        }

        //下面两个函数, 是用来运用滑块来调整音量的函数

        /// <summary>
        /// 设置音量
        /// </summary>
        /// <param name="hwo"></param>
        /// <param name="pdwVolume"></param>
        /// <returns></returns>
        [DllImport("Winmm.dll")]
        private static extern int waveOutSetVolume(int hwo, System.UInt32 pdwVolume);

        /// <summary>
        /// 获取音量
        /// </summary>
        /// <param name="hwo"></param>
        /// <param name="pdwVolume"></param>
        /// <returns></returns>
        [DllImport("Winmm.dll")]
        private static extern uint waveOutGetVolume(int hwo, out System.UInt32 pdwVolume);

        /// <summary>
        /// 用来播放音乐的MCI Command String多媒体设备程序接口
        /// </summary>
        /// <param name="lpstrCommand">需要对此媒体进行什么样的操作的命令string</param>
        /// <param name="lpstrReturnString"></param>
        /// <param name="uReturnLength"></param>
        /// <param name="hWndCallback"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        public static extern uint mciSendString(string lpstrCommand,
                string lpstrReturnString, uint uReturnLength, uint hWndCallback);

        private void BtnNext_Click(object sender, EventArgs e)
        {
            wavPlayer.Stop();

            LblTmr.ForeColor = System.Drawing.Color.LightGreen;

            ShowLetter();

            TimeChoose();

            Tmr.Enabled = true;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            int intTime = Convert.ToInt32(LblTmr.Text);

            if (intTime == 0)
            {
                wavPlayer.Stop();
                LblTmr.Text = "O V E R";
                SystemSounds.Beep.Play();
                Tmr.Enabled = false;
                return;
            }

            if (intTime < 7)
            {
                LblTmr.ForeColor = System.Drawing.Color.Red;
                wavPlayer.PlayLooping();
            }
            else if (intTime == 0)
            {
                wavPlayer.Stop();
            }

            LblTmr.Text = Convert.ToString(intTime - 1);
        }

        private void TbrVoice_ValueChanged(object sender, EventArgs e)
        {
            //先把trackbar的value值映射到0x0000～0xFFFF范围
            //此范围在静音与系统当前最高音量之间
            System.UInt32 Value = (System.UInt32)((double)0xffff * (double)TbrVoice.Value / (double)(TbrVoice.Maximum - TbrVoice.Minimum));

            //限制value的取值范围  
            if (Value < 0) Value = 0;
            if (Value > 0xffff) Value = 0xffff;

            //将但钱value的值赋给左右
            System.UInt32 left = Value;
            System.UInt32 right = Value;

            waveOutSetVolume(0, left << 16 | right); //"<<"左移，“|”逻辑或运算  
        }

        private void PlayBgm()
        {
            Bgm.BgmPath = BgmPath;
            Bgm.Play();
        }

        private void BtnBgmPause_Click(object sender, EventArgs e)
        {
            Bgm.Close();
        }
    }
}
