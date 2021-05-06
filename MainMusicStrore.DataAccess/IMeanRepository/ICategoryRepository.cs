
using MainMusicStrore.DataAccess.IRepository;
using MainMusicStrore.Models.DbModels;


namespace MainMusicStrore.DataAccess.IMeanRepository
{
    public interface ICategoryRepository :IRepository<Category>
    {

        void update(Category category);
    }
}
