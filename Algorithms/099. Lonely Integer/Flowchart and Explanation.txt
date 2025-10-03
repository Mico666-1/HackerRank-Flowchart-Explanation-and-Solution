┌─────────────┐
│    Start    │
└──────┬──────┘
       │
┌──────┴─────────────────────────────┐
│ Read array a                       │
│ Initialize result = 0              │
└──────┬─────────────────────────────┘
       │
┌──────┴─────────────────────────────┐
│ For each num in a                  │
│  result = result XOR num           │
└──────┬─────────────────────────────┘
       │
┌──────┴─────────────┐
│ Return result      │
└──────┬─────────────┘
       │
┌──────┴─────┐
│    End     │
└────────────┘

The function uses XOR to find the unique integer in an array where every other element occurs twice. XOR of a number with itself is 0, and XOR with 0 is the number itself. By XOR-ing all elements, all duplicates cancel out, leaving the single “lonely” integer.