using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_ApplicationEventLifeCycle
{
    public class DebugUtilityLog
    {
        public static void Log(string message=null,[CallerMemberName] string caller = null)
        {
            Debug.WriteLine(string.Format("Called from {0}{1}",caller??"",string.IsNullOrEmpty(message)?"":" with message "+message));
        }
    }
}
