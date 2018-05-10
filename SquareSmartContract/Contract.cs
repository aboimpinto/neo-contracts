using Neo.SmartContract.Framework;

namespace SquareSmartContract
{
    public class Contract : SmartContract
    {
        public static int Main(int num)
        {
            var result = num * num;
            return result;
        }
    }
}
