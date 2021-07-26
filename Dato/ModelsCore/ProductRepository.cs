namespace Dato.ModelsCore
{
    using Entities;
    public class ProductRepository : GenericRepository<ProductosPruebaCore>, IProductRepository
    {
        public ProductRepository(DataContextCore context) : base(context)
        {

        }
    }
}
