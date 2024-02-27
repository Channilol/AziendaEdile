namespace AziendaEdile.Models
{
    public static class StaticDB
    {
        private static int _maxId = 3;
        private static List<Dipendenti> _dipendenti = [
            new Dipendenti() { IdDipendente = 1, Nome = "Francesco", Cognome = "Cannizzo", Indirizzo = "Via Dionisio 5", CodiceFiscale = "ABCDEFG123456789", Coniugato = false, NumFigli = 0, Mansione = "Studente" },
            new Dipendenti() { IdDipendente = 2, Nome = "Fr", Cognome = "Cannizzo", Indirizzo = "Via Dionisio 5", CodiceFiscale = "ABCDEFG123456789", Coniugato = false, NumFigli = 0, Mansione = "Studente" },
            new Dipendenti() { IdDipendente = 3, Nome = "Franc", Cognome = "Cannizzo", Indirizzo = "Via Dionisio 5", CodiceFiscale = "ABCDEFG123456789", Coniugato = false, NumFigli = 0, Mansione = "Studente" }
            ];

        public static List<Dipendenti> GetAll()
        {
            return _dipendenti;
        }

        public static Dipendenti? GetById(int id)
        {
            for (int i = 0; i < _dipendenti.Count; i++)
            {
                Dipendenti dipendente = _dipendenti[i];
                if (_dipendenti[i].IdDipendente == id)
                {
                    return dipendente;
                }
            }

            return null;
        }

        public static Dipendenti Add(string Nome, string Cognome, string Indirizzo, string CodiceFiscale, bool Coniugato, int NumFigli, string Mansione)
        {
            _maxId++;
            var dipendente = new Dipendenti() { IdDipendente = _maxId, Nome = Nome, Cognome = Cognome, Indirizzo = Indirizzo, CodiceFiscale = CodiceFiscale, Coniugato = Coniugato, NumFigli = NumFigli, Mansione = Mansione};
            _dipendenti.Add(dipendente);
            return dipendente;
        }
    }
}
