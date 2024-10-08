'Quarta versão da função em Python'

#função de adição
def soma (a,b):
    resultado = a + b
    return resultado

#função de subtração
def subtracao (a,b):
    resultado = a - b
    return resultado

#função de multiplicação
def multiplicacao (a,b):
    resultado = a * b
    return resultado
    
#função de divisão
def divisao (a,b):
    resultado = a / b
    return resultado

#captura o valor do teclado e converte para um numero inteiro 
a = int(input())

op = input()

if op == '+':
    
    b = int(input())
    #chamada da função
    resultado_operacao = soma(a,b)
    #mostra o resultado
    print (resultado_operacao)

if op == '-':
    
    b = int(input())
    #chamada da função
    resultado_operacao = subtracao(a,b)
    #mostra o resultado
    print (resultado_operacao)
    
if op == '*':
    
    b = int(input())
    #chamada da função
    resultado_operacao = multiplicacao(a,b)
    #mostra o resultado
    print (resultado_operacao)
    
if op == '/':
    
    b = int(input())
    #chamada da função
    if b != 0:
        resultado_operacao = divisao(a,b)
        #mostra o resultado
        print (resultado_operacao)
    else:
        print('Erro não é possivel dividir por zero')