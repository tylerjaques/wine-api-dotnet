using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wine.Api.Models;

public class Event
{
    [Key]
    public string Code { get; set; }
    public string Region { get; set; }
    public string Host { get; set; }
    public string Date { get; set; }

}