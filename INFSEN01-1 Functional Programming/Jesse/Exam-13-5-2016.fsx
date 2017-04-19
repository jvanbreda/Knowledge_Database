let assignment1 num1 num2 num3 =
    if (num1 > num2 && num1 > num3) then printfn "first"
    if (num2 > num1 && num2 > num3) then printfn "second"
    if (num3 > num1 && num3 > num2) then printfn "third"

let tau0 (option: Option<'a>): List<'a> =
    match option with
    | Some x -> [x]
    | None -> []

let rec tau1 (inputFunction: (Option<'a> -> List<'a>)) (list1: List<Option<'a>>): List<'b> =
    match list1 with
    | [] -> []
    | x::xs -> (inputFunction x):: tau1 inputFunction xs

type Age = {
    days: int;
    months: int;
    years: int;
}

type Person = {
    firstname: string;
    lastname: string;
    age: Age;
}

let person = {
    Person.firstname = "Henk";
    Person.lastname = "Henksen";
    Person.age = {Age.days = 0; Age.months = 0; Age.years = 20};
}

let age (p:Person) : Person =
    let p = {p with age = {days = p.age.days + 1; months = p.age.months + 1; years = p.age.years + 1}}
    p

age person