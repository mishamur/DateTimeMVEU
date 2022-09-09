namespace Models
{
    public class People
    {
        private readonly DateOnly birthday;
        private readonly string fio;

        public People(DateOnly birthday, string fio)
        {
            this.birthday = birthday;
            this.fio = fio;
        }

        public string GetFio()
        {
            return this.fio;
        }

        public DateOnly GetBirthday()
        {
            return this.birthday;
        }
    }
}