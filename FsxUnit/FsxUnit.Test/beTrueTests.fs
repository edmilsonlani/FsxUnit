namespace FsxUnit.Test
open NUnit.Framework
open FsxUnit

[<TestFixture>]
type ``be True tests`` ()=
    [<Test>] member test.
     ``true should be True`` ()=
        true |> should be True

    [<Test>] member test.
     ``true expression should be True`` ()=
        (3 < 4) |> should be True

    [<Test>] member test.
     ``false should fail to be True`` ()=
        shouldFail (fun () -> false |> should be True)

    [<Test>] member test.
     ``false should not be True`` ()=
        false |> should'nt be True

    [<Test>] member test.
     ``true should fail to not be True`` ()=
        shouldFail (fun () -> true |> should'nt be True)
