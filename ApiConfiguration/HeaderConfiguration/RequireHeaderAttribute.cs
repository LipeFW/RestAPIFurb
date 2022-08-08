namespace RestAPIFurb.ApiConfiguration.HeaderConfiguration
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class RequireHeaderAttribute : Attribute
    {
        public string HeaderName { get; }
        public string Description { get; }
        public string DefaultValue { get; }
        public bool IsRequired { get; }

        public RequireHeaderAttribute(
            string headerName,
            string description = null,
            string defaultValue = null,
            bool isRequired = true)
        {
            HeaderName = headerName;
            Description = description;
            DefaultValue = defaultValue;
            IsRequired = isRequired;
        }

        public static class NameConstants
        {
            public const string Auth = nameof(Auth);
        }
    }
}
