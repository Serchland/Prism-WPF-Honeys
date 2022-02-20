using System;

namespace PrismWPFHoneys.Core.Types.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DependentViewAttribute : Attribute
    {
        public string Region { get; set; }
        public Type Type { get; set; }

        public DependentViewAttribute(String region, Type type)
        {
            if (string.IsNullOrEmpty(region))
                throw new ArgumentNullException(nameof(region));

            if (type == null)
                throw new ArgumentNullException(nameof(type));

            Region = region;
            Type = type;
        }
    }
}
