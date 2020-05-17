using System;
using System.Collections.Generic;
using System.Text;

namespace guessTheNumber
{
     class Guess
    {
        Player player = new Player();
        Machine machine = new Machine();
         int min = 0;
         int max= 100;

        int whatIsNumber;
        public void PlayerGuess(int userNumber, int inputUserMode)
        {
            for (int attempts = 4; attempts > -1; attempts--)
                
            {
                Console.Write($"Введите предполагаемое число в диапозоне от {min} да {max}, нажмите Enter: \n");
                if(inputUserMode == 1 || inputUserMode == 2 ) //угадывает человек
                {
                     this.whatIsNumber = player.WhatIsNumber();
                }
                if(inputUserMode == 3 || inputUserMode == 4) //угадывает машина
                {
                    
                     this.whatIsNumber = machine.BinarySearch(max, min);
                    Console.WriteLine(whatIsNumber);
                }
               
                //проверка условия, если неверно введено число;
                if (whatIsNumber < min || whatIsNumber > max) 
                {
                    Console.WriteLine("\nВы ввели  число не удоволетворяющее условиям, будьте аккуратнее"); 
                    attempts++;
                    continue;
                }
                ///Проверка услоивий на совпадение угадываемого числа с загаданным 
                if (whatIsNumber == userNumber)
                {
                    Console.WriteLine("WOW U REALLY MAD, perfect guess");
                    break;
                }
                if (attempts == 0)
                {
                    Console.WriteLine("Увы, вы Looser:(");
                    Console.WriteLine($"Правильное число: {userNumber}");
                    break;
                }
                else
                {
                    Denominator(whatIsNumber, userNumber, min, max);
                    Console.WriteLine($"Увы, неверно. Осталось количество попыток: {attempts}. ");
                   
                }
            }
        }
        //изменение условия диапозона чисел 
        void Denominator(int whatIsNumber, int userNumber, int min, int max) 
        {
            if(whatIsNumber < userNumber)
            {
                this.min = whatIsNumber;
            
            }
            if (whatIsNumber > userNumber)
            {
                this.max = whatIsNumber;
        
            }
        }

    }

}
