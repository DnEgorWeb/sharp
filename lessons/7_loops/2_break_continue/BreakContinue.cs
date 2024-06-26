namespace Loops;

/// Прерывание цикла: «break»
/// Обычно цикл завершается при вычислении условия в false.
/// Но мы можем выйти из цикла в любой момент с помощью специальной директивы break.
class BreakContinue
{
  /// Например, следующий код подсчитывает сумму вводимых чисел до тех пор,
  /// пока посетитель их вводит, а затем – выдаёт:
  void breakExample()
  {
    int sum = 0;

    while (true)
    {
      Console.WriteLine("Введите число");

      string? userInput = Console.ReadLine();

      if (userInput == null) break; // (*)

      int value = int.Parse(userInput);

      sum += value;
    }
    Console.WriteLine("Сумма: " + sum);
    /// Директива break в строке (*) полностью прекращает выполнение цикла
    /// и передаёт управление на строку за его телом, то есть на Console.WriteLine.
    /// 
    /// Вообще, сочетание «бесконечный цикл + break» – отличная штука для тех ситуаций,
    /// когда условие, по которому нужно прерваться,
    /// находится не в начале или конце цикла,
    /// а посередине или даже в нескольких местах его тела.
  }

  /// Переход к следующей итерации: continue
  /// Директива continue – «облегчённая версия» break. При её выполнении цикл не прерывается,
  /// а переходит к следующей итерации (если условие все ещё равно true).
  /// Её используют, если понятно, что на текущем повторе цикла делать больше нечего.
  /// Например, цикл ниже использует continue, чтобы выводить только нечётные значения:
  void continueExample()
  {
    for (int i = 0; i < 10; i++)
    {

      // если true, пропустить оставшуюся часть тела цикла
      if (i % 2 == 0) continue;
      Console.WriteLine(i); // 1, затем 3, 5, 7, 9
    }
    /// Для чётных значений i, директива continue прекращает выполнение тела цикла
    /// и передаёт управление на следующую итерацию for (со следующим числом).
    /// Таким образом Console.WriteLine вызывается только для нечётных значений.
  }
}
