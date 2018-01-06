module JsonParser

open Types
open System.IO
open System.Text
open Newtonsoft.Json;
open System
open MBrace.FsPickler.Json

let deserializeToBoard json =
    let jsonSerializer = FsPickler.CreateJsonSerializer(indent = false, omitHeader = true)
    jsonSerializer.
    let jsonTextReader = new StringReader(json) :> TextReader
    jsonSerializer.Deserialize<Board>(jsonTextReader)