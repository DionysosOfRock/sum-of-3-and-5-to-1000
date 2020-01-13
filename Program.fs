// summing all multiples of 3 and 5 to 1000 exclusive

let rec summing = function
    | a when a >= 999 -> a
    | a when a % 3 = 0 -> a + summing (a+1)
    | a when a % 5 = 0 -> a + summing (a+1)
    | a ->  summing (a+1)

let SumOf3and5 = summing 1
printfn "%i" SumOf3and5

System.Console.ReadKey() |> ignore