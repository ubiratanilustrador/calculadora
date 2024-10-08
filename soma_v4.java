/*Quarta versão da função soma*/
import java.util.Scanner;//importação biblioteca de digitação
public class Main
{
	public static void main(String[] args) {
	    
	       //Lê a partir da linha de comando
        Scanner sc = new Scanner(System.in);
		double a = sc.nextDouble();
		String operacao = sc.next();
		
	switch(operacao) {
        case "+":
        double b = sc.nextDouble();
        System.out.print("O resultado foi: "+ soma (a,b)); //chamo a função soma ao mesmo tempo passando os valores como paramentro
        break;
        case "-":
        b = sc.nextDouble();
        System.out.print("O resultado foi: "+ subtracao (a,b)); //chamo a função soma ao mesmo tempo passando os valores como paramentro
        break;
        case "*":
        b = sc.nextDouble();
        System.out.print("O resultado foi: "+ multiplicacao (a,b)); //chamo a função soma ao mesmo tempo passando os valores como paramentro
        break;
        case "/":
        b = sc.nextDouble();
        if (b != 0){
        System.out.print("O resultado foi: "+ divisao (a,b)); //chamo a função soma ao mesmo tempo passando os valores como paramentro
        }else{
            System.out.println("não é possível dividir por zero");
        }
        break;
  default:
    System.out.println("Erro, operação não encontrada");
}
	}
	
	public static double soma (double a, double b){
	    double c = 0; // crio uma variavel local para receber o valor
	    c = a + b; // realizo a operação de soma
	    return c; // retorno o resultado
	}
		public static double subtracao (double a, double b){
	    double c = 0; // crio uma variavel local para receber o valor
	    c = a - b; // realizo a operação de soma
	    return c; // retorno o resultado
	}
		public static double multiplicacao (double a, double b){
	    double c = 0; // crio uma variavel local para receber o valor
	    c = a * b; // realizo a operação de soma
	    return c; // retorno o resultado
	}
		public static double divisao (double a, double b){
	    double c = 0; // crio uma variavel local para receber o valor
	    c = a / b; // realizo a operação de soma
	    return c; // retorno o resultado
	}
}