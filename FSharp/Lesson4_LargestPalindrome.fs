namespace FSharp

module Lesson4_LargestPalindrome = 
    open System
    let threeDigitNumbers = [100..999]

    let reverse (s:string) = String(s.ToCharArray() |> Array.rev)

    let isPalidrome a = a.ToString() = reverse (a.ToString())

    let max =  Seq.allPairs threeDigitNumbers threeDigitNumbers
               |> Seq.map (fun (a,b) -> a * b)
               |> Seq.filter isPalidrome
               |> Seq.max
    
        

