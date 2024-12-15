namespace TheCoffee.src.User_Interface.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = $"{Root}/{Version}";
            
        public static class StoreRoutes
        {
            public const string GetStores = $"{Base}/Stores";
            public const string GetFilteredStores = $"{Base}/FilteredStores";
            public const string PostStore = $"{Base}/Stores";
            public const string PutStore = $"{Base}/Stores";
        }

        public static class PersonRoutes
        {
            public const string GetPerson = $"{Base}/Person";
            public const string PostPerson = $"{Base}/Person";
            public const string PutPerson = $"{Base}/Person";
            public const string RegisterPerson = $"{Base}/Person/Register";
            public const string AuthPerson = $"{Base}/Person/Authenticate";
        }
        public static class OrderRoutes
        {
            //Orders
            public const string GetOrders = $"{Base}/Orders";
            public const string GetAllOrders = $"{Base}/AllOrders";
            public const string GetFilteredOrders = $"{Base}/FilteredOrders";
            public const string PostOrder = $"{Base}/Order";
            public const string PutOrder = $"{Base}/Order";
            //Items
            public const string GetOrdersItems = $"{Base}/OrdersItems";
            public const string GetFilteredOrdersItems = $"{Base}/FilteredOrdersItems";
            public const string PostOrderItems = $"{Base}/OrderItem";
            public const string PutOrderItems = $"{Base}/OrderItem";
        }

        public static class ProductRoutes
        {
            public const string GetProducts = $"{Base}/Products";
            public const string GetProductsAndCharacteristics = $"{Base}/ProductsAndCharacteristics";
            public const string GetFilteredProducts = $"{Base}/FilteredProducts";
            public const string GetProductsCharacteristics = $"{Base}/ProductsCharacteristics";
            public const string PostProduct = $"{Base}/Product";
            public const string PutProduct = $"{Base}/Product";
        }
    }
}
