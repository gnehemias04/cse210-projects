using System;


class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }

    public int HowManyComments()
    {
        int count;
        count = _comment.Count();
        return count;
    }

    public string GetValues()
    {
        string allValues;
        string coments = "";
        int count = HowManyComments();


        foreach (Comment comment in _comment)
        {
            coments = coments + "\n" + comment.GetValues();
        }

        allValues = $"Title: {_title}\nAuthor: {_author}\nLength in seconds: {_length.ToString()}\nNumber of Comments: {count}\nComments:{coments}";


        return allValues;
    }

}
