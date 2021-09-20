using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumno
{
    class NodoC
    {
        private int numero;
        private string materia;
        private string calificacion;
        private NodoC siguienteCal;
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public string Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }
        public NodoC SiguienteCal
        {
            get { return siguienteCal; }
            set { siguienteCal = value; }
        }
        public NodoC()
        {
            numero = 0;
            materia = "";
            calificacion = "";
            siguienteCal = null;
        }
        public NodoC(int num, string m, string c)
        {
            numero = num;
            materia = m;
            calificacion = c;
            siguienteCal = null;
        }
        public override string ToString()
        {
            return numero + materia + calificacion;
        }
    }
}
