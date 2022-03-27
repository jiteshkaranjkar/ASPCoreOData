using System;

namespace ASPCoreOData.Model
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public double BuyingPrice { get; set; }
        public int Quantity { get; set; }
        public double CurrentPrice { get; set; }
        public double Holdings { get; set; }
    }
}
