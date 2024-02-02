namespace Services
{
    public class ProductServices
    {
        #region Singleton
        public static ProductServices Instance
        {
            get
            {
                if (instance == null) instance = new ProductServices();
                return instance;
            }
        }
        private static ProductServices instance { get; set; }
        private ProductServices()
        {
        }
        #endregion

        #region Services
        public List<Product> GetProducts()
        {
            using (var context = new DataContext())
            {

                return context.Products.OrderBy(x => x.Id).ToList();

            }
        }
        public Product GetProductById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Products.Find(id);
            }
        }
        public void CreateProduct(Product Product)
        {
            using (var context = new DataContext())
            {
                context.Products.Add(Product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product Product)
        {
            using (var context = new DataContext())
            {
                context.Products.Update(Product);
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (var context = new DataContext())
            {
                var productDB = context.Products.Find(ID);
                context.Products.Remove(productDB);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
