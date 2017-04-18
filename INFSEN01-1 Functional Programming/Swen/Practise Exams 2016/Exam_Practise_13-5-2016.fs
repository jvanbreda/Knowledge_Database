// Assignment 1
let assignment1a n1 n2 n3 =
    if(n1 > n2 && n1 > n3) then "First"
    else if (n2 > n1 && n2 > n3) then "Second"
    else "Third"

let assignment1b n1 n2 n3 =
    match (n1 > n2 && n1 > n3), (n2 > n1 && n2 > n3) with
    | true, _ -> "First"
    | _, true -> "Second"
    | _, _    -> "Third"

let findIndexOfLargest nList =
    let rec inner nList currentIndex indexOfMax maxNumber =
        match nList with
        | [] -> indexOfMax, maxNumber
        | head::tail -> if (head > maxNumber) then inner tail (currentIndex + 1) currentIndex head else inner tail (currentIndex + 1) indexOfMax maxNumber
    inner nList 0 0 -99999

let assignment1c n1 n2 n3 =
    match findIndexOfLargest [n1;n2;n3] with
    | 0, _ -> "First"
    | 1, _ -> "Second"
    | 2, _ -> "Third"

let r1a = assignment1a 9 8 3
let r1b = assignment1b 1 7 4
let r1c = assignment1c 8 1 9

// Assignment 2
let tau0 (instance: Option<'a>) : List<'a> =
    match instance with
    | None -> []
    | Some v -> [v]

let t1 = tau0 (Some 4)

let (t2: int list) = tau0 (None)

// Assignment 3, 4
// Possible invalid assignment
let tau1 (mapFunc: (Option<'a> -> 'a)) (someList: List<'a>) : List<'a> =
    let rec map (mapFunc: (Option<'a> -> 'a)) (someList: List<'a>) (accList: List<'a>) =
        match someList with
        | [] -> List.rev accList
        | head::tail -> map mapFunc tail ((mapFunc (Some head))::accList)
    map mapFunc someList []

tau1 (fun x -> x.Value * 2) [1..5] // Returns [2; 4; 6; 8; 10]

// Assignment 5
let isInRange min max subject =
    min <= subject && subject <= max

type Date = {
    day: int;
    month: int;
    year: int;
} with 
    member this.isValid = (isInRange 1 31 this.day) && (isInRange 1 12 this.month)
    member this.addDate amount = if(this.day + amount > 31) 
                                    then {this with day= (this.day + amount) % 31; month= this.month + (this.day + amount) / 31} // To-do: Don't add 1 but make an 'addMonth' func
                                    else {this with day= this.day + amount}

type Person = {
    name: string;
    surname: string;
    dateOfBirth: Date;
}

let author = {
    name= "Swen";
    surname= "Meeuwes";
    dateOfBirth= {day= 18; month= 8; year= 1996}
}

let age (person: Person) : Person =
    { 
        person with
            dateOfBirth= {
                person.dateOfBirth with 
                    day= person.dateOfBirth.day + 1
                    month= person.dateOfBirth.month + 1
                    year= person.dateOfBirth.year + 1
            }
    }

age author

author.dateOfBirth.addDate 95 // Bonus