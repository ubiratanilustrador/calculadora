/******************************************************************************
primeira versão do programa soma
*******************************************************************************/
using System;
class Operacao {
  static void Main() {
    
    //atribuição de dois valores as variaveis a e b
    int a = 5;
    int b = 5;
    
    //chamo a função e ao mesmo tempo passo as variaveis
      Console.WriteLine (soma(a,b));
  }
  
  static int soma (int a, int b){
      int resultado = a + b;
      return resultado;
  }
}