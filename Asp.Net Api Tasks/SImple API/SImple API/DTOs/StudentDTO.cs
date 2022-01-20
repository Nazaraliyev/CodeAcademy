using Simple_API.Model;

namespace Simple_API.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Photo { get; set; }
        public ClassDTO Class { get; set; }
        public LevelDTO Level { get; set; }
    }
}
