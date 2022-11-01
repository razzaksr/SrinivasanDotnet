using SrinivasanBasic;

Blocks bk = new Blocks();
bk.dollarToRupees(9000);
bk.dollarToRupees(700);
bk.dollarToRupees(0);
bk.dollarToRupees(12);

float term=bk.cmToInch(156);
Console.WriteLine(term);

//bk.eric(2, 3);
//bk.access();

//int ot=bk.otp();
//Console.WriteLine(ot);

Console.WriteLine(bk.otp());


// call by value
int cosmo = 45, delta = 90;
Console.WriteLine(cosmo+" "+delta);
bk.just(cosmo, delta);
Console.WriteLine(cosmo + " " + delta+" @ main");

// call by reference
bk.just(ref cosmo, ref delta);
Console.WriteLine(cosmo + " " + delta + " @ main");

int j=bk.hello();
Console.WriteLine(j);

Blocks.swaps(out cosmo, out delta);
Console.WriteLine("After out " + cosmo + " and " + delta);