namespace ConsoleSolution;

/// <summary>
/// Решение: система Ввода/Вывода (Input/Output)
/// 
/// Система Ввода отвечает за то,
/// что пользователь передает программе (говорят "передать на вход")
/// 
/// Система Вывода отвечает за то,
/// что программа отдает пользователю (говорят "получить на выходе")
/// 
/// Схема:
/// Ввод от Пользователя -> ...Логика программы... -> Вывод от Программы
/// 
/// Разные приложения используют разные интерфейсы для Ввода/Вывода.
/// В играх система ввода - мышь, клавиатура, тачпад, джойстик
///         система вывода - игровой интерфейс на мониторе, VR-очках, звуковых динамиках
///         
/// У нас консольное приложение, в нем ввод/вывод осуществляется через интерфейс консоли
/// </summary>
class ConsoleApp
{
  public void sayHello()
  {
    // Выведем пользователю надпись:
    Console.WriteLine("Как тебя зовут?");

    // Считаем его ответ и сохраним в переменную:
    string userName = Console.ReadLine();

    // Теперь выведем пользователю приветствие:
    Console.WriteLine("Привет, " + userName + "!");
  }

  public void multiLineOutput()
  {
    /// Для вывода строки в консоль мы использовали метод WriteLine,
    /// который автоматически добавляет перевод строки:
    Console.WriteLine("Первая строка!");
    Console.WriteLine("Вторая строка!");
  }

  public void singleLineOutput()
  {
    /// Но существует и метод, который не добавляет переноса:
    Console.Write("П");
    Console.Write("р");
    Console.Write("и");
    Console.Write("в");
    Console.Write("е");
    Console.Write("т");
  }

  public void mixOutput()
  {
    /// Тут главное запомнить, что WriteLine не выводить текст с новой строки
    Console.WriteLine("Здесь автоматически добавится перевод строки -->");
    Console.Write("А вот здесь не добавится!");
    /// Например вывод ниже будет с той же строки, что и "А вот здесь не добавится!"
    Console.WriteLine("А после этого текста снова будет перевод строки -->");
    /// Все потому что WriteLine добавляет перевод в конце, а не в начале строки.
  }
}