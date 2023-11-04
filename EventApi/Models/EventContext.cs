using Microsoft.EntityFrameworkCore;

namespace EventApi.Models;

public class EventContext : DbContext
{
    public EventContext(DbContextOptions<EventContext> options) : base(options)
    {
    }

    public DbSet<Event> Events { get; set; } = null!;

    public DbSet<EventRegistration> EventRegistrations { get; set; }

}