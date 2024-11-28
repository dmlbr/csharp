using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSLight
{
    internal class Program001VariableRu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            // variable
            // declaration and initialization
            // definition, (type + name) this is a variable declaration,
            // the value of a variable is initialization or assignment
            // type + name = value

            // переменная
            // объявление и инициализация
            // определение, (тип + название) это обьявление переменной,
            // значение переменной - это инициализация или присвоение
            // тип + название = значение


            // the main type
            // Integer types

            // основной тип
            // Целочисленные типы

            byte b;
            sbyte sb;
            short s;
            ushort us;
            int i;
            uint ui;
            long l;
            ulong ul;


            byte b2; // 0 до 255
            sbyte sb2; // -128 до 127
            short s2; // -32 768 до 32 767
            ushort us2; // 0 до 65 535
            int i2; // -2 147 483 648 до 2 147 483 647
                    // int (основной тип)
            uint ui2; // 0 до 4 294 672 295
            long l2 = long.MaxValue; // до
            long l3 = long.MinValue; // от
            ulong ul2; //

            float f; // примерно до 7 знаков после запятой
            double d; // примерно  до 15 знаков после запятой

            float f2 = 5.7f; // float < double и без превикса "f" думает, что это double, неявно(опционально) к float добавить нельзя
            double d2 = 5.7; // до 15 знаков после заяпятой

            // float (основной тип)
            // в Unity используется float, float меньше по объему и его обычно достаточно 

            // haracter type
            // символьный тип
            char c = ' ';

            // string type (basic type)
            // строковый тип (основной тип)
            string str = "string Привет, мир! Какб дела?";
            // string is a set of chars
            // string это набор char-ов
            // значит строка это нобар символов


            // logical type
            // boolean variable or bool (basic type)
            // it takes the values true or false

            // логический тип
            // булевая пееменная или bool (основной тип)
            // принимает значения true или false
            bool bl;


            // basic type
            // основные типы
            // int 
            // float
            // string
            // bool


            // name for the variable
            // it should be understandable for others
            // the name conveys the essence of the variable itself
            // in English
            // in camelCase style, the beginning is capitalized and the next word is capitalized
            // there are no underscores, everything is merged
            // the name of the variable reflects the essence of what it will store in itself


            // название для переменной
            // должно быть понятным для других
            // название передает суть самой переменной
            // на английском языке
            // в стиле camleCase, начало с прописной буквы и следущее слово с Заглавной
            // нету подчеркиваний, все слитно
            // имя переменной отражает суть того что она будет в себе хранить

        }
    }
}
