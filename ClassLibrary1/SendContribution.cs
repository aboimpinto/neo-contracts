using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;

namespace ClassLibrary1
{
    public static class SendContribution
    {
        public static bool CheckSendContribution(string method)
        {
            return method == "send";
        }

        public static string ExecuteSendContribution(object[] args)
        {
            //var isContractActive = Storage.Get(Storage.CurrentContext, "Active").AsString();
            //if (isContractActive == "1")
            //{
            //    Runtime.Log("--> Contract is active. It is possible to send contribution. <--");

            var report = (byte[])args[0];
            var destinationAddress = (byte[])args[1];
            var proofOfWork = (byte[])args[2];

            var destinationAddressString = destinationAddress.AsString();
            var proofOfWorkString = proofOfWork.AsString();

            var contribution = string.Concat(destinationAddressString, ",");
            contribution = string.Concat(contribution, proofOfWork);

            var recordedContributions = Storage.Get(Storage.CurrentContext, report).AsString();
            if (recordedContributions.Length != 0)
            {
                string contributionsWithSeparator = string.Concat(recordedContributions, "|");
                contribution = string.Concat(contributionsWithSeparator, contribution);
            }

            Storage.Put(Storage.CurrentContext, report, contribution);
            return "--> Contribution set successful <--";
            //}
            //else
            //{
            //    Runtime.Log("--> Contract is not active. It is not possible send contribution <--");
            //}
        }
    }
}
