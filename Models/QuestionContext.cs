using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace Models
{
    public class QuestionContext : DbContext
    {
        public DbSet<question> questions { get; set; }
        
    }
}
