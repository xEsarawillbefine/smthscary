using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class OceanChoose
    {
        public void ChooseOfOcean(OceanEnum oceanEnum)
        {
            switch (oceanEnum)
            {
                case OceanEnum.thePacificOcean:
                    Console.WriteLine($"Your choice is : {OceanEnum.thePacificOcean}");
                    break;
                case OceanEnum.theAtlanticOcean:
                    Console.WriteLine($"Your choice is : {OceanEnum.theAtlanticOcean}");
                    break;
                case OceanEnum.theIndianOcean:
                    Console.WriteLine($"Your choice is : {OceanEnum.theIndianOcean}");
                    break;
                case OceanEnum.theSouthernOcean:
                    Console.WriteLine($"Your choice is : {OceanEnum.theSouthernOcean}");
                    break;
                case OceanEnum.theArcticOcean:
                    Console.WriteLine($"Your choice is : {OceanEnum.theArcticOcean}");
                    break;
            }
        }
    }
}
