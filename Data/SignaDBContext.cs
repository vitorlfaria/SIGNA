using Microsoft.EntityFrameworkCore;
using SIGNA.Models;

namespace SIGNA.Data
{
    public class SignaDBContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public SignaDBContext(DbContextOptions<SignaDBContext> options) : base(options)
        {

        }
    }
}
