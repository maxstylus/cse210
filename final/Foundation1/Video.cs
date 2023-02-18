public class Video
{
    private string _title = "";
    private string _author = "";
    private int _length = 0;  // in seconds

    private List<Comment> _allComments = new List<Comment>();

    public int getNumComments()
    {
        return _allComments.Count;
    }

    public void addToCommentList(Comment comment)
    {
        _allComments.Add(comment);
    }

    public List<Comment> getCommentList()
    {
        return _allComments;
    }

    public string getTitle()
    {
        return _title;
    }

    public void setTitle(string title)
    {
        _title = title;
    }

    public string getAuthor()
    {
        return _author;
    }

    public void setAuthor(string author)
    {
        _author = author;
    }

    public int getLength()
    {
        return _length;
    }

    public void setLength(int length)
    {
        _length = length;
    }


}