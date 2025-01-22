namespace CalcApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.MapGet("/add", (int num1, int num2) => AddNumbers(num1, num2));

            app.MapGet("/sub", (int num1, int num2) => SubNumbers(num1, num2));

            app.Run();


            string AddNumbers(int num1, int num2)
            {
                return $"Summan av {num1} och {num2} är: {num1 + num2}";
            }

            string SubNumbers(int num1, int num2)
            {
                return $"Summan av {num1} och {num2} är: {num1 - num2}";
            }
        }


   
    }
}
