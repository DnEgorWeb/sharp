namespace Lesson4Basic;

/// Оператор - это наименьшая инструкция для программы
/// Многие операторы знакомы нам ещё с младшей школы:
///   сложение +, умножение *, вычитание - и так далее.
/// 
/// Термины: «унарный», «бинарный», «операнд»:
/// 
/// 1) Операнд – то, к чему применяется оператор.
/// Например, в умножении 5 * 2 есть два операнда:
///   левый операнд равен 5,
///   а правый операнд равен 2.
///   Иногда их называют «аргументами» вместо «операндов».
class Basic {
  
  void unary()
  {
    /// 2) Унарным называется оператор, который применяется к одному операнду.
    /// Например, оператор унарный минус "-" меняет знак числа на противоположный:
    int x = 1;
    x = -x;
    // теперь x равен -1;
  }

  void binary()
  {
    /// 3) Бинарным называется оператор, который применяется к двум операндам.
    /// Тот же минус существует и в бинарной форме:
    int first = 1;
    int second = 3;
    int result = second - first; // 2, бинарный минус вычитает значения
  }

  void stringConcatenation()
  {
    /// Обычно при помощи плюса '+' складывают числа.
    /// Но если бинарный оператор '+' применить к строкам, то он их объединяет в одну:
    string s = "моя" + "строка";
    // получится "моястрока"

    /// если хотя бы один операнд является строкой,
    /// то второй будет также преобразован в строку.
    string result = "1" + 2; // получится строка "12"
    /// порядок неважен, так тоже получится строка:
    string result2 = 2 + "1"; // получится строка "21"
  }

  void shortForm()
  {
    /// Часто нужно применить оператор к переменной и сохранить результат в ней же.
    int n = 2;
    n = n + 5; // теперь m = 7 (2 + 5 -> 7)
    n = n * 2; // теперь m = 14 (7 * 2 -> 14)
    /// Эту запись можно укоротить при помощи совмещённых операторов += и *=:
    int m = 2;
    m += 5; // теперь m = 7 (работает как n = m + 5)
    m *= 2; // теперь m = 14 (работает как n = m * 2)
    /// Подобные краткие формы записи существуют для всех
    /// арифметических и побитовых операторов: /=, -= и так далее
  }

  void incrementDecrement()
  {
    /// Одной из наиболее частых числовых операций является увеличение или уменьшение на единицу.
    /// Для этого существуют даже специальные операторы:
    /// 
    /// Инкремент ++ увеличивает переменную на 1:
    int counter = 2;
    counter++; // теперь counter равен 3
    /// Декремент -- уменьшает переменную на 1:
    counter--; // теперь counter снова равен 2
  }

  void postPreIncrement()
  {
    /// Операторы++ и-- могут быть расположены не только после,
    /// но и до переменной.
    /// Когда оператор идёт после переменной — это «постфиксная форма»: counter++.
    /// «Префиксная форма» — это когда оператор идёт перед переменной: ++counter.
    /// 
    /// Обе эти инструкции делают одно и то же: увеличивают counter на 1
    int counter = 1;
    int result = ++counter; // counter равняется 2, result равняется 2

    int counter2 = 1;
    result = counter2++; // counter равняется 2, result равняется 1
    /// В строке 86 постфиксная форма counter2++ также увеличивает counter2,
    /// но возвращает старое значение (которое было до увеличения).
    /// Так что результат будет 1.
    /// 
    /// Почему так работает?
    /// Все операторы "возвращают" какое-то значение
    /// Оператор "+" возвращает результат сложения левого операнда с правым:
    /// 1 + 2; // оператор "+" вернет число 3
    /// 
    /// Вот что делает префиксная форма инкремента (++counter):
    /// 1) увеличивает counter на единицу (было 1, стало 2)
    /// 2) возвращает значение counter (2)
    /// /// Вот что делает постфиксная форма инкремента (counter++):
    /// 1) возвращает значение counter (было 1, вернулось 1)
    /// 2) увеличивает counter на единицу (было 1, стало 2, но нам уже вернулась единица на шаге 1)
  }

  void operatorPrecedence()
  {
    /// Все операторы имеют свой приоритет:
    /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence
    /// Чем выше приоритет - тем раньше выполнится оператор
    /// В примере ниже сначала выполнится умножение,
    /// хотя оно идет после оператора сложения "+"
    /// 1 + 2 * 4
  }

  void assignOperator()
  {
    /// Рассмотрим присвоение значения переменной:
    int result = 1 + 2 * 4;
    /// Присвоение "=" - это тоже оператор! Который тоже возвращает значение.
    /// 
    /// У оператора "=" самый низкий приоритет из всех, так сделано
    /// чтобы в переменную записывалось значение только тогда, когда
    /// все другие операторы уже вернули свои значения.
    /// 
    /// Вот что происходит в примере выше:
    /// 1) 2 * 4 оператор умножения * вернул 8
    /// 2) 1 + 8 оператор сложения + вернул 9
    /// 3) оператор присвоения = вернул переменной result значение 9
  }
}