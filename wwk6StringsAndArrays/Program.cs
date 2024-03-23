

string hello = "hello, world!";

int stringLenght = hello.Length;

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);
hello = hello.Replace(hello[0], char.ToUpper(hello[0]));
firstLetter = hello[0];
Console.WriteLine(firstLetter);

//int wordCounter = 0;
//for (int i = 0; i < hello.Length; i++)
//{
//  Console.WriteLine($"{i} symbol in string: {hello [i]}");
//}

//Console.WriteLine(stringLenght);


