// Задача 74*: 4 друга должны посетить 12 пабов, в котором выпить по британской пинте 
// пенного напитка. До каждого бара идти примерно 15-20 минут, 
// каждый пьет пинту за 15 минут. 
//(Условимся, что все друзья в одном баре пьют по 1й пинте одновременно)
//У первого друга лимит выпитого 1.1 литра, 
// у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. 
// Необходимо выяснить, до скольки баров смогут дойти каждый из друзей
// (Пройденное расстояние (в барах)), пока не упадет. 
// И сколько всего времени будет потрачено на выпивку.

int timeRoad = 20;
int timeDrink = 15;
int pinta = 568;

int finalBar = 0;
int totalTime = 0;

int[] array = { 1100, 1500, 2200, 3300 };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Последний бар для друга № {i + 1}: {Bar(array[i])},");
    Console.WriteLine($"а его время до отключки: {TotalTime(array[i])} минут");
    Console.WriteLine();


    int Bar(int quantity)
    {
        finalBar = (quantity * 100 / pinta) / 100 + 1;
        return finalBar;
    }

    int TotalTime(int quantity)
    {
        totalTime = timeRoad * finalBar + timeDrink * (finalBar - 1) + ((quantity * 100 / pinta) % 100 * timeDrink) / 100;
        return totalTime;
    }
}



