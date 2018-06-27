namespace FSharp

module Lesson2_Fibonacci =
    open System.Diagnostics
   
    let isEven n =
        n % 2 = 0

    let rec fib n = 
        match n with
        | 0 -> 1
        | 1 -> 2
        | x -> fib (x-1) + fib (x-2)

    let fibSeries maxValue =
        Seq.initInfinite (fun a -> a)
        |> Seq.map fib
        |> Seq.filter isEven
        |> Seq.takeWhile (fun a -> a <= maxValue)
        |> Seq.sum
    
    let result = fibSeries 4000000
    Debug.WriteLine(result)