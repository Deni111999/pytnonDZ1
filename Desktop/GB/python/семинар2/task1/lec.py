#  Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.

N = int ( input ( 'Введите число: ' ))

y = 1
list = []

for x in range ( 1, N+1 ):
    y *= x
    list.append ( y )

print ( list )