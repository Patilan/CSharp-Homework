using System;

namespace ApplyBonusScores
{
    class ApplyBonusScores
    {
        static void Main()
        {
            //ApplyBonusScores
            Console.WriteLine("Type a digit between 1 and 9, please:");
             string digit = Console.ReadLine();
              int digitRead;
              if (int.TryParse(digit, out digitRead))
              {

                  switch (digitRead)
                  {
                      case 1:
                      case 2:
                      case 3:
                          int digitScored = digitRead * 10;
                          Console.WriteLine(digitScored);
                          break;
                      case 4:
                      case 5:
                      case 6:
                          digitScored = digitRead * 100;
                          Console.WriteLine(digitScored);
                          break;
                      case 7:
                      case 8:
                      case 9:
                          digitScored = digitRead * 1000;
                          Console.WriteLine(digitScored);
                          break;
                      default:
                          Console.WriteLine("Type a digit between 1 and 9 please.");
                          break;
                  }

              }
              else
              {
                  Console.WriteLine("You did not wrote a number. Eat my pajamas.");
              }
        }
    }
}
