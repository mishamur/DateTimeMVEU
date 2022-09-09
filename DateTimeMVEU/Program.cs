using IOUtilities;

namespace DateTimeMVEU
{

    /*
     * чтение с файла
     * ФИО : Д/Р
     * год_месяц_день
     * orderby в порядке убывания
     * вывод в файл - фио, день.месяц.год 
     * ФИО(пробел)00.00.0000
     */
    public static class Program
    {
        public static void Main(string[] args)
        {
            Reader reader = new Reader("./input.txt");
            List<Models.People> peoples = reader.Read().ToList();
            Writer writer = new Writer("./output.txt");
            writer.Write(peoples.OrderByDescending(x => x.GetBirthday()));

            /*
            foreach(Models.People people in peoples.OrderByDescending(x => x.GetBirthday()))
            {

                Console.WriteLine(people.GetFio() + people.GetBirthday());
            }
            */
        }
    }
}