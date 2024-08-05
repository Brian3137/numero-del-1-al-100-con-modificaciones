Console.WriteLine("Programa que muestra los numeros del 1 al 100");
Console.WriteLine("Donde si es multiplo de 3 se lo sustituye por la palabra FIZZ");
Console.WriteLine("Si es multiplo de 5 se lo sustituye por la palabra BUZZ");
Console.WriteLine("Ahora si es multiplo de 3 y 5 a la vez se lo sustituye por la palabra FIZZBUZZ");


for (int i = 1; i < 101; i++)
{
    if (i % 15 == 0) // multiplo de 3 y 5 al mismo tiempo , multiplico 3*5= 15
    {
        Console.WriteLine("FIZZBUZZ");
    }
    else
    {
        if (i % 5 == 0)  // solo si es multiplo de 5 
        {
            Console.WriteLine("BUZZ");
        }
        else
        {
            if ((i % 3) == 0) // solo si es multiplo de 3 
            {
                Console.WriteLine("FIZZ");
            }
            else
            {
                Console.WriteLine(i); // si no es multiplo de ninguno de los pedidos muestro "i"
            }
        }
    }

    Console.WriteLine(); // Salto de linea entre numero y numero ( lo busque como hacer ) 
}