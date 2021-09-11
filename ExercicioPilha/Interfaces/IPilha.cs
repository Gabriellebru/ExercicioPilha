using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPilha.Interfaces
{
    public interface IPilha<T>
    {
        public void Empilha(T codigo);
        public T Desempilha();
        public T Topo();
        public int Tamanho();
        public IEnumerable<T> RetornaTodosElementos();
        public bool PilhaVazia();

    }
}
