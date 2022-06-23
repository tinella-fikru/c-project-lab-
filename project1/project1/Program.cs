//Console.WriteLine("Hello, World!");
string b;
do
{
    Console.WriteLine("Enter the number of a month to find out how it's name came to be:");
    Console.WriteLine("1=January,2=February,3=March,4=April,5=May.6=June,7=July,8=August,9=September,10=October,11=November,12=December");
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            Console.WriteLine("JANUARY");
            Console.WriteLine("Named for the Roman god Janus, protector of gates and doorways." +
                "Janus is depicted with two faces, one looking into the past, the other into the future." +
                "In ancient Roman times, the gates of the temple of Janus were open in times of war and closed in times of peace.");
            break;
        case 2:
            Console.WriteLine("FEBRUARY");
            Console.WriteLine("From the Latin word februa, “to cleanse.” " +
                "The Roman calendar month of Februarius was named for Februalia, " +
                "a festival of purification and atonement that took place during this period.");
            break;
        case 3:
            Console.WriteLine("MARCH");
            Console.WriteLine("Named for the Roman god of war, Mars." +
                       "This was the time of year to resume military campaigns that had been interrupted by winter." +
                       " March was also a time of many festivals, presumably in preparation for the campaigning season.");
            break;
        case 4:
            Console.WriteLine("APRIL");
 Console.WriteLine("From the Latin word aperio, “to open(bud),” because plants begin to grow in this month." +
       " In essence, this month was viewed as spring’s renewal.");
            break;
        case 5:
            Console.WriteLine("MAY");
 Console.WriteLine("Named for the Roman goddess Maia, who oversaw the growth of plants." +
     "Also from the Latin word maiores, “elders,” who were celebrated during this month." +
    "Maia was considered a nurturer and an earth goddess, which may explain the connection with this springtime month. ");
            break;
        case 6:
            Console.WriteLine("JUNE");
 Console.WriteLine("Named for the Roman goddess Juno, patroness of marriage and the well - being of women." +
    "Also from the Latin word juvenis, “young people.”");
            break;
        case 7:
            Console.WriteLine("JULY");
 Console.WriteLine("Named to honor Roman dictator Julius Caesar(100 B.C.– 44 B.C.) after his death.In 46 B.C." +
    "Julius Caesar made one of his greatest contributions to history: With the help of Sosigenes, he developed the Julian calendar," +
    "the precursor to the Gregorian calendar we use today.");
            break;
        case 8:
            Console.WriteLine("AUGUST");
Console.WriteLine("Named to honor the first Roman emperor(and grandnephew of Julius Caesar), Augustus Caesar(63 B.C.– A.D. 14)." +
    "Augustus(the first Roman emperor) comes from the Latin word “augustus,” meaning venerable, noble, and majestic.");
            break;
        case 9:
            Console.WriteLine("SEPTEMBER");
Console.WriteLine("September comes from the Latin word septem, meaning “seven,” because it was the seventh month of the early Roman calendar.");
            break;
        case 10:
            Console.WriteLine("OCTOBER");

 Console.WriteLine("In the ancient Roman calendar, October was the name of the eighth month of the year." +
    "Its name comes from octo, the Latin word for “eight.” When the Romans converted to a 12 - month calendar," +
    "they tried to rename this month after various Roman emperors, but the name October stuck!" +

    "In Old England, the month was called Winmonath," +
    " means “wine month,” for this was the time of year when wine was made." +
     "The English also called it Winterfylleth, or “Winter Full Moon.”" +
     "They considered this full Moon to be the start of winter.In weather lore," +
     "we note, “If October brings heavy frosts and winds, then will January and February be mild.”");
            break;
        case 11:
            Console.WriteLine("NOVEMBER");
Console.WriteLine("From the Latin word novem, “nine,” because this had been the ninth month of the early Roman calendar.");
            break;
        case 12:
            Console.WriteLine("DECEMBER");
Console.WriteLine("From the Latin word decem, “ten,” because this had been the tenth month of the early Roman calendar.");
            break;
        default:
            Console.WriteLine("invalid number");
            break;
    }
    Console.WriteLine("****************************************************************");

    
             Console.WriteLine("Do you want to continue if yes enter (y) else (n)");
            b = Console.ReadLine();
    
}
while (b == "y");
