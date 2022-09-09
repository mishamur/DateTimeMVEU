using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOUtilities
{
    public class Writer
    {
        private readonly string filePath;

        public Writer(string filePath)
        {
            this.filePath = filePath;
        }

        public void Write(IEnumerable<Models.People> peoples)
        {
            
            using (var wf = File.CreateText(filePath))
            {
                foreach(var people in peoples)
                {
                    wf.WriteLine(people.GetFio() + people.GetBirthday());
                }
            }
            
        }
    }
}
