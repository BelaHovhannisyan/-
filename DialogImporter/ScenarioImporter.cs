using System.Collections;
using System.Collections.Generic;
using System.IO;
using DialogueSystem;


public class ScenarioImporter
{
    public Dialogue LoadFromTxt(string path, string chapterName, string partName)
    {
        StreamReader reader = new StreamReader(path, System.Text.Encoding.UTF8);
        string line;
        string chapter = chapterName;
        string part = partName;
        string name = "";
        List<Speech> speeches = new List<Speech>();
        List<string> type = new List<string>();
        List<string> text = new List<string>();
        while ((line = reader.ReadLine()) != chapterName)
        {
            if (line == null)
            {
                Dialogue ds = new Dialogue(chapter, part, speeches);
                return ds;
            }
        }
        while ((line = reader.ReadLine()) != partName)
        {
            if (line == null)
            {
                Dialogue ds = new Dialogue(chapter, part, speeches);
                return ds;
            }
        }
        line = reader.ReadLine();
        name = "Description";
        type.Add("Description");
        text.Add(line);
        line = reader.ReadLine();
        int i = 0;
        while (true)
        {
            i++;
            if (i > 10000)
            {
                System.Console.WriteLine("DialogueLoadingError");
                break;
            }
            if (line != null)
                if (line[0] == '-')
                {
                    type.Add("Speech");
                    line = line.Substring(1);
                    text.Add(line);
                }
                else if (line[0] == '*')
                {
                    type.Add("Action");
                    text.Add(line);
                }
                else
                {
                    Speech s = new Speech(name, new List<string>(type), new List<string>(text));
                    speeches.Add(s);
                    type.Clear();
                    text.Clear();
                    name = line;
                }
            line = reader.ReadLine();
            if (line == "-------------------------------------------------------------")
            {
                Speech s = new Speech(name, new List<string>(type), new List<string>(text));
                speeches.Add(s);
                break;
            }
        }
        Dialogue d = new Dialogue(chapter, part, speeches);
        reader.Close();
        return d;
    }
}