using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceList.BaseEntities
{
    class EntityLineNum
    {
        [Key, Column(Order = 1)]
        public int ParentRecId { get; set; }

        [Key, Column(Order = 2)]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int ChiledRecId { get; set; }
    }
}
