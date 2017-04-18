// Assignment 1
let assignment1a n1 n2 n3 =
    if(n1 > n2 && n1 > n3) then "First"
    else if (n2 > n1 && n2 > n3) then "Second"
    else "Third"

let findIndexOfLargest nList =
    let rec inner nList currentIndex indexOfMax maxNumber =
        match nList with
        | [] -> indexOfMax, maxNumber
        | head::tail -> if (head > maxNumber) then inner tail (currentIndex + 1) currentIndex head else inner tail (currentIndex + 1) indexOfMax maxNumber
    inner nList 0 0 -99999

let assignment1b n1 n2 n3 =
    match findIndexOfLargest [n1;n2;n3] with
    | 0, _ -> "First"
    | 1, _ -> "Second"
    | 2, _ -> "Third"

assignment1b 2 8 3

// Assignment 2
let tau0 (instance: Option<'a>) : List<'a> =
    match instance with
    | None -> []
    | Some v -> [v]

let t1 = tau0 (Some 4)

let (t2: int list) = tau0 (None)

// Assignment 3, 4
let tau1 (process: (Option<'a> -> Option<'b>)) (someList: List<'a>) : List<'b> =
    let rec map process someList =
        match someList with
        | [] -> someList
        | head::tail -> 
    map process someList