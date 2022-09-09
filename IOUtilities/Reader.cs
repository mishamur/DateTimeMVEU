namespace IOUtilities
{
    public class Reader
    {
     
        private readonly string filePath;

        public Reader(string filePath)
        {
            this.filePath = filePath;
        }

        public IEnumerable<Models.People> Read()
        {
            if (File.Exists(filePath))
            {
                using(var rf = File.OpenText(filePath))
                {
                    while (!rf.EndOfStream)
                    {
                        string s = rf.ReadLine();
                        if(s != null)
                            yield return Parser.PeopleParser.Parse(s);
                    }
                }
            }

        }
    }
}