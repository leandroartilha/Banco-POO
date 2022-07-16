using System;
namespace POO
{
    public class ContaBanco
    {

        public int numConta { get; set; }

        protected string tipo { get; set; }

        private string dono { get; set; }

        private int saldo { get; set; }

        private bool status { get; set; }

        public void estadoAtual()
        {
            Console.WriteLine("Conta: " + this.getnumConta());
            Console.WriteLine("Tipo: " + this.getTipo());
            Console.WriteLine("Dono: " + this.getDono());
            Console.WriteLine("Saldo: " + this.getSaldo());
            Console.WriteLine("Status: " + this.getStatus());
        }


        public ContaBanco()
        {
            this.saldo = 0;
            this.status = false;
            
        }

        public void abrirConta(string tipoDaConta)
        {
            setStatus(true);
            setTipo(tipoDaConta);
            Console.WriteLine("Conta Aberta");
        }
        public void fecharConta()
        {
            setStatus(false);
            Console.WriteLine("Conta Fechada!");
        }

        public void depositar(int valor)
        {
            if(this.status == true)
            {
                this.setSaldo(this.getSaldo() + valor);
            }
        }

        public void sacar(int valorSacar)
        {
            if(this.status == true && valorSacar < this.saldo)
            {
                this.setSaldo(getSaldo() - valorSacar);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou conta desativada");
            }

        }

        public void pagarMensal()
        {
            if(this.tipo == "cc")
            {
                setSaldo(getSaldo() - 10);
            }
            else
            {
                setSaldo(getSaldo() - 20);
            }
        }

        ///////////////////////
        ///

        public int getnumConta()
        {
            return numConta;
        }
        public void setnumConta(int numero)
        {
            this.numConta = numero;
        }

        public string getTipo()
        {
            return tipo;
        }
        public void setTipo(string tipoConta)
        {
            this.tipo = tipoConta;
        }

        public string getDono()
        {
            return dono;
        }
        public void setDono( string nomeDono)
        {
            this.dono = nomeDono;
        }

        public int getSaldo()
        {
            return saldo;
        }
        public void setSaldo(int valor)
        {
            this.saldo = valor;
        }

        public bool getStatus()
        {

            return status;
        }
        
        public void setStatus(bool statusRec)
        {
            this.status = statusRec;
        }
    }
}

