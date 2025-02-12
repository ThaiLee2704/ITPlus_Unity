using System;
using System.Collections;
using System.Collections.Generic;

namespace Buoi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<KeyValuePair<string, float>> _scores = new List<KeyValuePair<string, float>>()
            //{
            //    new KeyValuePair<string, float>("Ha", 22.5f),
            //    new KeyValuePair<string, float>("Hung", 21.25f),
            //    new KeyValuePair<string, float>("Lan", 26.75f),
            //    new KeyValuePair<string, float>("Tuan", 22.75f),
            //    new KeyValuePair<string, float>("Tu", 19.5f),
            //    new KeyValuePair<string, float>("Dat", 20.0f),
            //    new KeyValuePair<string, float>("Tung", 24.5f),
            //    new KeyValuePair<string, float>("Phuong", 28.75f),
            //    new KeyValuePair<string, float>("Cuong", 25.5f),
            //    new KeyValuePair<string, float>("Thanh", 20.75f)

            //};
            ////Mỗi value được kèm bời 1 key thì nó còn có thứ tự vì nằm trong List
            ////Tương tự như Dictionary nhưng ở đây là list nên ta có thể dùng đến index để sắp xếp còn Dictionary thì k sắp xếp được

            ////inputdata: try
            ////{
            ////    //int[] A = new int[3];
            ////    //A[5] = 3;               //Sai logic ở đây thì nó sẽ bắt Exception 
            ////    Console.WriteLine("Nhap data: ");
            ////    int.Parse(Console.ReadLine());
            ////}
            ////catch (Exception e)
            ////{
            ////    //Console.WriteLine("Errol...!");         //Dùng để rào xem lỗi ở đây không và chương trình còn chạy
            ////    //throw new Exception();                  //có thể bỏ ở bất kì đâu kể cả ngoài try catch để debuging
            ////    goto inputdata;
            ////}
            //////finally
            //////{
            //////    Console.WriteLine("Data hop le");       //Không chạy catch mà chạy finally luôn
            //////}

            ////Checked & Unchecked Exception
            ////int A = int.MaxValue;

            ////checked                 //Dùng để check xem A có tràn bộ nhớ không trong khi nếu k có 
            ////{                       //checked thì A vẫn hiển thị ra nhưng sai
            ////    A++;                //Unchecked thì khi chúng ta muốn bỏ qua 1 trường hợp nào đó, thường dùng
            ////}                       //khi IDE để tự động checked cho mọi số học thì lúc đó k cần dùng checked
            ////                        //để check mà dùng unchecked để bỏ qua số học đó

            ////Console.WriteLine(A);

            //List<string> names = new List<string>() { "Ha", "Hung", "Lan", "Tuan", "Tu", "Dat", "Tung", "Phuong", "Cuong", "Thanh" };
            //List<float> scores = new List<float>() { 25.5f, 21.25f, 26.75f, 22.75f, 19.5f, 20.0f, 24.5f, 28.75f, 25.5f, 20.75f };
            //List<int> intNames = new List<int>();

            //for (int i = 0; i < names.Count; i++)
            //{
            //    int total = 0;
            //    int order = 10000;
            //    for (int j = 0; j < 2; j++)                 //So sánh tổng của 2 kí tự đầu của mỗi tên
            //    {
            //        total += names[i].ToLower()[j] * order;
            //        order /= 100;
            //    }

            //    intNames.Add(total);
            //}

            //for (int i = 0; i < intNames.Count - 1; i++)
            //{
            //    for (int j = intNames.Count - 1; j > i; j--)
            //    {
            //        if (intNames[j] < intNames[j - 1])
            //        {
            //            int tmp = intNames[j];
            //            intNames[j] = intNames[j - 1];
            //            intNames[j - 1] = tmp;

            //            //string tmpName = names[j];
            //            //names[j] = names[j - 1];
            //            //names[j - 1] = tmpName;

            //            //float tmpScore = scores[j];
            //            //scores[j] = scores[j - 1];
            //            //scores[j - 1] = tmpScore;

            //            KeyValuePair<string, float> tmpPair = _scores[j];
            //            _scores[j] = _scores[j - 1];
            //            _scores[j - 1] = tmpPair;
            //        }
            //    }
            //}


            ////for (int i = 0; i < names.Count; i++)
            ////{
            ////    Console.WriteLine(names[i] + "---" + scores[i]);
            ////}

            //for (int i = 0; i < _scores.Count; i++)
            //{
            //    Console.WriteLine(_scores[i].Key + "---" + _scores[i].Value);
            //}

            //foreach (KeyValuePair<string, float> pair in _scores)
            //{
            //    Console.WriteLine(pair.Key + ":" + pair.Value);
            //}

            //BAI TAP
            //inputData: try
            //    {
            //        Console.WriteLine("Nhap vao 1 so nguyen to: ");
            //        int num = int.Parse(Console.ReadLine());
            //        if (num < 2) Console.WriteLine("Day khong phai la so nguyen to");
            //        else if (num == 2 || num == 3) Console.WriteLine(num);
            //        else
            //        {
            //            for (int i = 2; i <= Math.Sqrt(num); i++)
            //            {
            //                if (num % i == 0)
            //                {
            //                    Console.WriteLine("Day khong phai la so nguyen to");
            //                    break;
            //                }
            //                else Console.WriteLine(num);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Day khong phai la so nguyen to");
            //        goto inputData;
            //    }

            //BAI TAP
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
            input: try
                {
                    Console.Write(string.Format("Nhap vao so thu {0}: ", i + 1));
                    int number = int.Parse(Console.ReadLine());
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Khong phai so nguyen, nhap lai");
                    goto input;
                }
            }

            //foreach (int i in numbers)        //Mắc exception do miss giá trị, foreach không hỗ trợ việc danh sách bị thay đổi trong quá trình lặp
            //{
            //    if (i < 5)
            //    {
            //        numbers.Remove(i);

            //    }
            //}

            //foreach (int i in numbers)
            //    Console.Write(i + " ");

            for (int i = numbers.Count - 1; i >= 0; i--)    //Tránh miss giá trị khi remove thì bị hụt index, nên là phải duyệt từ cuối lên đầu
            {                                               //KẾT LUẬN: KHI REMOVE VALUE TRONG LIST THÌ NÊN DUYỆT TỪ CUỐI VỀ ĐẦU
                if (numbers[i] < 5)
                    numbers.Remove(numbers[i]);
                else
                    Console.Write(numbers[i] + " ");
            }

        }

    }
}
