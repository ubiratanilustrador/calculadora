/*segunda versão da função soma*/
import java.util.Scanner;//importação biblioteca de digitação
public class Main
{
	public static void main(String[] args) {
		
	    //Lê a partir da linha de comando
        Scanner sc = new Scanner(System.in);
		
		int a = sc.nextInt();
		int b = sc.nextInt();
		
		System.out.print("O resultado foi: "+ soma (a,b)); //chamo a função soma ao mesmo tempo passando os valores como paramentro

	}
	
	public static int soma (int a, int b){
	    int c = 0; // crio uma variavel local para receber o valor
	    c = a + b; // realizo a operação de soma
	    return c; // retorno o resultado
	}
}