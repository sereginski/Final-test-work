Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Описание решения:
Объявляется два массива одинаковой длины и переменная count, изначально она равна 0. Циклом прохожу по длине массива, внутри цикла проверка условия ( <=3 ), если верно - элемент первого массива заносится в count элемента второго массива. После присвоения переменная count увеличивается на 1 и возвращается к циклу for в котором i так же увеличивается на 1. И так по кругу, пока условие верно.
Схема: https://disk.yandex.ru/d/tFDCZlz0W2ZeJQ