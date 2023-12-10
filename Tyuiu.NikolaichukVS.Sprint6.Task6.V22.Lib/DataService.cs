using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NikolaichukVS.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string str, string path)
        {
            string res = "";
            string[] strPath = File.ReadAllLines(path);
            for (int i = 0; i < strPath.Length; i++)
            {
                string[] firstStr = strPath[i].Split(' ');
                if (firstStr.Length > 2)
                {
                    res += firstStr[firstStr.Length - 2];
                }
            }
            return res;
        }
    }
}
