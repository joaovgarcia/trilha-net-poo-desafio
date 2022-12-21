namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo  {get; set; }
        public string Emei { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string emei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Emei = emei;
            Memoria = memoria;
        }

        public string VisualizarNumero()
        {   
            return Numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void AlterarNumero(string numero)
        {

            Numero = numero;

        }

        public (string Modelo, string Emei, int Memoria) EspecificacoesTecnicas()
        {   
            (string Modelo, string Emei, int Memoria) espcs = (Modelo, Emei, Memoria);
            return espcs;
        }


        public abstract void InstalarAplicativo(string nomeApp);
    }
}