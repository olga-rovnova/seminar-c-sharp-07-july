// Задача 73: Есть число N. Сколько групп M можно получить 
// при разбиении всех чисел на группы так, чтобы в одной группе 
// все числа в группе друг на друга не делились? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.

int n = 30;
long[] number = new long[n];
FillArrayToN(number);
int countGroup = 1;

for (int i = 0; i < number.Length; i++) 
{
    if (number[i] != 0)
    {
        int index = 0;
        long[] num2 = new long[number.Length];
        for (int k = i; k < number.Length; k++) 
        {
            if (number[k] % number[i] != 0 || number[k] / number[i] == 1) 
            {
                num2[index] = number[k];
                index++;
            }
        }
        
        for (int j = 1; j < num2.Length; j++)
        {
            for (int l = j + 1; l < num2.Length; l++)
            {
                if (num2[j] != 0 && num2[l] % num2[j] == 0) 
                {
                    num2[l] = 0;
                }
            }
        }
        
        for (int f = 0; f < number.Length; f++)
        {
            for (int m = 0; m < num2.Length; m++)
            {
                if (num2[m] == number[f])
                {
                    number[f] = 0;
                }
            }
        }

        Console.Write($"группа {countGroup++}: ");

        for (int k = 0; k < num2.Length; k++)
        {
            if (num2[k] != 0)
            {
                Console.Write(num2[k] + " ");
            }
        }
        Console.WriteLine();
    }
}

void FillArrayToN(long[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = i + 1;
    }
}