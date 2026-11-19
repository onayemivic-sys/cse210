using System; 
using System.Collections.Generic;

public class Video
{
    // private fields.
    private string _title;
    private string _author;
    private int _length;
    private List <Comment> _comments;

    // constructor.
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    // method to add comment to video.
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    // to count the comments.
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    // to get video info.
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public int GetLength()
    {
        return _length;
    }
    //return list of comments.
    public List<Comment> GetComments()
    {
        return _comments;
    }
}