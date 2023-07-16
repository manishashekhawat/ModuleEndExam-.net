using System.ComponentModel.DataAnnotations;

namespace Question_one.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }
        public int Marks { get; set; }
    }

}
