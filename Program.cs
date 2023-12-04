public class Program
{
    public static void Main(string[] args)
    {
       var hw = new HomeworkMassive2();
       hw.Task1();
       hw.Task2();
       hw.Task3();
    }
}


public class HomeworkMassive2 
{
    public HomeworkMassive2()
    {
        
    }

    public void Task1()
    {
        int[,] arr = new int[new Random().Next(2,5), new Random().Next(4, 7)];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(10, 15);
                Console.Write("{0} ", arr[i, j]);
            }
        }
        Console.Write("Введите строку: ");
        int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
        Console.Write("Введите столбец: ");
        int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
        if ((pos1 < 0) || (pos2 < 0) || (pos1 > arr.GetLength(0) - 1) || (pos2 > arr.GetLength(1) - 1)) {
            Console.WriteLine("Такого элемента нет!");
        }
        else {
            Console.WriteLine(arr[pos1, pos2]);
        }
    }

    public void Task2()
    {
        int[,] arr = new int[new Random().Next(2,5), new Random().Next(4, 7)];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(1, 15);
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int asd=0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            asd = arr[0, i];
            arr[0, i] = arr[arr.GetLength(0)-1, i];
            arr[arr.GetLength(0) - 1, i]=asd;
        }
        Console.WriteLine("Обновлённый массив");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }


    public void Task3()
    {
        int[,] arr = new int[new Random().Next(2,5), new Random().Next(4, 7)];
        Console.WriteLine("Исходный массив");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(1, 15);
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int []asd=new int[arr.GetLength(0)];
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum+=arr[i, j];
            }
            asd[i]=sum;
        }
        int max = asd[0];
        int k = 0;
        for (int i = 0; i < asd.Length; i++)
        {
            if (asd[i] > max)
            {
                max = asd[i];
                k = i;
            }
        }
        Console.WriteLine("Номер строки: "+k);
        Console.WriteLine("Максимум : "+max);

    }
    
}


