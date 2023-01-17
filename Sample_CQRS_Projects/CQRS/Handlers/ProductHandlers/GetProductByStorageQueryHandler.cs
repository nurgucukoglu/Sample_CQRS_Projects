using Microsoft.EntityFrameworkCore;
using Sample_CQRS_Projects.CQRS.Results.ProductResult;
using Sample_CQRS_Projects.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace Sample_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
    public class GetProductByStorageQueryHandler
    {
        private readonly ProductContext _productContext;

        public GetProductByStorageQueryHandler(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public List<GetProductByStoragerQueryResult> Handle()
        {
            var values = _productContext.Products.Select(x => new
            GetProductByStoragerQueryResult
            {
                ProductID = x.ProductID,
                Name = x.Name,
                Storage = x.Storage

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
