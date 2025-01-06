namespace Projeto_aplicação_para_emprestimos.Models
{
    public class Emprestimosmodel
    {
        public int Id { get; set; }
        public required string Recebedor { get; set; }
        public required string Fornecedor { get; set; }
        public required string Livro { get; set; }
        public DateTime DataUtimautilizacao  { get; set; } = DateTime.Now;



    }
}
