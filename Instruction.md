**Описание программы**

Функция: 

    string[] FormatArray(string[] array)
 
Принимает массив из строк, и возвращает новый строчный массив длинной от 0 до 3 с случаным, неповторяющимся набором эллементов из массива который принимает.

    int newArrayLenght = new Random().Next(1,4);

Генерирует длинну для массива который выйдет

    int[] temp = new int[newArrayLenght];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = -1;
    }

Создаем еще один массив который будет хранить значения индексов, заполняем его -1. Это сделано по той причине что если просто задать пустой массив то он заполнится 0 и первый эллемент исходного массива никогда не попадет в итоговый.

        string[] finalArray = new string[newArrayLenght];

Создаем итоговый массив с сгенерированной длинной.

** Описание основного блока программы.

    for (int i = 0; i < newArrayLenght; i++)
    {
        int positionInFirstArray = new Random().Next(0,array.Length);
        while(!RepetitionCheck(positionInFirstArray,temp))
        {
            positionInFirstArray = new Random().Next(0,array.Length);
        }
        finalArray[i] = array[positionInFirstArray];
        temp[i] = positionInFirstArray;
    }
    return finalArray;

Следующая стока генерирейт то какой элемент массива будет добавлен в итоговый массив.

     int positionInFirstArray = new Random().Next(0,array.Length);

Проверка не была ли строка с таким индексом уже добавлена в итоговый массив. И новые генирации до тех пор пока индекс не будет новым. Описаниее функции далее

      while(!RepetitionCheck(positionInFirstArray,temp))
        {
            positionInFirstArray = new Random().Next(0,array.Length);
        }

Добавление в итоговый массив значения, который берется из входного массива с сгенерированным значением индекса.

        finalArray[i] = array[positionInFirstArray];

Добавления сгенерированного числа в массив который хранит индексы.

        temp[i] = positionInFirstArray;

После цикла for возвращаем получившийся массив.

        return finalArray;


**Описание функции для проверки уникальности**

Принимает сгенерированное число и массив чисел(в которые добавляются все предыдущие генирации прошедшие проверку на уникальность.

    bool RepetitionCheck(int index,int[] temp)
    {
        bool check = true;  
        for (int i = 0; i < temp.Length; i++)
        {
            if (index == temp[i])
            check = false;
        }
        return check;
    }

Задаем изначально что bool = true 

     bool check = true; 

После идет сравнения числа со значениями массива

    for (int i = 0; i < temp.Length; i++)
    {
        if (index == temp[i])
        check = false;
    }

Если таких нет то возвращяется true и основная функция идет дальше.
Если такая встречается то bool меняется на false и тогда в основной функцииидет повторная генерации и заново проверка на уникальность.