open System
open System.Collections.Generic

let primes = new List<int>([2; 3])

let isPrime n =
  if n < 2 || primes.Exists (fun d -> n % d = 0) then false else
  primes.Add n
  true

[<EntryPoint>]
let main argv =
  let maxI = int (argv.[0])
  printfn "%d\n%d" 2 3
  let mutable i = 0
  while i < maxI do
    let n = 6 * i
    if isPrime (n - 1) then printfn "%d" (n - 1)
    if isPrime (n + 1) then printfn "%d" (n + 1)
    i <- i + 1
  0