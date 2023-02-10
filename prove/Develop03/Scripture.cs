using System;

class Scripture
{
    private string _scriptureText;

    private Reference _scriptureReference;

    public Scripture (Reference scriptureReference, string scripturetext)
    {
        _scriptureReference = scriptureReference;
        _scriptureText      = scripturetext;
    }
    
    public string toString()
    {
        Console.WriteLine($"_scriptureText: {_scriptureText}");
        return string.Format("{0}", _scriptureText);
    }
}