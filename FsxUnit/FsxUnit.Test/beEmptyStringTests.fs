namespace FsxUnit.Test
open NUnit.Framework
open FsxUnit

[<TestFixture>]
type ``be EmptyString tests`` ()=
    [<Test>] member test.
     ``empty string should be EmptyString`` ()=
        "" |> should be EmptyString

    [<Test>] member test.
     ``non-empty string should fail to be EmptyString`` ()=
        shouldFail (fun () -> "a string" |> should be EmptyString)
        
    [<Test>] member test.
     ``non-empty string should not be EmptyString`` ()=
        "a string" |> should'nt be EmptyString

    [<Test>] member test.
     ``empty string should fail to not be EmptyString`` ()=
        shouldFail (fun () -> "" |> should'nt be EmptyString)