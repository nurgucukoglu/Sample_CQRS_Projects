namespace Sample_CQRS_Projects.CQRS.Results.ProductResult
{
	public class GetProductByAccounterQueryResult
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Brand { get; set; }
		public int Stock { get; set; }
		public decimal PurchasePrice { get; set; }
		public decimal SalePrice { get; set; }
	}
}
