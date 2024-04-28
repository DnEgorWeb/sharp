namespace Lesson4Basic;

/// Операторы сравнения:
/// 
/// 1) Больше/меньше: a > b, a < b
/// 2) Больше/меньше или равно: a >= b, a <= b.
/// 3) Равно: a == b. Для сравнения используется двойной знак равенства ==.
///                   Один знак равенства a = b означал бы присваивание.
/// 4) Не равно. В математике обозначается символом ≠,
///              но в кодинге записывается как a != b.
class Comparison
{
  void boolType() {
    /// Все операторы сравнения возвращают значение логического типа:
    /// true – означает «да», «верно», «истина».
    /// false – означает «нет», «неверно», «ложь».
    bool first = 2 > 1; // вернет true
    bool second = 2 == 1; // вернет false
    bool third = 2 != 1; // вернет true
    /// в этом примере мы сравниваем числа, а результат записываем в переменные.
  }

  void compareDiffTypes()
  {
    /// Нельзя сравнивать между собой типы, которые не приводятся друг к другу "неявно"
    // bool first = "hello" > 2; // расскоментируй эту строку
    // bool second = "1" > 2; // тоже не сработает, "1" - это строка
    /// Но можно сравнивать типы, которые приводятся друг к другу неявно:
    bool third = 1.2f == 1; // будет false
  }

  void mixingUp()
  {
    /// Очень часто нам нужно сделать больше одного сравнения.
    /// Например, проверить что кнопка "ускорение" нажата сейчас
    /// и что она уже была нажата до этого.
    bool isKeyPressed = true;
    bool shouldSpeedUp = Input.GetKey(Key.SHIFT) != 0 && !isKeyPressed;
    /// Здесь нужно сначала разобраться в приоритетах выполнения.
    /// Идет в https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence
    /// и видим, что приоритет && ниже, чем у != или !x
    /// значит, сначала выполняется "!isKeyPressed" (! имеет больший приоритет чем !=)
    /// 1) подставляем true вместо isKeyPressed и получается !true, что дает нам false
    ///   остается: bool shouldSpeedUp = Input.GetKey(Key.SHIFT) != 0 && false
    /// 2) далее переходим к Input.GetKey(Key.SHIFT) != 0
    ///    допустим, клавиша shift нажата и Input.GetKey(Key.SHIFT) возвращает 0.8f
    ///    подставляем 0.8f вместо Input.GetKey(Key.SHIFT), будет 0.8f != 0
    ///    что дает нам true, потому что 0.8f не равно 0.
    ///    У нас осталось: bool shouldSpeedUp = true && false;
    /// 3) Теперь переходим к оператору &&. Оператор && ищет первый false.
    ///    Здесь он его находит на месте второго операнда и возвращает его.
    ///    Результат: bool shouldSpeedUp = false;
  }
}

class Input {
  public static float GetKey(Key key) {
    return 0.8f;
  } 
}

enum Key {
  SHIFT
}