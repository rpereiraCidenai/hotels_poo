using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class QuartoLuxo:Quarto
    {
        private Boolean _temJacuzzi; // verdadeiro-"true" quando tem jacuzzi 
        private Boolean _temVistaMar; // verdadeiro-"true" quanto tem vista para o mar 


        public Boolean GetTemJacuzzi() // permite obter se tem ou nao jacuzzi true="tem jacuzzi"
        {
            return _temJacuzzi;
        }
        public void SetTemJacuzzi(Boolean temJacuzzi)// permite inserir ou alterar se tem jacuzzi  "true= tem jacuzzi "
        {
            this._temJacuzzi = true;
        }
        public Boolean GetTemVistaMar()// permite obter se tem ou nao vista para o mar true="tem vista para o mar "
        {
            return this._temVistaMar;
        }
        public void SetTemVistaMar(Boolean temVistaMar) // permite inserir ou alterar se tem vista para o mar "true= tem vista para o mar "
        {
            this._temVistaMar = true;
        }
        public override double CalcularPrecoTotal(int noites) //override para subscrever o metodo calcular preçobase da classe mae , visto que quando tem vista para o mar ou jacuzzi e calculado de forma diferente. 
        {
            double precoDeBase = noites * this.GetPrecoBase();

            if (_temJacuzzi == true)
            {
                precoDeBase = (precoDeBase * 1.10);

            }
            if (_temVistaMar == true)
            {
                precoDeBase = (precoDeBase * 1.20);

            }
            return precoDeBase;
        }
        public QuartoLuxo(int numero, int capacidade, double precoBase, bool temJacuzzi, bool temVistaMar) : base(numero, capacidade, precoBase) // construtor para inserir quartoluxo com herança do quarto.
        {
            _temJacuzzi = temJacuzzi;
            _temVistaMar = temVistaMar;

            
        }

        public QuartoLuxo(int numero, int capacidade, double precoBase) : base(numero, capacidade, precoBase) // construtor vazio.
        {
        }
    }
}
