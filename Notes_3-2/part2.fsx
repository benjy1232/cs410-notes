type RegisteredCustomer = { id: string; isEligible: bool }
type UnregisteredCustomer = { id: string }

// discriminated unit
type Customer =
    | Registered of RegisteredCustomer
    | Guest of UnregisteredCustomer

let calculateTotal (customer: Customer, cost: decimal) : decimal =
    match customer with
    | Registered c -> if c.isEligible && cost >= 100M then 0.9M * cost else cost
    | _ -> cost

let john = Registered { id = "John"; isEligible = true }
let mary = Registered { id = "John"; isEligible = true }
let richard = Registered { id = "John"; isEligible = false }
let sarah = Guest { id = "Sarah" }

let assertJohn: bool = calculateTotal (john, 100.0M) = 90.0M
let assertMary: bool = calculateTotal (mary, 99.00M) = 99.0M
let assertRichard: bool = calculateTotal (richard, 100.0M) = 100.0M
let assertSarah: bool = calculateTotal (sarah, 100.0M) = 100.0M

// Testing
assert assertJohn
assert assertMary
assert assertRichard
assert assertSarah