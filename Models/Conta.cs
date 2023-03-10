using DiO.Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Bank.Models
{
    public class Conta
    {
        private TipoConta TipoConta { get; set;  }
        private string Nome {get; set;}

        private double Saldo { get; set; }

        private double Credito { get; set;}

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome; 
        }

        public bool Sacar(double valorSaque)
        {

            if (this.Saldo - valorSaque < (this.Credito * -1))
            {
                Console.WriteLine("O saldo ? insuficiente");
                return false;
            }
            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} ? {1}", this.Nome, this.Saldo);
            return true; 
        }

        public void Depositar(double valoDeposito)
        {
            this.Saldo += valoDeposito;

            Console.WriteLine("O saldo atual de {0}, ? igual a {1}", this.Nome, this.Saldo); 
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia); 
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.TipoConta + " | "; 
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Cr?dito " + this.Credito;
            return retorno;
        }

    }
}