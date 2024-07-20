
public class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLength = length;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to return the number of comments
    public int ReturnNumberComments()
    {
        return _comments.Count;
    }

    // Method to display the information about the video and the comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Video Title: {_videoTitle}");
        Console.WriteLine($"Video Uploader: {_videoAuthor}");
        Console.WriteLine($"Video Duration: {_videoLength} min");
        Console.WriteLine($"Number of Comments: {_comments.Count}\n");

        if (_comments.Count > 0)
        {
            Console.WriteLine("Comments:");
            foreach (var comment in _comments)
            {
                Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine("No Comments Yet");
        }
    }
}
