

// For more information see https://aka.ms/fsharp-console-apps
// FizzBuzz
// if number is divisible by 3: Fizz
// if number is divisible by 5: Buzz
// if number is divisible by both: FizzBuzz

let fizzBuzz (num: int) (pairs: (int * string)list) =
        let mutable result = ""
        for (d, o) in pairs do
                let res = if num % d = 0 then o else ""
                System.Console.WriteLine res

[<EntryPoint>]
let main argv =
        let pairs = [(3, "Fizz"); (5, "Buzz")]
        fizzBuzz 3 pairs
        0
