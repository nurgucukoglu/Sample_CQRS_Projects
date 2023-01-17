using Sample_CQRS_Projects.CQRS.Queries.ProductQueries;
using Sample_CQRS_Projects.CQRS.Results.ProductResult;
using Sample_CQRS_Projects.DAL.Context;

namespace Sample_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductHumanResourcesByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductHumanResourcesByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductHumanResourceByIDQueryResult Handle(GetProductHumanResourceByIDQuery query) //Bu gelecek değerleri tutan GetProductHumanResourceByIDQueryResult türünde metod olacak ama parametre olarak id'yi içeren query sınıfını alacak
        {
            
            var values = _productContext.Products.Find(query.Id);

            return new GetProductHumanResourceByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Name = values.Name,
                SalePrice = values.SalePrice
            };
        }
    }
}
