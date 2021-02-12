// Defining the car type.
type Car =
    { Make: string
      Model: string
      TopSpeed: float }

// Creating two cars to race.
let carOne =
    { Make = "Ferrari"
      Model = "488 GTE"
      TopSpeed = 490.0 }

let carTwo =
    { Make = "McLaren"
      Model = "F1"
      TopSpeed = 490.1 }


let raceTheCars (carOne: Car) (carTwo: Car) =
    // Pattern match the potential race outcomes.
    let raceOutcome announce =
        match announce with
        | ("Ferrari") -> printfn "Ferrari wins!"
        | ("McLaren") -> printfn "The McLaren won!"
        | ("Tie!") -> printfn "It was a tie!"
        | _ -> printfn "Invalid result."

    // The race logic.
    let winner =
        if (carOne.TopSpeed > carTwo.TopSpeed) then carOne.Make
        elif (carOne.TopSpeed < carTwo.TopSpeed) then carTwo.Make
        else "Tie!"

    raceOutcome winner

[<EntryPoint>]
let main _ =
    raceTheCars carOne carTwo
    0 // return an integer exit code
