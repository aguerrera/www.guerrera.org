
#I @"c:\source\ionchamp\Garoozis\Garoozis\bin\debug"
#r "Garoozis.dll"

open System
open System.Collections.Generic
open System.IO
open Garoozis


let configSource = __SOURCE_DIRECTORY__ + @"\config.js"
let config = Garoozis.Utils.get_config(configSource)

Garoozis.Transformer.Build(config)
Garoozis.RemoteStorage.PublishToS3(config)

Console.ReadKey()
