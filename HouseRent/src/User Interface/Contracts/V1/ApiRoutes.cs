namespace HouseRent.src.User_Interface.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = $"{Root}/{Version}";
            
        public static class PropertiesRoutes
        {
            public const string GetProperties = $"{Base}/Properties";
            public const string GetFilteredProperties = $"{Base}/FilteredProperties";
            public const string PostPropertioes = $"{Base}/Properties";
            public const string PutPropertioes = $"{Base}/Properties";
        }

        public static class PersonRoutes
        {
            public const string GetPerson = $"{Base}/Person";
            public const string PostPerson = $"{Base}/Person";
            public const string PutPerson = $"{Base}/Person";
            public const string RegisterPerson = $"{Base}/Person/Register";
            public const string AuthPerson = $"{Base}/Person/Authenticate";


        }
    }
}
