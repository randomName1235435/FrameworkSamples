using IronPython.Hosting;

dynamic pyhthon = Python.CreateRuntime().UseFile("./multiplier.py");
var multiplier = pyhthon.multiplier;

int result = multiplier.calculate(10, 10);

Console.WriteLine($"result {result}");