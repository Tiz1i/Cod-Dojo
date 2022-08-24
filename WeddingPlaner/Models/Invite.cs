#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlaner.Models;
public class Invite
{
    [Key]
    public int InviteId { get; set; }
    public int UserId { get; set; }
    public int WeddingId { get; set; }
    public User? Person { get; set; }
    public Wedding? Wedding { get; set; }

   
}