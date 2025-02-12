using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net.Http.Headers;

namespace Buoi5
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int numStudent = NhapSoNguyen("Nhap vao si so cua lop: ");
        //    while (numStudent <= 1)
        //    {
        //        numStudent = NhapSoNguyen("Nhap vao si so cua lop: ");
        //    }
        //    List<KeyValuePair<string, float>> ScoreManager = NhapDSHS(numStudent);

        //    Console.WriteLine("---------Nhap danh sach xong---------");

        //    PrintList(ScoreManager);

        //    Console.WriteLine("---------Sua trung ten xong---------");

        //    DuplicateName(ScoreManager);

        //    PrintList(ScoreManager);

        //}

        //static int NhapSoNguyen(string message)
        //{
        //    int numStudent = 0;

        //input: try
        //    {
        //        Console.Write(message);
        //        numStudent = int.Parse(Console.ReadLine());
        //    }
        //    catch (Exception e)
        //    {
        //        goto input;
        //    }

        //    return numStudent;
        //}

        //static List<KeyValuePair<string, float>> NhapDSHS(int numStudent)   
        //{
        //    List<KeyValuePair<string, float>> ScoreManager = new List<KeyValuePair<string, float>>();

        //    for (int i = 0; i < numStudent; i++)
        //    {
        //        Console.Write("Nhap vao ten hs: ");
        //        string name = Console.ReadLine();

        //        int score = NhapSoNguyen(string.Format("Nhap vao diem cua {0}: ", name));

        //        ScoreManager.Add(new KeyValuePair<string, float>(name, score));
        //    }

        //    return ScoreManager;
        //}

        //static void PrintList(List<KeyValuePair<string, float>> ScoreManager)
        //{
        //    for (int i = 0; i < ScoreManager.Count; i++)
        //    {
        //        Console.WriteLine(ScoreManager[i].Key + "---" + ScoreManager[i].Value);
        //    }
        //}

        //static List<KeyValuePair<string, float>> DuplicateName(List<KeyValuePair<string, float>> ScoreManager)
        //{
        //    List<KeyValuePair<string, float>> tmpScoreManager = new List<KeyValuePair<string, float>>();

        //    for (int i = 0; i < ScoreManager.Count; i++)
        //    {
        //        tmpScoreManager.Add(new KeyValuePair<string, float>(ScoreManager[i].Key, ScoreManager[i].Value));

        //    }

        //    for (int i = 0; i < ScoreManager.Count; i++)
        //    {
        //        ScoreManager = CheckDuplicate(tmpScoreManager[i].Key, ScoreManager);
        //    }

        //    return ScoreManager;
        //}

        //static List<KeyValuePair<string, float>> CheckDuplicate(string name, List<KeyValuePair<string, float>> ScoreManager)
        //{
        //    Dictionary<int, KeyValuePair<string, float>> DuplicatedName = new Dictionary<int, KeyValuePair<string, float>>();
        //    for (int i = 0; i < ScoreManager.Count; i++)
        //    {
        //        if (name.Equals(ScoreManager[i].Key))
        //            DuplicatedName.Add(i, ScoreManager[i]);
        //    }

        //    char extend = 'A';
        //    foreach (KeyValuePair<int, KeyValuePair<string, float>> child in DuplicatedName)
        //    {
        //        KeyValuePair<string, float> pair = child.Value;
        //        pair = new KeyValuePair<string, float>(name + ' ' + extend, pair.Value);

        //        ScoreManager[child.Key] = pair;
        //        extend = (char)((int)extend + 1);
        //    }

        //    return ScoreManager;
        //}

        /////////////////////////////////////////////////////////////////////////////////////

        //static void Main(string[] args)
        //{
        //    //Thread bản chất là chia chường trình chạy thành các luồng chạy song song
        //    //với nhau nhằm tiết kiệm thời gian, chứ như bth chạy thì cái nào gọi trước
        //    //thì được chạy trước sẽ k được tối ưu hóa
        //    //Trong game thực tế có những tác vụ chạy không cần theo đúng tuần tự
        //    //chúng ta có thể chia chúng thành các Thread để chúng có thể chạy song song
        //    //nhằm tối ưu hóa về mặt thời gian
        //    //Unity không hỗ trợ chạy Thread nhưng sẽ có các packet ngoài hỗ trợ việc này
        //    Thread wrk1 = new Thread(JobA);

        //    wrk1.Start();

        //    Thread wrk2 = new Thread(JobB);
        //    Thread wrk3 = new Thread(JobB);

        //    wrk2.Start(0);
        //    wrk2.Join();        //Nó vẫn chạy song song nhưng mà thằng wrk2 chạy xong r wrk3 mới hiển thị
        //    wrk3.Start(250000);

        //}

        //static void JobA()
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    Console.WriteLine("WorkerA Start!");
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Console.WriteLine(0);
        //    //}

        //    int sum = 0;
        //    for (int i = 1; i < 500000; i++)
        //    {
        //        sum += i;
        //    }
        //    stopwatch.Stop();
        //    Console.WriteLine(stopwatch.Elapsed);
        //}

        //static void JobB(object numberStart)
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    Console.WriteLine("WorkerB Start!");
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    Console.WriteLine(1);
        //    //}
        //    int sum = 0;
        //    for(int i = (int)numberStart;i < (int)numberStart + 250000; i++)
        //    {  
        //        sum += i; 
        //    }
        //    Thread.Sleep(1000);

        //    stopwatch.Stop();
        //    Console.WriteLine(stopwatch.Elapsed);
        //}

        ///////////////////////////////////////////////////////////////////////////
        //ĐỌC GHI FILE

        static void Main(string[] args)
        {
            FileStream file = File.Open("Test.txt", FileMode.OpenOrCreate);
            using (StreamReader streamReader = new StreamReader(file))
            {
                //Console.Write(streamReader.ReadToEnd());
                Console.WriteLine(streamReader.ReadLine());
            }
        }
    }
}
