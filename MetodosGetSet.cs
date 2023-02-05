using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLogicProgramacion
{
    class MetodosGetSet
    {
        private String nombre, ciudad, edad;

        public void setNombre(String n)//captura el nombre
        {
            nombre = n;//lo guarda en una variable
        }

        public String getNombre() //retorna el nombre mostrandolo en pantalla
        {
            return nombre;        
        }

        public void setCiudad(String p)
        {
            ciudad = p;
        }

        public String getCiudad()
        {
            return ciudad;
        }

        public void setEdad(String p)
        {
            edad = p;
        }

        public String getEdad()
        {
            return edad;
        }


    }
}
