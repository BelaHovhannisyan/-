using System;
using System.Collections.Generic;

public class Speech
{
    public string Name { get { return _name; } }
    public List<string> Type { get { return _type; } }
    public List<string> Text { get { return _text; } }

    private string _name;
    private List<string> _type = new List<string>();
    private List<string> _text = new List<string>();

    public Speech(string name, List<string> type, List<string> text)
    {
        _name = name;
        _type = type;
        _text = text;
    }
}