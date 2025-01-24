using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Quarto
    {

        private int _numero; // para armazenar numero do quarto
        private int _capacidade; // para a capacidade " ou seja numero de pessoas max a dormir no quarto"
        private double _precoBase; // preço por noite 


        public int GetNumero() // para obter o numero do quarto 
        {
            return this._numero;
        }
        public void SetNumero(int numero) //para  inserir o numero do quarto 
        {
            this._numero = numero;
        }
        public int GetCapacidade()//para obter a capacidade do quarto 
        {
            return _capacidade;
        }
        public void SetCapacidade(int capacidade) // para inserir a capacidade max do quarto
        {
            this._capacidade = capacidade;
        }
        public double GetPrecoBase() //para obter o preço por noite
        {
            return this._precoBase;
        }
        public void SetPrecoBase(double precoBase) // para inserir ou alterar o preço por noite
        {
            this._precoBase = precoBase;
        }
        public virtual double CalcularPrecoTotal(int noites) // permite calcular preco total noites*preçoPorNoite
        {
            return noites * _precoBase;
        }

        public Quarto(int numero, int capacidade, double precoBase) // construtor
        {
            _numero = numero;
            _capacidade = capacidade;
            _precoBase = precoBase;
        }

        public Quarto()// Construtor vazio para permitir inserçao de objetos iguais.
        {
        }
    }
}
