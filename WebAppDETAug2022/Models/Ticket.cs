namespace WebAppDETAug2022.Models
{
    public class Ticket
    {
        internal int ID { get; set; }
        public string BookedBy { get; set; }
        public string BookedFor { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

    }
}

