//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

let readElements =
    Seq.initInfinite (fun _ -> Console.ReadLine() |> int)

let filterElements delimiter elements =
    Seq.filter (fun e -> delimiter > e) elements

let printElements elements =
    Seq.iter (fun e -> printfn "%d " e) elements

[<EntryPoint>]
let main argv =
    let delimiter = Console.ReadLine() |> int
    readElements
    |> filterElements delimiter
    |> printElements
    0 // return an integer exit code
