using Neo.SmartContract.Framework;

namespace SumSmartContract
{
    public class Contract : SmartContract
    {
        public static int Main(int a, int b)
        {
            var c = a + b;
            return c;
        }
    }
}
