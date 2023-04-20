var randomNumber = new Random(1);
int firstNumber = randomNumber.Next();
int secondNumber = randomNumber.Next();

Console.WriteLine(firstNumber +" + "+ secondNumber);
int answer;
answer = Convert.ToInt32(Console.ReadLine());
if((firstNumber+secondNumber)== answer){
    Console.WriteLine("Correct");
}
else{
    Console.WriteLine("Wrong");
}
