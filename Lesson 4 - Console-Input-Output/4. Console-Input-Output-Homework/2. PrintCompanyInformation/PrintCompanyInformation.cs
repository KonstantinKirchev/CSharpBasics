using System;

    class PrintCompanyInformation
    {
        static void Main()
        {
            string companyName = "Software University";
            string companyAddress = "26 V. Kanchev, Sofia";
            long phoneNumber = 359899555592;
            long? faxNumber = null;
            string webSite = @"http://softuni.bg";
            string managerFirstName = "Svetlin";
            string managerLastName = "Nakov";
            sbyte managerAge = 25;
            long managerPhone = 3592981981;
            Console.WriteLine("{0}\nAddress: {1}\nTel. +{2:000 000 00 00 00}\nFax:{3}(no fax)\nWeb Site: {4}\nManager: {5} {6} (age:\n{7}, tel. +{8:000 0 000 000}",
                companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);

        }
    }

