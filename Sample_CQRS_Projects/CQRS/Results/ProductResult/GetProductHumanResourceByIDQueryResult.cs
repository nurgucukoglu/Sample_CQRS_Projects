namespace Sample_CQRS_Projects.CQRS.Results.ProductResult
{
    public class GetProductHumanResourceByIDQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal SalePrice { get; set; }
    }
}
