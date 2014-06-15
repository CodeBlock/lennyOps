module LennyOpsTest

open LennyOps

[<EntryPoint>]
let main argv = 

    // declaration
    let myArray = [|"fsharp";"fsharp";"fsharp";"fsharp";"fsharp"|]
    let myList = ["fsharp";"fsharp";"fsharp";"fsharp";"fsharp"]
    let mySequence =  seq {for i = 1 to 10 do yield "fsharp"}
    let my2DArray = array2D [[1;2;3];[4;5;6];[7;8;9]]
    let myMap = Map.ofList [ (1, "i"); (2, "love"); (3, "fsharp") ]
    let mySet = Set.ofList ["I";"love";"fsharp";"very";"very";"much"] 
    // initial output
    printfn "Initial declaration:\n"
    printfn "Array\n%A" myArray
    printfn "List\n%A" myList
    printfn "Sequence\n%A" mySequence
    printfn "2D Array\n%A" my2DArray
    printfn "Map\n%A" myMap
    printfn "Set\n%A" mySet
    // map
    let mapArray = myArray |> map (fun x -> x.Length)
    let mapList = myList |> map (fun x -> x.Length)
    let mapSequence = mySequence |> map (fun x -> x.Length = 6)
    let map2DArray = my2DArray |> map (fun x -> x)
    let mapMap = myMap |> map (fun k v -> v.ToUpper())
    let mapSet = mySet |> map (fun x -> x.Length)
    // map output 
    printfn "\nAfter map operation:\n"
    printfn "Array\n%A" mapArray
    printfn "List\n%A" mapList
    printfn "Sequence\n%A" mapSequence
    printfn "2D Array\n%A" map2DArray
    printfn "Map\n%A" mapMap
    printfn "Set\n%A" mapSet

    let exit = System.Console.ReadLine()

    printfn "%A" argv
    0 
