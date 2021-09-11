using ExercicioPilha.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioPilha.Entidades
{
    public class PilhaEstatica<T> : IPilha<T>
    {
        private T[] VetorElementos;
        private int TamanhoMaximo = 30;
        private int Indice;

        //public PilhaEstatica()
        //{
        //    VetorElementos = new T[TamanhoMaximo];
        //    Indice = 0;
        //}

        public PilhaEstatica(int tamanhoMaximo)
        {
            if (tamanhoMaximo < 0)
                throw new ArgumentException("tamanhoMaximo", "Tamanho não pode ser menor ou igual a zero");

            TamanhoMaximo = tamanhoMaximo;
            VetorElementos = new T[TamanhoMaximo];
            Indice = 0;
        }

        public T Desempilha()
        {
            if (PilhaVazia())
                throw new InvalidOperationException("Pilha Vazia, operação não pode ser realizada");

            return VetorElementos[--Indice];
        }

        public void Empilha(T obj)
        {
            if (Indice == TamanhoMaximo)
                throw new InvalidOperationException("Pilha Cheia, operação não pode ser realizada");

            VetorElementos[Indice] = obj;
            Indice++;
        }

        public IEnumerable<T> RetornaTodosElementos()
        {
            for (int i = Indice - 1; i >= 0; i--)
            {
                yield return VetorElementos[i];
            }
        }

        public int Tamanho()
        {
            return Indice;
        }

        public T Topo()
        {
            if (PilhaVazia())
                throw new InvalidOperationException("Exceção: Pilha Vazia");

            return VetorElementos[Indice - 1];
        }

        public bool PilhaVazia()
        {
            return Indice == 0;
        }
    }
}
