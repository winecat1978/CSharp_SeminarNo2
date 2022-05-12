Console.WriteLine("Write number: ");

string numberStr = Console.ReadLine();

int firstNumber = int.Parse(numberStr);
int secondNumber = Convert.ToInt32(numberStr);
int thirdNumber = 8;

if (int.TryParse(numberStr, out int numberValue))
thirdNumber = numberValue;
bool needToCastToInt = true;
