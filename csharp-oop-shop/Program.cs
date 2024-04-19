namespace csharp_oop_shop
{
    class Prodotto
    {
        //Attributes
        private int code;
        private string name;
        private string description;
        private decimal price;
        private decimal vat;
        
        // Costruttore
        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {
            this.codice = GeneraCodice();
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
