# ControlWork
## Условие задачи
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## Методология
1. Создание функции, которая будет перебирать исходный массив строк, чтобы понять сколько элементов соответствует критерию, что установить длину нового массива.
1.1. Сборка нового массива строк .
2. Проверка, есть ли в новом массиве элементы и, если их нет, то вывод "[]", как установлено в условии задачи.
3. Вывод нового массива строк в отдельной функции.
Для решения задачи составил данную блок-схему. ![блок-схему](https://sun9-65.userapi.com/impg/YZqNhcFxG26ub_SwjwEEJaEvLKos7hbiRaOJXw/1uFNXo1fvw4.jpg?size=1608x1051&quality=95&sign=af36f7fb850931c923733a711d8411fe&type=album).