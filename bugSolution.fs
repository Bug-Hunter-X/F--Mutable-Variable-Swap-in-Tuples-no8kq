let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will print 20 20 as expected

let mutable a = 10
let mutable b = 20

let swap2 () = 
    let temp = a
    a <- b
    b <- temp

swap2 ()
printfn "%d %d" a b //this will print 20 20 which is expected.