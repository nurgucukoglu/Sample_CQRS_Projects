using Sample_CQRS_Projects.CQRS.Queries.ProductQueries;
using Sample_CQRS_Projects.CQRS.Results.ProductResult;
using Sample_CQRS_Projects.DAL.Context;

namespace Sample_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductAccounterByIDQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductAccounterByIDQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public GetProductAccounterByIDQueryResult Handle(GetProductAccounterByIDQuery query)
        {
            var values = _productContext.Products.Find(query.Id);
            return new GetProductAccounterByIDQueryResult
            {
                ProductID = values.ProductID,
                Brand = values.Brand,
                Description = values.Description,
                Name = values.Name,
                PurchasePrice = values.PurchasePrice,
                SalePrice = values.SalePrice,
                Stock = values.Stock,
                Tax = values.Tax

            };

        }
    }
}
