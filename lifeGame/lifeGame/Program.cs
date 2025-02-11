using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace lifeGame
{
    public class Program
    {
        static void Main(string[] args)

        //2중 포문으로 랜덤 숫자 0과 1을 대입
        //큰 2중 포문 안에 작은 2중 포문을 사용하여 칸수를 한 칸씩 줄인 후 큰 2중 포문의 해당 인덱스를 기준으로 작은 2중 포문을 돌려 자신 인덱스 포함 3*3칸의 카운트 갯수를 셈
        //인덱스 세포가 살아 있고 주변 8개를 카운트 하여 3개가 살아 있는 세포면 다음 세포로 살아나고
        //인덱스 세포가 죽어 있고 주변 8개를 카운트 하여 2,3개가 살아 있는 세포면 다음 세포로 살아난다.

        //콘솔에 출력은 별로 나와야 하기 때문에 조건에 만족하면 * 아니면 공백 출력

        //내 오류는 첫번째로 랜덤으로 값을 받은 후 while문에서 첫번째는 잘 돌아가지만 그 다음을 찍어도 계속 같은거만 출력 됨
        //이유는 while문 newArr이 arr을 참조하기 때문이다.(바뀐 newArr을 어떻게 참조 시킬지 생각해봄)
        //그래서 while문 마지막 코드에 arr값을 newArr값으로 변경
        {
            int rows =20;
            int cols = 20;

            int[,] arr = new int[rows, cols];
            int[,] newArr = new int[rows, cols];

           /* //랜덤숫자
            Random random = new Random();
                for(int i = 0; i < rows; i++)
                 {
                     for(int j = 0; j < cols; j++)
                     {
                         arr[i, j] = random.Next(0,2);
                     }
                 }
             while (true)
             {
                 for (int x = 1; x < rows - 1; x++)
                 {
                     for (int y = 1; y < cols - 1; y++)
                     {
                         int count = 0;
                         for (int z = -1; z <= 1; z++)
                         {
                             for (int k = -1; k <= 1; k++)
                             {

                                 if (arr[x + z, y + k] == 1)
                                 {
                                     count++;
                                 }
                             }
                         }

                         if (arr[x, y] == 1)
                         {
                             count--;
                         }

                         if (arr[x, y] == 1 && (count == 2 || count == 3))
                         {
                             newArr[x, y] = 1;
                         }

                         else if (arr[x, y] == 0 && count == 3)
                         {
                             newArr[x, y] = 1;
                         }
                         else
                         {
                             newArr[x, y] = 0;
                         }
                     }
                 }

                 for (int i = 0; i < rows; i++)
                 {
                     for (int j = 0; j < cols; j++)
                     {
                         if (newArr[i, j] == 1)
                         {
                             Console.Write("*");
                         }
                         else
                         {
                             Console.Write(" ");
                         }

                     }
                     Console.WriteLine();
                 }

                 for (int i = 0; i < rows; i++)
                 {
                     for (int j = 0; j < cols; j++)
                     {
                         arr[i, j] = newArr[i, j];
                     }
                 }

                 Console.ReadKey();
                 Console.Clear();

             }*/

            //글라이더(같은 패턴 반복)
            arr[1, 2] = 1;
            arr[2, 3] = 1;
            arr[2, 4] = 1;
            arr[3, 2] = 1;
            arr[3, 3] = 1;

            //0.5초후 자동변환 while문
            int startCount = 0;
            int endCount = 30;
            while (startCount < endCount)
            {
                for (int x = 1; x < rows - 1; x++)
                {
                    for (int y = 1; y < cols - 1; y++)
                    {
                        int count = 0;
                        for (int z = -1; z <= 1; z++)
                        {
                            for (int k = -1; k <= 1; k++)
                            {

                                if (arr[x + z, y + k] == 1)
                                {
                                    count++;
                                }
                            }
                        }

                        if (arr[x, y] == 1)
                        {
                            count--;
                        }

                        if (arr[x, y] == 1 && (count == 2 || count == 3))
                        {
                            newArr[x, y] = 1;
                        }

                        else if (arr[x, y] == 0 && count == 3)
                        {
                            newArr[x, y] = 1;
                        }
                        else
                        {
                            newArr[x, y] = 0;
                        }
                    }
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (newArr[i, j] == 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        arr[i, j] = newArr[i, j];
                    }
                }

                Thread.Sleep(500);
                Console.Clear();
                startCount++;
            }


        }  
    }
}
