namespace ConditionsProblem;

class Conditions
{
  /// Иногда нам нужно выполнить различные действия в зависимости от условий.
  /// Для этого мы можем использовать инструкцию if
  /// Инструкция if(...) вычисляет условие в скобках и, если результат true, то выполняет блок кода.
  void ifStatement()
  {
    // Синтаксис (вместо ... подставляется настоящее выражение):
    // if (...)
    // {
    //    этот блок кода выполняется только если условие внутри if (...) вернуло true
    // }

    // Пример:
    int age = int.Parse(Console.ReadLine());
    if (age >= 21)
    {
      // этот блок кода выполнится только если введенное число больше или равно 21 
      Console.WriteLine("Доступ Разрешен!");
    }
  }

  /// Выражение внутри if (...) может быть сколь угодно сложным,
  /// главное, чтобы возвращаемый результат был true или false (иначе не скомпилируется)
  void complexIfStatement() {
    Console.WriteLine("Введите email:");
    string email = Console.ReadLine();
    Console.WriteLine("Введите пароль:");
    string password = Console.ReadLine();
    if (email == "super_mail@yandex.com" && password == "secret")
    {
      // выполнится только если и email, и password
      // совпадают с значениями которые мы "захардкодили"
      Console.WriteLine("Доступ Разрешен!");
    }
  }

  /// Инструкция if может содержать необязательный блок «else» («иначе»). Он выполняется, когда условие ложно.
  void elseStatement()
  {
    int age = int.Parse(Console.ReadLine());
    if (age >= 21)
    {
      // этот блок кода выполнится только если введенное число больше или равно 21 
      Console.WriteLine("Доступ Разрешен!");
    }
    else
    {
      // этот блок кода выполнится если введенное число меньше 21
      Console.WriteLine("Доступ Запрещен!");
    }
  }

  /// Иногда нужно проверить несколько вариантов условия.
  /// Для этого используется блок else if
  void elseIfStatement()
  {
    Console.WriteLine("Привет! Как тебя зовут?");
    string name = Console.ReadLine();

    if (name == "Данил")
    {
      Console.WriteLine("Заходи, Данил!");
    }
    else if (name == "Ваня")
    {
      Console.WriteLine("Заходи, Ваня!");
    }
    else
    {
      Console.WriteLine("Уходите, мы Вас не знаем.");
    }

    /// В приведённом выше коде С# сначала проверит name == "Данил".
    /// Если это неверно, он переходит к следующему условию name == "Ваня".
    /// Если оно тоже ложно, тогда сработает блок else ("Уходите ...").
    /// 
    /// Блоков else if может быть и больше.
    /// Присутствие блока else не является обязательным.
  }
}