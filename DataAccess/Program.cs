using System;
using Microsoft.EntityFrameworkCore;
using Project_0;



namespace DataAccess
{
    class Program
    {
       
        static void Main(string[] args)
        {
            RunApplication run = new RunApplication();
            run.RunApp();
            AccessCustomer access = new AccessCustomer();
            access.AddCusToDataBase();

        }
    }
}
