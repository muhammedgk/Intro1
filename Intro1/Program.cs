// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");
string message1 = "Krediler";
int term = 12;
double amount = 100000;


string kredi1 = "Kredi 1";
string kredi2 = "Kredi 2";
string kredi3 = "Kredi 3";
string kredi4 = "Kredi 4";
string kredi5 = "Kredi 5";

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };
//foreach (string s in loans)
//{
//    Console.WriteLine(s);
//}
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 = new Course();
course1.Id = 1;
course1.Name = "İngilizce";
course1.Description = "Mük";
course1.Price = 100;

Course[] courses = { course1 };


CourseManager courseManager = new CourseManager();
courseManager.GetAll();

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Emine";
customer1.LastName = "Çetin";
customer1.CustomerNumber = "12345";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "89345678910";
customer2.FirstName = "Muhammed";
customer2.LastName = "Gedük";
customer2.CustomerNumber = "51329";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "123646";
customer3.TaxNumber = "123578945321";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "123649";
customer4.TaxNumber = "123578945324";

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities1[0]);
BaseCustomer[] customers = {customer1,customer2,customer3,customer4};

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
