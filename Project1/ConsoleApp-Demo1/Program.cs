//int fahrenheit = 94; //华氏度

//摄氏度 = (华氏度 - 32) x 5 / 9
//5和9默认是整数int，需要转换成小数才可以让计算结果是小数
//decimal celsius = (fahrenheit - 32) * 5m / 9m;

//Console.WriteLine($"The temperature is {celsius.ToString("F1")} Celsius.");

//Console.WriteLine("Windows " + 1 + 1);
//Console.WriteLine(5m / 10m);


////Sophia: 93, 87, 98, 95, 100

//Nicolas: 80, 83, 82, 88, 85

//Zahirah: 84, 96, 73, 85, 79

//Jeong: 90, 92, 98, 100, 97

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