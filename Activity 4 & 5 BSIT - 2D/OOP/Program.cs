﻿using System;
using OOP;
using static System.Console;

class MainProgram
{
    public static void Main()
    {
        OOP.ManageProduct.InsertNewProduct newProduct = new OOP.ManageProduct.InsertNewProduct();

        int limit = 0;

        WriteLine("\r\n  _   _                 __  __                     ____                _            _             _                                                 _     _                     _           ___     \r\n | | | | _____      __ |  \\/  | __ _ _ __  _   _  |  _ \\ _ __ ___   __| |_   _  ___| |_ ___    __| | ___    _   _  ___  _   _  __      ____ _ _ __ | |_  | |_ ___     ___ _ __ | |_ ___ _ _|__ \\  _ \r\n | |_| |/ _ \\ \\ /\\ / / | |\\/| |/ _` | '_ \\| | | | | |_) | '__/ _ \\ / _` | | | |/ __| __/ __|  / _` |/ _ \\  | | | |/ _ \\| | | | \\ \\ /\\ / / _` | '_ \\| __| | __/ _ \\   / _ \\ '_ \\| __/ _ \\ '__|/ / (_)\r\n |  _  | (_) \\ V  V /  | |  | | (_| | | | | |_| | |  __/| | | (_) | (_| | |_| | (__| |_\\__ \\ | (_| | (_) | | |_| | (_) | |_| |  \\ V  V / (_| | | | | |_  | || (_) | |  __/ | | | ||  __/ |  |_|   _ \r\n |_| |_|\\___/ \\_/\\_/   |_|  |_|\\__,_|_| |_|\\__, | |_|   |_|  \\___/ \\__,_|\\__,_|\\___|\\__|___/  \\__,_|\\___/   \\__, |\\___/ \\__,_|   \\_/\\_/ \\__,_|_| |_|\\__|  \\__\\___/   \\___|_| |_|\\__\\___|_|  (_)  (_)\r\n                                           |___/                                                            |___/                                                                                   \r\n ");
        string setters = ReadLine();//how many product do you want to enter?
        int setter;

        Int32.TryParse(setters, out setter);

       if (!Int32.TryParse(setters, out setter)) // Invalid program Count
        {
            Clear();
            WriteLine("\r\n_____  ______   _     _   ______   _       _____  _____      ______   ______   ______   _____    _    _   ______ _______    ______  ______   _    _   ______  _______ .\r\n | |  | |  \\ \\ | |   | | | |  | | | |       | |  | | \\ \\    | |  | \\ | |  | \\ / |  | \\ | | \\ \\  | |  | | | |       | |     | |     / |  | \\ | |  | | | |  \\ \\   | |    \r\n | |  | |  | | \\ \\   / / | |__| | | |   _   | |  | |  | |   | |__|_/ | |__| | | |  | | | |  | | | |  | | | |       | |     | |     | |  | | | |  | | | |  | |   | |    \r\n_|_|_ |_|  |_|  \\_\\_/_/  |_|  |_| |_|__|_| _|_|_ |_|_/_/    |_|      |_|  \\_\\ \\_|__|_/ |_|_/_/  \\_|__|_| |_|____   |_|     |_|____ \\_|__|_/ \\_|__|_| |_|  |_|   |_|    \r\n                                                                                                                                                                       \r\n");

            Main();
        }

        else
        {
            do
            {
                Clear();
                WriteLine("\r\n  _____       _              ____                _            _     _   _                          \r\n | ____|_ __ | |_ ___ _ __  |  _ \\ _ __ ___   __| |_   _  ___| |_  | \\ | | __ _ _ __ ___   ___   _ \r\n |  _| | '_ \\| __/ _ \\ '__| | |_) | '__/ _ \\ / _` | | | |/ __| __| |  \\| |/ _` | '_ ` _ \\ / _ \\ (_)\r\n | |___| | | | ||  __/ |    |  __/| | | (_) | (_| | |_| | (__| |_  | |\\  | (_| | | | | | |  __/  _ \r\n |_____|_| |_|\\__\\___|_|    |_|   |_|  \\___/ \\__,_|\\__,_|\\___|\\__| |_| \\_|\\__,_|_| |_| |_|\\___| (_)\r\n                                                                                                   \r\n ");
                string productName = ReadLine();// enter product name

                if (string.IsNullOrWhiteSpace(productName)) // product name cannot be blank
                {
                    Clear();
                    WriteLine("\n\r\n ______   ______   ______   _____    _    _   ______ _______    ______   ______   _________   ______    ______  ______   ______   ______   ______  _______    ______   ______    ______   _        ______   ______   _    __ .\r\n| |  | \\ | |  | \\ / |  | \\ | | \\ \\  | |  | | | |       | |     | |  \\ \\ | |  | | | | | | | \\ | |       | |     | |  | | | |  \\ \\ | |  \\ \\ / |  | \\   | |     | |  | \\ | |       | |  | \\ | |      | |  | | | |  \\ \\ | |  / /  \r\n| |__|_/ | |__| | | |  | | | |  | | | |  | | | |       | |     | |  | | | |__| | | | | | | | | |----   | |     | |__| | | |  | | | |  | | | |  | |   | |     | |--| < | |----   | |--| < | |   _  | |__| | | |  | | | |-< <   \r\n|_|      |_|  \\_\\ \\_|__|_/ |_|_/_/  \\_|__|_| |_|____   |_|     |_|  |_| |_|  |_| |_| |_| |_| |_|____   |_|____ |_|  |_| |_|  |_| |_|  |_| \\_|__|_/   |_|     |_|__|_/ |_|____   |_|__|_/ |_|__|_| |_|  |_| |_|  |_| |_|  \\_\\  \r\n                                                                                                                                                                                                                              \r\n");
        
                }

                else
                {
                    int productPrice = 0;
                    bool isValidInteger = false;

                    while (!isValidInteger)
                    {
                        WriteLine("\r\n  _____       _              ____                _            _     ____       _              \r\n | ____|_ __ | |_ ___ _ __  |  _ \\ _ __ ___   __| |_   _  ___| |_  |  _ \\ _ __(_) ___ ___   _ \r\n |  _| | '_ \\| __/ _ \\ '__| | |_) | '__/ _ \\ / _` | | | |/ __| __| | |_) | '__| |/ __/ _ \\ (_)\r\n | |___| | | | ||  __/ |    |  __/| | | (_) | (_| | |_| | (__| |_  |  __/| |  | | (_|  __/  _ \r\n |_____|_| |_|\\__\\___|_|    |_|   |_|  \\___/ \\__,_|\\__,_|\\___|\\__| |_|   |_|  |_|\\___\\___| (_)\r\n                                                                                              \r\n ");
                        string priceInput = ReadLine(); // enter product price
                        Clear();

                        isValidInteger = int.TryParse(priceInput, out productPrice);
                        if (!isValidInteger)
                        {
                            WriteLine("\r\n  ___                 _ _     _   _                   _       ____  _                                  _                                 _ _     _   _       _                       \r\n |_ _|_ ____   ____ _| (_) __| | (_)_ __  _ __  _   _| |_    |  _ \\| | ___  __ _ ___  ___    ___ _ __ | |_ ___ _ __    __ _  __   ____ _| (_) __| | (_)_ __ | |_ ___  __ _  ___ _ __ \r\n  | || '_ \\ \\ / / _` | | |/ _` | | | '_ \\| '_ \\| | | | __|   | |_) | |/ _ \\/ _` / __|/ _ \\  / _ \\ '_ \\| __/ _ \\ '__|  / _` | \\ \\ / / _` | | |/ _` | | | '_ \\| __/ _ \\/ _` |/ _ \\ '__|\r\n  | || | | \\ V / (_| | | | (_| | | | | | | |_) | |_| | |_ _  |  __/| |  __/ (_| \\__ \\  __/ |  __/ | | | ||  __/ |    | (_| |  \\ V / (_| | | | (_| | | | | | | ||  __/ (_| |  __/ |   \r\n |___|_| |_|\\_/ \\__,_|_|_|\\__,_| |_|_| |_| .__/ \\__,_|\\__(_) |_|   |_|\\___|\\__,_|___/\\___|  \\___|_| |_|\\__\\___|_|     \\__,_|   \\_/ \\__,_|_|_|\\__,_| |_|_| |_|\\__\\___|\\__, |\\___|_|   \r\n                                         |_|                                                                                                                         |___/           \r\n");
                        } // invalid input product price
                    }
                    Clear();
                    WriteLine("\r\n  _____       _              ____                _            _     ____                      _       _   _                 \r\n | ____|_ __ | |_ ___ _ __  |  _ \\ _ __ ___   __| |_   _  ___| |_  |  _ \\  ___  ___  ___ _ __(_)_ __ | |_(_) ___  _ __    _ \r\n |  _| | '_ \\| __/ _ \\ '__| | |_) | '__/ _ \\ / _` | | | |/ __| __| | | | |/ _ \\/ __|/ __| '__| | '_ \\| __| |/ _ \\| '_ \\  (_)\r\n | |___| | | | ||  __/ |    |  __/| | | (_) | (_| | |_| | (__| |_  | |_| |  __/\\__ \\ (__| |  | | |_) | |_| | (_) | | | |  _ \r\n |_____|_| |_|\\__\\___|_|    |_|   |_|  \\___/ \\__,_|\\__,_|\\___|\\__| |____/ \\___||___/\\___|_|  |_| .__/ \\__|_|\\___/|_| |_| (_)\r\n                                                                                               |_|                          \r\n ");
                    string productDescription = ReadLine(); // enter product description

                    newProduct.InsertData(productName, productPrice, productDescription);
                    limit++;
                    
                }

            } while (limit != setter);
        }
    }
}
