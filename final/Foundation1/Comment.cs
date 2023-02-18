public class Comment
{
    private string _personName = "";
    private string _comment = "";

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;
    }

    public string getPersonName()
    {
        return _personName;
    }

    public void setPersonName(string personName)
    {
        _personName = personName;
    }

    public string getComment()
    {
        return _comment;
    }

    public void setComment(string comment)
    {
        _comment = comment;
    }

}