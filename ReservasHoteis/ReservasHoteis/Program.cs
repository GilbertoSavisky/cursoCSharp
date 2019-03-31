using System;
using ReservasHoteis.Entities;
using ReservasHoteis.Entities.Exceptions;

namespace ReservasHoteis
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número do quarto: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-In data (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out data (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);

                Console.WriteLine("Reservation : " + reservation);

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Entre com a data para atualizar a reserva: ");
                Console.Write("Check-In data (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out data (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Reservation : " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro na reserva: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: "+e.Message);
            }
            catch(Exception e)// Capturar todo tipo de erro
            {
                Console.WriteLine("Erro: "+e.Message);
            }
        }
    }
}
