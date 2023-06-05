// See https://aka.ms/new-console-template for more information
// random util
Random rand = new Random(); // couldnt get this to be a global
// Coin Flip

string CoinFlip()
{
    if(rand.Next(2) == 0){
        return "heads";
    }
    else
    {
        return "tails";
    }
}

Console.WriteLine(CoinFlip());

// Dice Roll

int DiceRoll(int sides)
{
    return rand.Next(1,sides + 1);
}

Console.WriteLine(DiceRoll(6));

// Stat Roll

List<int> StatRoll(int rolls)
{
    List<int> StatSheet = new List<int>();
    int max = 0;
    int temp = 0;
    for (int i = 0; i < rolls; i++){
        temp = DiceRoll(6);
        if(temp > max){
            max = temp;
        }
        StatSheet.Add(temp);
    }
    Console.WriteLine(string.Join(", ", StatSheet));
    Console.WriteLine("Max roll: " + max);
    return StatSheet;
}

StatRoll(4);

// Roll Until....
string RollUntil(int target)
{
    if (target > 6){
        return "Target is out of bound";
    }
    
    int number = 0;
    int count = 0;

    while(number != target){
        number = DiceRoll(6);
        count += 1;
        Console.WriteLine(number);
    }

    return $"Rolled a {number} after {count} tries";
}

Console.WriteLine(RollUntil(2));