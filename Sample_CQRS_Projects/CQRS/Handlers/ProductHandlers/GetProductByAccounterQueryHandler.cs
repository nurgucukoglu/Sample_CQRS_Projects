using Microsoft.EntityFrameworkCore;
using Sample_CQRS_Projects.CQRS.Results.ProductResult;
using Sample_CQRS_Projects.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace Sample_CQRS_Projects.CQRS.Handlers.ProductHandlers
{
	public class GetProductByAccounterQueryHandler
	{
		private readonly ProductContext _productContext;

		public GetProductByAccounterQueryHandler(ProductContext productContext)
		{
			_productContext = productContext;
		}

		public List<GetProductByAccounterQueryResult> Handle()
		{
			//sonucun döneceği modelden sadece hangi  veriler listelenecekse  o gelecek
			//x. dan gelen değerler Resultdaki yani modeldeki veriler
			var values = _productContext.Products.Select(x => new GetProductByAccounterQueryResult
			{
				ProductID = x.ProductID,
				Name = x.Name,
				Stock = x.Stock,
				Brand = x.Brand,
				SalePrice = x.SalePrice,
				PurchasePrice = x.PurchasePrice

			}).AsNoTracking().ToList();

			//SaveChanges yoksa, sadece listeleme varsa;			
			//AsNoTracking takip etmeyerek sorgunun performansını arttırır.Takip sadece değişiklik yapılan update gibi işlemlerde gerekir.

			return values;
		}
	}
}
