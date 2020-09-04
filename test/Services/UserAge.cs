using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Services
{
    public class UserAge
    {
        int Age(DateTime birthDate, DateTime currentDate)
        {
            int YearsDiff = new DateTime(currentDate.Subtract(birthDate).Ticks).Year - 1;

            return YearsDiff;
        }
    }
}
