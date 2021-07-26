namespace Dato.ModelsCore
{
    using Entities;
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContextCore context) : base(context)
        {

        }
    }
}
