using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Group>()
            .HasData(
                new Group { GroupId = 1, Name = "Tech Jobs"},
                new Group { GroupId = 2, Name = "Service Jobs"},
                new Group { GroupId = 3, Name = "Agriculture Jobs"},
                new Group { GroupId = 4, Name = "Food Jobs"},
                new Group { GroupId = 5, Name = "Engineering Jobs"},
                new Group { GroupId = 6, Name = "Social Services Jobs"},
                new Group { GroupId = 7, Name = "Government Jobs"}
                );

            builder.Entity<Message>()
            .HasData(
                new Message {MessageId = 1, GroupId = 2, AuthorName = "James", Description="wow a good job", Year = 2018},
                new Message {MessageId = 2, GroupId = 1, AuthorName = "Shaun", Description="wow a bad job", Year = 2015},
                new Message {MessageId = 3, GroupId = 4, AuthorName = "Tim", Description="wow a job", Year = 2016},
                new Message {MessageId = 4, GroupId = 6, AuthorName = "Shane", Description="wow no job", Year = 2003}

            );
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}