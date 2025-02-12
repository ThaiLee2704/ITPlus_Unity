using System;
using System.Collections;
using System.Collections.Generic;


namespace Buoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1 = 1;
            //int num2 = 1;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //for (int i = 2; i < 15; i++)
            //{
            //    int sum = num1 + num2;
            //    Console.WriteLine(sum);

            //    num1 = num2;
            //    num2 = sum;
            //}

            //int[] fibo = new int[15];

            //fibo[0] = 1;
            //fibo[1] = 1;

            //for (int i = 2; i < 15; i++)
            //{
            //    fibo[i] = fibo[i - 1] + fibo[i - 2];
            //}

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(fibo[i]);
            //}

            //string S = "Hello";
            //Console.WriteLine(S[0]);

            //string[] S1 = new string[3];

            //S1[0] = "234";
            //Console.WriteLine(S1[0][1]);

            //string data = Console.ReadLine();

            ////for (int i = data.Length - 1; i >= 0; i--)
            ////{
            ////    Console.Write(data[i]);
            ////}

            //foreach (char c in data)    //Duyệt qua mảng không quan tâm thứ tự
            //{                           //Dùng cho những trường hợp duyệt qua mảng nhanh, tối ưu hóa hơn for
            //    Console.Write(c);
            //}

            //Bai tap 1:
            //string s = "Nhap vao so thu {0}: ";

            //string data;
            //int[] arr = new int[10];
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(string.Format(s, i + 1));
            //    data = Console.ReadLine();
            //    arr[i] = int.Parse(data);
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);

            //Console.Write("Nhap vao so thu 11: ");
            //data = Console.ReadLine();
            //int num = int.Parse(data);

            //foreach (int child in arr)
            //{
            //    if (num == child)
            //    {
            //        Console.WriteLine("Trung");
            //        break;
            //    }
            //}
            //Console.WriteLine(num + " & " + (sum / arr.Length));
            //Console.WriteLine("So lon hon la: " + (num > (sum / arr.Length) ? num : (sum / arr.Length)));

            //Bai tap 2:
            //string s = "Nhap vao so thu {0}: ";
            //int[] arr = new int[10];
            //string data;
            //bool check;
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write(string.Format(s, i + 1));
            //        data = Console.ReadLine();
            //        check = int.TryParse(data, out arr[i]);
            //        Console.WriteLine(check);
            //    } while (check == false);
            //}

            //foreach (int child in arr)
            //{
            //    if (child % 2 != 0)
            //        continue;
            //    sum += child;
            //}

            //Console.Write(sum);

            ///////////////////////////////////////////////
            //float[] A = new float[10];
            //A[0] = 1;

            //float[,] A1 = new float[3, 5];

            //List<int> B = new List<int>() {2, 1, 2 };
            //List<List<int>> B1 = new List<List<int>>();

            //B.Add(5);

            //B.RemoveAll(t => t == 2);

            //B.RemoveAt(0);      //Remove tại vị trí

            //B.Contains(5);      //Kiếm tra xem 5 có nằm trong List không

            //B.IndexOf(5);       //Nằm ở vị trí nào

            //foreach (int child in B)
            //{
            //    Console.WriteLine(child);
            //}

            ////Console.WriteLine(B.Count);

            ////List lấy dữ liệu ra thì cần truyền index vào để biết lấy phần từ nào và dùng để làm gì đó
            ////còn Stack và Queue thì k cần index và lấy ra là xóa luôn nên cần 1 biến để hứng

            //Stack<int> C = new Stack<int>();        //First In Last Out hoặc Last In First Out
            //C.Push(10);
            //C.Push(-3);
            //int num = C.Pop();

            //Queue<int> D = new Queue<int>();        //FIFO hoặc LILO
            //D.Enqueue(-100);
            //num = D.Dequeue();

            //HashSet<int> E = new HashSet<int>();    //Chỉ lưu những dữ liệu độc nhất và không cần truyền index

            //Dictionary<string , int> dict = new Dictionary<string , int>(); //Quản lý giá trị bằng 1 giá trị key khác, mỗi giá trị chỉ được 1 key
            //                                                                //Khi gọi giá trị chỉ cần gọi key
            //dict.Add("Key1", 10);
            //num = dict["key1"];

            /////////////////////
            //BUBBLE SORT
            //int[] A = new int[10] {8, 6, 34, 22, 40, 5, 11, 23, 44, 18};

            //for (int i = 0; i < A.Length - 1; i++)
            //{
            //    for (int j = A.Length - 1; j > i; j--)
            //    {
            //        if (A[j] < A[j - 1])
            //        {
            //            int tmp = A[j];
            //            A[j] = A[j - 1];
            //            A[j - 1] = tmp;
            //        }
            //    }
            //}

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //Bai tap
            string[] name = new string[10] {"Ha", "Hung", "Lan", "Tuan", "Tu", "Dat", "Tung", "Phuong", "Cuong", "Thanh"};
            float[] Score = new float[10] {25.5f, 21.25f, 26.75f, 22.75f, 19.5f, 20.0f, 24.5f, 28.75f, 25.5f, 20.75f};

            for (int i = 0; i < Score.Length - 1; i++)
            {
                for (int j = Score.Length - 1; j > i; j--)
                {
                    if (Score[j] < Score[j - 1])
                    {
                        float tmp = Score[j];
                        Score[j] = Score[j - 1];
                        Score[j - 1] = tmp;

                        string tmp2 = name[j];
                        name[j] = name[j - 1];
                        name[j - 1] = tmp2;
                    }
                }
            }

            for (int i = 0; i < Score.Length; i++)
            {
                Console.Write(Score[i] + " ");
                Console.WriteLine(name[i]);
            }
        }
    }
}
