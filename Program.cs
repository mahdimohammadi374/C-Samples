namespace EventsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("symbol a",1);
            NotificationService notificationService = new NotificationService();
            stock.PriceUpdatedEventHandler += notificationService.NotifyAdmin;

            stock.UpdatePrice(5);

            Console.WriteLine("Hello, World!");
        }
    }
}
