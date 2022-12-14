namespace ConsoleApp8 {
    class Program {
        public static void Main(string[] args) {
            var roundedRectangle = new RoundedRectangle(6, 12, 12);
            Console.WriteLine(roundedRectangle.GetInformation());
            roundedRectangle.MultByTwo();
            Console.WriteLine(roundedRectangle.GetInformation());
        }
    }
}