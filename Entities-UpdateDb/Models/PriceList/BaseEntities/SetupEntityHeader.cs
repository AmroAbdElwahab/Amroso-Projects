using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceList.BaseEntities
{
    public abstract class SetupEntityHeader
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int RecId { get; set; }

        [Index]
        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Image { get; set; }
    }
}
