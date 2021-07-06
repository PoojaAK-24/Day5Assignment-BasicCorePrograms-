using System;

namespace Day5_BasicCorePrograms
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Basic Core Program");
                Console.WriteLine("1 For: Flip a Coin Head and Tail. ");
                Console.WriteLine("2 For: Select Value is Leap Year Or not");
                Console.WriteLine("3 For: Select Power of 2 Number");
                Console.WriteLine("4 For: Select the Harmonic Number");
                Console.WriteLine("5 For: Select Factors of number");
                Console.WriteLine("6 For: Select Quotient and Remainder");
                Console.WriteLine("7 For: Select Swap the Numbers");
                Console.WriteLine("8 For :Select Even and Odd number");
                Console.WriteLine("9 For: Select Alphabet Vowel");
                Console.WriteLine("10 For: Select Greatest number among Three");
                int selection = Convert.ToInt32(Console.ReadLine());

                // user selection

                switch (selection)
                {
                    case 1:
                        //FLIP COIN
                        UC1_FlipCoinHeadOrTail FlipCoin = new UC1_FlipCoinHeadOrTail();
                        FlipCoin.CheckHeadTailPercentage();
                        break;
                    case 2:
                        //CheckLeapYearOrNot
                        UC2_CheckLeapYear LeapYearOrNot = new UC2_CheckLeapYear();
                        LeapYearOrNot.LeapYear();
                        break;
                    case 3:
                         //Power Of 2
                         UC3_CalculatePowerOf2 CalPower = new UC3_CalculatePowerOf2();
                        CalPower.CalcuOfPower();
                        break;
                    case 4:
                        //Harmonic Series
                        UC4_HarmonicNumber CalculateHarmonicNumber = new UC4_HarmonicNumber();
                        CalculateHarmonicNumber.CalcHarmonicSeries();
                        break;
                    case 5:
                        //Prime Factor
                        UC5_PrimeFactorization PrimeFactor = new UC5_PrimeFactorization();
                        PrimeFactor.CalcSFactorialSeries();
                        break;
                    case 6:
                        //  quotient remainder
                        UC6_QuotientRemainder QuesRem = new UC6_QuotientRemainder();
                        QuesRem.QuotientRemainder();
                        break;
                    case 7:
                        //Swap 2 number
                        UC7_Swap2Numbers SwapTwoNo = new UC7_Swap2Numbers();
                        SwapTwoNo.SwapTwoNumber();
                        break;
                    case 8:
                        // Even Or odd
                        UC8_EvenOrOdd EvenOdd = new UC8_EvenOrOdd();
                        EvenOdd.CheckEvenOrdd();
                        break;
                    case 9:
                        // Vowel or Not
                        UC9_VowelOrNot VowelNot = new UC9_VowelOrNot();
                        VowelNot.CheckGivenVowel();
                        break;
                    case 10:
                        //Greater Or Smallest
                        UC10_CheckGreaterOrSmallest checkgreaterOrSmallest = new UC10_CheckGreaterOrSmallest();
                        checkgreaterOrSmallest.GreaterOrSmaller();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Select in Between 1 to 10");
                        break;
                }
                Console.ReadLine();

            }
        }
    }


