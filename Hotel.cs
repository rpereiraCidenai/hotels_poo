using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Hotel
    {
        // Definição de uma classe Hotel que irá gerenciar os quartos e as reservas
        private string _nome;  // Nome do hotel
        private List<Reserva> _listaReservas = new List<Reserva>();  // Lista que armazena as reservas
        private List<Quarto> _listaQuartos = new List<Quarto>();  // Lista que armazena os quartos do hotel

        // Construtor que recebe o nome do hotel e inicializa o nome da instância
        public Hotel(string nome)
        {
            _nome = nome;  // Atribui o nome do hotel
        }

        // Métodos para gerir os Quartos

        // Adiciona um novo quarto ao hotel
        public void AdicionarQuarto(int numero, int capacidade, double preco)
        {
            // Verifica se já existe um quarto com o mesmo número
            foreach (var quarto in _listaQuartos)
            {
                if (quarto.GetNumero() == numero)
                {
                    Console.WriteLine("Já existe um quarto com o número " + numero);  // Mensagem de erro caso o número do quarto já exista
                    return;  // Termina a execução do método
                }
            }

            // Cria um novo quarto e adiciona à lista de quartos
            Quarto novoQuarto = new Quarto(numero, capacidade, preco);
            _listaQuartos.Add(novoQuarto);
            Console.WriteLine("Quarto " + numero + " adicionado com sucesso");  // Mensagem de sucesso
        }

        // Retorna o quarto pelo seu número, caso exista
        public Quarto GetQuarto(int numero)
        {
            foreach (var quarto in _listaQuartos)
            {
                if (quarto.GetNumero() == numero)
                {
                    return quarto;  // Retorna o quarto encontrado
                }
            }
            return null;  // Retorna null caso o quarto não seja encontrado
        }

        // Lista todos os quartos disponíveis no hotel
        public void ListarQuartos()
        {
            if (_listaQuartos.Count == 0)
            {
                Console.WriteLine("Não há quartos registados.");  // Mensagem caso não haja quartos
                return;
            }

            Console.WriteLine("Lista de Quartos:");
            foreach (var quarto in _listaQuartos)
            {
                // Exibe informações do quarto, como número, capacidade e preço
                Console.WriteLine("- Número: " + quarto.GetNumero() + ", Capacidade: " + quarto.GetCapacidade() + ", Preço: " + quarto.GetPrecoBase());
            }
        }

        // Métodos para gerir as Reservas

        // Adiciona uma nova reserva para um hóspede num quarto específico por um número de noites
        public void AdicionarReserva(string hospede, int numeroQuarto, int noites)
        {
            Quarto quarto = GetQuarto(numeroQuarto);  // Busca o quarto pelo número fornecido
            if (quarto == null)
            {
                Console.WriteLine("Quarto número " + numeroQuarto + " não encontrado.");  // Caso o quarto não exista
                return;  // Termina o método
            }

            // Cria a reserva e adiciona à lista de reservas
            Reserva novaReserva = new Reserva(_listaReservas.Count + 1, quarto, hospede, noites);
            _listaReservas.Add(novaReserva);
            Console.WriteLine("Reserva para o quarto " + numeroQuarto + " realizada com sucesso para " + hospede + " por " + noites + " noites");  // Mensagem de sucesso
        }

        // Lista todas as reservas realizadas
        public void ListarReservas()
        {
            if (_listaReservas.Count == 0)
            {
                Console.WriteLine("Não há reservas registadas.");  // Mensagem caso não haja reservas
                return;
            }

            Console.WriteLine("Lista de Reservas:");
            foreach (var reserva in _listaReservas)
            {
                // Exibe informações sobre a reserva, como ID, número do quarto, hóspede, número de noites e valor total
                Console.WriteLine("- Id: " + reserva.GetIdReserva() + ", Quarto: " + reserva.GetQuarto()?.GetNumero() + ", Hóspede: " + reserva.GetHospede() + ", Noites: " + reserva.GetNoites() + ", Valor: " + reserva.GetValorTotal());
            }
        }

        // Método para listar os quartos disponíveis, ainda a ser implementado
        public void ListarQuartosDisponiveis()
        {
            // Implementar lógica para listar quartos disponíveis

            foreach (var quarto in _listaQuartos)
            {
                // aqui percorre todos os quartos...
                bool quartoDisponivel = true;
        
                foreach (var reserva in _listaReservas)
                {
                    // percurrer a lista de reservas , 
                    if (reserva.GetQuarto() == quarto) // se o quarto da lista e o mesmo da reserva
                    {
                        quartoDisponivel = false;
                        break;
                    }
                        
                }

                //antes de salatar para outro quarto devo escrever no ecra
                if (quartoDisponivel == true)
                {
                    Console.WriteLine("o quarto " + quarto.GetNumero() + " esta disponivel capacidade:"+quarto.GetCapacidade()+" preco base: "+quarto.GetPrecoBase());
                }
               


            }


        }
    }
}
