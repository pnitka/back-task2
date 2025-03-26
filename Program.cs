//Задача 1: Создание класса
public class Animal
{
    public string name;
    public int age;
    public void PrintInfo()
    {
        Console.WriteLine("Имя: " + name + ", Возраст: " + age);
    }
}

//Задача 2: Наследование
public class Dog : Animal
{
    public string breed;
    public void Bark()
    {
        Console.WriteLine("Гав!");
    }
}

//Задача 3: Инкапсуляция
public class Animal
{
    private string name;
    private int age;

    public void SetName(string newName)
    {
        name = newName;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAge(int newAge)
    {
        age = newAge;
    }

    public int GetAge()
    {
        return age;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Имя: " + name + ", Возраст: " + age);
    }
}

//Задача 4: Работа с массивами объектов
Animal[] animals = new Animal[5];

animals[0] = new Animal();
animals[0].SetName("Полина");
animals[0].SetAge(5);

animals[1] = new Animal();
animals[1].SetName("Полинусик");
animals[1].SetAge(3);

animals[2] = new Animal();
animals[2].SetName("Полиника");
animals[2].SetAge(7);

animals[3] = new Animal();
animals[3].SetName("Никаполя");
animals[3].SetAge(4);

animals[4] = new Animal();
animals[4].SetName("ПолиныЗахватятМир");
animals[4].SetAge(2);

for (int i = 0; i < animals.Length; i++)
{
    animals[i].PrintInfo();
}

//Задача 5: Магазин книг
public class Book
{
    public string title;
    public string author;
    public double price;
    public void PrintDetails()
    {
        Console.WriteLine("Название: " + title + ", Автор: " + author + ", Цена: " + price);
    }
}
//тут массив книг
Book[] books = new Book[5];

books[0] = new Book();
books[0].title = "C# для начинающих";
books[0].author = "Иванов";
books[0].price = 450;

books[1] = new Book();
books[1].title = "Основы ASP.NET";
books[1].author = "Петров";
books[1].price = 600;

books[2] = new Book();
books[2].title = "Entity Framework Core";
books[2].author = "Сидоров";
books[2].price = 520;

books[3] = new Book();
books[3].title = "Паттерны проектирования";
books[3].author = "Козлов";
books[3].price = 700;

books[4] = new Book();
books[4].title = "Чистый код";
books[4].author = "Смирнов";
books[4].price = 480;

for (int i = 0; i < books.Length; i++)
{
    if (books[i].price > 500)
    {
        books[i].PrintDetails();
    }
}

//Задача 6: Ферма
public abstract class FarmAnimal
{
    public abstract void Eat();
    public abstract void Speak();
}

public class Cow : FarmAnimal
{
    public override void Eat()
    {
        Console.WriteLine("коровушка ест травку");
    }

    public override void Speak()
    {
        Console.WriteLine("Муу");
    }
}

public class Chicken : FarmAnimal
{
    public override void Eat()
    {
        Console.WriteLine("Курица клюет зерно");
    }
    public override void Speak()
    {
        Console.WriteLine("Ко-ко");
    }
}
List<FarmAnimal> animals = new List<FarmAnimal>();

animals.Add(new Cow());
animals.Add(new Chicken());

foreach (FarmAnimal animal in animals)
{
    animal.Speak();
}

//Задача 7: Банковский аккаунт
public class BankAccount
{
    public string accountNumber;
    public double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Недостаточно средств");
        }
    }
}
public class SavingsAccount : BankAccount
{
    public double interestRate;
    public void AddInterest()
    {
        balance += balance * interestRate;
    }
}

//Задача 8: магазин игрушек
public class Toy
{
    public string name;
    public double price;
}

public class Car : Toy
{
    public void Play()
    {
        Console.WriteLine("Врум!");
    }
}

public class Doll : Toy
{
    public void Play()
    {
        Console.WriteLine("Привет, я твоя новая кукла!");
    }
}
// массив игрушечек
Toy[] toys = new Toy[2];

Car car = new Car();
car.name = "Машинка";
car.price = 100;
toys[0] = car;

Doll doll = new Doll();
doll.name = "Кукла";
doll.price = 150;
toys[1] = doll;

// запуск моих игрушечек
foreach (Toy toy in toys)
{
    if (toy is Car)
    {
        ((Car)toy).Play();
    }
    else if (toy is Doll)
    {
        ((Doll)toy).Play();
    }
}

