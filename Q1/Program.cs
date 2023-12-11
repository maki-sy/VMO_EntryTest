using Q1;

Service service = new Service();
while (true)
{
	double x = service.baseValidate();
	int n = service.expValidate();
	Console.WriteLine("The sum is: "+service.sumOfSquares(x, n));
}