using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_vs_string
{
    class Constructor
    {
        private GeneratorDataMaze dataGenerator;

        public int[,] data
        {
            get; private set;
        }

        //1- означает стену, а 0 — пустое пространство, то есть сетка по умолчанию выглядит как окружённая стеной комната.
        void Awake()
        {
            dataGenerator = new GeneratorDataMaze();
         //--------------------------------------------------------   
            data = new int[,]       // для теста
            {                       //
            {1, 1, 1},              // =========
            {1, 0, 1},              // ===...===
            {1, 1, 1}               // =========
            };
         //---------------------------------------------------------
            GenerateNewMaze(13, 15); // вызвали размер сетки
        }

         public void Display()
        {
            Awake();
            int[,] maze = data;
            int rMax = maze.GetUpperBound(0);
            int cMax = maze.GetUpperBound(1);

            string msg = "";

            //Заменим цифры масива
            for (int i = rMax; i >= 0; i--)
            {
                for (int j = 0; j <= cMax; j++)
                {
                    if (maze[i, j] == 0)
                    {
                        msg += "...";
                    }
                    else
                    {
                        msg += "===";
                    }
                }
                msg += "\n";
            }
            Console.WriteLine(msg);
        }

        // создадим метод определяюший размере лабиринта (кол строк и столбцов)
        public void GenerateNewMaze(int sizeRows, int sizeCols)
        {
            if (sizeRows % 2 == 0 && sizeCols % 2 == 0)
            {
               Console.Write("Нечетные числа работают лучше для размера подземелья.");
            }

            this.data = dataGenerator.FromDimensions(sizeRows, sizeCols);
        }
    }
}
