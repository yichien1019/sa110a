using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CccTestProject
{
    public class OneMethod
    {
        private int BaseNumber = 2;

        public int Method1()
        {
            return BaseNumber + 5;
        }

        public int Method2()
        {
            return BaseNumber + 8;
        }
    }
}
