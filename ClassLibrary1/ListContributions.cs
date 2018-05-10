using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public static class ListContributions
    {
        public static bool CheckListContributions(string method)
        {
            return method == "list";
        }

        public static string ExecuteListContributions(object[] args)
        {
            //var isContractActive = Storage.Get(Storage.CurrentContext, "Active").AsString();
            //if (isContractActive == "1")
            //{
            //    Runtime.Log("--> Contract is active. It is possible to retrieve the contribution. <--");

            var report = (byte[])args[0];

            var recordedContributions = Storage.Get(Storage.CurrentContext, report).AsString();
            Runtime.Log(recordedContributions);

            return recordedContributions;
            //}
            //else
            //{
            //    Runtime.Log("--> Contract is not active. It is not possible send contribution <--");
            //}
        }
    }
}
