﻿namespace cval_exam_sakharov
{
    public class College
    {
        public string NameColl { get; set; }
        public string Address { get; set; }
        public List<Teachers> teachers = new List<Teachers>();

        public College(string nm, string add)
        {
            NameColl = nm;
            Address = add;
        }

        public void ShowAll()
        {
            Console.WriteLine($"Колледж:{NameColl}\n" + $"Адрес: {Address}\nПреподаватели:");
            teachers.Sort();
            foreach (Teachers teachers in teachers)
            {
                teachers.Show();
            }
        }
    }

    public class Teachers: IComparable<Teachers>
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public Teachers(string nm, string cur)
        {
            Name = nm;
            Course = cur;
        }
        public void Show()
        {
            Console.WriteLine($"\tФИО: {Name}\n" + $"\tДисциплина: {Course}");
        }

        public int CompareTo(Teachers? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}