using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Domain.Models
{
    public class Ticker
    {
        public bool Success { get; set; }
        public MarketTicker Result { get; set; }
    }
}
