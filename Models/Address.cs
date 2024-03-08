using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models;

public class Address{
    [Key]
    public int Id {get; set;}

    [Required][StringLength(20)]
    public string  Street {get; set;}
    [Required][StringLength(20)]
    public string  City {get; set;}
    [Required][StringLength(20)]
    public string  State {get; set;}

}
// string will convert into a varchar by using the EF Framework.