using System;

public class Video 
{
   public string _title;
   public string _author;
   public float _length;

   public List<Comment> _comments = new List<Comment>();

    public Video()
    {
    }

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetVideoDetails()
    {
        return($"Title : {_title} - Author: {_author} - Length: {_length} mins - Comments: {_comments.Count}.");
    }

    public void GetComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.GetComment();
        }
    }
}