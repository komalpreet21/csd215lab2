type Coach = {
    Name: string
    FormerPlayer: bool
}

type stats = {
    Wins: int
    Losses: int
}

type Team = {
    Name: string
    Coach: Coach
    stats: stats
}





let tm = [
    {Name = "Boston Celtics"; Coach = {Name = "Joe Mazzulla"; FormerPlayer= true} ; stats = {Wins=3570 ;Losses=2462 }}
    {Name = "Phoenix Suns"; Coach = {Name = "Igor Kokoskov"; FormerPlayer= true} ; stats = {Wins=2146 ;Losses=1804 }}
    {Name = "Toronto Raptors"; Coach = {Name = "Darko Rajakovic"; FormerPlayer= true} ; stats = {Wins=1071 ;Losses=1157 }}
    {Name = "Miami Heat"; Coach = {Name = "Erik Spoelstra"; FormerPlayer= true} ; stats = {Wins=1475 ;Losses=1328 }}
    {Name = "Atlanta Hawks"; Coach = {Name = "Quin Snyder"; FormerPlayer= true} ; stats = {Wins= 2891 ;Losses=2964 }}
]

let topteam = tm |> List.filter (fun tm -> tm.stats.Wins > tm.stats.Losses)

//printfn "%A" topteam

topteam |> List.iter (fun tm -> printfn "tm Name: %s" tm.Name)
topteam |> List.iter (fun tm -> printfn "tm wins: %d" tm.stats.Wins)

let calculateSuccessPercentage tm =  float tm.stats.Wins / float ( tm.stats.Wins + tm.stats.Losses ) * 100.0

let successPercentages = topteam |> List.map calculateSuccessPercentage 

let avg = List.average successPercentages 

printfn "The Percentage of Team %f" avg
type Cuisine = 
    | Korean 
    | Turkish

type MovieType = 
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks 
    | IMAXWithSnacks
    | DBOXWithSnacks

type Activity = 
    | BoardGAme 
    | Chill 
    |Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int* float
 
let calculatebudget Actvty = 
    match Actvty  with 
    | BoardGame -> 10.0
    | Chill -> 0.0
    | Movie Regular -> 12.0
    | Movie IMAX -> 17.0
    | Movie DBOX -> 20.0
    | Movie _ -> 12.0 + 5.0
    | Restaurant Koreannn -> 70.0
    | Restaurant Turkish -> 65.0
    | LongDrive (kilometres, fuelcharge) -> float kilometres * fuelcharge

let eveningActvty = Restaurant Turkish
let budget = calculatebudget eveningActvty
printfn "Est budget: %.2f CAD" budget
