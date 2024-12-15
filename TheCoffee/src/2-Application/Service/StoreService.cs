using TheCoffee.src.Domain.Model.Store;
using TheCoffee.src.Infrastructure.Repositories;
using TheCoffee.src.User_Interface.Contracts.Requests;


namespace TheCoffee.src.Application.Service
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _repository;

        public StoreService(IStoreRepository repository) => _repository = repository;

        public  ICollection<Store> GetStores()
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetActiveProperties();
        }
        public Store GetStoreById(int i)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetStore(i);
        }
        public ICollection<Store> GetStoreByFilter(GetStoresQuery f)
        {                       
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.GetFilteredStores(f);
        }

        public Store AddStore(Store property)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.AddStore(property);
        }
        public Store UpdateStore(Store property)
        {
            //aqui posso fazer uma validações antes de chamar, criar e etc..
            return _repository.UpdateStore(property);
        }
       
    }
}
