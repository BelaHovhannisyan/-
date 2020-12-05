using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DialogueSystem
{
    public class Dialogue
    {
        private string _chapter;
        private string _part;
        private List<Speech> _speeches = new List<Speech>();

        public Dialogue(string chapter, string part, List<Speech> speeches)
        {
            _chapter = chapter;
            _part = part;
            _speeches = speeches;
        }

        public void WriteContent()
        {
            System.Console.WriteLine(_chapter);
            System.Console.WriteLine(_part);
            foreach(Speech s in _speeches)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
