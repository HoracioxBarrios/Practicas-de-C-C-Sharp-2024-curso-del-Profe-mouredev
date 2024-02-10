using System;// espacio de nombre System que tiene clases y metodos que se pueden usar en este caso el metodo Console

namespace AplicacionDeConsola // espaco de nombre que creamos (el nuestro)
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola C# 2024"); //si no incluyesemos el 'using System' tendrimos que escribir: System.Console.WriteLine()
                                               // para comentar en una linea se usa doble barra así.

            /*para
             comentar
            multilinea
            se usa la barra y el asterisco
            así.
            
            Algo importante es que lo que se comenta no es tomado por 
            el compilador como codigo, sino que lo ignora
            */

            //---------------------------- TIPOS DE DATOS ----------------------------
            //---------------------------- TIPOS DE DATOS ---------------------------- 
            //---------------------------- TIPOS DE DATOS ---------------------------- 


            // ----- TIPO DE DATO CADENA DE CARACTERES string -----
            string myString = "Esto es una cadena de texto";
            Console.WriteLine(myString);
            myString = "Cambio el texto en esta linea";
            Console.WriteLine(myString);



            //----- TIPO DE DATO PARA NUMEROS ENTEROS int -----
            int myInt = 7;
            myInt = myInt + 4;
            Console.WriteLine(myInt);// aca vale 11
            Console.WriteLine(myInt - 1);// en tiempo de ejecucion muestra 10, pero nose modifica el valor de la variable realmente
            Console.WriteLine(myInt);// aca vale 11 


            //----- TIPOS DE DATOS PARA NUMEROS FLOTANTES -----
             
            float myFloat = 1.5F;// se usa sufijo F al final para representar un float [longitud menor]
            Console.WriteLine(myFloat);

            double myDouble = 1.5; // [tiene una longitud mayor] es recomandable usar este en su lugar
            Console.WriteLine(myDouble);


            // #OPERACIONES:

            Console.WriteLine(myDouble + myFloat + myInt);// se puede operar porque c# trata a todos como datos numericos


            //----- TIPO DE DATO dynamic -----

            dynamic myDynamic = "Hola";
            Console.WriteLine(myDynamic);// "hola"
            myDynamic = 50;
            Console.WriteLine(myDynamic);// 50
            /* no es recomendable usar dynamyc, porque si uno quiere hacer una 
             operacion con esta variable tendria que estar comprobando que tipo de 
            dato tiene dentro, para hacer dicha operacion*/


            // ----- PALABRA RESERVADA var -----
            var myVar1 = "es una nueva cadena de texto";
            Console.WriteLine(myVar1);
            /*
             * var infiere el tipo de dato en este caso que es string
             
             * Es importante tener en cuenta que la inferencia de tipo con var no 
             * significa que la variable sea de un tipo dinámico. El tipo de dato 
             * se determina en tiempo de compilación, y una vez que la variable ha 
             * sido declarada e inicializada, su tipo es fijo.
             */


            //myString2 = 150; // esto da el siguiente error:

            /*Gravedad	Código	Descripción	Proyecto	Archivo	Línea	Estado suprimido
            Error	CS0029	No se puede convertir implícitamente el tipo 
            'int' en 'string'	AplicacionDeConsola	C:\Users\xxxxxx\Desktop\Practicas_C_Sharp\1_practicas de curso de mouredev\AplicacionDeConsola\AplicacionDeConsola\Program.cs	75	Activo
*/
            var myVar2 = 100;
            Console.WriteLine(myVar2.GetType()); //System.Int32 ----- aca usamos GetType() que es un metodo que viene de la clase base  System.Object la cual heredan todos los tipos de referencia (clases) y en cuanto a los tipos de valor struct no heredan directamente de object sino que se implementa la interfaz System.ValueType la cual a su vez deriva de System.Object .

            Console.WriteLine(myVar1.GetType()); //System.String

            //myvar1 = 1.5; //da [error]  porque no se puede cambiar el tipo de dato cuando ya se ha inferido arriba en tiempo de ejecucion.
            

            // ----- Tipo de dato Bool -----
            bool myBool = false;

            myBool = true;

            //---------------------------- ******* ---------------------------- 
            //---------------------------- ******* ---------------------------- 
            //---------------------------- ******* ---------------------------- 

            // ----- INTERPOLACION DE STRING -----
            Console.WriteLine($"El valor de mi Entero es {myInt} y el valor de mi boolean es {myBool}");

            // ----- CONSTANTE -----
            const string MyConstante = "Mi constante";// en UpperCamelCase !!!
            Console.WriteLine(MyConstante);



            //---------------------------- ESTRUCTURAS ----------------------------
            //---------------------------- ESTRUCTURAS ----------------------------
            //---------------------------- ESTRUCTURAS ---------------------------- 

            //****** ARRAY ***** 

            //los arrays (Empiezan en la posicion 0 , 1, 2, 3, 4,etc, hasta la longitud que definamos en la creacion del mismo y dicha longitud no se puede cambiar mas)

            /*
            //Esto da error!

            var myArray = ["Hora", "Barrios", "Practica"];
            Console.WriteLine(myArray);

            //Esto da error!

            var myArray = ["Hora", "Barrios", "Practica"];
            Console.WriteLine(myArray[0]);

            //Esto da error!

            var myArray = new string["Hora", "Barrios", "Practica"];
            Console.WriteLine(myArray[0]);
            */


            /* asi seria correcto (instanciar el array, agregamos los elementos harcodeados )
               y conseguir el primer elemento del array.
            */

            // En C# hay que crearlo con la palabra reservada NEW
            var myArray = new string[] { "Hora", "Barrios", "Practica" };
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray);// no sale esto: System.String[]
            /*
            //Esto da error!
            myArray[3] = "Agregame este string";
            Console.WriteLine(myArray[3]);

            Cuando creamos un ARRAY tenemos que definirle la longitud y esta es inalterable!
            por lo tanto ya no podemos agregar mas elementos.
            */

            myArray[2] = "Practicamos"; // SÍ podemos modificar un elemento existente
            Console.WriteLine(myArray[2]);

            /*
            //Esto da error!
            myArray[2] = 30; // No podemos agregar un tipo de dato distinto al tipo de array creado, ya que en este caso es un arrays de strings
          
            Console.WriteLine(myArray[2]);           

            */
            /*
             Dato extra:-
             */

            //****** DICTIONARY O DICCIONARIOS ***** 
            var myDictionary = new Dictionary<string, int>
            {
                {"Julia", 36 }, // clave en string , valor en entero
                {"Alberto", 65 },
                {"Luis", 15 }
            };
            Console.WriteLine(myDictionary["Alberto"]);// accedemos al diccionario por su clave aca.
            Console.WriteLine(myDictionary);//nos sale esto: System.Collections.Generic.Dictionary`2[System.String,System.Int32]



            var myDictionary2 = new Dictionary<string, int> { };

            // Agregar elementos al diccionario
            myDictionary2.Add("horacio", 38);
            myDictionary2.Add("cintia", 36);
            myDictionary2.Add("mitagi", 58);



            // Acceder a elementos del diccionario
            Console.WriteLine($"el valor de la clave 'horacio' es: {myDictionary2["horacio"]}");

            //recorrer los elementos del diccionario

            foreach(var kvp in myDictionary2)
            {
                Console.WriteLine($"La Clave {kvp.Key} tiene un Valor de {kvp.Value}");
            }

            /*
             
            La variable kvp es una convención comúnmente utilizada en C# y en otros 
            lenguajes para referirse a un par clave-valor (Key-Value Pair, en inglés) 
            dentro de un diccionario. kvp es simplemente un acrónimo que 
            representa "Key-Value Pair". Esta convención es bastante común y ayuda a 
            que el código sea más legible y comprensible.
             */


            /*
             
             ------ DATO ------: 
            
            La elección entre usar un bucle foreach y un bucle for depende de la 
            estructura de datos que estás recorriendo y de tus preferencias personales 
            en términos de legibilidad y conveniencia.

            * Aquí hay algunas consideraciones para elegir entre foreach y for:

            -------- Foreach:

            Sintaxis simplificada: El bucle foreach proporciona una sintaxis más 
            simple y directa para recorrer colecciones, como matrices, listas, 
            diccionarios y otros tipos que implementan la interfaz IEnumerable.

            Estructura de datos complejas: Es especialmente útil cuando 
            estás trabajando con estructuras de datos complejas, como diccionarios 
            o listas, donde necesitas acceder tanto a la clave como al valor 
            (como en el caso de un diccionario).



            -------- For:

            Control de índice explícito: El bucle for es útil cuando necesitas un 
            control explícito sobre el índice, como cuando recorres una matriz o 
            una colección basada en índices numéricos.

            Iteración personalizada: Si necesitas una iteración más compleja, 
            como un incremento personalizado, iteraciones inversas, o alguna 
            lógica de control de flujo más avanzada, el bucle for puede ser más apropiado.





            En resumen, el bucle foreach es conveniente cuando necesitas 
            recorrer elementos en una colección de manera simple y cuando no 
            necesitas controlar explícitamente los índices. Sin embargo, si 
            necesitas un control más granular sobre el índice o si la lógica 
            de iteración es más compleja, un bucle for puede ser más apropiado. 
            En el caso de los diccionarios, donde quieres acceder tanto a la 
            clave como al valor, el foreach es una opción más natural y legible.
             
             */



            //****** SETS *****
            var mySet = new HashSet<string> { "nerd", "moura", "julia" };

            Console.WriteLine(mySet);// nos sale esto: System.Collections.Generic.HashSet`1[System.String]

            //Console.WriteLine(mySet[0]); esto falla porque los sets son estructuras desordenadas

            /*los set no pueden tener elementos duplicados pero cuando se va a hacer el hashset 
             se omiten dichos duplicados*/


            //****** TUPLAS *****
            var myTupla = ("duplicado", "myu", "ele", "duplicado", "esTupla");
            // Console.WriteLine(myTupla[0]); falla porque no tenemos un indexado como tal
            //hay que acceder siempre recorriendolo

            //Console.WriteLine(myTupla);








            //---------------------------- BUCLES ----------------------------
            //---------------------------- BUCLES ----------------------------
            //---------------------------- BUCLES ----------------------------

            // For

            List<string> listaDePalabras = new List<string>
            {
                "Hola", "Buenas", "chau"
            };

                //index inicial = 0;que itere si index es menor a 10; en cada iteracion se incrementa el valor de index en +1
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);// vemos el indice
                //Console.WriteLine(listaDePalabras[index]); // si queremos ver el valor del elemento en ese indice (en esa posicion) de esta manera rompe porque se el for depende de la longitud del indice : if (index < 10)y no de los elmentos. 
                /*Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')*/


            }




            for (int index = 0; index < listaDePalabras.Count();  index++)
            {
                Console.WriteLine(listaDePalabras[index]);// vemos el valor del elemento que esta en la lista en esa posicion indicandole en cada vuelta el indice
            }
            // a diferencia del error arriba marcado, aca le decimos que itere teniendo hasta el ultimo elemento y se detenga con la condicion if(index < listaDePalabras.Count())

            // en lugar de hacer lo que esta aca arriba usando foreach se hace mas facil.

            foreach (var palabra in listaDePalabras)
            {
                Console.WriteLine(palabra);
            }


            // foreach
            // forma de inicializar una lista con elementos

            List<string> listaDePalabras2 = new List<string>
            {
                "Hola", "Buenas", "chau"
            };



            //forma de inicializar una lista, y luego agregarle los elementos 

            //List<string> listaDeälabras2; //Nos da error , porque antes de Add debemos inicializar el objeto list<string> de este caso
            List<string> listaDePalabras3 = new List<string>();


            listaDePalabras3.Add("Hello");
            listaDePalabras3.Add("Buenas noches");
            listaDePalabras3.Add("Buenos dias");

            foreach(var palabra in listaDePalabras2)// var palabra esta variable es de scope limitado solo existe dentro de este for
            {
                Console.WriteLine(palabra);
            }

            foreach(string palabra in listaDePalabras3) // string palabra esta variable es de scope limitado solo existe dentro de este for, y es otra variable distinta a la que existe en el for de arriba.
            {
                Console.WriteLine(palabra);
            }

            // Console.WriteLine(palabra); palabra no existe en este contexto, solo dentro del scope donde fue declarado


            /*
             EN RESUMEN:
             si bien como vimos usando for y foreach se puede recorrer una lista ingresando elemento por elemento
            FOREACH nos ssirve para recorrer estructuras ya formadas de una forma mas optima
             
             */


            // ejemplo recorriendo las diferentes estructuras:
            foreach(var myItem in myArray)
            {
                Console.WriteLine(myItem);
            }


            foreach(var myItem in myDictionary)
            {
                Console.WriteLine(myItem);
            }


            foreach(var myItem in mySet)
            {
                Console.WriteLine(myItem);
            }
            /*
             User
            un set puede tener elementos repetidos?

            ChatGPT:
            En términos generales, un conjunto (set) en matemáticas y en la mayoría de 
            las implementaciones en programación es una colección de elementos distintos, 
            lo que significa que no puede tener elementos repetidos. Cada elemento 
            en un conjunto es único.

            en mi set tengo 2 repetidos, al imprimir solo imprime uno solo!!!
             */







            /* DA ERROR RECORRER UNA TUPLA CON FOREACH ---------------------------------
            foreach(var myItem in myTupla)
            {
                Console.WriteLine(myItem.Item1);
            }

            NO se puede usar un bucle foreach directamente en una tupla de la 
            forma (string, string, string, string, string) porque no implementa 
            la interfaz IEnumerable, la cual es necesaria para poder iterar sobre 
            sus elementos.

            */

            // PARA RECORRER UNA TUPLA HAY QUE COMVERTIRLA A IEnumerable (que es una interfaz que tiene metodos) -------------
            //EJEMPLO:

            var myTuple = ("PEPE", "ENRRIQUE", "LUCIA", "SOFI", "PEPE");
            // Convertir la tupla a IEnumerable
            IEnumerable<string> enumerableTupla = new List<string> { myTuple.Item1, myTuple.Item2, myTuple.Item3, myTuple.Item4, myTuple.Item5 };

            //iteramos los elem
            foreach(var item in enumerableTupla)
            {
                Console.WriteLine(item);
            }


            /*User
            una tupla puede tener elementos repetidos?

            ChatGPT:
            Sí,una tupla en C# puede contener elementos repetidos.         
            La tupla es una estructura de datos que permite almacenar una secuencia 
            ordenada de elementos heterogéneos. Esto significa que puedes tener 
            cualquier combinación de elementos en una tupla, incluidos elementos repetidos.
            */


            //---------------------------- FLUJOS ----------------------------
            //---------------------------- FLUJOS ----------------------------
            //---------------------------- FLUJOS ----------------------------

            string myVariable = "Mañana";

            // ejemplo de condicion con if (si la condicion es verdadera ingresa a las llaves y ejecuta el console.writeline
            if(myVariable == "Mañana")
            {
                Console.WriteLine("Hola buen dia");
            }



            // ejemplo de dos  condiciones if, si no se cumplen ninguna condicion, entra al else.
            string myVariable2 = "Mañana";

            if (myVariable2 == "Mañana")
            {
                Console.WriteLine("Hola buen dia");
            }
            else if(myVariable2 == "Tarde")
            {
                Console.WriteLine("Hola buenas tardes");
            }
            else
            {
                Console.WriteLine("Hola buenas noches");
            }




            /*
             tambien podemos crear condiciones usando los operadores logicos AND (&&) y OR (||)


             
             */

            // AND
            string myVariable3 = "Mañana";
            bool esValido = true; // true o false



            if (myVariable3 == "Mañana" && esValido == true) // las dos condiciones deben ser verdaderas para que muestre
            {
                Console.WriteLine("Hola buen dia");
            }
            else if (myVariable3 == "Tarde" && esValido == true)
            {
                Console.WriteLine("Hola buenas tardes");
            }
            else if(myVariable3 == "Noche" && esValido == true)
            {
                Console.WriteLine("Hola buenas noches");
            }
            else
            {
                Console.WriteLine("No es valido");
            }


            //OR
            string nombre1 = "pepe";
            string nombre2 = "pepe";

            if(nombre1 == "pepe" || nombre2 == "pepe")// con que una de las condiciones sea verdadera ya pasa a la llave y muestra el mensaje
            {
                Console.WriteLine("Al menos uno de los nombres es 'pepe'");
            }


            //---------------------------- FUNCIONES O METODOS ----------------------------
            //---------------------------- FUNCIONES O METODOS ----------------------------
            //---------------------------- FUNCIONES O METODOS ----------------------------

            /*
             Una funcion es un bloque de codigo reutilizable.

             un metodo  es una funcion pero dentro del contexto de una class.
             en el paradigma POO orientado a objetos las funciones que operan sobre los
             datos de un objeto, se llaman metodos.
             
             */

            myFuntion();

            Console.WriteLine(myFuntionWithReturn(100, 50));



            MyClass miClaseInstanciable = new MyClass("Flior", "Tabulatero", "Gret");

            Console.WriteLine(miClaseInstanciable.myName);
            Console.WriteLine(miClaseInstanciable.LastName);
            Console.WriteLine(miClaseInstanciable.SecondLastName);



            // uso de los setters - cambiamos los valores de los atributos provados
            miClaseInstanciable.LastName = "McDonal";
            miClaseInstanciable.SecondLastName = "Pikefor";


            Console.WriteLine(miClaseInstanciable.myName);
            Console.WriteLine(miClaseInstanciable.LastName);
            Console.WriteLine(miClaseInstanciable.SecondLastName);

        }//fun Main


        /*
        void myFuntion()
        {
            Console.WriteLine("Mi funcion");
        }

        como estamos en el Main esto debeser una funcion estatica:

        error: se requiere una referencia al objeto para el campo, metodo, o propiedad
        'Program.myFuntion()' no estaticos
        */

        
        static void myFuntion()// no recibe parametros y no devuelve nada.
        {
            Console.WriteLine("Mi funcion");
        }

        static int myFuntionWithReturn(int num1, int num2)// recibe dos parametros
        {
            return num1 + num2;// devuelve el resultado
        }

        //---------------------------- CLASS ----------------------------
        //---------------------------- CLASS ----------------------------
        //---------------------------- CLASS ----------------------------
        /*
         Clase Instanciable:

        Estas son clases que puedes utilizar como plantillas para crear instancias u objetos 
        en tiempo de ejecución. Puedes crear instancias de estas clases utilizando el 
        operador new.
         */


        class MyClass
        {
            public string myName; // Variable de clase que actúa como un atributo público, permitiendo el acceso externo.

            private string _myLastName; // Campo o atributo privado para almacenar el apellido.

            public string SecondLastName { get; set; }
            /* 
            La "Propiedad AutoImplementada" en C# es una sintaxis simplificada que permite declarar propiedades sin necesidad de definir un campo privado explícito.
            El compilador genera automáticamente un campo privado para almacenar el valor de la propiedad.
            Puedes acceder y modificar la propiedad SecondLastName como cualquier otra propiedad pública.
            */


            public MyClass(string myName, string myLastName, string secondLastName)            
            {
                this.myName = myName;// this hace referencia a todo lo que es de este contexto. o sea, contexto local de este scope.
                _myLastName = myLastName;
                SecondLastName = secondLastName;
            }
            /* 
            Constructor que recibe tres parámetros: myName, myLastName y secondLastName.
            El guion bajo antes de _myLastName es una convención común para los campos privados en C#.
            */



            // Propiedad Get y Set para acceder al campo privado _myLastName.
            public string LastName
            {
                get { return _myLastName; } // Getter para obtener el valor de _myLastName.
                set { _myLastName = value; } // Setter para asignar un valor a _myLastName.
            }
        }


    }// fin class program


}// fin namespace





