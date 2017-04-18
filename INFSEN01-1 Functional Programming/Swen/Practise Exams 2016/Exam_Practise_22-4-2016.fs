// Assignment 1
let assignment1 n1 n2 =
    let isFizzing = n1 % 4 = 0
    let isBuzzing = n2 % 4 = 0
    match (isFizzing, isBuzzing) with
    | true, true -> "FizzBuzz"
    | true, false -> "Fizz"
    | false, true -> "Buzz"
    | _ -> "No fizzing/ Buzzing :c" 

let fizzBuzzResult = assignment1 4 3

// Assignment 2
let zip (l1: list<'T>) (l2: list<'T>) =
    let rec inner (l1: list<'T>) (l2: list<'T>) accl =
        match l1 with
        | [] -> List.rev accl
        | head::tail -> inner l1.Tail l2.Tail ((l1.Head, l2.Head) :: accl)        
    inner l1 l2 []

let unzip l1 =
    let rec inner (l1: ('T * 'T) list) accl1 accl2 =
        match l1 with
        | [] -> List.rev accl1, List.rev accl2
        | head::tail -> inner tail (fst head::accl1) (snd head::accl2)
    inner l1 [] []

let zippedResult = zip [1;2;3] [4;5;6]
let unzippedResult = unzip zippedResult

// Assignment 3
type Expression =
    | Value of int
    | Sum of Expression * Expression
    | Subtract of Expression * Expression
    | Multiply of Expression * Expression
    | Divide of Expression * Expression

let rec evalExpression expression =
    match expression with
    | Value x -> x
    | Sum (left, right) ->
        (fun left right ->
            left + right
        ) (evalExpression left) (evalExpression right)
    | Subtract (left, right) ->
        (fun left right ->
            left - right
        ) (evalExpression left) (evalExpression right)
    | Multiply (left, right) ->
        (fun left right ->
            left * right
        ) (evalExpression left) (evalExpression right)
    | Divide (left, right) ->
        (fun left right ->
            left / right
        ) (evalExpression left) (evalExpression right)

let evaluation = evalExpression(Sum(Subtract(Value 3, Value 4), Value 5))

// Assignment 4
type Projectile = {
    position: float * float
}

let updateProjectile projectile =
    match projectile.position with
    | x, y -> { position = x + 0.1, y + 0.3}

type Ship = {
    position: float * float
    projectiles: list<Projectile>
}

let someShip = { position = 0.0, 0.0; projectiles = [{ position = 0.0, 0.0 }; { position = 10.0, 10.0 }] }

// "Game Loop"
let update ship =
    let rec updateProjectiles projectiles acc =
        match projectiles with
        | [] -> List.rev acc
        | head::tail -> updateProjectiles tail ((updateProjectile head)::acc)
    { position = 0.0, 0.0; projectiles = updateProjectiles ship.projectiles [] }

let shipAfter2Iters = update (update someShip)

// Assignment 5
type Action =
    | Move of float * float
    | Shoot

let execute ship action =
    match action with
    | Move (x, y) -> { position = fst ship.position + x, snd ship.position + y; projectiles = ship.projectiles }
    | Shoot -> { position = ship.position; projectiles = { position = ship.position }::ship.projectiles }

let playerShip = { position = 0.0, 0.0; projectiles = [] }

let moveRight = Move (0.4, 0.0)
let playerShipAfterMove = execute playerShip moveRight
let playerShipAfterShoot = execute playerShip Shoot