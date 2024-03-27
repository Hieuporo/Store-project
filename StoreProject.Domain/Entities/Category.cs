﻿using StoreProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Domain.Entities
{
    public class Category : BaseDomainEntity
    {
        public string Name {  get ; set; }
        public string Image {  get; set; }
        public string Description {  get ; set; }
        public ICollection<Product> Products { get; }

    }
}
