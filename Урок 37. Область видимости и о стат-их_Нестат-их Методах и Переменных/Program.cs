﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_37.Область_видимости_и_о_стат_их_Нестат_их_Методах_и_Переменных
{
    internal class Program
    {
        int a = 11;

        static void Main(string[] args)
        {
            a++;                 // Программа выдает ошибку потому что, мы используем Нестатическую переменную a, обьявленную в классе Programm, в Статическом Методе Main
                                            // (Область видимости для класса Programm и Метода Main на одном уровне, так как класс Programm содержит в себе Метод Main)

            // Если коротко почему Статические методы не могут работать с Нестатическими переменными, потому что для работы класса со статическими переменными
            // у нас нет необходимости создавать обьект этого класса, мы можем поставить после вызова Класса точку и вызвать Статический Метод. Пример:
            // Programm.Foo

            // Чтобы же работать с Нестатическими переменными, необходимо сначала создать Экземпляр Класса, и уже после, используя Экземпляр класса, вызвать переменную Пример:
            // Programm programm = new Programm();
            // programm.a
        }
    }
}