using Microsoft.EntityFrameworkCore;
using Projeto_aplicação_para_emprestimos.Models;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_aplicação_para_emprestimos.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
    
        }
        public DbSet<Emprestimosmodel> Emprestimos { get; set; }
    }
}
