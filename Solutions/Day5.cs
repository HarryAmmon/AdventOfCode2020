using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCodeCore;
using Solutions.Entities;
using Solutions.Services;

namespace Solutions
{
    public class Day5 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            int maxID = 0;
            foreach (string row in fileContent)
            {
                ITicketScanner scanner = new TicketScanner();
                Ticket result = scanner.GenerateTicket(row);
                if (result.SeatID > maxID)
                {
                    maxID = result.SeatID;
                }
            }
            return maxID;
        }

        public int Part2(string[] fileContent)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (string row in fileContent)
            {
                ITicketScanner scanner = new TicketScanner();
                tickets.Add(scanner.GenerateTicket(row));
            }
            tickets = tickets
                        .OrderBy(x => x.RowNumber)
                        .ThenBy(x => x.SeatNumber)
                        .ToList();

            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket.ToString());
            }

            return -1;
        }
    }
}