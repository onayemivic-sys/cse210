public class Comment
{
    //private fields to store comments information.
    private string _commenterName;
    private string _commentText;

    //constructor.
    public Comment (string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }
    // Method to return the comment info
    public string GetCommenterName()
    {
        return _commenterName;
    }
    public string GetCommentText()
    {
        return _commentText;
    }
}