using System.Collections.Generic;

using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

using SignalR.StockTicker.WebApp.Models;

namespace SignalR.StockTicker.WebApp.SignalRHubs
{
    [HubName("stockTicker")]
    public class StockTickerHub : Hub
    {
        private readonly Services.StockTicker _stockTicker;

        public StockTickerHub() :
            this(Services.StockTicker.Instance)
        {

        }

        public StockTickerHub(Services.StockTicker stockTicker)
        {
            _stockTicker = stockTicker;
        }

        public IEnumerable<Stock> GetAllStocks()
        {
            return _stockTicker.GetAllStocks();
        }

        public string GetMarketState()
        {
            return _stockTicker.MarketState.ToString();
        }

        public void OpenMarket()
        {
            _stockTicker.OpenMarket();
        }

        public void CloseMarket()
        {
            _stockTicker.CloseMarket();
        }

        public void Reset()
        {
            _stockTicker.Reset();
        }
    }
}