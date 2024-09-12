using Pattern;
bool run = true;
/*
Server instace = Server.Instance;
Console.WriteLine("Выберите действие: " + '\n');


while (run)
{
    Console.WriteLine("1) Добавить адрес\n" +
        "2) Посмотреть все адресы https://\n" +
        "3) Посмотреть все адресы http://\n" +
        "4) Выход");

    byte choose = byte.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            bool start = true;
            Console.Clear();
            Console.WriteLine("Введите символ q чтобы выйти");
            while (start)
            {
                Console.WriteLine("Введите адрес: ");
                string addres = Console.ReadLine();
                if (addres.ToLower() == "q")
                {
                    Console.Clear();
                    break;
                }
                if (eager_sign.AddServer(addres))
                    Console.WriteLine("Успешно!");
                else
                    Console.WriteLine("Не удалось добавить!");
                
            }
            break;

        case 2:
            instace.ShowAllHTTPS();
            break;
        case 3:
            instace.ShowAllHTTP();
            break;
        case 4:
            run = false;
            break;
    }
}
*/
Server1 eager_sign = Server1.Instance;
Console.WriteLine("Выберите действие: " + '\n');
run = true;

while (run)
{
    Console.WriteLine("1) Добавить адрес\n" +
        "2) Посмотреть все адресы https://\n" +
        "3) Посмотреть все адресы http://\n" +
        "4) Выход");

    byte choose = byte.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            bool start = true;
            Console.Clear();
            Console.WriteLine("Введите символ q чтобы выйти");
            while (start)
            {
                Console.Write("Введите адрес: ");
                string addres = Console.ReadLine();
                if (addres.ToLower() == "q")
                {
                    Console.Clear();
                    break;
                }
                if (eager_sign.AddServer(addres))
                    Console.WriteLine("Успешно!");
                else
                    Console.WriteLine("Не удалось добавить!");
                
            }

            break;

        case 2:
            eager_sign.ShowAllHTTPS();
            break;
        case 3:
            eager_sign.ShowAllHTTP();
            break;
        case 4:
            run = false;
            break;
    }
}