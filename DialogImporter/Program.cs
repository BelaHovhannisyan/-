using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DialogueSystem
{
    public class Dialogue
    {
        
        public string Chapter { get { return _chapter; } }
        public string Part { get { return _part; } }
        public List<Speech> Speeches { get { return _speeches; } }

        private string _chapter;
        private string _part;
        private List<Speech> _speeches = new List<Speech>();

        public Dialogue(string chapter, string part, List<Speech> speeches)
        {
            _chapter = chapter;
            _part = part;
            _speeches = speeches;
        }
    }
}
