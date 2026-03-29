using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Data.Models
{
    public class Director
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>(); 

    }
}
