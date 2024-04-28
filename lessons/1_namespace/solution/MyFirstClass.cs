namespace Lesson1Solution;

// Вариант 2:
// using NamespaceRandomNamespaceSolution;

class MyFirstClass
{
  void createSecondClass()
  {
    // Вариант 1: хранить MySecondClass в этом же файле:
    // new MySecondClass();

    // Вариант 2: явно указать пространство имен
    // new NamespaceRandomNamespaceSolution.MySecondClass();

    // Вариант 3: испортировать класс из пространства имен
    // при помощи директивы "using" (вверху файла)
    // new MySecondClass();

    // Вариант 4: использовать одинаковые названия для нэймспэйсов
    // new MySecondClass();
  }
}

// class MySecondClass
// {
// }