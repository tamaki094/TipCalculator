using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

namespace TipCalculator
{
    public class TipModel : INotifyPropertyChanged
    {
       

        public TipModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
        private decimal _Total ;
        private int _Propina;
        private int _NoPersonas;
        private decimal _TotalPropina;
        private decimal _TotalConPropina;
        private decimal _PropinaPorPersona;
        private decimal _TotalPorPersona;

        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        public int Propina
        {
            get { return _Propina; }
            set { _Propina = value; }
        }
        public int NoPersonas
        {
            get { return _NoPersonas; }
            set { _NoPersonas = value; }
        }
        public decimal TotalPropina
        {
            get { return _TotalPropina; }
            set { _TotalPropina = value; OnPropertyChanged(); }
        }
        public decimal TotalConPropina
        {
            get { return _TotalConPropina; }
            set { _TotalConPropina = value; OnPropertyChanged(); }
        }
        public decimal PropinaPorPersona
        {
            get { return _PropinaPorPersona;  }
            set { _PropinaPorPersona = value; OnPropertyChanged(); }
        }
        public decimal TotalPorPersona
        {
            get { return _TotalPorPersona; }
            set { _TotalPorPersona = value; OnPropertyChanged(); }
        }



    }
}
