using System;
using System.Collections.Generic;

namespace HealthCareDAL.Models
{
    public partial class QuaterInfo
    {
        public int QuaterInfoId { get; set; }
        public string Quater { get; set; } = null!;
        public decimal Sales { get; set; }
        public decimal OtherIncome { get; set; }
        public decimal GrossProfit { get; set; }
        public decimal Depreciation { get; set; }
        public decimal Interest { get; set; }
        public decimal Tax { get; set; }
        public decimal NetProfit { get; set; }
    }
}
