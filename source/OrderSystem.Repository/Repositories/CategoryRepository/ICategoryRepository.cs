using OrderSystem.DataAccess.Entities;
namespace OrderSystem.Repository.Repositories.CategoryRepository;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
}