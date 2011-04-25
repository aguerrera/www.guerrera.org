
#r "lib\Garoozis.dll"

open System
open System.Collections.Generic
open System.IO


let configSource = "config.js"
let config = Garoozis.Utils.get_config(configSource)
Garoozis.Transformer.build_pages config.OutputDir config.SourceDir
Garoozis.RemoteStorage.publish_to_s3(config)
