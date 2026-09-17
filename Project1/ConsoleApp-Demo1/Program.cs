#if false
#region 华氏度转摄氏度练习
int fahrenheit = 94; //华氏度

//摄氏度 = (华氏度 - 32) x 5 / 9
//5和9默认是整数int，需要转换成小数才可以让计算结果是小数
decimal celsius = (fahrenheit - 32) * 5m / 9m;

Console.WriteLine($"The temperature is {celsius.ToString("F1")} Celsius.");

Console.WriteLine("Windows " + 1 + 1);
Console.WriteLine(5m / 10m);
#endregion

#region 打印成绩练习

//初始化成绩列表
List<int> num0 = new List<int>
{
    93, 87, 98, 95, 100
};
List<int> num1 = new List<int>
{
    80, 83, 82, 88, 85
};
List<int> num2 = new List<int>
{
    84, 96, 73, 85, 79
};
List<int> num3 = new List<int>
{
    90, 92, 98, 100, 97
};

//存入字典数值
Dictionary<string, List<int>> nameList = new Dictionary<string, List<int>>
{
    { "Sophia", num0 },
    { "Nicolas", num1 },
    { "Zahirah", num2 },
    { "Jeong", num3 }
};

double avgScore;//平均分
char rating;//评分等级 A or B

Console.WriteLine("Studeng\t\tGrade");
foreach (var item in nameList)
{
    avgScore = item.Value.Average();
    if (avgScore >= 90)
    {
        rating = 'A';
    }
    else
    {
        rating = 'B';
    }
    Console.WriteLine(item.Key + "\t\t" + avgScore + " " + rating);
}
#endregion
#endif

class Program
{
    public static void Main()
    {
        Console.Write("输入学生名字：");
        string? input0 = Console.ReadLine();
        string name = string.IsNullOrWhiteSpace(input0) ? "无名氏" : input0;

        Console.Write("输入课程数量：");
        int courseNum = Convert.ToInt32(Console.ReadLine());

        List<Course> list = new List<Course>();

        for (int i = 1; i <= courseNum; i++)
        {
            Console.Write($"输入第{i}个课程的名称：");
            string? input1 = Console.ReadLine();
            Console.Write($"输入第{i}个课程的成绩：");
            double grade = Convert.ToDouble(Console.ReadLine());
            Console.Write($"输入第{i}个课程的信用小时数：");
            double hours = Convert.ToDouble(Console.ReadLine());

            Course course = new Course
            {
                Name = string.IsNullOrWhiteSpace(input1) ? "无科目名" : input1,
                Grade = grade,
                ReditHours = hours
            };
            list.Add(course);
        }

        Console.WriteLine($"学生：{name}");
        Console.WriteLine($"\n课程\t成绩\t学分");

        double totalGrade = 0;
        double totalHours = 0;
        foreach (Course course in list)
        {
            Console.WriteLine($"{course.Name}\t{course.Grade}\t{course.ReditHours}");
            totalGrade += course.Grade * course.ReditHours;
            totalHours += course.ReditHours;
        }
        double GPA = totalGrade / totalHours;
        Console.WriteLine($"最终GPA：\t{GPA.ToString("F2")}");
    }
}

/// <summary>
/// 课程属性
/// </summary>
public class Course
{
    public string? Name { get; set; }
    public double Grade { get; set; }
    public double ReditHours { get; set; }
}