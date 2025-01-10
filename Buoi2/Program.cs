using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap so thu nhat: ");
            //string data = Console.ReadLine();

            //float number1 = float.Parse(data);

            //Console.Write("Nhap so thu hai: ");
            //data = Console.ReadLine();

            //float number2 = float.Parse(data);

            //Console.WriteLine("Tong: " + (number1 + number2));
            //Console.WriteLine("Hieu: " + (number1 - number2));
            //Console.WriteLine("Tich: " + (number1 * number2));
            //Console.WriteLine("Thuong: " + (number1 / number2));

            //Console.WriteLine("Math: " + Math.Abs((Math.Pow(8, 1.0f/3))));

            //bool c = !((number1 < number2) || (number1 == number2));
            //Console.WriteLine(c);

            //string s1 = "Hell0";
            //string s2 = "hell0";
            //Console.WriteLine(string.Compare(s1, s2, true));    //Trả về 0 thì giống nhau, khác 0 là khác nhau
            //                                                    //Bth để mặc định là false, tức nghĩa là so sánh tuyệt đối phân biệt chữ hoa
            //                                                    //chữ thường, còn true là không phân biệt hoa, thường
            //string s3 = "Hello ThaiLee";
            //string s4 = "ThaiLee Hello ";
            //Console.WriteLine(s3.Substring(6, 6));              //Bắt đầu lấy ở kí tự thứ 6 và lấy 6 kí tự

            //Console.WriteLine(s3.Contains(s4));                 //Kiểm tra xem s3 có chứ s4 hay không
            //Console.WriteLine(s3.StartsWith(s4));               //Kiểm tra xem s3 có bắt đầu bằng s4 hay không

            //string s5 = "         Hello MF         ";           //Xóa hết các dấu cách ở đầu và đít của string
            //Console.WriteLine(s5.Trim() + "uck");

            //Console.WriteLine("Nhap vao so thu 1: ");
            //Console.WriteLine("Nhap vao so thu 2: ");

            //string s = "Please input number {0} -- {1} -- {2}: ";                 //Cách khác tối ưu hơn trên
            //Console.WriteLine(string.Format(s, "Thai", 3, 5));
            //Console.WriteLine(string.Format(s, 2, 4, 6));

            //bool c = true;
            //if (c)
            //{
            //    Console.WriteLine("Hello");
            //    int a = 1;
            //    int b = 2;
            //}
            //else if (c == false)
            //{
            //    Console.WriteLine("Bye!");
            //}
            //else
            //{
            //    Console.WriteLine("PP");
            //}

            //Bai tap
            //string s = "Input number {0}: ";

            //Console.Write(string.Format(s, 1));
            //string data = Console.ReadLine();
            //float number1 = float.Parse(data);

            //Console.Write(string.Format(s, 2));
            //data = Console.ReadLine();
            //float number2 = float.Parse(data);

            ////Cách 1:
            //float maxNum = (Math.Abs(number1 - number2) + (number1 + number2)) / 2;
            //Console.WriteLine("So lon nhat la: " + maxNum);

            //Cách 2:
            //string result = "So lon nhat la";
            //result += (number1 >= number2 ? number1 : number2);

            //Cách 3:
            //if (number1 > number2)
            //{
            //    Console.WriteLine(number1);
            //}
            //else if (number1 == number2) 
            //{ 
            //    Console.WriteLine(number2); 
            //}
            //else
            //{
            //    Console.WriteLine(number2);
            //}

            //string s = "Input number {0}: ";
            //Console.Write(string.Format(s, 1));

            //string data = Console.ReadLine();

            //float number1 = 0;
            //Console.WriteLine(float.TryParse(data, out number1));
            //Console.WriteLine(number1);
            //if (!float.TryParse(data, out number1))
            //{
            //    Console.WriteLine("Parse khong thanh cong");
            //    return;
            //}

            //float number2 = 0;
            //Console.Write(string.Format(s, 2));
            //data = Console.ReadLine();
            //float.TryParse(data, out number2);

            //bool result = true;
            //do
            //{
            //    int number1 = 0;
            //    Console.Write("Nhap 1 so nguyen: ");
            //    string data = Console.ReadLine();
            //    result = int.TryParse(data, out number1);
            //    Console.WriteLine(result);
            //} while (result == false);

            //Console.Write("Nhap vao 1 so nguyen: ");
            //string data = Console.ReadLine();
            //int num = 0;
            //while (!int.TryParse(data, out num))
            //{
            //    Console.Write("Khong the parse du lieu, nhap lai: ");
            //    data = Console.ReadLine();
            //}
            //Console.WriteLine("Success!");


        }
    }
}
