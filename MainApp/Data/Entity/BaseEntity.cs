using System.ComponentModel.DataAnnotations;

namespace MainApp.Data.Entity;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime UpdateAt { get; set; }
}