using System;
using System.Text.Json.Serialization;
namespace FormMarket
{
    public class Product
    {
        [JsonPropertyName("Brand")]
        public string Brand { get; set; }
        [JsonPropertyName("Model")]
        public string Model { get; set; }
        [JsonPropertyName("Submodel")]
        public string Submodel { get; set; }
        [JsonPropertyName("Memory")]
        public int Memory { get; set; }
        [JsonPropertyName("Quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("Price")]
        public int Price { get; set; }

        public Product()
        { }

        public Product(string lines)
        {
            string[] values = lines.Split('\t');
            this.Brand = values[0];
            this.Model = values[1];
            this.Submodel = values[2];
            this.Memory = Convert.ToInt32(values[3]);
            this.Quantity = Convert.ToInt32(values[4]);
            this.Price = Convert.ToInt32(values[5]);

        }
        public Product(string Brand, string Model, string Submodel, int Memory, int Quantity)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Submodel = Submodel;
            this.Memory = Memory;
            this.Quantity = Quantity;
        }

    }
}