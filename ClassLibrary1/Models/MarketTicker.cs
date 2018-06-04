using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class MarketTicker
    {
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Last { get; set; }
    }
}
