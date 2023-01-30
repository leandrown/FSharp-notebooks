#r "nuget: Deedle"

open Deedle

let titanic = Frame.ReadCsv("titanic.csv")

titanic.Print()