using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internationalization;
using static TestA.TestA;
using static TestB.TestB;

namespace StartPro { 
    class Program
    {
        static void Main(string[] args)
        {
            //言語を引数として与える
            //enの場合はHELLo, jaの時はこんにちは出力される。
            Localization.localize("ja");
            setA();
            setB();

            Localization.localize("en");
            setA();
            setB();
            
        }
    }
}

