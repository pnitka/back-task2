Создание класса
Создайте класс Animal с полями name (имя) и age (возраст).
Добавьте метод PrintInfo, который выводит имя и возраст животного.
Наследование
Создайте класс Dog, который наследуется от Animal.
Добавьте поле breed (порода) и метод Bark(), который выводит "Гав!".
Инкапсуляция
В классе Animal сделайте поля name и age приватными.
Создайте методы SetName, SetAge, GetName и GetAge для доступа к этим полям.
Работа с массивами объектов
Создайте массив из 5 объектов Animal.
Заполните массив данными и выведите информацию о каждом животном, используя метод PrintInfo.
Магазин книг
Создайте класс Book с полями title (название), author (автор) и price (цена).
Реализуйте метод PrintDetails, который выводит всю информацию о книге.
Создайте массив из 5 книг, заполните его и выведите данные о книгах, чья цена больше 500.
Ферма
Создайте абстрактный класс FarmAnimal с методами Eat() и Speak().
Реализуйте классы Cow и Chicken, которые наследуются от FarmAnimal.
Метод Speak для коровы должен выводить "Муу", а для курицы — "Ко-ко".
Создайте список из нескольких животных, позвольте каждому "сказать" что-то.
Банковский аккаунт
Создайте класс BankAccount с полями accountNumber (номер счета), balance (баланс).
Реализуйте методы Deposit и Withdraw. Ограничьте снятие суммы так, чтобы оно не превышало текущий баланс.
Создайте наследника SavingsAccount, у которого есть поле interestRate (процентная ставка) и метод AddInterest, который увеличивает баланс на основе процентной ставки.
Магазин игрушек
Создайте базовый класс Toy с полями name (название) и price (цена).
Реализуйте классы-наследники Car (игрушечная машинка) и Doll (кукла).
Добавьте метод Play() в каждом классе: для машинки — "Врум!", для куклы — "Привет, я твоя новая кукла!".
Создайте массив из нескольких игрушек и вызовите метод Play() для каждой из них.
Система управления школой
Создайте класс Person с полями name (имя) и age (возраст).
Реализуйте наследников Student и Teacher.
У Student добавьте поле grade (класс) и метод Study(), который выводит "Я учусь".
У Teacher добавьте поле subject (предмет) и метод Teach(), который выводит "Я преподаю {subject}".
Создайте массив, содержащий объекты Student и Teacher, и вызовите соответствующие методы для каждого объекта.
Система аренды машин
Создайте класс Vehicle с полями brand (марка) и pricePerDay (цена за день аренды).
Реализуйте метод CalculateCost, который рассчитывает стоимость аренды за указанное количество дней.
Создайте наследников Car и Truck. Добавьте специфичные методы: Car может возвращать строку "Легковой автомобиль", а Truck — "Грузовик".
Создайте список из нескольких машин и рассчитайте стоимость аренды каждой на 3 дня.
Бойцовский клуб
Создайте базовый класс Fighter с полями name (имя), health (здоровье) и методом Attack(Fighter opponent), который уменьшает здоровье оппонента.
Реализуйте наследников Boxer и Karateka, у каждого свой уникальный метод атаки.
Создайте бой между двумя случайно выбранными бойцами, пока здоровье одного из них не станет меньше или равно 0. Выведите победителя.
Менеджер задач
Создайте класс Task с полями title (название задачи), isCompleted (завершена ли задача).
Добавьте метод CompleteTask(), который меняет статус задачи на завершенный.
Создайте класс Project, содержащий список задач. Добавьте методы:
AddTask(Task task) — добавление задачи.
ShowTasks() — вывод всех задач.
ShowCompletedTasks() — вывод завершенных задач.
