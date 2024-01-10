using BuilderDesignPattern.Assets;

namespace BuilderDesignPattern.Builder
{
    internal class BusinessComputer : IBuilder
    {
        private string brandName;
        private Product product;

        public BusinessComputer(string brand)   
        {
            product = new Product();
            this.brandName = brand;
        }

        public void SetBrand()
        {
            product.Add(string.Format("Business computer brand name :{0}", this.brandName));
        }

        public void AddRam()
        {
            product.Add("32GB RAM");
        }

        public void AddCpu()
        {
            product.Add("Intel Core 2 Duo CPU");
        }

        public void AddGraphicCard()
        {
            product.Add("Embedded GPU");
        }
        
        public void EndOperations()
        {
            product.Add("Business computer is ready to be used.");
        }

        public Product GetComputer()
        {
            return product;
        }

    }
}
