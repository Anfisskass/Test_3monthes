# Задача
1. Нарисовать блок схему-схему алгоритма - в файле blocksh.drawio.png 
2. Описание блок схемы
Start - начало нашего массива.
По условии задачи у нас есть массив - array
Размер данного массива определяет пользователь - size
Нам необходимо создать второй массив, в котором длина строк меньше или равна 3, поэтому вводим переменную 
второго массива (массив, который будет получаться на выходе) - array2
Счетчик - i
А также вводим переменную для второго массива для подсчета данных строк - index
Первое условие в ромбе массив не должен быть больше заданного размера.
Если условие совпадает, то мы переходим к дальнейшему решению задачи.
Если нет, то программа заканчивается.
Второе условие (второй ромб) мы проверяем длину текущего элемента массива.
Если он меньше или равно 3, то мы добавляем в index данный iый элемент из исходного массива
При этом index увеличивается.
Если длина больше, то мы переходим к следующему элементу.
После этого мы увеличиваем счетчик для проверки всех элементов.
Когда цикл заканчивается - задача заканчивается. 
