﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTicaretUygulamasi.EntityLayer.Interface;

namespace eTicaretUygulamasi.EntityLayer.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public string? ProductCode { get; set; }
        public int Stock { get; set; }
        public bool IsActive { get; set; }
        public bool IsHome { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int AuthorId { get; set; }
        //public Author? Author { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
