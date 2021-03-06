﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApi.Models
{
    public class Message: BaseEntity
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime MessageDate { get; set; }
        public string Content { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeletedForMe { get; set; }
    }
}
