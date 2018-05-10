using Neo.SmartContract.Framework;

namespace MultiplySmartContract
{
    public class Contract : SmartContract
    {
        public static int Main(int a, int b)
        {
            var c = a * b;
            return c;
        }
    }
}
