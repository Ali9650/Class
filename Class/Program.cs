public static class Program
{
    public static void Main(string[] args)
    {
        //Student student = new Student("Ali", "Cahangirov", 20,
        //    new int[] { 100, 70, 75, 84, 70 },
        //    new int[] { 100, 90, 60 },
        //    new int[] { 90, 100, 76 },
        //    95,
        //    new bool[] { true, false, false, true, true, false });

        //int finalResult = student.GetFinalResult();

        //if (finalResult >= 95)
        //{
        //    Console.WriteLine("HighHonour");
        //}
        //else if (finalResult >= 85)
        //{
        //    Console.WriteLine("Honour");
        //}
        //else if (finalResult >= 65)
        //{
        //    Console.WriteLine("Normal");
        //}
        //else
        //{
        //    Console.WriteLine("Fail");
        //}
        //Animal animal = new Animal("It", "men", "boz", 3);

        //Console.WriteLine(animal.GetInfoAnimal());

        //Building building = new Building("Bina", 15, 100, "Baki");
        //Console.WriteLine(building.GetInfoBuilding());

        //Gun gun = new Gun("AK", 12, 7, 300, "sniper");
        //gun.Fire ();
        //gun.Checkbullet ();
        //gun.Reload ();
        //Console.WriteLine(gun.GetInfoGun());

        //double number1 = Convert.ToDouble(Console.ReadLine());
        //double number2 = Convert.ToDouble(Console.ReadLine());

        //char _operator = Convert.ToChar(Console.ReadLine());

        //char[] operators = { '+', '-', '/', '*' };

        //while (!operators.Contains(_operator))
        //{
        //    Console.WriteLine("Yeniden daxil edin");
        //    _operator = Convert.ToChar(Console.ReadLine());
        //}
        //Calculator calculator = new(number1, number2, _operator);


    }

}



public class Student
{
    public string name;
    public string surname;
    public int age;
    int[] homeworkGrades;
    int[] projectGrades;
    int[] quizGrades;
    int FinalGrade;
    bool[] continuity;

    public Student(string name, string surname, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continuity)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.homeworkGrades = homeworkGrades;
        this.projectGrades = projectGrades;
        this.quizGrades = quizGrades;
        this.FinalGrade = finalGrade;
        this.continuity = continuity;
    }

    public int GetcontuniutyGrade()
    {
        int attendedCount = 0;
        foreach (var IsAttended in continuity)
        {
            if (IsAttended)
            {
                attendedCount++;
            }
        }
        return attendedCount * 100 / continuity.Length;
    }

    public int GetAverageGrade(int[] grades)
    {
        int sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return sum / grades.Length;
    }

    public int GetFinalResult()
    {
        int homeworkAverageGrade = GetAverageGrade(homeworkGrades);
        int projectAverageGrade = GetAverageGrade(projectGrades);
        int quizAverageGrade = GetAverageGrade(quizGrades);
        int continuityGrade = GetcontuniutyGrade();
        return ((homeworkAverageGrade * 20) / 100 + (projectAverageGrade * 20) / 100 + (quizAverageGrade * 20) / 100 + (FinalGrade * 30) / 100 + (continuityGrade * 10) / 100);
    }
}

public class Animal
{
    public string name;
    public string breed;
    public string colour;
    public int age;

    public Animal(string name, string breed, string colour, int age)
    {
        this.name = name;
        this.breed = breed;
        this.colour = colour;
        this.age = age;
    }

    public string GetInfoAnimal()
    {
        return $"{name} {breed} {colour} {age}";
    }
}
public class Building
{
    public Building(string name, int height, int area, string address)
    {
        this.name = name;
        this.height = height;
        this.area = area;
        this.address = address;
    }

    public string name;
    public int height;
    public int area;
    public string address;
    public string GetInfoBuilding()
    {
        return $"{name} {height} {area} {height * area}";
    }
}

public class Gun
{
    public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
    {
        this.name = name;
        this.maxCapacity = maxCapacity;
        this.currentBullet = currentBullet;
        this.totalBullet = totalBullet;
        this.type = type;

    }
    public string name;
    public int maxCapacity;
    public int currentBullet;
    public int totalBullet;
    public string type;

    public void Fire()
    {
        if (type == "assault")
        {
            currentBullet = 0;
        }
        else if (type == "sniper")
        {
            currentBullet = currentBullet - 1;
        }
    }

    public void Checkbullet()
    {
        if (currentBullet > maxCapacity)
        {
            Console.WriteLine("currentBullet maxCapacity-den boyukdu");
        }
    }

    public void Reload()
    {
        int difference = 0;
        difference = maxCapacity - currentBullet;
        currentBullet = maxCapacity;
        totalBullet = totalBullet - difference;

    }

    public string GetInfoGun()
    {
        return $"{name} {currentBullet} {totalBullet} {type}";
    }
}

public class Calculator
{
    public Calculator(double number1, double number2, char operation)
    {
        this.number1 = number1;
        this.number2 = number2;
        this.operation = operation;
        switch (operation)
        {
            case '+':
                Console.WriteLine(Add());
                break;
            case '-':
                Console.WriteLine(Substract());
                break;
            case '/':
                Console.WriteLine(Divide());
                break;
            case '*':
                Console.WriteLine(Multiply());
                break;
            default:
                break;
        }
    }
    public double number1;
    public double number2;
    public char operation;
    

    public double Add()
    {
        return number1 + number2;
    }

    public double Substract()
    {
        return number1 - number2;
    }

    public double Multiply()
    {
        return number1 * number2;
    }

    public double Divide()
    {
        return number1 / number2;
    }
}








