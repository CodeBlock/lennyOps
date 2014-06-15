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

    printfn "%A" argv
    0 
