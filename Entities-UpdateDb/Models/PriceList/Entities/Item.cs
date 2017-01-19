using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using PriceList.BaseEntities;
using PriceList.Enums;

namespace PriceList.Models
{
    public class Item : EntityHeader
    {
        public int UnitRecId { get; set; }

        [ForeignKey("UnitRecId")]
        public virtual Unit Unit { get; set; }        

    }
}