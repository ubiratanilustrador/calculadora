/*primeira versão da função soma*/
public class Main
{
	public static void main(String[] args) {
		
		int a = 5;
		int b = 5;
		
		System.out.print(soma (a,b)); //chamo a função soma ao mesmo tempo passando os valores como paramentro

	}
	
	public static int soma (int a, int b){
	    int c = 0; // crio uma variavel local para receber o valor
	    c = a + b; // realizo a operação de soma
	    return c; // retorno o resultado
	}
}