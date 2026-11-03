using E_Commerce.Domain.Entities.Common;

namespace E_Commerce.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string PictureUrl { get; set; } = default!;

        public decimal Price { get; set; }

    }
}
