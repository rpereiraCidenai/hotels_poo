using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
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
            _quarto = quarto  ;
            _hospede = hospede ;

            _noites = noites;
            CalcularTotal(); // Calcula o valor total no construtor
        }

        public int GetIdReserva() // devolve id da reserva
        {
            return _idReserva;
        }

        public void SetIdReserva(int idReserva) //alterar ou criar id resrva
        {
         
            _idReserva = idReserva;
        }

        public Quarto GetQuarto() // devolve quarto relativo a esta reserva
        {
            return _quarto;
        }

        public void SetQuarto(Quarto quarto) //altera ou grava quarto relativo a reserva 
        {
            _quarto = quarto ;
        }

        public string GetHospede() // devovle hospoedo alojado nesta reserva
        {
            return _hospede;
        }

        public void SetHospede(string hospede) // faz set do hospede 
        {
            _hospede = hospede;
        }

        public int GetNoites()
        {
            return _noites;
        }

        public void SetNoites(int noites) //armazena numero noties 
        {
            if (noites > 0)
            {
                _noites = noites;
                CalcularTotal();//Recalcula o valor total

            }
            
        }
        public double GetValorTotal()
        {
            return _valorTotal;
        }
        // Removido o SetValorTotal

        private void CalcularTotal() // solicita ao quarto o valor total e devovle
        {
            _valorTotal = _quarto.CalcularPrecoTotal(_noites);
        }

    }
}
