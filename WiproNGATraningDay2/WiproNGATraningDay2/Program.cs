internal class Program
{
    private static void Main(string[] args)
    {
        ////string are immutabale
        //string new1 = "Hello";
        //Console.WriteLine(new1 );

        //new1 = new1 + " World";
        //Console.WriteLine(new1 );

        ////where a stringbuilder are muatable

        //StringBuilder new2 = new StringBuilder("Traning");
        //Console.WriteLine(new2 );
        //new2.Append(" Program");
        //Console.WriteLine(new2);


        ////Arrays
        //int[] arr = new int[5];
        //int[] arr2 = new int[5]; 

        //arr[0] = 1; 
        //arr[0] = 2;
        //arr[1] = 3;
        //arr[2] = 4;
        //arr[3] = 5;
        //arr[4] = 6;

        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine("Enter the array values");
        //    arr2[i]=Convert.ToInt16(Console.ReadLine());
        //}

        //foreach (var item in arr2)
        //{
        //    Console.WriteLine(item);
        //}


        //TWo D Array
        //int[,] twoDmatrix = new int[3,3];
        //twoDmatrix[0, 0] = 1;
        //twoDmatrix[0, 1] = 2;
        //twoDmatrix[0, 2] = 3;

        //twoDmatrix[1, 0] = 4;
        //twoDmatrix[1, 1] = 5;
        //twoDmatrix[1, 2] = 6;

        //twoDmatrix[2, 0] = 7;
        //twoDmatrix[2, 1] = 8;
        //twoDmatrix[2, 2] = 9;


        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.Write(twoDmatrix[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}


        //int[] ints = { 971, 223, 763 ,43400,45000};

        //int max = ints[0];

        //for (int i = 1; i < ints.Length; i++)
        //{
        //    if (max < ints[i])
        //    {
        //        max = ints[i];
        //    }
        //}
        //Console.WriteLine("The max elment in the array is: " + max);
        //Console.WriteLine(ints.Length);

        //Array.Sort(ints);
        //show(ints);

        // void show(int[] intss) {
        //    foreach (var item in intss)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


        //Console.WriteLine();
        //Console.WriteLine("Jagged Array");
        //int[][] jagged = new int[3][];

        //jagged[0] = new int[]{ 1, 2, 3 };
        //jagged[1] = new int[]{2, 3, 4 };
        //jagged[2] = new int[]{4, 5, 6 };

        //for (int i = 0; i < jagged.Length; i++)
        //{
        //    for (int j = 0; j < jagged[i].Length; j++)
        //    {
        //        Console.Write(jagged[i][j] + " ");
        //    }
        //    Console.WriteLine();
        //}

        Console.WriteLine("Enter the total no. of teams");
        int teams = Convert.ToInt32(Console.ReadLine());

        int[][] jaggedTeams = new int[teams][];


        for (int i = 0; i < jaggedTeams.Length; i++)
        {

            Console.WriteLine("Enter the number of rounds played by team " + (i + 1));
            int round = Convert.ToInt32(Console.ReadLine());


            jaggedTeams[i] = new int[round];

            for (int j = 0; j < round; j++)
            {
                Console.WriteLine("Enter the score of round " + (j + 1) + " of team " + (i + 1));
                jaggedTeams[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }


        for (int k = 0; k < jaggedTeams.Length; k++)
        {
            Console.WriteLine("Scores for Team " + (k + 1) + ":");

            int totalScore = 0;

            for (int l = 0; l < jaggedTeams[k].Length; l++)
            {
                Console.Write(jaggedTeams[k][l] + " ");
                totalScore += jaggedTeams[k][l];
            }

            Console.WriteLine();
            Console.WriteLine("Total score for Team " + (k + 1) + ": " + totalScore);
        }

    }
}