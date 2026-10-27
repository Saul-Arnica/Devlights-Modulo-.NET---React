using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;

namespace TipoDeDatos;

public class  Programa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Span<int> spanEnteros = new Span<int>(new int[5]);
        // uso local de spanEnteros aquí
    }

    sbyte sbytecito = 10;// el tamaño es de 8bits va de -128 a 127
    byte bite = 10;// el tamaño es de 8bits va de 0 a 255
    short shortcito = 10;// el tamaño es de 16bits va de -32,768 a 32,767
    ushort ushortcito = 10;// el tamaño es de 16bits va de 0 a 65,535 (sin signo -)
    int entero = 10;// el tamaño es de 32bits va de -2,147,483,648 a 2,147,483,647
    uint enteroSinSigno = 10;// el tamaño es de 32bits va de 0 a 4,294,967,295
    nint enteroNativo = 10;/*
                            * el tamaño es de 32bits o 64bits dependiendo de la plataforma va de -2,147,483,648 a 2,147,483,647 
                            * o -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
                            * tiene interoperabilidad con punteros y puede ser usado para representar direcciones de memoria
                            */
    nuint enteroNativoSinSigno = 10;/*
                                * el tamaño es de 32bits o 64bits dependiendo de la plataforma va de 0 a 4,294,967,295 
                                * o 0 a 18,446,744,073,709,551,615
                                * tiene interoperabilidad con punteros y puede ser usado para representar direcciones de memoria
                                */

    long enteroLargo = 10;// el tamaño es de 64bits va de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807
    ulong enteroLargoSinSigno = 10;// el tamaño es de 64bits va de 0 a 18,446,744,073,709,551,615
    float puntoFlotante1 = 10.5f;// el tamaño es de 32bits va de ±1.5 x 10−45 a ±3.4 x 1038
    double puntoFlotante2 = 10.5;// el tamaño es de 64bits va de ±5.0 × 10−324 a ±1.7 × 10308
    decimal decimal1 = 10.5m;// el tamaño es de 128bits va de ±1.0 x 10−28 a ±7.9 x 1028
    bool booleano = true;// el tamaño es de 1bit va de true o false
    char caracter = 'a';// el tamaño es de 16bits, puede almacenar un caracter o una palabra
    string cadena = "Hola Mundo";/* el tamaño es de 16bits, puede almacenar una cadena de caracteres con longitud variable, no es
                                  * primitivo, es una clase que representa una secuencia de caracteres(tipo char) Unicode 
                                  * y proporciona métodos para manipular cadenas de texto
                                  */
    /*---------------------------------------------------------------------------------------------------------------------------------*/
    //Arreglos
    //Son de tamaño fijo, se definen con corchetes y se accede a sus elementos mediante un índice, el primer elemento tiene índice 0.
    //Tipos:
    int[] arregloEnterosUnidimencional = new int[5];// arreglo de enteros de tamaño 5 unidimencional.
    int[,] arregloEntrerosMultidimencional = new int[5, 5];// arreglo de enteros de tamaño 5x5 multidimencional (Matrices)
                                                           //  siempre con [,] al principio
    int[][] arregloEnterosEscalonados = new int[5][];// arreglo de enteros de tamaño 5x5 jagged(escalonados) o (arreglo de arreglos)
                                                     // siempre con [][] al principio
    /*---------------------------------------------------------------------------------------------------------------------------------*/
    //Colecciones
    //Viven dentro de System.Collections.Generic, son dinámicas, fuertemente tipadas y permiten almacenar elementos de un tipo específico.
    //Se pueden agregar o eliminar elementos, no tienen un tamaño fijo y se accede a sus elementos mediante un índice.(solo aceptan un tipo de dato)
    //Tipos:
    
    //List<T> es una colección genérica que permite almacenar elementos de un tipo 'T' específico
    List<int> listaEnteros = new List<int>();// lista de enteros

    //Dictionary<TKey, TValue> es una colección genérica que permite almacenar pares de clave-valor
    //Donde 'TKey' es el tipo de la clave y 'TValue' es el tipo del valor
    Dictionary<string, int> diccionarioEnteros = new Dictionary<string, int>();// diccionario de enteros con clave string y valor int

    //HashSet<T> es una colección genérica que permite almacenar elementos de un tipo 'T' específico, pero no permite elementos duplicados
    HashSet<int> conjuntoEnteros = new HashSet<int>();// conjunto de enteros

    //Queue<T> es una colección genérica que permite almacenar elementos de un tipo 'T' específico,
    //pero sigue el principio FIFO (First In First Out), es decir, una COLA.
    Queue<int> colaEnteros = new Queue<int>();// cola de enteros

    //Stack<T> es una colección genérica que permite almacenar elementos de un tipo 'T' específico,
    //pero sigue el principio LIFO (Last In First Out), es decir, una PILA.
    Stack<int> pilaEnteros = new Stack<int>();// pila de enteros

    //LinkedList<T> es una colección genérica que permite almacenar elementos de un tipo 'T' específico,
    //Son listas doblemente enlazadas, no almacenan de forma contigua los datos y las inserciones y eliminaciones son más rápidas que en una lista,
    //pero el acceso a los elementos es más lento, los elementos se almacenan en nodos que contienen referencias al nodo anterior y al siguiente.
    //El primer nodo se llama Head y el último nodo se llama Tail, el nodo que apunta a null es el último nodo.
    LinkedList<int> listaEnlazadaEnteros = new LinkedList<int>();// lista enlazada de enteros
    /*---------------------------------------------------------------------------------------------------------------------------------*/
    //Colecciones avanzadas
    //Concurrentes: Se encuentran dentro de System.Collections.Concurrent, diseñadas para ser "Thread-Safe" (Seguras para el uso en múltiples hilos),
    //Permiten el acceso concurrente a los elementos de la colección sin necesidad de bloquear el acceso a la misma.
    //Tipos:

    //Diccionario concurrente de enteros con clave string y valor int
    ConcurrentDictionary<string, int> diccionarioConcurrenteEnteros = new ConcurrentDictionary<string, int>();
    
    //Cola concurrente de enteros
    ConcurrentQueue<int> colaConcurrenteEnteros = new ConcurrentQueue<int>();

    //Bolsa concurrente de enteros
    ConcurrentBag<int> bolsaConcurrenteEnteros = new ConcurrentBag<int>();

    //ReadOnlyCollection son "envolturas" que bloquean una lista para que el resto del código no pueda modificarla, pero si puede leerla.
    ReadOnlyCollection<int> coleccionSoloLecturaEnteros = new ReadOnlyCollection<int>(new List<int>());// colección de enteros solo lectura

    //Span y Memory son "ventanas" que permiten leer o modificar secciones de arreglos sin crear copias en memoria.
    Memory<int> memEnteros = new Memory<int>(new int[5]);//  Memory de enteros (sirve dentro de métodos asíncronos y dentro de clases normales)
    //Span vive unicamente dentro de el Stack(la memoria temporal y ultrarapida de la CPU) y no puede vivir dentro de clases normales, solo dentro de métodos síncronos.
    //Un ejemplo de uso:
    // Cuando necesitas modificar los datos rápido, siempre hacerlo dentro de un método:
    public void MiCambioRapido()
    {
        Span<int> ventana = memEnteros.Span;
        ventana[0] = 100;
    }
   Memory<int> miMemoria = new int[5];
    //O
    public void MiCambioRapido2()
    {
        Span<int> ventana = miMemoria.Span;
        ventana[0] = 100;
    }
    
    //O
    public void MiMetodoRapido()
    {
        //Cuando creo un Span sobre un arreglo (El arreglo va al Heap, el Span va al Stack)
        Span<int> ventanaArreglo = new int[5];

        // Usamos el 'stackalloc' para evitar el Heap por completo
        // Esto crea el espacio directamente en la memoria caché del procesador/Stack.
        Span<int> ventanaUltraRapida = stackalloc int[5];

        ventanaUltraRapida[0] = 100;
    }

    //De otra forma explicado con IA:
    public class EjemplosMemoria
    {
        // Span y Memory son "ventanas" que permiten leer o modificar secciones de arreglos sin crear copias en memoria.

        // 1. Memory de enteros (sirve a nivel de clase y en métodos asíncronos)
        Memory<int> memEnteros = new Memory<int>(new int[5]);

        // (Sintaxis alternativa más corta para hacer exactamente lo mismo)
        Memory<int> miMemoria = new int[5];

        // Span vive únicamente dentro del Stack (memoria temporal y ultrarrápida) 
        // y no puede vivir como campo de clase, solo dentro de métodos (síncronos).

        // --- EJEMPLOS DE USO ---

        // Ejemplo A: Cuando necesitas modificar los datos de Memory rápido, lo conviertes a Span dentro del método
        public void MiCambioRapido()
        {
            Span<int> ventana = memEnteros.Span;
            ventana[0] = 100;
        }

        public void MiCambioRapido2()
        {
            Span<int> ventana = miMemoria.Span;
            ventana[0] = 100;
        }

        // Ejemplo B: Creación directa de Spans (sin pasar por Memory)
        public void MiMetodoRapido()
        {
            // Opción 1: Creo un Span sobre un arreglo nuevo. (El arreglo va al Heap, el Span va al Stack)
            Span<int> ventanaArreglo = new int[5];

            // Opción 2: Usamos 'stackalloc' para evitar el Heap por completo.
            // Esto crea el espacio de los 5 enteros directamente en la memoria caché/Stack. ¡Rendimiento extremo!
            Span<int> ventanaUltraRapida = stackalloc int[5];
            ventanaUltraRapida[0] = 100;
        }
    }
    

}