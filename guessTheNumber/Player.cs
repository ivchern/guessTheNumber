using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace guessTheNumber
{
    class Player
    {
        //считываем число и проверяем его
        public int InputUserNumber()
        {
            Console.WriteLine("Введите загадываемое число больше 0 и меньше 100 (ввод скрыт), и нажмите  Enter ");
            string _inputUserNumber = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                
                if (key.Key == ConsoleKey.Enter)
                    break;
                _inputUserNumber += key.KeyChar;
            }

            int inputUserNumber = Convert.ToInt32(_inputUserNumber);

            if (inputUserNumber > 100 || inputUserNumber < 0)
            {
                throw new ArgumentException("Число не может быть меньше 0 и больше 100 равен нулю.", nameof(inputUserNumber));
            }
            return inputUserNumber;
        }

        //Вводим угадываемое число 
        public int WhatIsNumber() //Вводим угадываемое число 
        {
          int guessTheNumber = int.Parse(Console.ReadLine());
            return guessTheNumber;
        }
        
    }



}

