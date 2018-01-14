using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<PersonsExam> personExam { get; set; }

    }
}
