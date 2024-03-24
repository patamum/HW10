namespace Task10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите градусы");
            int grade_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите минуты");
            int minute_ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите секунды");
            int second_ = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(grade_, minute_, second_);
            double totalRadian = angle.ToRadian();
            Console.WriteLine($"{grade_} ° {minute_}' {second_}'' = {totalRadian} рад");
        }
    }
}