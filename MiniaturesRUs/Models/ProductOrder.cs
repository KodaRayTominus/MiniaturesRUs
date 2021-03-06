﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MiniaturesRUs.Models
{
    public class ProductOrder
    {
        [Key]
        [ForeignKey("Order")]
        [Column(Order = 1)]
        public int OrderId { get; set; }


        [Key]
        [ForeignKey("Miniature")]
        [Column(Order = 2)]
        public int ProductId { get; set; }

        public Order Order { get; set; }

        public Miniature Miniature { get; set; }

        public ProductOrder()
        {
        }

        public ProductOrder(int orderId, int productId)
        {
            OrderId = orderId;
            ProductId = productId;
        }
    }
}