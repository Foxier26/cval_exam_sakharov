using cval_exam_sakharov;
class Program
{
    static void Main(string[] args)
    {
        College college = new College("Первый Московский Образовательный Комплекс", "Староватутинский проезд, д. 6");

        college.teachers.Add(new Teachers("Журавлев Данила Никитич", "Тестирование Информационных Систем"));
        college.teachers.Add(new Teachers("Тузовский Анатолий Федорович", "Информационные системы и программирование"));
        college.teachers.Add(new Teachers("Сыроватко Георгий Андреевич", "Компьютерные сети"));
        college.ShowAll();
        Console.ReadKey();
    }
}