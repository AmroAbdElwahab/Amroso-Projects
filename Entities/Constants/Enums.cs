using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serenity.ComponentModel;

namespace PriceList.Enums
{
    [EnumKey("Transactions.Month")]
    public enum Month
    {
        January = 1,
        February = 2,
        March = 3,
        April = 4,
        May = 5,
        June = 6,
        July = 7,
        August = 8,
        September = 9,
        October = 10,
        November = 11,
        December = 12
    }

    [EnumKey("Transactions.Status")]
    public enum Status
    {
        New = 1,
        Posted = 2
    }
}
