using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CccTestProject
{
    public class MyCode1
    {
        public string Reverse(string input)   //�N��J���r�갵���઺�ʧ@
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
