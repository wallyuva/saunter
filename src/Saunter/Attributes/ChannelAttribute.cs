using System;

namespace Saunter.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ChannelAttribute : Attribute
    {
        public string Name { get; }

        public string Description { get; set; }
        
        public string Parameters { get; set; }

        public ChannelAttribute(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}