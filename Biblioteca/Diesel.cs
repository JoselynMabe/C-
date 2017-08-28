using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Diesel:Vehiculo,IVehiculo
    {
        public TipoCaja CajadeCambio { get; set; }
        private int _capacidadEstanque;

        public int Estanque
        {
            get { return _capacidadEstanque; }
            set {
                if (value>=40 && value<=80)
                {
                    _capacidadEstanque = value;
                }
                else
                {
                    throw new ArgumentException("capacidad estanque entre 40 y 80 litros");
                }                
            }
        }
        public Diesel():base()
        {
            CajadeCambio = TipoCaja.Automatica;
            Estanque = 45;
        }
        public Diesel(string pat, string col, DateTime ff, int kxl, Dueno d,
            TipoCaja caja,int estan):base(pat,col,ff,kxl,d)
        {
            CajadeCambio = caja; Estanque = estan;
        }

        public int ValorxKilometro()
        {
            switch (CajadeCambio)
            {
                case TipoCaja.Automatica:
                    return 500;                    
                case TipoCaja.Mecanica:
                    return 400;                    
                default:
                    break;
            }
            return 0;
        }
    }
}
