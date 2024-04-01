namespace _2._9
{
    [Flags]
    enum Kwartaly
    {
        I_kwartal = 1,
        II_kwartal = 2,
        III_kwartal = 4,
        IV_kwartal = 8,
        KwartalyLetnia = I_kwartal | IV_kwartal,
        KwartalyZimowe = II_kwartal | III_kwartal
    }
    struct Kwartalnik
    {
        string tytul;
        Kwartaly kwartal;
        DateTime rokWydania;
        int liczbaStron;
        public Kwartalnik(string tytul, Kwartaly kwartal, DateTime rokWydania, int liczbaStron)
        {
            this.tytul = tytul;
            this.kwartal = kwartal;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
        }
        public override string ToString()
        {
            string output = string.Empty;
            if(Kwartaly.KwartalyLetnia.HasFlag(kwartal))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                output = $"Tytuł: {tytul}, kwartał: {kwartal}, rok wydania: {rokWydania}, liczbaStron: {liczbaStron}";
            }
            else if (Kwartaly.KwartalyZimowe.HasFlag(kwartal))
            {
                Console.ForegroundColor = ConsoleColor.White;
                output = $"Tytuł: {tytul}, kwartał: {kwartal}, rok wydania: {rokWydania}, liczbaStron: {liczbaStron}";
            }
            return output;
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kwartalnik[] kwartalniki = {new Kwartalnik("Kubki", Kwartaly.I_kwartal, new DateTime(2024, 01, 24), 254), 
                                        new Kwartalnik("Szkalnki", Kwartaly.III_kwartal, new DateTime(2023, 05, 11), 505)};
            foreach (Kwartalnik k in kwartalniki)
            {
                Console.WriteLine(k.ToString());
            }
        }
    }
}
