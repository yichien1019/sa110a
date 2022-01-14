using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CccTestProject
{
    public static class TwoMethod
    {
        public static int Now { get; set; }

        public static int Get()
        {
            return Now;
        }
    }
}
