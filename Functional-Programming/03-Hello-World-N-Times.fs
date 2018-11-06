//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    for _ in 1 .. n do printfn "Hello World"
    0 // return an integer exit code
