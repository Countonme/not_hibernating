using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace not_hibernating
{
    public class SleepPrevention
    {
        [DllImport("kernel32.dll")]
        private static extern uint SetThreadExecutionState(uint esFlags);




        // ES_CONTINUOUS (0x80000000)：
        // 表示设置的状态是连续有效的。线程的状态不会在调用一次后自动恢复。
        // ES_SYSTEM_REQUIRED (0x00000001)：
        // 防止系统进入睡眠状态。
        // ES_DISPLAY_REQUIRED (0x00000002)：
        // 防止显示器关闭（保持显示器常亮）。
        private const uint ES_CONTINUOUS = 0x80000000;
        private const uint ES_SYSTEM_REQUIRED = 0x00000001;
        private const uint ES_DISPLAY_REQUIRED = 0x00000002;

        // 阻止系统休眠
        public static void PreventSleep(bool keepDisplayOn = true)
        {
            uint flags = ES_CONTINUOUS | ES_SYSTEM_REQUIRED;
            if (keepDisplayOn)
            {
                flags |= ES_DISPLAY_REQUIRED;
            }
            SetThreadExecutionState(flags);
        }

        // 恢复系统休眠
        public static void RestoreSleep()
        {
            SetThreadExecutionState(ES_CONTINUOUS);
        }
    }
}
