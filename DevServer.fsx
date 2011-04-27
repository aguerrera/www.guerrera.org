
#I @"c:\source\ionchamp\Garoozis\Garoozis\bin\debug"
#r "Garoozis.dll"

open System
open System.Collections.Generic
open System.IO
open Garoozis


let configSource = __SOURCE_DIRECTORY__ + @"\config.js"
let config = Garoozis.Utils.get_config(configSource)

let args = Environment.GetCommandLineArgs()


let run_output_server () = 
    printfn "STARTING output server www.guerrera.org."
    Garoozis.WebServer.StartOutputServer 8088 config

let run_dev_server () = 
    printfn "STARTING dev server www.guerrera.org."
    Garoozis.WebServer.StartDevServer 8088 config

if args.Length > 0 then
    let isstatic = args |> Array.exists (fun s -> s.ToLower() = "--static")
    match isstatic with
    | true -> run_output_server()
    | _ -> run_dev_server()
else
    run_dev_server () 