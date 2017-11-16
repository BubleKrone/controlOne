using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace play_ground
{
    interface drawable
    {
        void draw();
    }
    enum block
    {
        you = 'P',
        free = '-',
        woll = '#'
    }
    class cell : drawable
    {
        private char[,] mass = new char[10,10];
        private char cell_1;
        protected char getCell
        {
            get
            {
                return cell_1;                
            }
            set
            {
                cell_1 = value;
            }
        }
        ////////////////////////////
        public void draw()
        {
            Random r = new Random();
            bool check = true;
            for (int j = 1; j < mass.GetLength(0); j++)
            {
                for (int i = 1; i <= mass.GetLength(1); i++)
                {
                    switch (r.Next(0, 5))
                    {
                        case 0:
                            getCell = Convert.ToChar(block.free);
                            break;
                        case 1:
                            getCell = Convert.ToChar(block.free);
                            break;
                        case 2:
                            getCell = Convert.ToChar(block.woll);
                            break;
                        case 3:
                            getCell = Convert.ToChar(block.free);
                            break;
                        default:
                            if (check == true)
                            {
                                getCell = Convert.ToChar(block.you);
                                check = false;
                            }
                            else
                            {
                                getCell = Convert.ToChar(block.free);
                            }
                            break;
                    }

                    Console.Write(" " + getCell);
                    //if (i % 10 == 0)
                    //{
                    //    Console.WriteLine();
                    //}
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            cell qar = new cell();
            bool succes = true;
            ConsoleKeyInfo input;
           
            do
            {
                qar.draw();

                input = Console.ReadKey();
                               
                if (input.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();
                    succes = false;
                }
                else succes = true;
            } while (!succes);
            

            //Console.ReadKey();
        }
    }
}
