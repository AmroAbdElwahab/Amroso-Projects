using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceList.Enums;

namespace PriceList.BaseEntities
{
    public abstract class TransEntityHeader
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }

        [Index(IsUnique = true)]
        [StringLength(20)]
        public string Code { get; set; }

        public DateTime Date { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public Status Status { get; set; }


    }
}
