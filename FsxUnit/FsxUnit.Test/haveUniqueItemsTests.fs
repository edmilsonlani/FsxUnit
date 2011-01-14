namespace FsxUnit.Test
open NUnit.Framework
open FsxUnit

[<TestFixture>]
type ``have unique items list tests`` ()=
    [<Test>] member test.
     ``empty list should have unique items `` ()=
        [] |> should have uniqueItems

    [<Test>] member test.
     ``empty list should fail to have non-unique items `` ()=
        shouldFail(fun () -> [] |> should'nt have uniqueItems)
    
    [<Test>] member test.
     ``one-item list should have unique items `` ()=
        [1] |> should have uniqueItems
    
    [<Test>] member test.
     ``one-item list should fail to have non-unique items `` ()=
        shouldFail(fun () -> [1] |> should'nt have uniqueItems)

    [<Test>] member test.
     ``unique list should have unique items `` ()=
        [1;2;3] |> should have uniqueItems

    [<Test>] member test.
     ``unique list should fail to have non-unique `` ()=
        shouldFail(fun () -> [1;2;3] |> should'nt have uniqueItems)

    [<Test>] member test.
     ``non-unique list should not have unique items`` ()=
        [1;1;1] |> should'nt have uniqueItems
    
    [<Test>] member test.
      ``non-unique list should fail to have unique items `` ()=
        shouldFail(fun () -> [1;1;1] |> should have uniqueItems)