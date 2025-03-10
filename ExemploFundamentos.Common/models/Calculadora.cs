using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            System.Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y){
            System.Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(int x, int y){
            System.Console.WriteLine($"{x} x {y} = {x*y}");
        }
        public void Dividir(int x, int y){
            System.Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia(int x,int y){
            double pot = Math.Pow(x,y);
            System.Console.WriteLine($"{x}^{y} = {pot}");
        }
        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            System.Console.WriteLine($"Seno de {angulo}º = {Math.Round(seno,4)} ");
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            System.Console.WriteLine($"Coseno de {angulo}º = {Math.Round(coseno,4)} ");
        }
        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            System.Console.WriteLine($"Tangente de {angulo}º = {Math.Round(tangente,4)} ");
        }
        public void Modulo(int x, int y){
            System.Console.WriteLine($"{x} % {y} = {x%y}");
        }
        public void Incrementar(int x){
            int y = x;
            y++;
            System.Console.WriteLine($"{x}++ = {y}");
        }
        public void Decrementar(int x){
            int y =x;
            y--;
            System.Console.WriteLine($"{x}-- = {y}");
        }

        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            System.Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}