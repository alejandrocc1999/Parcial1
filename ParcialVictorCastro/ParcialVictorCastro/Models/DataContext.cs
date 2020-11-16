
namespace ParcialVictorCastro.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext 
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialVictorCastro.Models.Country> Countries { get; set; }
    }
}