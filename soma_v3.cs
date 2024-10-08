/******************************************************************************
terceira versão do programa soma
*******************************************************************************/
using System;
class Operacao {
  static void Main() {
    String op;
    int a;
    int b;
    //atribuição de dois valores as variaveis a. Int32.Parse converte para inteiro
    a = int.Parse(Console.ReadLine());//captura do teclado o valor digitado
    op = Console.ReadLine();
    
      switch (op)
    {
        case "+":
          b = int.Parse(Console.ReadLine());//captura do teclado o valor digitado
          //chamo a função e ao mesmo tempo passo as variaveis
          Console.WriteLine ("Resultado foi: "+soma(a,b));
          break;
        default:
          Console.WriteLine("Erro, operação não encontrada");
          break;
    }
  }
  
  static int soma (int a, int b){
      int resultado = a + b;
      return resultado;
  }
}