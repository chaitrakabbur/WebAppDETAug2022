//using System.Net.Sockets;
//using WebAppDETAug2022.Models;

//namespace WebAppDETAug2022.Services
//{
//    public class TicketService
//    {
//        static List<Ticket> Tickets { get; }
//        static int nextId = 3;
//        static TicketService()
//        {
//            Tickets = new List<Ticket>
//            {
//            new Ticket{Id=1,Category="PlatinumPlus",Price=5000,MaxLimit=200000},
//            new Ticket{Id=2,Category="Platinum",Price=4000,MaxLimit=300000},
//            new Ticket{Id=3,Category="Gold",Price=3000,MaxLimit=500000},
//            new Ticket{Category="Silver",Price=2000,MaxLimit=500000},
//            new Ticket{Category="General",Price=8000,MaxLimit=100000}

//            };
//        }

//        public static List<Ticket> GetAll() => Tickets;

//        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

//        public static void Add(Ticket ticket)
//        {
//            ticket.Id = nextId++;
//            Tickets.Add(ticket);
//        }
//    }
//}
