namespace EventsProject;

internal sealed class Stock
{
    public Stock(string symbol, decimal price)
    {
        Symbol = symbol;
        _price = price;
    }

    public string Symbol { get; set; }
    private decimal _price;

    // CUSTOM EVENT

    //public delegate void CustomPriceUpdated(object source, UpdatePriceEventArgs args); 
    //public event CustomPriceUpdated PriceUpdated;  


    public event EventHandler<UpdatePriceEventArgs> PriceUpdatedEventHandler;


    public void UpdatePrice(decimal newPrice) 
    {
        if (newPrice == _price) return;
        var oldPrice = _price;
        _price = newPrice;

    
        OnPriceUpdated(new UpdatePriceEventArgs(Symbol,oldPrice,newPrice));  
    }
    
    protected void OnPriceUpdated(UpdatePriceEventArgs args)
    {
        // INVOKE CUSTOM EVENT

        //if(PriceUpdated != null)
        //{
        //    PriceUpdatedEventHandler(this, args);
        //}

        PriceUpdatedEventHandler?.Invoke(this, args);
    }

}
