// // Задача 18: Напишите программу, 
// 1. которая по заданному номеру четверти, показывает диапазон
// // возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти:");
// int quater = Convert.ToInt32(Console.ReadLine())
// string Diopos(int quat)
// {
//     if (quat == 1) return "Диапазон значений координат x > 0 и y > 0";
//     if (quat == 2) return "Диапазон значений координат x < 0 и y > 0";
//     if (quat == 3) return "Диапазон значений координат x < 0 и y < 0";
//     if (quat == 4) return "Диапазон значений координат x > 0 и y < 0";
    
// }


Console.WriteLine("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());

string Diopos(int quat)
{
    if (quat == 1) return "Диапазон значений коодинат X > 0 и Y > 0";
    if (quat == 2) return "Диапазон значений коодинат X < 0 и Y > 0";
    if (quat == 3) return "Диапазон значений коодинат X < 0 и Y < 0";
    if (quat == 4) return "Диапазон значений коодинат X > 0 и Y < 0";
    return "Введите значение от 1 до 4";
}

string resalt = Diopos(quater);
Console.WriteLine(resalt);
