using Open_BootCampo;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Ejercicio4 obj = new Ejercicio4();


Console.WriteLine("===== Condicion If =====");
Console.WriteLine(obj.CondicionIf(-5));

Console.WriteLine("===== Bucle While =====");
obj.BucleWhile(0);

Console.WriteLine("===== Bucle Do While =====");
obj.BucleDoWhile(0);

Console.WriteLine("===== Bucle For =====");
obj.BucleFor();

Console.WriteLine("===== Condicion Switch =====");
obj.CondicionSwitch("Verano");



