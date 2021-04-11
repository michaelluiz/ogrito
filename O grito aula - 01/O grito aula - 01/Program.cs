using System;

namespace O_grito_aula___01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("insira seu cartão");
            //Console.ReadLine();
            //Console.WriteLine("Digite sua senha de 4 digitos");
            //Console.ReadLine();
            //Console.WriteLine("Selecione o serviço");
            //Console.ReadLine();
            //Console.WriteLine("Digite o valor");
            //Console.ReadLine();
            //Console.WriteLine("Digite sua senha de 4 digitos");
            //Console.ReadLine();
            //Console.WriteLine("aguarde e a contagem das cedulas, e confira o valor");
            //Console.WriteLine("Deseja outro serviço?");
            //string continuar;
            //continuar = Console.ReadLine();
            //Console.WriteLine(continuar);

            // Pedir o nome de uma pessoa
            // imprimir o nome na tela

            //Console.WriteLine("Digite seu Nome");
            //string nomeDeUmaPessoa;
            //nomeDeUmaPessoa = Console.ReadLine();
            //Console.WriteLine(nomeDeUmaPessoa);

            // Você vai pedir a idade de uma pessoa, e vai mostrar a idade somado com 2

            //Console.WriteLine("informe sua idade");
            //int idadeDeUmaPessoa;
            //idadeDeUmaPessoa = int.Parse(Console.ReadLine());
            //idadeDeUmaPessoa = idadeDeUmaPessoa + 2;
            //Console.WriteLine(idadeDeUmaPessoa);



            //double pesoEmKg;
            //double alturaEmMetros;
            //double IMC;
            //Console.WriteLine("IMC");
            //Console.WriteLine("informe seu peso em kg");
            //pesoEmKg = double.Parse(Console.ReadLine());
            //Console.WriteLine("informe sua altura em metros");
            //alturaEmMetros = double.Parse(Console.ReadLine());
            //IMC = pesoEmKg / (alturaEmMetros * alturaEmMetros);
            //Console.WriteLine(IMC);

            double valorDoProduto;
            double lucro;
            double venda;
            Console.WriteLine("valor de Compra");
            valorDoProduto = double.Parse(Console.ReadLine());
            lucro = valorDoProduto * 0.43;
            Console.WriteLine("lucro");
            Console.WriteLine(lucro);
            venda = valorDoProduto + lucro;
            Console.WriteLine("Valor de Venda");
            Console.WriteLine(venda);


            


         }
    }
}
