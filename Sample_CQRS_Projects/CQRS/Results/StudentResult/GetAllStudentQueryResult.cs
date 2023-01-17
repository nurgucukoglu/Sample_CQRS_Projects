namespace Sample_CQRS_Projects.CQRS.Results.StudentResult
{
    public class GetAllStudentQueryResult
    {
        //sadece listelenecek veriler
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
    }
}
