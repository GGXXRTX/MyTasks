using System;
using System.Collections.Generic;
using System.Linq;

public class BankAccount
{
    public int AccountNumber { get; }
    public string AccountHolder { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountNumber = GenerateAccountNumber();
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    private static int GenerateAccountNumber()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // Generates a 6-digit account number
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        else
        {
            Console.WriteLine("Сумма пополнения должна быть положительной.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
        else
        {
            Console.WriteLine("Сумма снятия должна быть положительной.");
        }
    }
}

public class Bank
{
    private List<BankAccount> accounts = new List<BankAccount>();

    public void CreateAccount()
    {
        Console.Write("Введите имя владельца счета: ");
        string accountHolder = Console.ReadLine();
        Console.Write("Введите начальный баланс: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal initialBalance) && initialBalance >= 0)
        {
            BankAccount account = new BankAccount(accountHolder, initialBalance);
            accounts.Add(account);
            Console.WriteLine($"Счет создан. Номер счета: {account.AccountNumber}");
        }
        else
        {
            Console.WriteLine("Некорректный начальный баланс. Баланс должен быть неотрицательным числом.");
        }
    }


    public void DepositToAccount()
    {
        Console.Write("Введите номер счета: ");
        if (int.TryParse(Console.ReadLine(), out int accountNumber))
        {
            Console.Write("Введите сумму пополнения: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                BankAccount account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
                if (account != null)
                {
                    account.Deposit(amount);
                    Console.WriteLine($"Баланс счета {accountNumber} пополнен.");
                }
                else
                {
                    Console.WriteLine("Счет не найден.");
                }
            }
            else
            {
                Console.WriteLine("Некорректная сумма пополнения.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный номер счета.");
        }
    }

    public void WithdrawFromAccount()
    {
        // Аналогичная реализация для снятия средств, как и для пополнения
        Console.Write("Введите номер счета: ");
        if (int.TryParse(Console.ReadLine(), out int accountNumber))
        {
            Console.Write("Введите сумму снятия: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                BankAccount account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
                if (account != null)
                {
                    account.Withdraw(amount);
                    Console.WriteLine($"Баланс счета {accountNumber} изменен.");
                }
                else
                {
                    Console.WriteLine("Счет не найден.");
                }
            }
            else
            {
                Console.WriteLine("Некорректная сумма снятия.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный номер счета.");
        }
    }


    public void CheckBalance()
    {
        Console.Write("Введите номер счета: ");
        if (int.TryParse(Console.ReadLine(), out int accountNumber))
        {
            BankAccount account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                Console.WriteLine($"Баланс счета {accountNumber}: {account.Balance}");
            }
            else
            {
                Console.WriteLine("Счет не найден.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный номер счета.");
        }
    }

    public void ListAllAccounts()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("Счета отсутствуют.");
            return;
        }
        Console.WriteLine("Список всех счетов:");
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine($"Номер счета: {account.AccountNumber}, Владелец: {account.AccountHolder}, Баланс: {account.Balance}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
        int choice;

        do
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Создать новый счет");
            Console.WriteLine("2. Пополнить счет");
            Console.WriteLine("3. Снять деньги со счета");
            Console.WriteLine("4. Проверить баланс");
            Console.WriteLine("5. Вывести все счета");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите пункт меню: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1: bank.CreateAccount(); break;
                    case 2: bank.DepositToAccount(); break;
                    case 3: bank.WithdrawFromAccount(); break;
                    case 4: bank.CheckBalance(); break;
                    case 5: bank.ListAllAccounts(); break;
                    case 0: Console.WriteLine("До свидания!"); break;
                    default: Console.WriteLine("Неверный выбор."); break;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
            }
        } while (choice != 0);
    }
}

