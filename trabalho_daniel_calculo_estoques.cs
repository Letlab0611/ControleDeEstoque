using System;
using System.Globalization;


namespace atividadeDaniel
{
    public class Program
    {
        static void Main(string[] arg)
        {
            //recebe nome quantidade e preço do produto
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            // separa os dados para calcular valor
            Produto p = new Produto(nome, preco, quantidade);
            //mostra os dados
            Console.WriteLine("Dados do produto:" + p);
            //adiciona ao estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            //atualiza os dados
            Console.WriteLine("Dados do atualizados: " + p);
            //remove do estoque
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            
            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
    public class Produto
    {
        //declara
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Produto(string nome, double preco, int quantidade)
        {
            nome = nome;
            preco = preco;
            quantidade = quantidade;
        }
        //calcula valor do estoque, com quantidade de produtos e preço
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        //adiciona ao estoque
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        //remove do estoque
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }
        //override
        public override string ToString()
        {
            return Nome
            + ", R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + Quantidade
            + " unidades, Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
