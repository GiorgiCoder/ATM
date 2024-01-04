using System.Collections.Generic;
using System;

class Program
{

    public static List<CardHolder> cardHolders = new List<CardHolder>
        {
            new CardHolder("giorgi", "gio123", 91294710, 0123, "Giorgi", "Otinashvili", 0, 0),
            new CardHolder("temo", "temo123", 42938795, 1234, "Temo", "Otinashvili", 0, 0),
            new CardHolder("malkhazi", "malkhazi123", 74016552, 2345, "Malkhaz", "Doe", 0, 0),
            new CardHolder("ushangi", "ushangi123", 85854926, 3456, "Ushangi", "Vighacishvili", 0, 0),
            new CardHolder("zurabchik", "zura123", 85123926, 4567, "Zura :)", "Avaliani", 0, 0)
        };



    public static void createAccount()
    {

        Console.WriteLine("\nEnter your Name and Surname: ");

        string[] name = Console.ReadLine().Split(" ");
        int cardNo = randomCardNumber();

        while (checkIfExists(cardNo))
        {
            cardNo = randomCardNumber();
        }
        int newPin;
        Console.WriteLine("\nCreate your PIN code: ");

        while (true)
        {
            try
            {
                newPin = int.Parse(Console.ReadLine());
                break;
            }
            catch { Console.WriteLine("\nEnter digits!"); }
        }

    }

    public static int randomCardNumber()
    {
        Random random = new Random();
        return random.Next(00000001, 99999999);
    }

    public static bool checkIfExists(int cardNo)
    {
        foreach (CardHolder ch in cardHolders)
        {
            if (ch.getCardNumber() == cardNo)
                return true;
        }
        return false;
    }

    public static void balance(CardHolder ch)
    {
        Console.WriteLine("\nYour current balance is: " + ch.getBalance() + "$");
    }

    public static void deposit(CardHolder ch)
    {
        Console.WriteLine("\nEnter the amount of deposit: ");
        double dep = double.Parse(Console.ReadLine());
        ch.setBalance(ch.getBalance() + dep);
        Console.WriteLine("\nMoney deposited successfully. Your new balance is: " + ch.getBalance() + "$");
    }

    public static void withdraw(CardHolder ch)
    {
        Console.WriteLine("\nEnter the amount of withdrawal: ");
        double withd = double.Parse(Console.ReadLine());
        if (withd <= ch.getBalance())
        {
            ch.setBalance(ch.getBalance() - withd);
            Console.WriteLine("\nMoney withdrawn successfully. Your new balance is: " + ch.getBalance() + "$");
        }
        else
        {
            Console.WriteLine("\nInsufficient balance!\n");
        }
    }

    public static void changePinCode(CardHolder ch)
    {
        Console.WriteLine("\nEnter new PIN code: ");
        while (true)
        {
            try
            {
                int newPin = int.Parse(Console.ReadLine());
                ch.setPin(newPin);
                Console.WriteLine("\nThe PIN code has been updated successfully!");
                break;
            }
            catch { Console.WriteLine("Enter digits!"); }
        }
    }

    public static bool deleteAccount(CardHolder ch)
    {
        int k = 0;
        Console.WriteLine("\nEnter your PIN code to confirm: ");
        int userPin;
        while (true)
        {
            try
            {
                k++;
                if (k == 4)
                {
                    Console.WriteLine("\nToo many unsuccessful tries. Try again later.");
                    return false;
                }
                userPin = int.Parse(Console.ReadLine());
                if (userPin == ch.getPin())
                {
                    cardHolders.Remove(ch);
                    Console.WriteLine("\nYour account has been deleted successfully.");
                    return true;
                }
                else Console.WriteLine("\nEnter valid PIN code!");
            }
            catch
            {
                Console.WriteLine("\nEnter valid PIN code!");
            }
        }

    }

}