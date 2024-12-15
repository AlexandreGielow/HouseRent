using TheCoffee.src.Domain.Model.Property;
using TheCoffee.src.User_Interface.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;
using TheCoffee.src.Domain.Model.Store;

namespace TheCoffee.src.Infrastructure.Repositories
{
    public interface IStoreRepository
    {
        ICollection<Store>  GetActiveProperties();
        ICollection<Store> GetFilteredStores(GetStoresQuery filter);
        Store GetStore(int id);
        Store AddStore([FromBody] Store property);
        Store? UpdateStore([FromBody] Store Property);
    }
}
