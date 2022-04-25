using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//usando annotations 

namespace Aula01Semana11.Models
{
    [Table("imoveis")]
    public class Imovel
    {
        [Column("id")]
        public int Id { get; set; }
        [MaxLength(20)]
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("descricao_curta")]
        public string DescricaoCurta { get; set; }
        [Column("descricao_longa")]
        public string DescricaoLonga { get; set; }
        [Column("data_criacao")]
        public DateTime DataCriacao { get; set; }
        [Column("data_atualizacao")]
        public DateTime DataAtualizacao { get; set; }
        [Column("preco")]
        public float Preco { get; set; }
        [Column("area")]
        public float Area { get; set; }
        [Column("valor-condominio")]
        public float ValorCondominio { get; set; }
        [Column("endereco")]
        public Endereco? Endereco { get; set; }
        [Column("proprietario")]
        public ICollection<Proprietario>? Proprietarios { get; set; }
        //public EnumTipo TipoImovel { get; set; }
        //public string Corretor { get; set; }
    }
}
