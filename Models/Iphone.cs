namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {

            if (nomeApp == "1")
            {
                Console.WriteLine("Aguarde...");
                Console.WriteLine("Itunes Instalado com sucesso");
            }
            else if (nomeApp == "2")
            {
                Console.WriteLine("Aguarde...");
                Console.WriteLine("Safari instalado com sucesso");
            }
            else
            {
                Console.WriteLine("Hm, parece que não temos este app...");
            }
            
        }
    }
}