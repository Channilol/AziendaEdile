namespace AziendaEdile.Models
{
    public class Pagamenti
    {
        public int Id { get; set; }

        public DateOnly Periodo { get; set; }

        public decimal Ammontare { get; set; }

        public bool Tipo {  get; set; }

    }
}
