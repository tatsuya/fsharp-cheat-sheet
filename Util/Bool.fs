﻿module Bool

let isNumeric x =
    System.Double.TryParse x |> fst
    
let isCommentLine (s : string) =
    s.TrimStart().[0] = '#'

let areSameLists f (xs : 'a list) (ys : 'a list) =
    xs.Length = ys.Length &&
    List.forall2 (fun x y -> f x y) xs ys

let excludeNone (xs : 'a option array) =
    Array.filter (fun (x : 'a option) -> x.IsSome) xs