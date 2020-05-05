using System;
using Microsoft.EntityFrameworkCore;
using Project_0;



namespace DataAccess
{
    class Program
    {
        static void Main()
        {
            AccessCustomer accessCus = new AccessCustomer();
            InventoryAccess invAcc = new InventoryAccess();
            RunApplication.RunApp();
            #region Check whether to add customer to database or to lookup existing
            if (RunApplication.CusExists == false)
            {
                accessCus.AddCusToDataBase();
            }
            else if (RunApplication.CusExists ==true )
            {
                do
                {
                    GetCustLookupInfo.GetCustID();
                    Console.WriteLine("Looking for customer");
                    if (GetCustLookupInfo.CustIDHolder != null)
                    {
                        accessCus.LookUpCustFromDB();
                    }    
                }while (accessCus.ExistingCustomer == null);
            }
            #endregion
        }
    }
}
