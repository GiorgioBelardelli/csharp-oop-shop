namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto1 = new Prodotto("Telefono", "One Plus Nord", 399.99m);
            prodotto1.getNomeConCodice();
            Console.WriteLine(prodotto1.Nome);
            Console.WriteLine("Prezzo con IVA: " + prodotto1.getPrezzoConIva());
            Console.WriteLine("BONUS: " + prodotto1.getNomeConPadLeft());
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Prodotto prodotto2 = new Prodotto("Televisore", "Samsung", 1029.89m);
            prodotto2.getNomeConCodice();
            Console.WriteLine(prodotto2.Nome);
            Console.WriteLine("Prezzo con IVA: " + prodotto2.getPrezzoConIva());
            Console.WriteLine("BONUS: " + prodotto2.getNomeConPadLeft());
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Prodotto prodotto3 = new Prodotto("Moka", "Bialetti", 19.99m);
            prodotto3.getNomeConCodice();
            Console.WriteLine(prodotto3.Nome);
            Console.WriteLine("Prezzo con IVA: " + prodotto3.getPrezzoConIva());
            Console.WriteLine("BONUS: " + prodotto3.getNomeConPadLeft());
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Prodotto prodotto4 = new Prodotto("Asciugacapelli", "Roventa", 29.99m);
            prodotto4.getNomeConCodice();
            Console.WriteLine(prodotto4.Nome);
            Console.WriteLine("Prezzo con IVA: " + prodotto4.getPrezzoConIva());
            Console.WriteLine("BONUS: " + prodotto4.getNomeConPadLeft());
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            Prodotto[] prodotti =
                [ 
                new Prodotto("Monopoly", "Un gioco di soldi", 19.99m), 
                new Prodotto("7 Wonders", "Un gioco meraviglioso", 39.99m), 
                new Prodotto("Carcassonne", "Un bel gioco", 29.99m), 
                new Prodotto("Exploding Kittens", "Un gioco di gattini ed esplosioni", 14.99m), 
                new Prodotto("Citadels", "Un gioco di Intrighi", 19.99m), 
                ];
            foreach (var prodotto in prodotti)
            {
                Console.WriteLine(prodotto.Nome);
                prodotto.getNomeConCodice();
                Console.WriteLine("Prezzo con IVA: " + prodotto.getPrezzoConIva());
                Console.WriteLine("BONUS: " + prodotto.getNomeConPadLeft());
                Console.WriteLine(" ");

            }

        }
    }
}

    internal class Prodotto()
    {
        private int _codice;
        public int Codice
        {
            get
            {
                return _codice;
            }
        }

        ///

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        /// 
        private string _descrizione;
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            set
            {
                _descrizione = value;
            }
        }

        ///
        private decimal _prezzo;
        public decimal Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                _prezzo = value;
            }
        }

        ///
        private int _iva22;
        public int Iva22
        {
            get
            {
                return _iva22;
            }
            set
            {
                _iva22 = 22;
            }
        }

        private Random rnd = new Random();


        ///COSTRUTTORE
        public Prodotto(string Nome, string Descrizione, decimal Prezzo) : this()
        {
            _codice = rnd.Next(1, 1000000);
            _nome = Nome;
            _descrizione = Descrizione;
            _prezzo = Prezzo;
            _iva22 = 22;
        }

        ///METODO PER PREZZO CON IVA
        public decimal getPrezzoConIva()
        {
            decimal prezzoConIVA = Prezzo * ((decimal)_iva22 / 100);
            decimal prezzoComplessivo = Prezzo + prezzoConIVA;
            return prezzoComplessivo;
        }

        ///METODO PER NOME + CODICE
        public void getNomeConCodice()
        {
            Console.WriteLine($"Prodotto: {_nome}{_codice} ");
        }

        ///***********BONUS 1***********///
        public string getNomeConPadLeft() 
        {
            return Codice.ToString().PadLeft(8, '0');
        }
    }

