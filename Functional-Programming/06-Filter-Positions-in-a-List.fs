//Enter your code here. Read input from STDIN. Print output to STDOUT
open System

let readElements =
    Seq.initInfinite (fun _ -> Console.ReadLine() |> int)

let indexElements elements =
    Seq.mapi (fun i e -> e, i) elements

let unIndexElements elements =
    Seq.map (fun (e, i) -> e) elements

let filterElements elements =
    indexElements elements
    |> Seq.filter (fun (e, i) -> i % 2 <> 0)
    |> unIndexElements

let printElements elements =
    Seq.iter (fun e -> printfn "%d " e) elements

[<EntryPoint>]
let main argv =
    readElements
    |> filterElements
    |> printElements
    0 // return an integer exit code
