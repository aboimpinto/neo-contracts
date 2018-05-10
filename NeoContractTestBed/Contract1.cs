using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace NeoContractTestBed
{
    public class Contract1 : SmartContract
    {
        public static void Main()
        {
            Storage.Put(Storage.CurrentContext, "HelloString", "Hello NEO developers");

            Runtime.Log("--> Audit log from the SmartContract");
        }
    }
}
