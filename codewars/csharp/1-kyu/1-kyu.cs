using System;


{
    class Program
{
        
        {
//Examples:
//1) n =   3, x = 1, y = 3 =>  true because   3 is divisible by 1 and 3
// 2) n =  12, x = 2, y = 6 =>  true because  12 is divisible by 2 and 6
// 3) n = 100, x = 5, y = 3 => false because 100 is not divisible by 3
// 4) n =  12, x = 7, y = 5 => false because  12 is neither divisible by 7 nor 5


def is_divisible(n, x, y):
    #your code here
    n = int (input())
    x = int (input())
    y = int (input())
    if n % x == 0 and y % x == 0:
            return True
    elif n % x != 0 and y % x != 0:
        return False

    result = is_divisible(n = int(input()), x = int(input()), y = int(input()))
    print(result)                }

            }



            {

}



        }


    }
}

