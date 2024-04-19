using System;

namespace csharp_oop_shop
{
    class Product
    {
        // Attributi
        public decimal Code { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Vat { get; set; }

        // Costruttore
        public Product(string name, string description, decimal price, int vat)
        {
            Code = GenerateCode();
            Name = name;
            Description = description;
            Price = price;
            Vat = vat;
        }

        // Metodo per generare un codice casuale
        private decimal GenerateCode()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999);
        }

        // Metodo getter per il prezzo comprensivo di iva
        public decimal GetPriceWithVat()
        {
            return Price * (1 + (decimal)Vat / 100);
        }

        // Metodo per ottenere il nome esteso (codice + nome)
        public string GetNameWithCode()
        {
            return Code.ToString().PadLeft(8, '0') + "-" + Name;
        }

        // Metodo per stampare i dettagli del prodotto
        public void SeeDetails()
        {
            Console.WriteLine($"\nCodice: {Code}  \nNome: {Name}  \nDescrizione: {Description}  \nPrezzo base: {Price}  \nPrezzo con IVA: {GetPriceWithVat():F2}  \nIVA: {Vat:F2}%");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un prodotto
            Product product1 = new Product("Smartphone", "Telefonino con funzioni avanzate", 500.00m, 22);

            // Test dei metodi
            Console.WriteLine("\nDettagli del prodotto:");
            product1.SeeDetails();

            Console.WriteLine("\nNome esteso del prodotto:");
            Console.WriteLine(product1.GetNameWithCode());

            // Modifica del nome
            product1.Name = "Tablet";

            // Stampa dei dettagli aggiornati
            Console.WriteLine("\nDettagli del prodotto aggiornati:");
            product1.SeeDetails();

            // Creazione di un array di prodotti
            Product[] productList = new Product[5];
            productList[0] = new Product("Libro", "Romanzo di fantascienza", 20.00m, 22);
            productList[1] = new Product("Scarpe", "Scarpe sportive", 80.00m, 22);
            productList[2] = new Product("Maglietta", "Maglietta in cotone", 25.00m, 22);
            productList[3] = new Product("Orologio", "Orologio analogico da polso", 150.00m, 22);
            productList[4] = new Product("Zaino", "Zaino da escursione impermeabile", 50.00m, 22);

            // Stampa dell'elenco dei prodotti
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("\nElenco dei prodotti nel negozio:");
            foreach (Product product in productList)
            {
                product.SeeDetails();
            }
        }
    }
}
