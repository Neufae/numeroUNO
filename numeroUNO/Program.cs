
var stream = File.Open("C:\\Users\\neufa\\repos\\numeroUNO\\numeroUNO\\generatedCode.txt", FileMode.Open);
string text = string.Empty;
using(var reader = new StreamReader(stream))
{
    text = reader.ReadToEnd();
}
var lines = text.Split(Environment.NewLine).ToList();
var leftList = new List<string>();
var rightList = new List<string>();
lines.ForEach(line =>
{
    var split = line.Split("   ").ToList();
    leftList.Add(split[0]);
    rightList.Add(split[1]);
});
leftList.Sort();
rightList.Sort();

var diffList = new List<int>();
for (int i = 0; i < leftList.Count; i++)
{
    int left = int.Parse(leftList[i]);
    int right = int.Parse(rightList[i]);
    diffList.Add(Math.Abs(left - right));
}
var sum = diffList.Sum();
int debug = 0;