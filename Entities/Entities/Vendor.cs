using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceList.BaseEntities;
using PriceList.Enums;

namespace PriceList.Models
{
    public class Vendor : EntityHeader
    {
        public string Address { get; set; }
    }
}