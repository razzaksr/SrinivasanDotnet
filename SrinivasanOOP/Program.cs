using SrinivasanOOP;

//DemoSingle demo = new DemoSingle();
//demo.display();


//DemoOverride demo = new DemoOverride();
//demo.search(9.2);
//demo.find(4.5);
/*
Wallet wal1 = new Wallet();
wal1.Number = 876545678345;
wal1.Balance = 3450.5;
wal1.Holder = "Srinivasan";

Wallet wal2 = new Wallet();
wal2.Number = 1122473822301;
wal2.Balance = 9812.4;
wal2.Holder = "Vasan";

Console.WriteLine(wal1);
wal1.deposit(12000);
Console.WriteLine(wal1);
wal1.transfer(wal2, 5400);
Console.WriteLine(wal1);
Console.WriteLine(wal2);
*/

youtube y1 = new youtube();
y1.email = "srini@gmail.com";
y1.password = "pass1srini";
y1.Name = "Srinivasan";
y1.Contact = 87656789343;

y1.isValid();

y1.addToLiked("Microsoft C#");
y1.addToLiked("Dot net framework");
y1.viewMyList();


PlayStore play = new PlayStore();
play.email = "razzaksr@gmail.com";
play.Name = "Razak Mohamed S";
play.password = "razak123";
play.Contact = 87654567897;

play.myApps();
play.install("VLC");
play.install("MX");
play.install("MS Office");
play.install("Temple Run");
play.install("PhonePay");
play.install("Gpay");
play.install("PayTm");
