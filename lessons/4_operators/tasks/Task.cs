namespace Lesson4Basic;

class Task {
  void first()
  {
    /// Чему будут равны переменные a, b, c и d в примере ниже?
    int a = 1, b = 1;

    int c = ++a; // ?
    int d = b++; // ?
  }

  void second()
  {
    /// Чему будут равны переменные a и x после исполнения кода в примере ниже ?
    int a = 2;
    int x = 1 + (a *= 2); // ?
  }

  void third()
  {
    /// Каким будет результат этих выражений?
    /// 5 > 4
    /// 4 <= 5
    /// 12 != 20
    /// 3 == 3
  }

  void fourth()
  {
    /// Каким будет result?
    string result = "Мой возраст: " + 10 + "4" + " лет"; // ?
  }

  void fifth()
  {
    /// Каким будет result?
    bool result = 2 < 1 && 3 * 4 < 14 || 6 - 3 < 4;
  }

  void sixth()
  {
    /// Каким будет result?
    bool result = 12 - 4 < 9 || 3 + 5 > 1 && 12 - 4 > 5;
  }
}