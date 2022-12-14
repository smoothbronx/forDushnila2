namespace ConsoleApp8 {
    class Program {
        public static void Main(string[] args) {

            var rectangle = new Rectangle(12, 12);
            var roundedRectangle = new RoundedRectangle(6, 12, 12);

            Console.WriteLine(rectangle.GetInformation());
            Console.WriteLine(roundedRectangle.GetInformation());

            rectangle.MultByTwo();
            roundedRectangle.MultByTwo();

            Console.WriteLine(rectangle.GetInformation());
            Console.WriteLine(roundedRectangle.GetInformation());
        }
    }
}