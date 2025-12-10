using System;

namespace CropsDictonary.Core
{
    public class Crop()
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
