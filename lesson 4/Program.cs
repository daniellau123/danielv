string food ;

Random random = new Random();
int i= random.Next(0,100);// 0 < = i , 100
Console.WriteLine(i);
Console.WriteLine("We have ramen,spaghetti,salad.Which do you like?");
food = Console.Readline();
switch(food)
{
    case"ramen":
       Console.WriteLine ("It cost you NT200.") ;
       break;
    case"spaghetti":
       Console.WriteLine ("It cost you NT180.") ;
       break;
    case"salad":
       Console.WriteLine ("It cost you NT60.") ;
       break;
    default:
       Console.WriteLine ("Sorry, we do not sell " + food + ".");
       break;
}