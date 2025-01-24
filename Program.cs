using ConsoleApp16;

namespace hotels2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel("Meu Hotel");

            // Adicionar Quartos
            hotel.AdicionarQuarto(101, 2, 100.00);
            hotel.AdicionarQuarto(102, 1, 80.00);
            hotel.AdicionarQuarto(101, 3, 120.00); // Tenta adicionar um quarto com número repetido

            // Listar quartos
            hotel.ListarQuartos();

            // Adicionar Reservas
            hotel.AdicionarReserva("João", 101, 3);
            hotel.AdicionarReserva("Maria", 102, 2);
            hotel.AdicionarReserva("José", 200, 1); // Tenta adicionar uma reserva com quarto inexistente

            // Listar Reservas
            hotel.ListarReservas();

            Console.ReadKey();
        }
    }
}