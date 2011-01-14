namespace FsxUnit.Test
open NUnit.Framework
open FsxUnit

[<TestFixture>]
type ``Less Than tests`` ()=
    // Collection   
    [<Test>] member test.
     ``Number 0 should be less than 1`` ()=
        0 |> should be (lessThan 1)

    [<Test>] member test.
     ``Number 1 should fail to be less than 0`` ()=
        shouldFail(fun () -> 1 |> should be (lessThan 0))

    [<Test>] member test.
     ``Number 1 should'nt be less than 0`` ()=
        1 |> should'nt be (lessThan 0)

    [<Test>] member test.
     ``Number 0 should fail to not be less than 1`` ()=
        shouldFail(fun () -> 0 |> should'nt be (lessThan 1))

    [<Test>] member test.
     ``Number 0 should'nt be less than 0`` ()=
        0 |> should'nt be (lessThan 0)
    
    [<Test>] member test.
     ``Number 1 should fail to be greater than 1`` ()=
        shouldFail(fun () -> 1 |> should be (lessThan 1))
    
[<TestFixture>]
type ``Less Than tests or Equal`` ()=
    // Collection   
    [<Test>] member test.
     ``Number 0 should be less than 1`` ()=
        0 |> should be (lessThanOrEqual 1)

    [<Test>] member test.
     ``Number 1 should fail to be less than 0`` ()=
        shouldFail(fun () -> 1 |> should be (lessThanOrEqual 0))

    [<Test>] member test.
     ``Number 1 should'nt be less than 0`` ()=
        1 |> should'nt be (lessThanOrEqual 0)

    [<Test>] member test.
     ``Number 0 should fail to not be less than 1`` ()=
        shouldFail(fun () -> 0 |> should'nt be (lessThanOrEqual 1))

    [<Test>] member test.
     ``Number 0 should be less than 0`` ()=
        0 |> should be (lessThanOrEqual 0)
    
    [<Test>] member test.
     ``Number 1 should fail to not be greater than 1`` ()=
        shouldFail(fun () -> 1 |> should'nt be (lessThanOrEqual 1))
    


