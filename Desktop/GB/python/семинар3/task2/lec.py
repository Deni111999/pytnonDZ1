# Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

import os
from random import *
os.system("cls")

list = [randint(1, 21) for i in range(8)]
print(list, '\n')
for i in range((len(list)+1)//2):
    print(list[i] + list[len(list)-1-i], end=' '*6,)
print('\n')    

