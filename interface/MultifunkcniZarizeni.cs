namespace interface
{
    public class MultifunkcniZarizeni : IPripojitelne, ITiskarna, ISkener
    {
        public void Pripoj(string adresa)
        {
            // Implementace připojení k zařízení
            Console.WriteLine($"Připojuji k zařízení - IP adresa: {adresa}");
        }

        public void Odpoj()
        {
            // Implementace odpojení od zařízení
            Console.WriteLine("Odpojuji od zařízení");
        }

        public void Tiskni(string dokument)
        {
            // Implementace tisku dokumentu
            Console.WriteLine($"Tisknu dokument: {dokument}");
        }

        public string Skenuj()
        {
            // Implementace skenování dokumentu
            return "Skenovaný dokument";
        }

    }
}