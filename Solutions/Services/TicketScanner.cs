using System;
using Solutions.Entities;

namespace Solutions.Services
{
    public class TicketScanner : ITicketScanner
    {
        private readonly int MaxRow = 127;
        private readonly int MinRow = 0;
        private readonly int MaxColumn = 7;
        private readonly int MinColumn = 0;

        public Ticket GenerateTicket(string ticketString)
        {
            int rowNumber = GenerateRow(ticketString);
            int seatNumber = GenerateSeat(ticketString);

            Ticket ticket = new Ticket()
            {
                BinaryIndicator = ticketString,
                RowNumber = rowNumber,
                SeatNumber = seatNumber
            };
            return ticket;
        }


        private int GenerateSeat(string ticket)
        {
            int currentMax = MaxColumn;
            int currentMin = MinColumn;

            for (int i = 7; i < ticket.Length; i++)
            {
                int midPoint = CalculateMidpoint(currentMin, currentMax, ticket[i]);
                if (ticket[i] == 'R')
                {
                    currentMin = midPoint;
                }
                else if (ticket[i] == 'L')
                {
                    currentMax = midPoint;
                }
            }
            return currentMax;
        }

        private int GenerateRow(string ticket)
        {

            int currentMax = MaxRow;
            int currentMin = MinRow;

            for (int i = 0; i < 7; i++)
            {
                int midPoint = CalculateMidpoint(currentMin, currentMax, ticket[i]);
                if (ticket[i] == 'F')
                {
                    currentMax = midPoint;
                }
                else if (ticket[i] == 'B')
                {
                    currentMin = midPoint;
                }
            }
            return currentMax;
        }

        public int CalculateMidpoint(int lowerBound, int upperBound, char direction)
        {
            int sumOfBounds = lowerBound + upperBound;
            int midPoint = sumOfBounds / 2;
            if (sumOfBounds % 2 != 0 && (direction == 'B' || direction == 'R'))
            {
                midPoint += 1;
            }
            return midPoint;
        }
    }
}

// FBFBBFFRLR