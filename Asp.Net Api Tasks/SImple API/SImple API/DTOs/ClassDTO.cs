namespace Simple_API.DTOs
{
    public class ClassDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public QualificationDTO Qualification { get; set; }
        public DegreDTO Degre { get; set; }
    }
}
