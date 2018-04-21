open System

// Finds the factorial of n.
let rec factorial(n : int) : int64 = 
    match n with  
        | 1 -> int64(1)  
        | n -> int64(n) * factorial(n - 1)  

        
// Finds the nth fibonacci number.
// This is extremely slow. Would not recommend recursion here. :)
let rec fibonacci(n : int) = 
    match n with
        | x when x <= 0 -> 0
        | 1 -> 1
        | n -> fibonacci(n-1) + fibonacci(n-2)

// Calculates x to the power of y.
// x: The base.
// y: The exponent.
let rec power(x : int, y : int) =
    match y with
        | 0 -> 1
        | y -> x * power(x,y-1)

printfn "6 factorial: %d" (factorial(6))
printfn "3 to the power of 5: %d" (power(3,5))
printfn "Fibonacci sequence: "
for n in 1 .. 20 do
    printfn "%d" (fibonacci(n))

Console.ReadKey() |> ignore
