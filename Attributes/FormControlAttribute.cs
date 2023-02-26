using BlazorReflection.Data;

namespace BlazorReflection.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FormControlAttribute : Attribute
    {
        public FormControlAttribute(FormControlType type)
        {
            Type = type;
        }

        public FormControlType Type { get; private set; }
    }
}
