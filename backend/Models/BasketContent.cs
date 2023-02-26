using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BasketContent
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BasketContentId { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }  
        public DateTime DateAdded { get; set; }
    }
}
