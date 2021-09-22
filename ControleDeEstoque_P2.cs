using System;
using System.Globalization; //para muitos tipos de globalização


namespace homework5
{
    public class Program
    {
        static void Main(string[] arg)
        {
            //recebe o nome, valor e quantidade de item
            Console.WriteLine("Entre com os dados do produto;");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());


            // cria dados do produto
            Produto p = new Produto(nome, preco, quantidade);
            //mostra dados do produto
            Console.WriteLine("Dados do produto:" + p);
            //adiciona os produtos ao estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            //atualiza os valores totais
            Console.WriteLine("Dados do atualizados: " + p);
            //remove os produtos do estoque
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);
            //atualia os valores totais
            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
    public class Produto
    {
        //declaração
        private string _nome;
        private double _preco;
        private int _quantidade;

        //construtor
        public Produto() { }
        public Produto(string nome, double preco, int quantidade)
        {
            nome = _nome;
            preco = _preco;
            quantidade = _quantidade;
        }

        //get & set
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }
        public double Preco
        {
            get { return _preco; }
        }
        public int quantidade
        {
            get { return _quantidade; }
        }

        //utilização GET & SET
        public string GetNome()
        {
            return _nome;
        }
        public void setNome(string nome)
        {
            _nome = nome;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double GetPreco()
        {
            return _preco;
        }
        //calcula o valor total do estoque, com base no preço e quantidade
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        //adiciona ao estoque
        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }
        //remove do estoque
        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }
        //substitui valores
        public override string ToString()
        {
            return _nome
            + ", R$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + _quantidade
            + " unidades, Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}