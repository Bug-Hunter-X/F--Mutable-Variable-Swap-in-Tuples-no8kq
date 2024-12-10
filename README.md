# F# Mutable Variable Swap in Tuples

This repository demonstrates an unexpected behavior when using mutable variables within tuples in F#.  When swapping mutable variables directly, it works as expected. However, when the mutable variables are part of a tuple, the swap operation doesn't modify the original variables outside the tuple scope.

The `bug.fs` file contains the code exhibiting the issue. The `bugSolution.fs` file presents a corrected approach.

## Setup

No special setup required. The code can be run using a F# compiler (e.g., .NET SDK).