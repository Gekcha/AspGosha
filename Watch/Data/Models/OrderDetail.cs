using System.Collections.Generic;
using System;

namespace Shop.Data.Models
{
    public class OrderDetail
    {

        public int id { get; set; }
        public int orderId { get; set; }
        public int WatchId { get; set; }
        public uint price { get; set; }
        public virtual Watch Watch { get; set; }
        public virtual Order order { get; set; }


    }
}
