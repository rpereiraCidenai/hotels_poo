using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Quarto
    {
        private int _numero;
        private int _capacidade;
        private double _precoBase;

        public int GetNumero()
        {
            return this._numero;
        }
        public void SetNumero(int numero)
        {
            this._numero = numero;
        }
        public int GetCapacidade()
        {
            return _capacidade;
        }
        public void SetCapacidade(int capacidade)
        {
            this._capacidade = capacidade;
        }
        public double GetPrecoBase()
        {
            return this._precoBase;
        }
        public void SetPrecoBase(double precoBase)
        {
            this._precoBase = precoBase;
        }
        public virtual double CalcularPrecoTotal(int noites)
        {
            return noites * _precoBase;
        }

        public Quarto(int numero, int capacidade, double precoBase)
        {
            _numero = numero;
            _capacidade = capacidade;
            _precoBase = precoBase;
        }
    }
}
