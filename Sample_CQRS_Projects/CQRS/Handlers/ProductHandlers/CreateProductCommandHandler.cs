using Sample_CQRS_Projects.CQRS.Commands.ProductCommands;
using Sample_CQRS_Projects.DAL.Context;
using Sample_CQRS_Projects.DAL.Entities;

namespace Sample_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ProductContext _productContext;

        public CreateProductCommandHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void Handle(CreateProductCommand command)
        {
            _productContext.Products.Add(new Product
            {
                //ekleme işleminde veritabanındaki entity'e ekleme yapılacağı
                //için new'e entity adı Product verilecek
                //karşısınada eklenecek değerleri parametreleri tutan 
                //Command sınıfı verilecek
                Brand = command.Brand,
                Cost = command.Cost,
                Stock = command.Stock,
                Tax = command.Tax,
                PurchasePrice = command.PurchasePrice,
                SalePrice = command.SalePrice,
                Name = command.Name,
                Size = command.Size,
                ProduceodDate = command.ProduceOfDate,
                EndofDate = command.EndOfDate,
                Status = true

            });
            _productContext.SaveChanges();


        }
    }
}
