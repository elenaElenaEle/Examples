// Решение арифметических выражений

string emp = String.Empty; // emp для того, чтобы вся строчка вмещалась без горизонтального скрола
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0    1    2     3    4    5    6     7   8    9    10   11
void InOrderTraversal(int pos = 1) // метод, позволяющий делать обход. обход начинаем с поз.1, т.е. "/"
{
    if (pos < tree.Length) // условие вылета из рекурсии
    {
        int left = 2 * pos; // левая часть дерева
        int right = 2 * pos + 1; // правая часть дерева 
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left); // если левое поддерево имеется и элемент который таам хранится не является пустым (ситуация 6 и 7 поз. = emp)
        Console.WriteLine(tree[pos]);// выводим значение операции или числа
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
