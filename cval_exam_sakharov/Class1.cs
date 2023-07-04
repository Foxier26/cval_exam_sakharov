namespace cval_exam_sakharov
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
            Console.WriteLine($"Колледж:{NameColl}\n" + $"Адрес: {Address}");
            teachers.Sort();
            foreach (Teachers teachers in )
            {
                teachers.Show();
            }
        }
    }

    public class Teachers
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
            Console.WriteLine("Преподаватели:\n" + $"\tПреподаватель: {Name}\n" + $"\tДисциплина: {Course}");
        }
    }
}