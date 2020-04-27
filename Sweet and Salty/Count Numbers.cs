using System;
using System.Collections.Generic;
using System.Text;

namespace Sweet_and_Salty
{
    #region References
    // For Loop Reference
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/for
    // Is divisable reference
    // https://www.sanfoundry.com/csharp-program-divisible/
    #endregion
    class CountNumbers
    {
        #region BooleanDeclarations
        // declare booleans to be accessed by print results check
        private int howManyareBoth = 0;
        public int HowManyAreBoth { get => howManyareBoth;}
        private int curCount = 1;
        public int CurCount { get => curCount; }
        // Declare a Method that runs a For loop through each number 
        #endregion
        internal void IncreaseNumCount()
        {
            for (int countNum = 0; countNum <= 100; countNum++)
            {
                curCount = countNum;
                // check each whate each variable is devisable by and set the bools accoringly
                if (countNum % 3 == 0 || countNum % 5 == 0)
                {
                    if (countNum % 5 == 0 && countNum % 3 == 0)
                    {
                        howManyareBoth++;
                        Console.WriteLine("Sweet n Salty");
                    }
                    else if (countNum % 5 == 0)
                    {
                        Console.WriteLine("Salty");
                    }
                    else Console.WriteLine("Sweet");
                }
                else Console.WriteLine(curCount);
            }

            if (curCount == 100)
            {
                Console.WriteLine("the amount of  results that are both" + howManyareBoth);
            }
        }
    }
}
