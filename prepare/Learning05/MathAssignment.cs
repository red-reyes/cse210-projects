using System;

namespace Learning05
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection = "";
        private string _problems = "";

        //constructors
        public MathAssignment() : base()
        {
        }
        public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = topic;
        }

        public string GetTextbookSection()
        {
            return _textbookSection;
        }
        public void SetTextbookSection(string textbookSection)
        {
            _textbookSection = textbookSection;
        }
        
        public string GetProblems()
        {
            return _problems;
        }
        public void SetProblems(string problems)
        {
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"{_textbookSection}, {_problems}";
        }
    }
}