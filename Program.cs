// See https://aka.ms/new-console-template for more information

using System; 
using DIO.Bank.Models;

namespace DIO.Bank
{
    class Program{
        static void Main(string[] args){
            Conta minhaConta = new Conta(DiO.Bank.Models.TipoConta.PessoaFisica, 0, 0, "Vinicius Henrique");

            Console.WriteLine(minhaConta.ToString());
        }

        //private static string ObterOpcaoUsuario()
        //{
        //    Console.WriteLine();
        //}
    }
}