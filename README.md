# Контрольная gо основному блоку

## Задача:
 Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение:
Зарашиваем у пользователя ввести строку с элементами, разделяя запятой. Затем находим количество элементов в данном массиве, совадающих с условием < или = 3, через *string[ ] GetArraySort (string[ ] array)*. Подходящие (perfect) элементы записываем в новый массив *string[ ] arrayPerfSimb = new string[count]*. Затем выводим получившийся массив через *void Print*, который озвояет вывести элементы массива через запятую.

## Файлы:
В *Program.cs* находится сам код. Блок-схема с решением - *Simbols.drawio* и *Simbols.drawio.png*: фрагменты кода с пояснениями.
