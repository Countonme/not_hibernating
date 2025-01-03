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
