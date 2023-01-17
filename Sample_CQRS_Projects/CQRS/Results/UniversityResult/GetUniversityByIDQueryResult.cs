namespace Sample_CQRS_Projects.CQRS.Results.UniversityResult
{
    public class GetUniversityByIDQueryResult
    {
        //üniversite ile ilgili
        //sadece şu bilgiler olsun
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Population { get; set; }
    }
}
