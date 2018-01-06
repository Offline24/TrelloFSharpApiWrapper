module JsonParser

open Types
open System.IO
open System.Runtime.Serialization.Json
open System.Text

/// Object from Json 
let internal unjson<'t> (jsonString:string)  : 't =  
        use ms = new MemoryStream(ASCIIEncoding.Default.GetBytes(jsonString)) 
        let obj = (new DataContractJsonSerializer(typeof<'t>)).ReadObject(ms) 
        obj :?> 't


let deserializeToBoard json = unjson<Board> json