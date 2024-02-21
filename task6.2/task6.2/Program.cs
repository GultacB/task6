string[] NameSurname =new string[5] { "Gultac Baxsizade", "Aysun Memmedova","Mirseyid Eliyev","Vusal Agayev","Aytekin Ibayeva" };
string[] attendance = new string[5] { "Online", "Offline", "Offline", "Online", "Online" };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{NameSurname[i]} {attendance[i]}");
}
