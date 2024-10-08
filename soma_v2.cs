/******************************************************************************
Segunda versão do programa soma
*******************************************************************************/
using System;
class Operacao {
  static void Main() {
    
    //atribuição de dois valores as variaveis a e b
    //Int32.Parse converte para inteiro
    int a = Int32.Parse(Console.ReadLine());//captura do teclado o valor digitado
    int b = Int32.Parse(Console.ReadLine());//captura do teclado o valor digitado
    
    //chamo a função e ao mesmo tempo passo as variaveis
      Console.WriteLine ("Resultado foi: "+soma(a,b));
  }
  
  static int soma (int a, int b){
      int resultado = a + b;
      return resultado;
  }
}