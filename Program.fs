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


let race (carOne: Car) (carTwo: Car) =
    // Pattern match the potential race outcomes.
    let raceOutcome race =
        match race with
        | ("Ferrari") -> printfn "Ferrari wins!"
        | ("McLaren") -> printfn "The McLaren won!"
        | ("Tie!") -> printfn "It was a tie!"
        | _ -> printfn "Invalid result."

    // The race logic.
    let racing =
        if (carOne.TopSpeed > carTwo.TopSpeed) then carOne.Make
        elif (carOne.TopSpeed < carTwo.TopSpeed) then carTwo.Make
        else "Tie!"

    raceOutcome racing

[<EntryPoint>]
let main _ =
    race carOne carTwo
    0 // return an integer exit code
