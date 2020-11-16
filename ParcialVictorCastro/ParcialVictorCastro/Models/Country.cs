
namespace ParcialVictorCastro.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Country
    {
     [Key]
     [StringLength(50)]
     public string Alpha3Code { get; set; }

     [StringLength(50)]
     public string Region { get; set; }

     [StringLength(50)]
     public string Name { get; set; }

     [Range(1,99999)]
     public int Area { get; set; }

     [Range(1, 9999)]
     public int CallingCodes { get; set; }

     [StringLength(50)]
     public string languages { get; set; }

    [StringLength(50)]
    public string flag { get; set; }


    }
}