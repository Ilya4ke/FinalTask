# Итоговая работра

## Задание - Напишите программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меьнше либо равна 3 символам. Первоначальный массив можно задать с клавиатуры или вессти на старте выполнения алгоритма.

### Решение:

1. Просим пользователя ввести размер изначального массива.
2. Просим пользовалетя заполнить массив.
3. Создаем второй массив. Размер массива будет такой же как и в первом случае тк пользователь может заполнить все ячейки массива строкой длинна которой будет меньше или равна 3.
4. Создаем функцию которая будет получать два массива, проверять значения в первом массиве и если длинна строки меньше или равна 3 то записывать эту строку в второй массив. Для продвижения по ячейкам второго массива создаем переменную ***count*** .
5. Создаем вторую функцию для печати нового массива. Аналогично предыдущей функции мы проходим по каждой ячейке массива и печатаем ее.
6. Вызываем функцию из пункта ***4*** и передаем в нее два массива, первый заполнил пользователь, второй аналогичный ему по размерам.
7. Вызываем функцию из пункта ***5*** и передаем в нее второй массив который получился в результате работы функции из пункта ***4***.

***
### Схематическое изображение алгоритма решения находится в папке **Share**
### Рабочая программа находится в папке **Task** файл **Program**
### Файлы продублированны в удаленном репозиторие [GitHub](https://github.com/Ilya4ke/FinalTask.git)