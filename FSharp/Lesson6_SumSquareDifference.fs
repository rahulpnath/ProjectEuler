module Lesson6_SumSquareDifference

let numbers = [1..100]

let combinations1 = Seq.allPairs numbers numbers

let sqr a = a * a
let sumOfSquares = numbers |> Seq.sumBy sqr
                   
let combinationsSum = Seq.allPairs numbers numbers
                   |> Seq.sumBy (fun (a,b) -> a * b)
                   
let sumSquareDifference = combinationsSum-sumOfSquares