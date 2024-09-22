string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rand = new Random();

int randomIndex = rand.Next(0, snacks.Length);

// Viitamine massiivi elemendile randomIndex abil
Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");
