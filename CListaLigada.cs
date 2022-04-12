using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
    class CListaLigada
    {
        //ES el acla o encabezado de la lista
        private CNodo ancla;

        //Esta variable de referencia nos ayuda trabajar con la lista
        private CNodo trabajo;

        //esta variable de referencia, apoya en ciertas operaciones de la lista 
        private CNodo trabajo2;

        public CListaLigada()
        {
            //Instanciamos el ancla
            ancla = new CNodo();

            //Como es una lista vacía, su siguiente es null
            ancla.Siguiente = null;

        }

        //Recorre la lista 
        public void Transversa()
        {
            //Trabajo al inicio
            trabajo = ancla;

            //Recorremos hasta encocntrar el final
            while(trabajo.Siguiente!= null)
            {
                trabajo = trabajo.Siguiente; //Avanzamos trabajo
                //Obtenemos el dato y lo mostramos
                int d = trabajo.Dato; 
                Console.WriteLine("{0}, ", d);
            }

            //Bajamos la línea
            Console.WriteLine();
        }

        //Adicionar un nuevo elemento
        public void Adicionar(int pDato)
        {
            //Trabajo al inicio
            trabajo = ancla;

            //Recorremos hasta encontrar el final
            while(trabajo.Siguiente!= null)
            {
                //Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            //Creamos el nuevo nodo
            CNodo temp = new CNodo();

            //Insertamos el dato
            temp.Dato = pDato;

            //Finalizamos correctamente
            temp.Siguiente = null;

            //ligamos el ultimo nodo encontrado con el recién creado
            trabajo.Siguiente = temp;
        }
    }
}
