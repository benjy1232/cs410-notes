open System

let rec readOperator () = 
        System.Console.WriteLine "Enter an operator"
        let operation = System.Console.ReadLine().[0]
        match operation with
        | '*' | '/' | '+' | '-' -> operation
        | _ ->
                System.Console.WriteLine "Invalid input, please try again"
                readOperator()

let rec readOperand () = 
        System.Console.WriteLine "Enter an operand"
        let input = Console.ReadLine()
        match System.Double.TryParse input with
        | true, value -> value
        | false, _ ->
                System.Console.WriteLine "Invalid input, please try again"
                readOperand()

let performCalculation (operation: string) (operand1: float) (operand2: float) = 
        match operation with
        | "+" -> operand1 + operand2
        | "-" -> operand1 - operand2
        | "*" -> operand1 * operand2
        | "/" -> operand1 / operand2
        | _ -> failwith "Invalid operation"

// For more information see https://aka.ms/fsharp-console-apps
[<EntryPoint>]
let main args = 
        Console.WriteLine "Welcome to the calculator program"
        let num1 = System.Console.ReadLine()
        let num2 = System.Console.ReadLine()
        0

