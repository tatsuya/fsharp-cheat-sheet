[![Build status](https://ci.appveyor.com/api/projects/status/s4jjgea8khrku115?svg=true)](https://ci.appveyor.com/project/tatsuya/fsharp-utility-library)

###### fsharp.org
- [F# Language Specification](http://fsharp.org/specs/language-spec)
- [F# Component Design Guidelines](http://fsharp.org/specs/component-design-guidelines)

###### MSDN (except collections)
- [Access Control](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/access-control-%5Bfsharp%5D)
- [Casting and Conversions](https://msdn.microsoft.com/visualfsharpdocs/conceptual/casting-and-conversions-%5bfsharp%5d)
- [Code Formatting Guidelines](https://msdn.microsoft.com/visualfsharpdocs/conceptual/code-formatting-guidelines-%5bfsharp%5d)
- [Compiler Options](https://msdn.microsoft.com/visualfsharpdocs/conceptual/compiler-options-%5bfsharp%5d)
- [Computation Expressions](https://msdn.microsoft.com/visualfsharpdocs/conceptual/computation-expressions-%5bfsharp%5d)
- [Constraints](https://msdn.microsoft.com/visualfsharpdocs/conceptual/constraints-%5bfsharp%5d)
- [Core.Operators Module](https://msdn.microsoft.com/visualfsharpdocs/conceptual/core.operators-module-%5bfsharp%5d)
- [Core.Printf Module](https://msdn.microsoft.com/visualfsharpdocs/conceptual/core.printf-module-%5bfsharp%5d)
- [Debugging F#](https://msdn.microsoft.com/en-us/library/ee843932.aspx)
- [Statically Resolved Type Parameters](https://msdn.microsoft.com/visualfsharpdocs/conceptual/statically-resolved-type-parameters-%5bfsharp%5d)
- [Symbol and Operator Reference](https://msdn.microsoft.com/visualfsharpdocs/conceptual/symbol-and-operator-reference-%5bfsharp%5d)
- [Tail calls in F#](https://blogs.msdn.microsoft.com/fsharpteam/2011/07/08/tail-calls-in-f/)

###### Collections
- [Collections.Array Module](https://msdn.microsoft.com/visualfsharpdocs/conceptual/collections.array-module-%5bfsharp%5d)
- [Collections.List Module](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/collections.list-module-%5bfsharp%5d)
- [Collections.List<'T> Union](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/collections.list%5b't%5d-union-%5bfsharp%5d)
- [Collections.Map Module](https://msdn.microsoft.com/visualfsharpdocs/conceptual/collections.map-module-%5bfsharp%5d)
- [Collections.Map<'Key,'Value> Class](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/collections.map%5b'key,'value%5d-class-%5bfsharp%5d)
- [Collections.Seq Module](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/collections.seq-module-%5bfsharp%5d)
- [Collections.Set Module](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/collections.set-module-%5bfsharp%5d)
- [Collections.Set<'T> Class](https://msdn.microsoft.com/en-us/visualfsharpdocs/conceptual/collections.set%5B't%5D-class-%5Bfsharp%5D)

###### Tutorials in Visual Studio Gallery
- [F# Introduction Tutorial - Visual Studio 2010](https://code.msdn.microsoft.com/windowsdesktop/F-Introduction-Tutorial-1707e309)
- [F# Samples 101 - Visual Studio 2010](https://code.msdn.microsoft.com/windowsdesktop/F-Samples-101-0576cb9f)
- [F# 3.0 Sample Pack](https://code.msdn.microsoft.com/windowsdesktop/F-30-Sample-Pack-d06ea11f)

###### Tutorials NOT in Visual Studio Gallery
- New Project > Templates > Visual F# > Tutorial
- [Introductory Micro Samples](https://fsharp3sample.codeplex.com/wikipage?Title=MicroSamples)
- [F# 3.0 Micro Samples](https://fsharp3sample.codeplex.com/wikipage?Title=FSharp3Samples)

###### Best practices
- Project Properties > Build
  - Other flags > "--warnon:1182"
  - Treat warnings as errors > All
- Open fsproj, and set the value of <DebugType> to
  - "pdbonly" in the debug configuration
  - "none" in the release configuration

###### Array
```fsharp
let xs = [| 1 .. 5 |]

// Use properties rather than functions
printfn "%A" (xs.Length) // Simpler than (Array.length xs)
printfn "%A" (xs.[2]) // Simpler than (Array.get xs 2)
```

###### List
```fsharp
let xs = [ 1 .. 5 ]

// Use properties rather than functions
printfn "%A" (xs.IsEmpty) // Simpler than (List.isEmpty xs)
printfn "%A" (xs.Length) // Simpler than (List.length xs)
printfn "%A" (xs.Head) // Simpler than (List.head xs)
printfn "%A" (xs.Tail) // Simpler than (List.tail xs)
printfn "%A" (xs.[2]) // Simpler than (xs.Item 2) or (List.item 2 xs)
```

###### Set
```fsharp
let xs = set [ 1 .. 5 ]
let ys = set [ 1 .. 5 ]

// Use properties rather than functions
printfn "%A" (xs.IsEmpty) // Simpler than (Set.isEmpty xs)
printfn "%A" (xs.Count) // Simpler than (Set.count xs)
printfn "%A" (xs.MaximumElement) // Simpler than (Set.maxElement xs)
printfn "%A" (xs.MinimumElement) // Simpler than (Set.minElement xs)
printfn "%A" (xs.Contains 2) // Simpler than (Set.contains 2 xs)
printfn "%A" (xs.Add 6) // Simpler than (Set.add 6 xs)
printfn "%A" (xs.Remove 2) // Simpler than (Set.remove 2 xs)
printfn "%A" (xs.IsProperSubsetOf ys) // Simpler than (Set.isProperSubset xs ys)
printfn "%A" (xs.IsSubsetOf ys) // Simpler than (Set.isSubset xs ys)
printfn "%A" (xs.IsProperSupersetOf ys) // Simpler than (Set.isProperSuperset xs ys)
printfn "%A" (xs.IsSupersetOf ys) // Simpler than (Set.isSuperset xs ys)
```

###### How to initialize a map
```fsharp
let m = Map.ofList [ 1, "one"; 2, "two" ]
```

###### How to initialize a seq
```fsharp
let xs = seq { 0 .. 5 }
```

###### How to initialize a dictionary of .NET Framework
```fsharp
let d = dict [ 1, "one"; 2, "two" ]
```

###### Discriminated union
can have static members such as:
```fsharp
type Rank = 
    /// Represents the rank of cards 2 .. 10
    | Value of int
    | Ace
    | King
    | Queen
    | Jack
    static member GetAllRanks() = 
        [ yield Ace
          for i in 2 .. 10 do yield Value i
          yield Jack
          yield Queen
          yield King ]
```

###### Pattern matching on records
```fsharp
type Person = { First : string; Last : string }

let person = { First = "John"; Last = "Doe" }

match person with 
| { First = "John" } -> printfn "Hi John !" 
| _  -> printfn "Not John .."
```
