namespace Sample_CQRS_Projects.CQRS.Results.ProductResult
{
    public class GetProductByStoragerQueryResult
    {
        //Depocunun göreceği alanlar 
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Storage { get; set; }
    }
}
