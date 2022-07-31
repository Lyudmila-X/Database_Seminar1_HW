using System.Text;
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
string text = "ID;Surname;Name;Date Of Birth;Bank Credentials;\n";

int count = 100;

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    string surname = $"Фамилия_{id}";
    string name = $"Имя_{id}";
    int year = random.Next(1950, 2005);
    int month = random.Next(1, 13);
    int day = random.Next(1, 29);
    DateTime birth = new DateTime(year, month, day);
    string bankCredentials = Convert.ToString(random.Next(1000, 10000)) + " " + Convert.ToString(random.Next(1000, 10000)) + " "
                           + Convert.ToString(random.Next(1000, 10000)) + " " + Convert.ToString(random.Next(1000, 10000));
    text += $"{id};{surname};{name};{birth.ToShortDateString()};{bankCredentials};\n";
}

File.WriteAllText("пользователи.csv", text, Encoding.GetEncoding(1251));

string text2 = "ID;Время начала поездки;Время окончания поездки;Адрес парковки начало поездки ID;Адрес парковки конец поездки ID;Пользователь ID;Самокат ID;\n";

int count2 = 100;

for (int id = 1; id <= count2; id++)
{
    int year2 = 2022;
    int month2 = 7;
    int day2 = random.Next(1, 32);
    int hour = random.Next(0, 24);
    int min = random.Next(0, 60);
    int sec = random.Next(0, 60);
    DateTime start = new DateTime(year2, month2, day2, hour, min, sec);
    int value = random.Next(10, 61);
    DateTime finish = start.AddMinutes(value);
    int adressStr = random.Next(0, 25);
    int addressFin = random.Next(0, 25);
    int userID = random.Next(0, 101);
    int scooterID = random.Next(0, 101);
    text2 += $"{id};{start};{finish};{adressStr};{addressFin};{userID};{scooterID};\n";
}

File.WriteAllText("поездки.csv", text2, Encoding.GetEncoding(1251));

string text3 = "ID;Название модели;Количество шт;\n";
int count3 = 5;
for (int id = 1; id <= count3; id++)
{
    string[] model = { "Ninebot MAX Pro", "OKAI S500", "OKAI S400", "OKAI S300", "OKAI S200" };
    int amount= random.Next(1, 51);
     text3 += $"{id};{model[id-1]};{amount};\n";
}
File.WriteAllText("модели самокатов.csv", text3, Encoding.GetEncoding(1251));