using WebApplication1.DTOS;



namespace WebApplication1.Repositories
{
    public interface IProductRepository
    {
        public Task<Product?> GetById(int id);
        public Task<List<Product>> GetAll();
        public Task<Product> Create(Product product);
        public Task<Product?> UpdateById(int ID ,Product product);
        public Task<bool?> DeleteById(int id);
    }
}
