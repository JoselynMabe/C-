using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Dueno
    {
        private string _rut;
        private string _nombre;
        private TipoSexo _sexo;

        public string Rut
        {
            get { return _rut; }
            set {

                _rut = value;
            }
        }        
        public string Nombre
        {
            get { return _nombre; }
            set {
                if (value.Split(' ').Length>=2)
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("deben ser 2 palabras");
                }
                
            }
        }        
        public TipoSexo Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }
        public Dueno()
        {
            Rut = "11111111-1";
            Nombre = "Sin Nombre";
            Sexo = TipoSexo.Femenino;
        }
        public Dueno(string rut,string nom,TipoSexo sex)
        {
            Rut = rut;Nombre = nom;Sexo = sex;
        }

    }
}
