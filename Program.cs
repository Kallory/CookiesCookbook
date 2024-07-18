namespace Cookbook {
    internal class Program {
        private static void Main(string[] args) {
            

            CookbookController cookbookController = new CookbookController();
            cookbookController.Initialize();

            
            Console.ReadLine();
        }
    }
}