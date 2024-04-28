namespace Lesson3TypeConversions;

class TypeConverions {
  public void changeDataType()
  {
    // Переменные могут менять свое значение, но не тип.
    // Тип назначается во время создания переменной и остается с ней навсегда.

    // Создали переменную типа int
    int myNumber;
    // Пытаемся присвоить ей другие типы, но компилятор не разрешает
    // раскоментируй три строки ниже:
    // myNumber = "Привет!";
    // myNumber = true;
    // myNumber = 15.2f;

    // Поэтому C# называют языком с статической типизацией
    // статика означает "неизменный", буквально - неменяющиеся типы данных
    // один раз объявили тип, и для этой переменной он с ней до конца. 
  }

  public void implicitConversions()
  {
    // некоторые типы могут неявно приводиться к другим типам.
    // это сделано для удобства, и работает только для некоторых типов.

    // создали переменную, максимальное значение которой - 128
    byte tinyNumber = 10;
    // присвоили ее в переменную типа long (на расширение, т.к. long вмещает в себя больше)
    long bigNumber = tinyNumber;

    // а вот обратно (на "сужение") уже не получится:
     // byte anotherTinyNumber = bigNumber; // расскоментируй строку - не скомпилируется!
    // так работает из-за внутреннего устройства программы:
    // любые числа хранятся в битах (нолики и единички),
    // тип byte состоит всего из 8 битов,
    // а тип long состоит из 64 битов.
    // Получается 8 битов помещается в 64 бита (byte может присвоиться в long),
    // а вот наоборот не выйдет - 64 бита не влезут в 8 битов.

    // другой пример неявного преобразования - сложение разных типов со строкой
    // тут получится строка: "Мой возраст составляет: 14"
    string myAge = "Мой возраст составляет: " + 14;
    // кейсы со сложением мы рассмотрим подробнее в следующей части
  }

  public void explicitConversions()
  {
    /// до этого мы рассмотрели неявные преобразования, теперь
    /// рассмотрим явные.
    /// Явные преобразования - это когда мы прямо говорим компилятору,
    /// что хотим преобразовать один тип к другому. Работает не для всех типов.
    double x = 1234.7;
    int a;
    // Преобразуем double (дробный тип) в int (целый тип).
    a = (int) x; // получится 1234

    // с явными преобразованиями нужно быть осторожным,
    // т.к. не все можно преобразовать. Вот так не сработает:
    string myName = "Петя";
    // int myNumber = (int) myName; // раскоментируй эту строку - выведет "не могу сконвертировать строку в число"

    // синтаксис (<тип>) <название переменной> называется "преобразовать к типу",
    // еще часто говорят "скастовать к типу", от слова cast - преобразовать
    // в рабочем примере выше мы привели тип double к типу int
  }
}