//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

let readLines =
    Seq.initInfinite (fun _ -> Console.ReadLine() |> int)

let printNTimes n element =
    for _ in 1 .. n do printfn "%d" element

[<EntryPoint>]
let main argv =
    let s = Console.ReadLine() |> int
    Seq.iter (fun x -> printNTimes s x) readLines
    0 // return an integer exit code
