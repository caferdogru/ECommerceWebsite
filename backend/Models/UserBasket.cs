﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserBasket
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserBasketId { get; set; }
        public int User { get; set; }
    }
}
