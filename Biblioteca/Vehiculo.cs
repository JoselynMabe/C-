using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vehiculo
    {
        #region campos
        private string _patente;
        private string _color;
        private DateTime _fechaFabricacion;
        private int _kxLitro;
        private Dueno _dueño;
        #endregion

        #region propiedades
        public Dueno Dueño
        {
            get { return _dueño; }
            set { _dueño = value; }
        }
        public int KxLitro
        {
            get { return _kxLitro; }
            set {
                if (value>=1 && value<=15)
                {
                    _kxLitro = value;
                }
                else
                {
                    throw new ArgumentException("kilometros por litro entre 1 y 15");
                }                
            }
        }
        public DateTime FechaFabricacion
        {
            get { return _fechaFabricacion; }
            set {
                if (value >=new DateTime(1980,1,1) && value<=DateTime.Now.Date)
                {
                    _fechaFabricacion = value;
                }
                else
                {
                    throw new ArgumentException("fecha entre 1-1-1980 y actual");
                }
                
            }
        }
        public string Color
        {
            get { return _color; }
            set {
                if (value.Trim().Length>=3)
                {
                    _color = value;
                }
                else
                {
                    throw new ArgumentException("largo minimo 3 caracteres en color");
                }
                
            }
        }
        public string Patente
        {
            get { return _patente; }
            set {
                if (value.Trim().Length==6)
                {
                    _patente = value;
                }
                else
                {
                    throw new ArgumentException("patente de largo 6");
                }                
            }
        }
        #endregion

        public Vehiculo()
        {
            Patente = "xxxx99";
            Color = "Negro";
            FechaFabricacion = new DateTime(1980,1,1);
            KxLitro = 5;
            Dueño = new Dueno();
        }
        public Vehiculo(string pat,string col,DateTime ff,int kxl, Dueno d)
        {
            Patente = pat;
            Color = col;
            FechaFabricacion = ff;
            KxLitro = kxl;
            Dueño = d;
        }
        public int Años(){
            return DateTime.Now.Year - FechaFabricacion.Year;
        }
        public string Imprimir() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente  :" + Patente);
            sb.AppendLine("Color    :" + Color);
            sb.AppendLine("Fecha Fab:" + FechaFabricacion);
            sb.AppendLine("K x Litro:" + KxLitro);
            sb.AppendLine("Nombre Dueño:" + Dueño.Nombre);
            return sb.ToString();
        }
    }
}
