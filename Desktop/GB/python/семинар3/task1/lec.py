# Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

import os
from random import *
os.system("cls")

n = randint(7, 13)
list = [randint(1, 21) for i in range(n)]
print(list, '\n')

print('Сумма элементов на нечетных позициях равна ', sum(list[1::2]), '\n')