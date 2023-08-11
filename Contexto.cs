using Microsoft.EntityFrameworkCore;

namespace APITAT
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):
            base (options){ }

        public DbSet<Aluno> Alunos { get; set; }

    }
}
