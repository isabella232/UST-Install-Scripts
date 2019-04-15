using Microsoft.Deployment.WindowsInstaller;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace USTCustomActions
{
    public static class RegistryUtil
    {
        public static void SetLongPathKey()
        {

            RegistryKey pathKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\FileSystem", true);
            pathKey.SetValue("LongPathsEnabled", "1", RegistryValueKind.DWord);
            pathKey.Close();

        }
    }
}



