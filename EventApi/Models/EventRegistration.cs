using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApi.Models;

[Table("event_registration", Schema = "docu")]
public class EventRegistration
{
    [Key]
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    [ForeignKey("Event")]
    public long EventId { get; set; }
}