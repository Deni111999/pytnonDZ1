#Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

import math

print("Введите коортинаты точки A: ")
a_x = int(input("x of A = "))
a_y = int(input("y of A = "))
print("Введите коортинаты точки B: ")
b_x = int(input("x of B = "))
b_y = int(input("y of B = "))
distance = round(math.sqrt(math.pow(b_x - a_x, 2) + math.pow(b_y - a_y, 2)), 3)
print(f"расстояние между точкой A[{a_x};{a_y}] и B[{b_x};{b_y}] = {distance}")