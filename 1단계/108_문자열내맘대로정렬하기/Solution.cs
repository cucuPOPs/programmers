using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _108
{

    class Solution
    {
        public string[] solution(string[] strings, int n)
        {
            return strings.OrderBy(s => s[n]).ThenBy(s => s).ToArray();
        }
    }
}