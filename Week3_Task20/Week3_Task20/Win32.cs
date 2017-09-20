using System;
using System.Runtime.InteropServices;

namespace Week3_Task20
{
     public class Win32
        {
            [DllImport("user32.dll")]
            public static extern void LockWorkStation();
        }
    
}
