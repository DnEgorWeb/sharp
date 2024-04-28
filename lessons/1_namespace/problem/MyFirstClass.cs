namespace Lesson1MyFirstClass;

/// <summary>
/// Проблема: как использовать другие классы?
/// Здесь компилятор ругается:
/// "The type or namespace name 'MySecondClass' could not be found"
/// ("Не могу найти тип или пространство имен 'MySecondClass'")
/// </summary>
class MyFirstClass
{
  void createSecondClass()
  {
    // new MySecondClass();
  }
}

class Something
{
}