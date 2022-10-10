// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
using MyFiles;

Hai h = new Hai();
h.saySome();

Access ac = new Access();
ac.doSome();
*/

/*
// data types: variable>> data storage

int hai = 89;
Console.WriteLine(sizeof(int));

Console.WriteLine(hai);


Int64 mobile = 87654678987656;
Console.Write(mobile+" "+sizeof(Int64));

string hey = "Zealous Tech Corp";
Console.WriteLine("\n"+hey+" "+hey.Length);

String org = "Wipro LTD";
Console.WriteLine(org+" "+org.Length);

//char byte= 'E';
//char continue= 'E';

*/

/*
dynamic abc=98;
Console.WriteLine(abc);
abc = "Razak Mohamed S";
Console.WriteLine(abc);
*/

// conversion from one type to another:
//  (targetType)original variable>> casting

float accBalance = 4394.512F;
int wallet=0;
int userGiven=0;
Console.WriteLine("Enter the amoun to transfer from account to wallet");
userGiven=Convert.ToInt32(Console.ReadLine());
accBalance=accBalance-userGiven;
wallet = wallet + userGiven;
//wallet =(int) accBalance;// explicit casting: high size to small size
Console.WriteLine("Availabale PayTM wallet balance is "+wallet);
Console.WriteLine("Availabale Account balance is " + accBalance);

/*
double balance = 24500.45;
Console.WriteLine("Enter the amount to deposite ");
int userGiven=Convert.ToInt32(Console.ReadLine());
balance = balance + userGiven; // implicit conversion: small size type high size type
Console.WriteLine("Your current balance is " + balance);
*/

/*
// Parsing/convert
Console.WriteLine("Tell us desired brand, budget and features ");
string brand = Console.ReadLine();//"Redmi";
int budget = Convert.ToInt32(Console.ReadLine());
string features = Console.ReadLine();
Console.WriteLine("Your requirement for the TV with brand of "+
    brand+" had a features like "+features+" under the "+
    budget
    +" has noticed we'll revert back with suggested TV's once process your request");
*/