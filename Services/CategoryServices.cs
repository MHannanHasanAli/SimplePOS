namespace Services
{
    public class CategoryServices
    {
        #region Singleton
        public static CategoryServices Instance
        {
            get
            {
                if (instance == null) instance = new CategoryServices();
                return instance;
            }
        }
        private static CategoryServices instance { get; set; }
        private CategoryServices()
        {
        }
        #endregion

        #region Services
        public List<Category> GetCategorys()
        {
            using (var context = new DataContext())
            {

                return context.Categorys.OrderBy(x => x.Id).ToList();

            }
        }
        public Category GetCategoryById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Categorys.Find(id);
            }
        }
        public void CreateCategory(Category Category)
        {
            using (var context = new DataContext())
            {
                context.Categorys.Add(Category);
                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category Category)
        {
            using (var context = new DataContext())
            {
                context.Categorys.Update(Category);
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (var context = new DataContext())
            {
                var categoryDB = context.Categorys.Find(ID);
                context.Categorys.Remove(categoryDB);
                context.SaveChanges();
            }
        }

        #endregion
    }
}
