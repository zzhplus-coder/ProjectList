using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Demo1
{
    internal static class Tool
    {
        /// <summary>
        /// 获取评分
        /// </summary>
        /// <param name="score">分数</param>
        /// <returns>评分等级</returns>
        public static string GetLevel(decimal score)
        {
            string level = score switch
            {
                >= 97 => "A+",
                >= 93 => "A",
                >= 90 => "A-",
                >= 87 => "B+",
                >= 83 => "B",
                >= 80 => "B-",
                >= 77 => "C+",
                >= 73 => "C",
                >= 70 => "C-",
                >= 67 => "D+",
                >= 63 => "D",
                >= 60 => "D-",
                _ => "F"
            };
            return level;
        }
    }
}