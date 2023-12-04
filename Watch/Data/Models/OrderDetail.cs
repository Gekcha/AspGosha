using System.Collections.Generic;
using System;

namespace Shop.Data.Models
{
    public class OrderDetail
    {

        public int id { get; set; }
        public int orderId { get; set; }
        public int CarId { get; set; }
        public uint price { get; set; }
        public virtual Car Car { get; set; }
        public virtual Order order { get; set; }


    }
}
