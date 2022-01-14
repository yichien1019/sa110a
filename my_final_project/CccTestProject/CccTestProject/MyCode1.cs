using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CccTestProject
{
    public class MyCode1
    {
        public string Reverse(string input)   //將輸入的字串做反轉的動作
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
