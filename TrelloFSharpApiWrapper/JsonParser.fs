module JsonParser

open Types
open System.IO
open System.Text
open Newtonsoft.Json;
open System

let deserializeToBoard json =

    let x = JsonConvert.DeserializeObject<Board>json
    x