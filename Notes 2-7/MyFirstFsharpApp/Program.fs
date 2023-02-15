open System

let from whom =
        sprintf "from %s" whom

let prefix (prefixStr: string) (baseStr: string) : string = prefixStr + "," + baseStr
let isEven (num: int) : bool = num % 2 = 0

// For more information see https://aka.ms/fsharp-console-apps
[<EntryPoint>]
let main argv =
        let message = from "F# "
        printfn "Hello world %s" message
        System.Console.WriteLine 1
        System.Console.WriteLine $"Is 5 even? {isEven 5}"
        0
