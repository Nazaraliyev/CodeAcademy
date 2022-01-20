namespace Simple_API.DTOs
{
    public class QualificationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal FreeScore { get; set; }
        public decimal PaidScore { get; set; }
        public FacultyDTO Faculty { get; set; }
    }
}
