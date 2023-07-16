using Question_one.Models;
using System.Collections.Generic;
using System.Linq;


namespace Question_one.Data_Access
{
        public class StudentRepository
        {
            private List<Student> _students = new List<Student>();

            public List<Student> GetAllStudents()
            {
                return _students;
            }

            public Student GetStudentById(int id)
            {
                return _students.FirstOrDefault(s => s.Id == id);
            }

            public void AddStudent(Student student)
            {
                student.Id = _students.Count + 1;
                _students.Add(student);
            }

            public void UpdateStudent(Student student)
            {
                var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
                if (existingStudent != null)
                {
                    existingStudent.RollNo = student.RollNo;
                    existingStudent.Name = student.Name;
                    existingStudent.Stream = student.Stream;
                    existingStudent.Marks = student.Marks;
                }
            }

            public void DeleteStudent(int id)
            {
                var student = _students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    _students.Remove(student);
                }
            }
        }
    }

