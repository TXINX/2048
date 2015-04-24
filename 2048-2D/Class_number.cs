using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048_2D
{
    class Class_Number
    {
        int[,] OutputArray=new int[4,4];
        public Class_Number()
        {
        }

        public void restart()
        {
            Initialize(OutputArray);
        }
        public string Final_Output(System.Windows.Forms.Button a)
        {
         //   Initialize(OutputArray);
            Deal_With_Directions(a);
            OutputArray = Deal_With_Array(OutputArray);
            OutputArray = Get_An_Random_Two(OutputArray);
            string Final_Output = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
			{
                if (OutputArray[i,j]==0)
                {
                    Final_Output += "     ";
                }
                else
                {
                    string b = OutputArray[i, j].ToString();
                    int l = b.Length;
                    int k = (5-l) / 2;
                    for (int x = 0; x < k; x++)
                    {
                        Final_Output += " ";
                    }
                    Final_Output += b;
                    for (int y = 0; y < 5-l-k; y++)
                    {
                        Final_Output += " ";
                    }
                    
                }
                    
			}
                Final_Output += " \n\n";
            }
            return Final_Output;
        }
/// <summary>
/// 
/// </summary>
/// <param name="Parameter_1"></param>
        int[,] Initialize(int[,] Parameter_1)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Parameter_1[i, j] = 0;
                }
            }
            return Parameter_1;
        }
/// <summary>
///
/// </summary>
/// <param name="Parameter_3"></param>
        int[,] Deal_With_Array(int[,] Parameter_3)
        {
            int[,] TempraryArray=new int[4,4];
         //   int[,] Counting = new int[1, 4];



            if (vector == "down")
            {
                int n = 3;
                for (int j = 3; j > -1; j--)
                {
                    int m = 3;
                    for (int i = 3; i > -1; i--)
                    {
                        if (Parameter_3[i, j] != 0)
                        {
                            TempraryArray[m, n] = Parameter_3[i, j];
                            --m;
                        }
                    }
                    --n;
                }

                n = 3;
                for (int j = 3; j > -1; j--)
                {
                    int m = 3;
                    for (int i = 3; i > -1; i--)
                    {
                        if (i > 0 && TempraryArray[i, j] == TempraryArray[i - 1, j])
                        {
                            TempraryArray[m, n] = 2 * TempraryArray[i, j];
                            TempraryArray[i - 1, j] = 0;
                            i--;
                        }
                        else
                        {
                            TempraryArray[m, n] = TempraryArray[i, j];
                        }
                        --m;
                    }
                    --n;
                }
            }



            if (vector == "up")
            {
                int n = 0;
                for (int j = 0; j < 4; j++)
                {
                    int m = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (Parameter_3[i, j] != 0)
                        {
                            TempraryArray[m, n] = Parameter_3[i, j];
                            ++m;
                        }
                    }
                    ++n;
                }

                n = 0;
                for (int j = 0; j < 4; j++)
                {
                    int m = 0;
                    for (int i = 0; i < 4; i++)
                    {                        
                            if (i < 3&&TempraryArray[i, j] == TempraryArray[i + 1, j])
                            {
                                TempraryArray[m, n] = 2 * TempraryArray[i, j];
                                TempraryArray[i + 1, j] = 0;
                                i++;
                            }
                            else
                            {
                                TempraryArray[m, n] = TempraryArray[i, j];
                            }
                            ++m;
                    }
                    ++n;
                }
            }



            if (vector == "right")
            {
                int m = 3;
                for (int i = 3; i > -1; i--)
                {
                    int n = 3;
                    for (int j = 3; j > -1; j--)
                    {
                        if (Parameter_3[i, j] != 0)
                        {
                            TempraryArray[m, n] = Parameter_3[i, j];
                            --n;
                        }
                    }
                    --m;
                }

                m = 3;
                for (int i = 3; i > -1; i--)
                {
                    int n = 3;
                    for (int j = 3; j > -1; j--)
                    {

                        if (j > 0 && TempraryArray[i, j] == TempraryArray[i, j - 1])
                        {
                            TempraryArray[m, n] = 2 * TempraryArray[i, j];
                            TempraryArray[i, j - 1] = 0;
                            j--;
                        }
                        else
                        {
                            TempraryArray[m, n] = TempraryArray[i, j];
                        }
                        --n;

                    }
                    --m;
                }
            }



            if (vector == "left")
            {
                int m = 0;
                for (int i = 0; i < 4; i++)
                {
                    int n = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        if (Parameter_3[i, j] != 0)
                        {
                            TempraryArray[m, n] = Parameter_3[i, j];
                            ++n;
                        }
                    }
                    ++m;
                }

                m = 0;
                for (int i = 0; i < 4; i++)
                {
                    int n = 0;
                    for (int j = 0; j < 4; j++)
                    {

                        if (j < 3 && TempraryArray[i, j] == TempraryArray[i, j + 1])
                        {
                            TempraryArray[m, n] = 2 * TempraryArray[i, j];
                            TempraryArray[i, j + 1] = 0;
                            j++;
                        }
                        else
                        {
                            TempraryArray[m, n] = TempraryArray[i, j];
                        }
                        ++n;
                    }
                    ++m;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (TempraryArray[i,j]==2048)
                    {
                        Initialize(TempraryArray);
                        System.Windows.Forms.MessageBox.Show("你赢啦！");
                    }
                }
            }

            return TempraryArray;
        }
/// <summary>
/// 
/// </summary>
/// <param name="Parameter_2"></param>
        int[,] Get_An_Random_Two(int[,] Parameter_2)
        {
           // Random Random_Number2 = new Random();
            Random Random_Number = new Random();
            int Counting_The_Empty=0;
            int[] Temprary_Array1=new int[16];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Parameter_2[i,j]==0)
	                    {
                            Temprary_Array1[Counting_The_Empty]=4*i+j;
		                    ++Counting_The_Empty;
	                    }
                }
            }
            int k = (Temprary_Array1[Random_Number.Next(Counting_The_Empty)] - (Temprary_Array1[Random_Number.Next(Counting_The_Empty)] % 4)) / 4;
            int l = Temprary_Array1[Random_Number.Next(Counting_The_Empty)] % 4; 
            Parameter_2[k,l]=(Random_Number.Next(2)+1)*2;
            return Parameter_2;
        }


        string vector;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Parameter_Button1"></param>
        void Deal_With_Directions(System.Windows.Forms.Button Parameter_Button1)
        {
            vector = Parameter_Button1.Name;
        /*    switch (Parameter_Button1.Name)
            {
                case "up":
                    vector[0, 1] = -1;
                    break;
                case "down":
                    vector[0, 1] = 1;
                    break;
                case "left":
                    vector[0, 0] = -1;
                    break;
                case "right":
                    vector[0, 0] = 1;
                    break;
                default:
                    break;
            }*/
        }
        
    }
}
