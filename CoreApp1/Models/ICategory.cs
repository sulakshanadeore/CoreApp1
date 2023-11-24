using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace CoreApp1.Models
{
    public interface ICategoryRepository
    {
        public List<Category> Categories();
        public void Insert(Category category);
        public void Update(int id,Category category);
        public void Delete(int id);
        public Category FindCategory(int id);

    }

    public class CategoryRepository : ICategoryRepository
    {
        static List<Category> categories = new List<Category>() 
        {
            new Category{Catid=1,CatName="beverages",Description="All Beverges" },
            new Category{ Catid=2,CatName="Snacks",Description="All Snacks"},
            new Category{CatName="Lunch",Catid=3,Description="All Lunch Items" }
            };

        public List<Category> Categories()
        {
        return categories;  
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
            Category c1=categories.Find(c => c.Catid == id);
            categories.Remove(c1);

        }

        public Category FindCategory(int id)
        {
            Category c1 = categories.Find(c => c.Catid == id);
            return c1;
        }

        public void Insert(Category category)
        {
            categories.Add(category);
        }

        public void Update(int id, Category category)
        {
            Category c1 = categories.Find(c => c.Catid == id);
            c1.CatName = category.CatName;
            c1.Description = category.Description;
        }
    }
}
