open SwaggerProvider

type MyTypeProvider = SwaggerProvider<"./spec.json">

[<EntryPoint>]
let main _ =
    let provider = MyTypeProvider()
    let response = provider.ResponseGet()
    let items = response.Items
    0
