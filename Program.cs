namespace POO
{

    class Program
    {
        static void Main(string[] args)
        {

            Controlador p = new ControleRemoto();

            p.ligar();
            p.maisVolume();
            p.ligarMudo();
            p.abrirMenu();

        }
    }
    

}





