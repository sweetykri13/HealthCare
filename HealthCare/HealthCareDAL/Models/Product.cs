using System;
using System.Collections.Generic;

namespace HealthCareDAL.Models
{
    public partial class Product
    {
        public int ProductsId { get; set; }
        public string Name { get; set; } = null!;
        public string SaltComposition { get; set; } = null!;
        public string About { get; set; } = null!;
        public string UseDescription { get; set; } = null!;
        public string SideEffectsDescription { get; set; } = null!;
    }
}
