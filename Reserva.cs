using System;

namespace ConsoleApp16
{
    internal class Reserva
    {
        private int _idReserva;
        private Quarto _quarto;
        private string _hospede;
        private int _noites;
        private double _valorTotal;

        public Reserva(int idReserva, Quarto quarto, string hospede, int noites)
        {
            _idReserva = idReserva;
            _quarto = quarto ?? throw new ArgumentNullException(nameof(quarto), "O quarto não pode ser nulo.");
            _hospede = hospede ?? throw new ArgumentNullException(nameof(hospede), "O nome do hóspede não pode ser nulo.");

            if (noites <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(noites), "O número de noites deve ser maior que zero.");
            }

            _noites = noites;
            CalcularTotal(); // Calcula o valor total no construtor
        }

        public int GetIdReserva()
        {
            return _idReserva;
        }

        public void SetIdReserva(int idReserva)
        {
            if (idReserva <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(idReserva), "O Id da reserva deve ser maior que zero.");
            }
            _idReserva = idReserva;
        }

        public Quarto GetQuarto()
        {
            return _quarto;
        }

        public void SetQuarto(Quarto quarto)
        {
            _quarto = quarto ?? throw new ArgumentNullException(nameof(quarto), "O quarto não pode ser nulo.");
        }

        public string GetHospede()
        {
            return _hospede;
        }

        public void SetHospede(string hospede)
        {
            _hospede = hospede ?? throw new ArgumentNullException(nameof(hospede), "O nome do hóspede não pode ser nulo.");
        }

        public int GetNoites()
        {
            return _noites;
        }

        public void SetNoites(int noites)
        {
            if (noites <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(noites), "O número de noites deve ser maior que zero.");
            }
            _noites = noites;
            CalcularTotal();//Recalcula o valor total
        }
        public double GetValorTotal()
        {
            return _valorTotal;
        }
        // Removido o SetValorTotal

        private void CalcularTotal()
        {
            _valorTotal = _quarto.CalcularPrecoTotal(_noites);
        }
    }
}