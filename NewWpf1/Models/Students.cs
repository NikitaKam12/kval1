using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWpf1.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Otchestvo { get;set; } 
        public List<int> Marks { get; set; }

        public string FormatMarks
        {
            get 
            
            { 
                StringBuilder stringBuilder = new StringBuilder();
                foreach (var item in Marks)
                {

                    stringBuilder.Append($"{item},");
                }
                stringBuilder.Length--;
                 return stringBuilder.ToString();
            }
        }
    }
}
