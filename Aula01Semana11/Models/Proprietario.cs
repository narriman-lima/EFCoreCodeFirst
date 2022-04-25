namespace Aula01Semana11.Models
{
    public class Proprietario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Contato>? Contatos { get; set; }
        public ICollection<Imovel>? Imoveis { get; set; }
    }
}
