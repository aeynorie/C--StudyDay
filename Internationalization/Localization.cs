using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace Internationalization
{
    
    public static class Localization
    {

        public static void localize(string lang)
        {
            var culture = new CultureInfo("ja-JP");
            
            if (lang == "ja")
            {
                culture = new CultureInfo("ja-JP");
            }
            if (lang == "en")
            {
                culture = new CultureInfo("en-US");
            }

            //コマンドライン引数の場合は以下で取得可能
            // var  cmds = Environment.GetCommandLineArgs();
            //for (int i = 0; i <= cmds.Length; i++)
            //{
                //処理
 
            // }

            Thread.CurrentThread.CurrentUICulture = culture;
        }

        //public static string Message(string key)
        //{
        //    ResourceManager rm = Properties.Resource.ResourceManager;
        //    return rm.GetString(key);
        //}
    }
}
