using Models;
using System.Globalization;
namespace Parser
{
    public static class PeopleParser
    {
        public static People Parse(string input)
        {
            string[] tuple = input.Split(":");
            string fio = tuple.ElementAt(0);

            DateOnly birtday;
            DateOnly.TryParseExact(tuple.ElementAt(1), "yyyy_MM_d", out birtday);
            
            
            return new People(birtday, fio);

            
        }
    }
}