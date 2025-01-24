using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class QuartoLuxo:Quarto
    {
        private Boolean _temJacuzzi;
        private Boolean _temVistaMar;

        public Boolean GetTemJacuzzi()
        {
            return _temJacuzzi;
        }
        public void SetTemJacuzzi(Boolean temJacuzzi)
        {
            this._temJacuzzi = true;
        }
        public Boolean GetTemVistaMar()
        {
            return this._temVistaMar;
        }
        public void SetTemVistaMar(Boolean temVistaMar)
        {
            this._temVistaMar = true;
        }
        public override double CalcularPrecoTotal(int noites)
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
        public QuartoLuxo(int numero, int capacidade, double precoBase, bool temJacuzzi, bool temVistaMar) : base(numero, capacidade, precoBase)
        {
            _temJacuzzi = temJacuzzi;
            _temVistaMar = temVistaMar;
        }
    }
}
