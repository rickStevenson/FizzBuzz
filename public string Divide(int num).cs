public string Divide(int num)
{
    if(num % 3 == 0 && num % 5 == 0){
        return "fizzbuzz";
    }
    if(num % 3 == 0){
        return "fizz";
    }
    if(num % 5 == 0){
        return "buzz";
    }
    return "This number is not divisible by 3 0r 5";
}