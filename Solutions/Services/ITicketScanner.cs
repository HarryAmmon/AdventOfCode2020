using Solutions.Entities;

namespace Solutions.Services
{
    public interface ITicketScanner
    {
        Ticket GenerateTicket(string ticket);
    }
}