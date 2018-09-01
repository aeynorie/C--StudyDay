using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;



namespace Internationalization
{
    class Program
    {
        static void Main(string[] args)
        {
            //言語を引数として与える
            Localization.localize("en");
            //enの場合はHELLo, jaの時はこんにちは出力される。
        }
    }
}
