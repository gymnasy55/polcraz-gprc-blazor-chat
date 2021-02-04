using Microsoft.EntityFrameworkCore;

namespace Polcraz.gRPC_Chat.Database
{
    public class ChatDbContext : DbContext
    {
        public DbSet<ChatMessage> Messages { get; set; }

        public ChatDbContext()
        {
            
        }

        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options)
        {
            
        }
    }
}
