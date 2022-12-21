namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
{
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {

            if (nomeApp == "1")
            {
                Console.WriteLine("Aguarde...");
                Console.WriteLine("Google Play Instalado com sucesso");
            }
            else if (nomeApp == "2")
            {
                Console.WriteLine("Aguarde...");
                Console.WriteLine("Mozila firefox instalado com sucesso");
            }
            else
            {
                Console.WriteLine("Hm, parece que não temos este app...");
            }
        }
    }
}