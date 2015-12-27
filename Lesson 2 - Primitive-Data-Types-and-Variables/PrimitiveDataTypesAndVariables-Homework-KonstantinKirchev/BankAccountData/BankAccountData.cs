using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Konstantin";
            string middleName = "Konstantinov";
            string lastName = "Kirchev";
            string holderName = firstName +" "+ middleName +" "+ lastName;
            uint balance =  10000000;
            string bankName = "Central Cooperative Bank";
            string iBAN = "CECBSOF";
            ulong firstCreditCardNumber = 2324354364687;
            ulong secondCreditCardNumber = 2324354364354;
            ulong thirdCreditCardNumber = 2324354364245;
            Console.WriteLine("Holder Name: {0}\nBalance: {1}\nBank Name: {2}\nIBAN: {3}\nFirst Credit Card Number: {4}\nSecond Credit Card Number: {5}\nThird Credit Card Number: {6}",
                holderName, balance, bankName, iBAN, firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
        }
    }

