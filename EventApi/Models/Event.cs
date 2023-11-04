using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApi.Models;

[Table("event", Schema = "docu")]
public class Event
{
    [Key]
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual ICollection<EventRegistration>? EventRegistrations { get; set; }
}