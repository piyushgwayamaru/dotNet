using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_activity
{
    internal class Palindrome
    {
        public bool checkPalindrome(string inputString)
        {
            var len = inputString.Length;
            var checkPalString = "";
            for (var i = len - 1; i >= 0; i--)
            {
                checkPalString += inputString[i];
            }
            if (checkPalString == inputString) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
