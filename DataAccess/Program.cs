using System;
using Microsoft.EntityFrameworkCore;
using Project_0;



namespace DataAccess
{
    class Program
    {
        static void Main()
        {
            AccessCustomer access = new AccessCustomer();
            RunApplication.RunApp();
            if (RunApplication.CusExists == false)
            {
                access.AddCusToDataBase();
            }
            else
            {
                do
                {
                    GetCustLookupInfo.CustIDHolder = null;
                    GetCustLookupInfo.GetCustID();
                    Console.WriteLine("Looking for customer");
                    if (GetCustLookupInfo.CustIDHolder != null)
                    {
                        access.LookUpCustFromDB();
                    }
                }
                while (access.ExistingCustomer == null);
            }
        }
    }
}
