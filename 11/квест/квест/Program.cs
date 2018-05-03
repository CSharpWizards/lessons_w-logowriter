using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ты - супергерой. Твоя задача - вызволить принцессу/принца из плена Всемирной Сети, куда она/он попала, по неосторожности ткнув в рекламный баннер. В самом начале ты только-только получил известие о неприятности, и стоишь перед выбором:");
            Console.WriteLine("введите номер ответа 1/2");
            Console.WriteLine("вариант1. Поиграть в Доту ");
            Console.WriteLine("вариант2. Узнать, на каком сайте она застряла");
            int yznat = int.Parse(Console.ReadLine());
            if (yznat == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("вы узнали, что принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob");
            }


            Console.WriteLine("введите номер ответа 1/2/3");
            Console.WriteLine("вариант1. Послушаться совета в адресе сайта и поиграть в Доту");
            Console.WriteLine("вариант2. Перейти на сайт");
            Console.WriteLine("вариант3. Обновить антивирус, а потом перейти на сайт ");
            int yznat2 = int.Parse(Console.ReadLine());
            if (yznat2 == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (yznat2 == 2)
            {
                Console.WriteLine("вы заразились тем же вирусом, что и принцесса и застряли на том же сайте со сломанным компьютером)");
            }
            else
            {
                Console.WriteLine("вы обновили анти вирус, а потом перешли на сайт ");
            }




            Console.WriteLine("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2");
            Console.WriteLine("введите номер ответа 1/2/3");
            Console.WriteLine("вариант1. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            Console.WriteLine("вариант2. Проверить исходный код Капча-Монстра ");
            Console.WriteLine("вариант3. Решить пример и найти ответ 6");
            int yznat3 = int.Parse(Console.ReadLine());
            if (yznat3 == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (yznat3 == 2)
            {
                Console.WriteLine("вы проверили исходный код капча монстра");
                
            }
            else
            {
                Console.WriteLine("ха неудачнег ты думал, что будет так легко выиграть в этом примере есть невидимые скобки и на самом деле он выглядит так (2 + 2) * 2)");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("вы вскрываете код Капча-Монстра и видите, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");



            Console.WriteLine("введите номер ответа 1/2/3");
            Console.WriteLine("вариант1. Круто, пойду попробую так в своей программе!");
            Console.WriteLine("вариант2. Ответить монстру: 6 ");
            Console.WriteLine("вариант3. Заменить цвет всех черный символов на белый и перезагрузить Капчу-Монстра");
            int yznat4 = int.Parse(Console.ReadLine());
            if (yznat4 == 1)
            {
                Console.WriteLine("Ты ты ковырялся там где не надо до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (yznat2 == 2)
            {
                Console.WriteLine("конечно не правильно зря ли подвох находил ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2 ) * 2");
                
            }




                
            Console.WriteLine("введите номер ответа 1/2");
            Console.WriteLine("вариант1. Герою лень считать, и он идет в Доту  ");
            Console.WriteLine("вариант2.Ответить монстру: 8 ");
            int yznat5 = int.Parse(Console.ReadLine());
            if (yznat2 == 1)
            {
                Console.WriteLine("Ты просидел в Доте до утра, и принцессу спас другой хакер");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Капча-Монстр обиженно сопит: \"Как ты догадался? Я же спрятал скобки!\", отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:\\Antivirus\\cure.exe. ");

            }




               Console.WriteLine("введите номер ответа 1/2");
            Console.WriteLine("вариант1. Отправить лекарство принцессе по почте и пойти в Доту   ");
            Console.WriteLine("вариант2. Записать лекарство на флешку и пойти к принцессе/принцу домой");
            int yznat6 = int.Parse(Console.ReadLine());
            if (yznat6 == 1)
            {
                Console.WriteLine("возможно ты забыл но у принцессы/принца сломался комьпьютер и сообщение ей не пришло");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("ура победа");
            }
                Console.ReadLine();
        }
    }
}
