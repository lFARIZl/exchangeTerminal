using System.Globalization;

namespace exchange_rate
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] rateCurrency = new string[4]
            { "show-recent-currency-rates",
                "find-currency-rate-by-code",
                "calculate-amount-by-currecy",
                "Exit" };

            string[] rateCurrencyInAze = new string[4]
            { "azn mezenneleri ile tanıs olma",
                "ixtiyari secilmis azn mezennesi ile tanıs olma.",
                " ixtiyari secilmis azn mezennesi ile tanıs olma ve daxil edilmis mezennenin hesablanmasi",
                "terminaldan cixis" };

            double[] rateCurrencyExchange = new double[4]
            { 1.7000,
                1.8011,
                0.0898,
                0.0224};

            string[] rateCurrencyExchangeAlpha = new string[4]
            { "USD",
                "EURO",
                "TRY",
                "RUB" };

            Console.WriteLine("ATM`e xos gelmisiniz");
            int check = 0;
            while (check < rateCurrency.Length)
            {
                Console.WriteLine($"{rateCurrency[check]} - {rateCurrencyInAze[check]}");
                check++;
            }

            Console.Write("Yuxarıdakı Secimlerden Birini Ediniz : ");
            string EnterYourChoice = Console.ReadLine();


            Console.WriteLine("------------------------------------------------");


            while (EnterYourChoice != rateCurrency[3])
            {
                check = 0;
                while (check < rateCurrency.Length)
                {
                    Console.WriteLine($"{rateCurrency[check]} - {rateCurrencyInAze[check]}");
                    check++;
                }

                Console.Write("Yuxarıdakı Secimlerden Birini Ediniz : ");
                EnterYourChoice = Console.ReadLine();

                if (EnterYourChoice == rateCurrency[0])
                {
                    Console.WriteLine("Valyuta Kod Kurs");
                    check=0;
                    while (check < rateCurrencyExchangeAlpha.Length)
                    {
                        Console.WriteLine($"{rateCurrencyExchangeAlpha[check]}  {rateCurrencyExchange[check]}");

                        check++;
                    }
                }

                else if (EnterYourChoice == rateCurrency[1])
                {
                    Console.Write("Tanis Olmaq Istediyiniz Mezennenin Kodunu Daxil Edin :");
                    String alpha3Code = Console.ReadLine();

                    {
                        if (alpha3Code == rateCurrencyExchangeAlpha[0])
                        {
                            Console.WriteLine("Valyuta Kod Kurs");
                            Console.WriteLine($"{rateCurrencyExchangeAlpha[0]}  {rateCurrencyExchange[0]}");
                        }

                        else if (alpha3Code== rateCurrencyExchangeAlpha[0])
                        {
                            Console.WriteLine("Valyuta Kod Kurs");
                            Console.WriteLine($"{rateCurrencyExchangeAlpha[1]}  {rateCurrencyExchange[1]}");
                        }

                        else if (alpha3Code == rateCurrencyExchangeAlpha[2])
                        {
                            Console.WriteLine("Valyuta Kod Kurs");
                            Console.WriteLine($"{rateCurrencyExchangeAlpha[2]}  {rateCurrencyExchange[2]}");
                        }

                        else if (alpha3Code == rateCurrencyExchangeAlpha[3])
                        {
                            Console.WriteLine("Valyuta Kod Kurs");
                            Console.WriteLine($"{rateCurrencyExchangeAlpha[3]}  {rateCurrencyExchange[3]}");
                        }

                        else
                        {
                            Console.WriteLine("Qeyd Etdiyiniz Mezenne Siyahida Yoxdur Zehmet Olmasa Yeniden Yoxlayin");
                        }

                    }

                }

                else if (EnterYourChoice == rateCurrency[2])
                {
                    Console.Write("Hesaplamaq Istediyiniz Mezennenin Kodunu Daxil Edin :");
                    String alpha3Code = Console.ReadLine();

                    Console.Write("Hesaplamaq Istediyiniz Mezennenin Qiymetini Daxil Edin :");
                    double amount = Convert.ToDouble (Console.ReadLine());

                    if (alpha3Code == rateCurrencyExchangeAlpha[0])
                    {

                        double usdAmountCalc = amount * rateCurrencyExchange[0];

                        Console.Write("");
                        Console.WriteLine(usdAmountCalc + $"{rateCurrencyExchangeAlpha[0]}  {rateCurrencyExchange[0]}");
                    }

                    else if (alpha3Code == rateCurrencyExchangeAlpha[1])

                    {
                        double euroAmountCalc = amount * rateCurrencyExchange[1];

                        Console.Write("");
                        Console.WriteLine(euroAmountCalc + $"{rateCurrencyExchangeAlpha[1]}  {rateCurrencyExchange[1]}");
                    }

                    else if (alpha3Code == rateCurrencyExchangeAlpha[2])
                    {

                        double tryAmountCalc = amount * rateCurrencyExchange[2];

                        Console.Write("");
                        Console.WriteLine(tryAmountCalc + $"{rateCurrencyExchangeAlpha[2]}  {rateCurrencyExchange[2]}");
                    }

                    else if (alpha3Code == rateCurrencyExchangeAlpha[3])
                    {
                        double rublAmountCalc = amount * rateCurrencyExchange[3];

                        Console.Write("");
                        Console.WriteLine(rublAmountCalc + $"{rateCurrencyExchangeAlpha[3]}  {rateCurrencyExchange[3]}");
                    }

                    else
                    {
                        Console.WriteLine("Qeyd Etdiyiniz Mezenne Siyahida Yoxdur Zehmet Olmasa Yeniden Yoxlayin");
                    }

                    Console.ReadLine();
                }

                else if (EnterYourChoice == rateCurrency[3])
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil Etdiyiniz Komanda Yalnisdir Yeniden Secim Edin");
                }
            }
        }
    }
}