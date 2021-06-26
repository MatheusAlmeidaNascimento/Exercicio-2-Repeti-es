using System;

namespace Exercicio_2_Repetições
{
    class Program
    {
        static void Main(string[] args)
        {

          string nome;
          string senha;
          bool resposta = false;  


          while (resposta == false)
          {
          Console.WriteLine("Crie um nome de usuário: ");
          nome = Console.ReadLine(); 

          Console.WriteLine("Crie uma senha");
          senha = Console.ReadLine();

              
              while (nome == senha)
              {
              Console.WriteLine("A sua senha não pode ser igual ao nome de usuário!");
              Console.WriteLine("Por favor crie uma outra senha");
              senha = Console.ReadLine();
                  
              }
            
            if (senha != nome)
            {
                resposta = true;
                Console.WriteLine("Sua senha foi criada com sucesso");
            }
              Console.WriteLine("Cadastro feito com sucesso!");
          }
                
        }
    }
}
