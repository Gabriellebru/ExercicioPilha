using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPilha.Entidades
{
    public class Container
    {
        int codigo;

        public Container(int Codigo)
        {
            codigo = Codigo;
        }

        public int PegaCodigo()
        {
            return codigo;
        }
    }
}
