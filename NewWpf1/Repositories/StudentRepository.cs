using NewWpf1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWpf1.Repositories
{
    public class StudentRepository
    {
        private readonly string _filepath;
        public StudentRepository(string filepath)
        {
            _filepath = filepath;
        }

        public List<Students> GetStudents()
        {
            List<Students> result = new List<Students>();

            string[] students = File.ReadAllLines(_filepath);
            foreach (string s in students)
            {
                var currentstudent = s.Split('.');
                Students student = new Students();

                student.Id = int.Parse(currentstudent[0]);
                student.Name = currentstudent[1];
                student.Surname = currentstudent[2];
                student.Otchestvo = currentstudent[3];
                student.Marks = new List<int>();
                var marks = currentstudent[4].Split(',');
                foreach (var mark in marks)
                {
                    student.Marks.Add(int.Parse(mark));
                }
                result.Add(student);
            }
                return result;
        }

        public void AddStudent(Students student)
        {
            string studentline = $"{student.Id}.{student.Name}.{student.Surname}.{student.Otchestvo}.{student.FormatMarks}";
            using (StreamWriter stringWriter = new StreamWriter(_filepath, true))
            {
                stringWriter.WriteLine(studentline);
            }
        }
    }

}

