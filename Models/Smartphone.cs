namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }
        public void NumeroSmartphone()
        {
            System.Console.WriteLine($"Numero: {Numero}");
        }
        public void NomeModelo()
        {
            System.Console.WriteLine($"Modelo: {Modelo}");
        }
        public void NumeroIMEI()
        {
            System.Console.WriteLine($"IMEI: {IMEI}");
        }
        public void QuantidadeMemoria()
        {
            System.Console.WriteLine($"Memoria: {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}