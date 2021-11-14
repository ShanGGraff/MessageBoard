namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    public string AuthorName { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
  }
}