// Задача 9: система управления школой
public class Person
{
    public string name;
    public int age;
}

public class Student : Person
{
    public int grade;

    public void Study()
    {
        Console.WriteLine("Я учусь");
    }
}

public class Teacher : Person
{
    public string subject;

    public void Teach()
    {
        Console.WriteLine("Я преподаю " + subject);
    }
}

Person[] people = new Person[2];

Student student = new Student();
student.name = "Алиса";
student.age = 16;
student.grade = 10;
people[0] = student;

Teacher teacher = new Teacher();
teacher.name = "Иван";
teacher.age = 35;
teacher.subject = "Математика";
people[1] = teacher;

foreach (Person person in people)
{
    if (person is Student)
    {
        ((Student)person).Study();
    }
    else if (person is Teacher)
    {
        ((Teacher)person).Teach();
    }
}

// Задача 10: система аренды машин
public class Vehicle
{
    public string brand;
    public double pricePerDay;

    public double CalculateCost(int days)
    {
        return pricePerDay * days;
    }
}

public class Car : Vehicle
{
    public string GetVehicleType()
    {
        return "Легковой автомобиль";
    }
}

public class Truck : Vehicle
{
    public string GetVehicleType()
    {
        return "Грузовик";
    }
}

List<Vehicle> vehicles = new List<Vehicle>();
Car car = new Car();
car.brand = "Toyota";
car.pricePerDay = 50;
vehicles.Add(car);

Truck truck = new Truck();
truck.brand = "Ford";
truck.pricePerDay = 100;
vehicles.Add(truck);

foreach (Vehicle vehicle in vehicles)
{
    Console.WriteLine("Стоимость аренды " + vehicle.brand + ": " + vehicle.CalculateCost(3));

    if (vehicle is Car)
    {
        Console.WriteLine(((Car)vehicle).GetVehicleType());
    }
    else if (vehicle is Truck)
    {
        Console.WriteLine(((Truck)vehicle).GetVehicleType());
    }
}

// Таска 11: Бойцовский клуб
using System;
public class Fighter
{
    public string name;
    public int health;

    public virtual void Attack(Fighter opponent)
    {
        Console.WriteLine(name + " атакует " + opponent.name);
    }
}

public class Boxer : Fighter
{
    public override void Attack(Fighter opponent)
    {
        Console.WriteLine(name + " бьет " + opponent.name + " кулаком!");
        opponent.health -= 15;
    }
}

public class Karateka : Fighter
{
    public override void Attack(Fighter opponent)
    {
        Console.WriteLine(name + " бьет " + opponent.name + " ногой!");
        opponent.health -= 10;
    }
}
// тут мои бойцы биться будут
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Boxer boxer = new Boxer();
        boxer.name = "Рокки";
        boxer.health = 100;

        Karateka karateka = new Karateka();
        karateka.name = "Брюс";
        karateka.health = 80;

        Random random = new Random();
        Fighter attacker;
        Fighter defender;

        if (random.Next(2) == 0)
        {
            attacker = boxer;
            defender = karateka;
        }
        else
        {
            attacker = karateka;
            defender = boxer;
        }

        while (boxer.health > 0 && karateka.health > 0)
        {
            attacker.Attack(defender);
            Console.WriteLine(defender.name + " здоровье: " + defender.health);

            Fighter temp = attacker;
            attacker = defender;
            defender = temp;
        }

        if (boxer.health <= 0)
        {
            Console.WriteLine(karateka.name + " победил!");
        }
        else
        {
            Console.WriteLine(boxer.name + " победил!");
        }
    }
}


// Задачка 12: Менеджер задач (я спать, сладких снов)
using System.Collections.Generic;

public class Task
{
    public string title;
    public bool isCompleted;

    public void CompleteTask()
    {
        isCompleted = true;
    }
}

public class Project
{
    public List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void ShowTasks()
    {
        foreach (Task task in tasks)
        {
            Console.WriteLine("Задача: " + task.title + ", Завершена: " + task.isCompleted);
        }
    }

    public void ShowCompletedTasks()
    {
        foreach (Task task in tasks)
        {
            if (task.isCompleted)
            {
                Console.WriteLine("Задача: " + task.title + ", Завершена: " + task.isCompleted);
            }
        }
    }
}
