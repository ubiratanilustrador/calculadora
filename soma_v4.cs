/******************************************************************************
Quarta versão do programa soma
*******************************************************************************/
using System;
class Operacao {
  static void Main() {
    String op;
    double a;
    double b;
    //atribuição de dois valores as variaveis a. Int32.Double converte para double
    a = double.Parse(Console.ReadLine());//captura do teclado o valor digitado
    op = Console.ReadLine();
    
      switch (op)
    {
        case "+":
          b = double.Parse(Console.ReadLine());//captura do teclado o valor digitado
          //chamo a função e ao mesmo tempo passo as variaveis
          Console.WriteLine ("Resultado foi: "+soma(a,b));
          break;
        case "-":
         b = double.Parse(Console.ReadLine());//captura do teclado o valor digitado
          //chamo a função e ao mesmo tempo passo as variaveis
          Console.WriteLine ("Resultado foi: "+subtracao(a,b));
          break;
        case "*":
         b = double.Parse(Console.ReadLine());//captura do teclado o valor digitado
          //chamo a função e ao mesmo tempo passo as variaveis
          Console.WriteLine ("Resultado foi: "+multiplicacao(a,b));
          break;
        case "/":
          b = double.Parse(Console.ReadLine());//captura do teclado o valor digitado
              //chamo a função e ao mesmo tempo passo as variaveis
         if(b!=0){
              Console.WriteLine ("Resultado foi: "+divisao(a,b));
         }else{
             Console.WriteLine("Não é possivel dividir por zero");
         }
          break;
        default:
          Console.WriteLine("Erro, operação não encontrada");
          break;
    }
  }
  
  static double soma (double a, double b){
      double resultado = a + b;
      return resultado;
  }
  
    static double subtracao (double a, double b){
      double resultado = a - b;
      return resultado;
  }
  
    static double multiplicacao (double a, double b){
      double resultado = a * b;
      return resultado;
  }
  
    static double divisao (double a, double b){
      double resultado = a / b;
      return resultado;
  }
}