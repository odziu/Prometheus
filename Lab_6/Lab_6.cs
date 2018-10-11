using System;
using System.Reflection;
using System.Linq;

namespace Lab_6
{
    //  Напишіть публічний абстрактний клас Animal, що буде описувати трарин.
    //  Він повинен містити такі члени:
    //  1.	Публічний автозгенерований параметр(get; set; ) Weight типу float.
    //  2.	Публічний автозгенерований параметр(get; set; ) Color типу string.
    //  3.	Публічний конструктор Animal, що приймає два аргументи : color типу string, weight типу float, та присвоює ці аргументи автозгенерованим параметрам.
    //  4.	Публічний абстрактний метод MakeSound без аргументів, що повертає string.

    public abstract class Animal
    {
        public float Weight { get; set; }

        public string Color { get; set; }

        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }

        public abstract string MakeSound();
    }

    //  Напишіть публічний абстрактний клас AnimalWithTail, що буде описувати тварин з хвостом та наслідує клас Animal. Він повинен містити такі члени:
    //  1.	Публічний автозгенерований параметр(get; set; ) TailLength типу float.
    //  2.	Публічний конструктор AnimalWithTail, що приймає три аргументи : color типу string, weight типу float, tailLength типу float, та присвоює ці аргументи автозгенерованим параметрам(Ви повинні викликати конструктор базового типу з двома аргументами).
    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }

        public AnimalWithTail(string color, float weight, float tailLength) : base(color, weight)
        {
            TailLength = tailLength;
        }
    }


    //Напишіть публічний клас Cat, що буде описувати кота та наслідує клас AnimalWithTail. Він повинен містити такі члени:
    //  1.	Публічний конструктор Cat, що приймає три аргументи : color типу string, weight типу float, tailLength типу float, та присвоює ці аргументи автозгенерованим параметрам(Ви повинні викликати конструктор базового типу з трьома аргументами).
    //  2.	Приватний метод Purr без аргументів, що повертає string “purrrrrrrr”.
    //  3.	Приватний метод Meow без аргументів, що повертає string “Meow”.
    //  4.	Публічний override метод MakeSound без аргументів, що повертає результат виклику Purr() + Meow().
    //  5.	Публічний override метод ToString без аргументів, що повертає результат виклику $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}".
    public class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
        }

        private string Purr()
        {
            return "purrrrrrrr";
        }

        private string Meow()
        {
            return "Meow";
        }

        public override string MakeSound()
        {
            string s = Purr() + Meow();
            return s;
        }

        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }


    //Напишіть публічний клас Dog, що буде описувати собаку та наслідує клас AnimalWithTail. Він повинен містити такі члени:
    //  1.	Публічний конструктор Dog, що приймає три аргументи : color типу string, weight типу float, tailLength типу float, та присвоює ці аргументи автозгенерованим параметрам(Ви повинні викликати конструктор базового типу з трьома аргументами).
    //  2.	Публічний override метод MakeSound без аргументів, що повертає “Woof”.
    //  3.	Публічний override метод ToString без аргументів, що повертає результат виклику $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}".



    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) : base(color, weight, tailLength)
        {
        }

        public override string MakeSound()
        {
            return "Woof";
        }

        public override string ToString()
        {
            return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            PrintClassInfo(typeof(Animal));
            PrintClassInfo(typeof(AnimalWithTail));
            PrintClassInfo(typeof(Cat));
            PrintClassInfo(typeof(Dog));
            Console.WriteLine(new Cat("Balck", 2, 1));
            Console.WriteLine(new Dog("Brown", 5, 2));
        }

        private static void PrintClassInfo(Type type)
        {
            var props = type.GetProperties();
            var fields = type.GetFields().Concat(type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)).ToArray();
            var constructors = type.GetConstructors();
            var methods = type.GetMethods();

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
