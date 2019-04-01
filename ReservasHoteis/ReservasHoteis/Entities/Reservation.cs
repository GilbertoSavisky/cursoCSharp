using System;
using ReservasHoteis.Entities.Exceptions;
using System.Text;

namespace ReservasHoteis.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            UpdateDates(checkIn, checkOut);
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if(checkIn < now || checkOut < now)
            {
                throw new DomainException("Datas para reservas tem que ser datas futuras!");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainException("Data de saída tem que ser posterior à data de entrada!");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Quarto: {RoomNumber}, check-in: {CheckIn}, check-out: {CheckOut}, {Duration()} noites";
        }
    }

}
