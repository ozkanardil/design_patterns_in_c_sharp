using BuilderDesignPattern.Assets;

namespace BuilderDesignPattern.Builder
{
    internal class GamingComputer : IBuilder
    {
        private string brandName;
        private Product product;

        public GamingComputer(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void SetBrand()
        {
            product.Add(string.Format("Gaming computer brand name :{0}", this.brandName));
        }

        public void AddRam()
        {
            product.Add("128GB RAM");
        }

        public void AddCpu()
        {
            product.Add("Intel Core 8 CPU");
        }

        public void AddGraphicCard()
        {
            product.Add("External GPU");
        }

        public void EndOperations()
        {
            product.Add("Caming computer is ready to be used.");
        }

        public Product GetComputer()
        {
            return product;
        }

    }
}
