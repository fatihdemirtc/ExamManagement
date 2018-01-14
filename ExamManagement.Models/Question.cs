using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamManagement.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Option> Options { get; set; }
        public byte CorrectAnswer { get; set; }
        public Exam Exam { get; set; }

    }
}
