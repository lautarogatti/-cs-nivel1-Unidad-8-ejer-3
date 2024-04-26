using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.*/
            int n, contadorPrimo = 0, sumaPrimos = 0, promedio;
            Console.WriteLine("Ingrese un numero ");
            n = int.Parse(Console.ReadLine());
            while( n != 0){
                
                if (primo (n) == 1){
                    contadorPrimo++;
                    sumaPrimos += n;
                    }
                Console.WriteLine("Ingrese un numero ");
                n = int.Parse(Console.ReadLine());
                }
            promedio = sumaPrimos / contadorPrimo;
            Console.WriteLine("El promedio es " + promedio);
            /*Console.WriteLine(contadorPrimo);*/
        }
        static int primo(int n){
            int con = 0, r = 0;
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0){
                    con++;
                }
                if(con == 2){
                    r = 1;
                }else{
                    r = 0;
                }   
            }
            return r;
        }
    }
}
