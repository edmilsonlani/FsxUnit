namespace FsxUnit.Test
open NUnit.Framework
open FsxUnit

[<TestFixture>]
type ``Not a Number tests`` ()=
    // Collection   
    [<Test>] member test.
     ``Number 1 should be a number`` ()=
        1 |> should'nt be NaN

    [<Test>] member test.
     ``float number 2.0 should be a number`` ()=
        2.0 |> should'nt be NaN

    [<Test>] member test.
     ``float number 2.0 should fail to not be a number`` ()=
        shouldFail(fun () -> 2.0 |> should be NaN)
    
   
    