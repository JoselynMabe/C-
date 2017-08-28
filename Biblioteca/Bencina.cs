using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Bencina:Vehiculo,IVehiculo
    {
        public TipoOctanaje Octanaje { get; set; }
        private int _mantencion;

        public int Mantencion
        {
            get { return _mantencion; }
            set {
                if (value>=1 && value<=4)
                {
                    _mantencion = value;
                }
                else
                {
                    throw new ArgumentException("mantencion entre 1 y 4 meses");
                }                
            }
        }
        public Bencina():base()
        {
            Octanaje = TipoOctanaje.o97;
            Mantencion = 1;
        }
        public Bencina(string pat, string col, DateTime ff, int kxl, Dueno d,
            TipoOctanaje tipooct,int man):base(pat,col,ff,kxl,d)
        {
            Octanaje = tipooct; Mantencion = man;            
        }

        public int ValorxKilometro()
        {
            int valor = 0;
            switch (Octanaje)
            {
                case TipoOctanaje.o97:
                    valor = 735;
                    break;
                case TipoOctanaje.o95:
                    valor = 720;
                    break;
                case TipoOctanaje.o93:
                    valor = 710;
                    break;
                default:
                    break;
            }
            return valor;
        }
    }
}
