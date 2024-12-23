using System;
namespace FormMarket
{
	public class Product
	{
		public string Brand;
		public string Model;
		public string Submodel;
		public int Memory;
		public int Quantity;

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