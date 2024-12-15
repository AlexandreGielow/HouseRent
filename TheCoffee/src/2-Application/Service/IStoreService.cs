using TheCoffee.src.Domain.Model.Store;
using TheCoffee.src.User_Interface.Contracts.Requests;

namespace TheCoffee.src.Application.Service
{
    public interface IStoreService
    {
        public ICollection<Store> GetStores();
        public Store GetStoreById(int id);
        public ICollection<Store> GetStoreByFilter(GetStoresQuery filter);
        public Store AddStore(Store property);
        public Store UpdateStore(Store property);
    }
}
