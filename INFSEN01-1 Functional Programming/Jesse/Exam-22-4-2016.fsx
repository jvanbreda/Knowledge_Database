let assignment1 num1 num2 =
    match num1 % 4 = 0, num2 % 4 = 0 with
    | true, false -> "Fizz"
    | false, true -> "Buzz"
    | true, true -> "FizzBuzz"
    | false, false -> "No match found"

let rec zip list1 list2 =
    match list1, list2 with
    | [], [] -> []
    | h1::t1, h2::t2 -> (h1, h2)::zip t1 t2

let rec unzip list =
    match list with
    | [] -> ([],[])
    | h::t -> (fst(h)::fst(unzip t), snd(h)::snd(unzip t))

type Expression =
    | Number of int
    | Add of Expression * Expression
    | Product of Expression * Expression
    | Difference of Expression * Expression
    | Division of Expression * Expression

let rec eval (expression: Expression) =
    match expression with 
    | Number x -> x
    | Add (x,y) -> eval x + eval y
    | Product (x, y) -> eval x * eval y
    | Difference (x, y) -> eval x - eval y
    | Division (x, y) -> eval x / eval y

type Ship = {
    mutable position: float * float;
    mutable projectiles: (float * float) list;
};

let s1 = {
    Ship.position = (0.4, 0.5);
    Ship.projectiles = [(0.0, 0.0); (1.0, 1.0)];
}

let update (ship:Ship): Ship =
    let rec updateProjectiles projectiles  = 
        match projectiles with 
        | [] -> []
        | x::xs -> (fst(x) + 0.1, snd(x) + 0.3)::updateProjectiles xs
    ship.projectiles <- updateProjectiles ship.projectiles
    ship

update s1