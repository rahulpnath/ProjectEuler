namespace FSharp

module Lesson5_SmallestMultiple = 
    
    let rec gcd a b =
        if a = 0L then b
        elif b = 0L then a
        elif a > b then gcd b a
        else match b % a with
             | 0L -> a
             | r -> gcd a r

    let lcm a b = 
        (a * b)/(gcd a b)

    let rec lcmList a b =
        match b with
        | [] -> a
        | [head] -> lcm a head
        | head::tail -> lcm a (lcmList head tail)

    
    