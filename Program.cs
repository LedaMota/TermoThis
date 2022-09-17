using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aqui estou intanciando a classe e passando um objeto
            Acessar a = new Acessar();


            //Aqui montei uma condicional pegando um metodo login e estou passando uma senha,
            //se for igual entra dentro da condicional se não for retorna false.
            if (a.Login("abm999"))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }

            Console.ReadKey();
        }
    }
}
