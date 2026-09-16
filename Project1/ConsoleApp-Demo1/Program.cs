string name = "Bob";
int num = 3;
double temp = 34.4;

string text = $"Hello, \t\t{name}! You have {num} messages in your inbox. The temperature is {temp} celsius.";

//Console.WriteLine(text);
//Console.Write(@"C:       user\zzhplus\invoices");
//Console.WriteLine("h \"a\"");
//Console.WriteLine("c:\\source\\repos");

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt\n");

Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");

//View English output:
//  c:\Exercise\ACME\data.txt

//Посмотреть русский вывод:
//  c:\Exercise\ACME\ru-RU\data.txt