namespace FsxUnit.Test

[<AutoOpen>]
module Common =
    open NUnit.Framework
    
    let shouldFail (f : unit -> unit) =
        Assert.Throws<AssertionException>(new TestDelegate(f))
        |> ignore