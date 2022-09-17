using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{    //Aqui criei uma classe Acessar 
    class Acessar
    {   //Aqui declarei uma variavel do tipo string senha fiz uma atribuição de senha.
        string senha = "abc123";
                
        //Aqui criei um metódo tipo bool com o nome login  com um parametro que vai receber senha do tipo string
        public bool Login(string senha)
        {
            //Aqui o retorno do metódo onde eu comparei a senha vindo da variavel com a senha vindo do parametro.
            //coloquei o this para especificar que estou pegando a variavel e não o parametro.
            return this.senha == senha;
        }
    }
}
