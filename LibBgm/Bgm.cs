using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibBgm
{
    public class Bgm
    {
        /// <summary>
        /// 用来播放音乐的MCI Command String多媒体设备程序接口
        /// </summary>
        /// <param name="lpstrCommand">需要对此媒体进行什么样的操作的命令string</param>
        /// <param name="lpstrReturnString"></param>
        /// <param name="uReturnLength"></param>
        /// <param name="hWndCallback"></param>
        /// <returns></returns>
        [DllImport("winmm.dll")]
        private static extern uint mciSendString(string lpstrCommand,
                string lpstrReturnString, uint uReturnLength, uint hWndCallback);

        /// <summary>
        /// 音乐文件的绝对地址
        /// </summary>
        public static string BgmPath { set; get; }

        //打开path这个路径的歌曲", type mpegvideo是文件类型,
        //alias是将文件别名为media

        /// <summary>
        /// 从音乐文件的绝对地址打开音乐文件, 此方法需要提前给BgmPath赋值, 否则无法打开
        /// </summary>
        public static void Open()
        {
            mciSendString("open \"" + BgmPath + "\" type mpegvideo alias media", null, 0, 0);
        }

        /// <summary>
        /// 从音乐文件的绝对地址打开音乐文件
        /// </summary>
        /// <param name="Path">音乐文件的地址</param>
        public static void Open(string Path)
        {
            mciSendString("open \"" + Path + "\" type mpegvideo alias media", null, 0, 0);
        }

        /// <summary>
        /// 播放音乐
        /// </summary>
        public static void Play()
        {
            Open();
            mciSendString("play media notify", null, 0, 0);
        }

        /// <summary>
        /// 关闭音乐播放
        /// </summary>
        public static void Close()
        {
            mciSendString("close media", null, 0, 0);
        }

        /// <summary>
        /// 暂停音乐播放, 如果已经暂停了, 就开始播放
        /// </summary>
        public static void Pause()
        {
            mciSendString("pause media", null, 0, 0);
        }
    }
}
