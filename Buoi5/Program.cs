using System;
using System.Buffers;

namespace k1enn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            MyList list = new MyList();

            // Thêm phần tử vào danh sách
            Console.WriteLine("Nhập các phần tử vào danh sách (AddLast):");
            list.Input2(); // Nhập danh sách từ người dùng
            Console.WriteLine("Danh sách vừa nhập:");
            list.ShowList();

            // Kiểm tra hàm MaxSubString()
            Console.WriteLine("\nKiểm tra hàm MaxSubString():");
            MyList maxSubString = list.MaxSubString(); // Gọi hàm MaxSubString()

            if (maxSubString.Count > 0)
            {
                Console.WriteLine("Đoạn con tăng dần dài nhất có ít nhất 2 phần tử là:");
                maxSubString.ShowList(); // Hiển thị đoạn con tăng dần dài nhất
            }
            else
            {
                Console.WriteLine("Không tìm thấy đoạn con tăng dần dài nhất có ít nhất 2 phần tử.");
            }
        }
    }
}
