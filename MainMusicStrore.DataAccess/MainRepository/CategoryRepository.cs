using MainMusicStore.Data;
using MainMusicStrore.DataAccess.IMeanRepository;
using MainMusicStrore.Models.DbModels;
using System.Linq;

namespace MainMusicStrore.DataAccess.MainRepository
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) 
            :base(db)
        {
            _db = db;
        }

        public void update(Category category)
        {
            var data = _db.Categories.FirstOrDefault(x => x.id == category.id);
            if (data != null)
            {
                data.CategoryName = category.CategoryName;
            }
            _db.SaveChanges();
        }
    }
}
