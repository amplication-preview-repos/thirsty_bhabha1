using Microsoft.EntityFrameworkCore;

namespace ChatAppService.Infrastructure;

public class ChatAppServiceDbContext : DbContext
{
    public ChatAppServiceDbContext(DbContextOptions<ChatAppServiceDbContext> options)
        : base(options) { }
}
