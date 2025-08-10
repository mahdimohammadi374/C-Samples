namespace EventsProject;

internal sealed class NotificationService
{
    // Subscriber must have a method based on defined delegate by publisher
    internal void NotifyAdmin(object sourec, UpdatePriceEventArgs args)
    {
        Console.WriteLine($"Price of Stock {args.Symbol} changed from {args.OldPrice} to {args.NewPrice}");
    }
}
