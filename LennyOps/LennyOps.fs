module LennyOps

type Ops =   
    // map.
    // Data Structures supported:
    // List, Array, Array2D, Array3D, Seq, Map, Set
    static member map (f: ('a -> 'b), (x: list<'a>)) = x |> List.map f
    static member map (f: ('a -> 'b), (x: array<'a>)) = x |> Array.map f    
    static member map (f: ('a -> 'b), (x: 'a[,])) = x |> Array2D.map f
    static member map (f: ('a -> 'b), (x: 'a[,,])) = x |> Array3D.map f
    static member map (f: ('a -> 'b), (x: seq<'a>)) = x |> Seq.map f
    static member map (f: ('a -> 'b -> 'c), (x: Map<'a, 'b>)) = x |> Map.map f
    static member map (f: ('a -> 'b), (x: Set<'a>)) = x |> Set.map f

let inline mapOp< ^t, ^f, ^x, ^c when (^t or ^f) : (static member map : ^f * ^x -> ^c) > f x = 
    ((^t or ^f) : (static member map : ^f * ^x -> ^c) (f, x))

let inline map f x = mapOp<Ops, _, _, _> f x