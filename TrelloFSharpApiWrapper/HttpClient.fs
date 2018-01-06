module HttpClient

open System
open System.Net.Http

let get (url:Uri) =
    let client = new HttpClient();
    client.GetStringAsync(url)
    |> Async.AwaitTask
    |> Async.RunSynchronously