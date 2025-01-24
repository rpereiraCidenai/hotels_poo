using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    internal class Hotel
    {
        private string _nome;
        private List<Reserva> _listaReservas = new List<Reserva>();
        private List<Quarto> _listaQuartos = new List<Quarto>();

        public Hotel(string nome)
        {
            _nome = nome;
        }

        // Métodos para Gerir Quartos
        public void AdicionarQuarto(int numero, int capacidade, double preco)
        {
            foreach (var quarto in _listaQuartos)
            {
                if (quarto.GetNumero() == numero)
                {
                    Console.WriteLine($"Já existe um quarto com o número {numero}");
                    return;
                }
            }

            Quarto novoQuarto = new Quarto(numero, capacidade, preco);
            _listaQuartos.Add(novoQuarto);
            Console.WriteLine($"Quarto {numero} adicionado com sucesso");
        }

        public Quarto GetQuarto(int numero)
        {
            foreach (var quarto in _listaQuartos)
            {
                if (quarto.GetNumero() == numero)
                {
                    return quarto;
                }
            }
            return null;
        }

        public void ListarQuartos()
        {
            if (_listaQuartos.Count == 0)
            {
                Console.WriteLine("Não há quartos registados.");
                return;
            }

            Console.WriteLine("Lista de Quartos:");
            foreach (var quarto in _listaQuartos)
            {
                Console.WriteLine($"- Número: {quarto.GetNumero()}, Capacidade: {quarto.GetCapacidade()}, Preço: {quarto.GetPrecoBase()}");
            }
        }

        // Métodos para Gerir Reservas
        public void AdicionarReserva(string hospede, int numeroQuarto, int noites)
        {
            Quarto quarto = GetQuarto(numeroQuarto);
            if (quarto == null)
            {
                Console.WriteLine($"Quarto número {numeroQuarto} não encontrado.");
                return;
            }
            Reserva novaReserva = new Reserva(_listaReservas.Count + 1, quarto, hospede, noites);
            _listaReservas.Add(novaReserva);
            Console.WriteLine($"Reserva para o quarto {numeroQuarto} realizada com sucesso para {hospede} por {noites} noites");
        }

        public void ListarReservas()
        {
            if (_listaReservas.Count == 0)
            {
                Console.WriteLine("Não há reservas registadas.");
                return;
            }
            Console.WriteLine("Lista de Reservas:");
            foreach (var reserva in _listaReservas)
            {
                Console.WriteLine($"- Id: {reserva.GetIdReserva()}, Quarto: {reserva.GetQuarto()?.GetNumero()}, Hóspede: {reserva.GetHospede()}, Noites: {reserva.GetNoites()}, Valor: {reserva.GetValorTotal()}");
            }
        }

        public void ListarQuartosDisponiveis()
        {
            // Implementar lógica para listar quartos disponíveis
        }
    }
}