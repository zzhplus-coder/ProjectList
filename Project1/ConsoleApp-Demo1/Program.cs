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

#region 计算学生GPA
//交互程序
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

//课程属性类
public class Course
{
    public string? Name { get; set; }
    public double Grade { get; set; }
    public double ReditHours { get; set; }
}
#endregion

#region 模拟投骰子游戏
//投骰子游戏
//说明：一共三次机会，如果任意两次骰子的数值相同就获得2点积分奖励，如果三次数值都相同则获得6点积分奖励
//最终骰子数值+所有奖励得粉大于等于15就获胜，否则失败
int round = 0;
int[] numArray = new int[3];
Random random = new Random();
while (true)
{
    Console.Write($"按下Y开始投第{round + 1}个骰子：");
    string? letter = Console.ReadLine();
    if (string.Equals(letter, "Y", StringComparison.OrdinalIgnoreCase))
    {
        int num = random.Next(1, 7);
        Console.WriteLine($"第{round + 1}轮的骰子点数为：{num}");
        numArray[round] = num;
        round++;
        if (round == 3) break;
    }
    else
    {
        Console.WriteLine("输入错误，请重新输入！");
    }
}

int total = numArray[0] + numArray[1] + numArray[2];
if ((numArray[0] == numArray[1]) && (numArray[1] == numArray[2]))
{
    Console.WriteLine("三次相同，奖励6点数");
    total += 6;
}
else if ((numArray[0] == numArray[1]) || (numArray[1] == numArray[2]) || (numArray[2] == numArray[0]))
{
    Console.WriteLine("两次相同，奖励2点数");
    total += 2;
}

//switch表达式
string reward = total switch
{
    >= 16 => "一辆新车",
    >= 10 => "一台新的笔记本电脑",
    7 => "一次旅行机会",
    _ => "一只小猫"
};
Console.WriteLine($"最终点数是{total}，恭喜获得了{reward}！");
#endregion

#region 模拟订阅到期
Random random = new Random();
int days = random.Next(15);
if (days == 0)
{
    Console.WriteLine("你的订阅已到期");
}
else if (days == 1)
{
    Console.WriteLine($"你的订阅还剩1天到期，现在续费享受20%的折扣");
}
else if (days <= 5)
{
    Console.WriteLine($"你的订阅还剩{days}天到期，现在续费享受10%的折扣");
}
else if (days <= 10)
{
    Console.WriteLine("你的订阅即将到期，请尽快续订");
}
#endregion
#endif

class Program
{
    public static void Main()
    {
        string[] orders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        foreach (var item in orders)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
        }

    }
}