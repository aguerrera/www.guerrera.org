﻿
#I @"c:\source\git\Garoozis\src\bin\debug"
#r "Garoozis.dll"

open System
open System.Collections.Generic
open System.IO
open Garoozis


let configSource = __SOURCE_DIRECTORY__ + @"\config.js"
let config = Garoozis.Utils.get_config(configSource)

Garoozis.RemoteStorage.PublishToS3(config)

printfn "DONE POSTING www.guerrera.org. "

//Console.ReadKey()
