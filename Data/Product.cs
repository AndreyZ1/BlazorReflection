using BlazorReflection.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorReflection.Data
{
    public class Product
    {
        [DisplayName("Product name")]
        [FormControl(FormControlType.Text)]
        public required string Name { get; init; }

        [DisplayName("Product description")]
        [FormControl(FormControlType.Textarea)]
        public required string Description { get; init; }

        [DisplayName("Product type")]
        public required ProductType Type { get; set; }

        [DisplayName("Product price")]
        [Range(0,10)]
        public required decimal Price { get; set; }

        [DisplayName("Is Product available")]
        public bool IsAvailable { get; set; }

        [DisplayName("Has subscription")]
        public bool? HasSubscription { get; set; }
    }
}
