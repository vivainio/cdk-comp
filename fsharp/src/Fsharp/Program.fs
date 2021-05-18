open Amazon.CDK
open Fsharp

[<EntryPoint>]
let main _ =
    let app = App(null)

    FsharpStack(app, "FsharpStack", StackProps()) |> ignore

    app.Synth() |> ignore
    0
