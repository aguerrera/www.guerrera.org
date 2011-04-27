
#I @"c:\source\ionchamp\Garoozis\Garoozis\bin\debug"
#r "Garoozis.dll"

open System
open System.Collections.Generic
open System.IO
open Garoozis


let configSource = __SOURCE_DIRECTORY__ + @"\config.js"
let config = Garoozis.Utils.get_config(configSource)

printfn "STARTING output server www.guerrera.org."
Garoozis.WebServer.StartOutputServer 8088 config

//printfn "STARTING dev server www.guerrera.org."
//Garoozis.WebServer.StartDevServer 8088 config


Console.ReadKey()