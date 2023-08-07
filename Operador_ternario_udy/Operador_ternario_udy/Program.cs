
//operador ternario
bool usuarioEstaLogueado = true;
/*
string mensajeBienvenida;

if (usuarioEstaLogueado)
{
    mensajeBienvenida = "¡Que bueno qye has vuelto!";
}
else
{
    mensajeBienvenida = "Logueate para comenzar";

}*/ 
//mejor forma de resumirlo asignano el valor a la variable
string mensajeBienvenida = usuarioEstaLogueado ? "¡Que bueno qye has vuelto!" : "Logueate para comenzar";
// <condicion>? <si la condicion es true>: <si la condicion es false>
Console.WriteLine(mensajeBienvenida);





//Ejercicio 

namespace DecisionesyBucles.Ejercicios
{
    /*
    Borra el código del if-else y sustitúyelo por uno que use el operador ternario.

    Tu solución debe quedar por debajo del comentario y por encima del return.
     */

    public class NumeroMayorParte2
    {
        public int DeterminarElNumeroMayor(int a, int b)
        {
            int resultado;

            // Tu código debajo de esta línea
            if (a > b)
            {
                resultado = a;
            }
            else
            {
                resultado = b;
            }
            resultado = a > b ? a : b;
            return resultado;
        }
    }
}