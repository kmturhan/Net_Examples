using Events;

Product hardDisk = new Product(50);
hardDisk.ProductName = "Hard Disk";

Product gsm = new Product(50);
gsm.ProductName = "GSM";
gsm.StockControlEvent += Gsm_StockControlEvent;

void Gsm_StockControlEvent()
{
	Console.WriteLine("Gsm about to finish!");
}

for (int i = 0; i < 10; i++)
{
	hardDisk.Sell(10);
	gsm.Sell(10);
	Console.ReadLine();
}