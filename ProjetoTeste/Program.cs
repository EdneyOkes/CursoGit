using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTeste
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Bem vindo de volta das férias!");
            Console.WriteLine("Vamos avançar nessa porra!"); // Voltar ao estado anterior do commit -> git clean -df   -> git checkout -- .

            Console.WriteLine("Teste de modificar commit agora");

            // Removendo o commit totalmente e voltando ao estado anterior (git reset --soft HEAD~1) - mantenado os arquivos
            // Removendo o commit totalmente e voltando ao estado anterior (git reset --hard HEAD~1) - apagando os arquivos

            // Aula 105 >> Finalizando aulas sobre Git

            // Vizualizar um commit anterior >>> (Dar um git status antes) >>> git checkout <código do commit>
            // Voltar para o último commit >>>> git checkout <nome do branch>


        }
    }
}
