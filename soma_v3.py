'Terceira versão da função em Python'

#função de adição
def soma (a,b):
    resultado = a + b
    return resultado

#captura o valor do teclado e converte para um numero inteiro 
a = int(input())

op = input()

if op == '+':
    
    b = int(input())
    #chamada da função
    resultado_somar = soma(a,b)

#mostra o resultado
print (resultado_somar)