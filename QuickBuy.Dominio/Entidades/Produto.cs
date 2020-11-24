namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao  { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificada a referência do produto");

            if (Quantidade == 0)

                AdicionarCritica("Quantidade não foi informada");
        }
    }
}
