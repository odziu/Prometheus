using System;
using System.Reflection;
using System.Linq;

namespace Lab5
{
    public enum Gender { Male, Female };

    public class Cat
    {
        //  1. Автозгенерований параметр тільки для зчитування Name типу string. 
        public string Name { get; }

        //  2. Автозгенерований параметр тільки для зчитування Gender типу Lab5.Gender (enum (дивись нижче)). 
        public Lab5.Gender Gender { get; }

        //  3. Приватне поле _energy типу double. Параметр Energy має записувати і зчитувати значення з цього поля. 
        private double _energy;

        //  4. Публічне статичне readonly поле MaxEnergy типу double зі значенням 20.
        public static readonly double MaxEnergy = 20;

        //  5. Публічне статичне readonly поле MinEnergy типу double зі значенням 0. 
        public static readonly double MinEnergy = 0;

        //  6. Публічне статичне readonly поле SleepEnergyGain типу double зі значенням 10. 
        public static readonly double SleepEnergyGain = 10;

        //  7. Публічне статичне readonly поле JumpEnergyDrain типу double зі значенням 0.5.
        public static readonly double JumpEnergyDrain = 0.5;

        //  8. Параметр для зчитування для всіх(public) та запису(private) Energy типу double. Якщо значення, що записується, менше за MinEnergy, то необхідно кидати помилку(exception) з повідомленням "Not enough energy to jump". Якщо значення більше за MaxEnergy, то необхідно записувати значення MaxEnergy.
        public double Energy
        {
            get { return _energy; }
            private set
            {

                if (value < Cat.MinEnergy)
                {
                    throw new Exception("Not enough energy to jump");
                }
                else if (value > Cat.MaxEnergy)
                {
                    _energy = Cat.MaxEnergy;
                }
                else
                {
                    _energy = value;
                };
            }
        }

        //  9. Конструктор, який приймає 2 аргументи name та gender типів string та Lab5.Gender відповідно та записує ці значення в параметри Name та Gender відповідно.Також конструктор повинен записати в параметр Energy значення MaxEnergy. 
        public Cat(string name, Lab5.Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.Energy = Cat.MaxEnergy;
        }

        //  10.	Метод Jump() без параметрів типу void, який зменшує Energy на JumpEnergyDrain.
        public void Jump()
        {
            this.Energy -= Cat.JumpEnergyDrain;
        }

        //  11.	Метод Sleep() без параметрів типу void, який збільшує Energy на SleepEnergyGain.
        public void Sleep()
        {
            this.Energy += Cat.SleepEnergyGain;
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            var faradayTheCat = new Cat("Faraday", Gender.Male);
            var adaTheCat = new Cat("Ada", Gender.Female);

            PrintCatInfo(faradayTheCat);
            PrintCatInfo(adaTheCat);

            faradayTheCat.Jump();
            PrintCatInfo(faradayTheCat);
            for (var i = 0; i < 40; i++)
            {
                try
                {
                    faradayTheCat.Jump();
                    PrintCatInfo(faradayTheCat);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(i);
                    break;
                }
            }
            PrintCatInfo(adaTheCat);
            PrintCatInfo(faradayTheCat);
            for (var i = 0; i < 4; i++)
            {
                faradayTheCat.Sleep();
                PrintCatInfo(faradayTheCat);
            }
            PrintCatInfo(adaTheCat);
            adaTheCat.Sleep();
            PrintCatInfo(adaTheCat);
            PrintCatClassInfo();
        }

        private static void PrintCatInfo(Cat cat)
        {
            Console.WriteLine($"{cat.Name}, {cat.Gender}, {cat.Energy}");
            Console.WriteLine($"{typeof(Cat).GetField("_energy", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(cat)}");
        }

        private static void PrintCatClassInfo()
        {
            var catType = typeof(Cat);
            var props = catType.GetProperties();
            var fields = catType.GetFields().Concat(catType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)).ToArray();
            var constructors = catType.GetConstructors();
            var methods = catType.GetMethods();

            var sortLambda =
                new Func<MemberInfo, MemberInfo, int>(
                    (first, second) =>
                            String.Compare(first.Name, second.Name, StringComparison.Ordinal));
            Array.Sort(props, sortLambda.Invoke);
            Array.Sort(fields, sortLambda.Invoke);
            Array.Sort(constructors, sortLambda.Invoke);
            Array.Sort(methods, sortLambda.Invoke);
            foreach (var propertyInfo in props)
            {
                Console.WriteLine(
                    $"{propertyInfo.Name}, {propertyInfo.PropertyType}, {propertyInfo.CanRead}, {propertyInfo.CanWrite}");
            }
            foreach (var fieldInfo in fields)
            {
                Console.WriteLine(
                    $"{fieldInfo.Name}, {fieldInfo.FieldType}, {fieldInfo.IsPrivate}, {fieldInfo.IsPublic}, {fieldInfo.IsStatic}, {fieldInfo.IsInitOnly}, {fieldInfo.IsLiteral}");
            }
            foreach (var constructorInfo in constructors)
            {
                Console.WriteLine(
                    $"{constructorInfo.Name}, {constructorInfo.DeclaringType}, {constructorInfo.IsPublic}, {string.Join(", ", constructorInfo.GetParameters().ToArray<object>())}");
            }
            foreach (var methodInfo in methods)
            {
                Console.WriteLine(
                    $"{methodInfo.Name}, {methodInfo.DeclaringType}, {methodInfo.IsPublic}, {string.Join(", ", methodInfo.GetParameters().ToArray<object>())}");
            }

        }

        
        
    }
}
