namespace Cookbook {
    internal class Program {
        private static void Main(string[] args) {
            StringsTextualRepository stringsTextualRepository = new StringsTextualRepository();
            List<string> names = new List<string>();
            names.Add("Parker");
            stringsTextualRepository.Write("names.txt", names);

            CookbookController cookbookController = new CookbookController();
            cookbookController.Initialize();

            
            Console.ReadLine();
        }
    }
}