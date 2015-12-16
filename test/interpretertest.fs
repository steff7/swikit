INCLUDE ../swikit.fs

\ ------------------------------------------------------------------------
TESTING INFIX EXPRESSIONS

T{ ` ´ -> }T
T{ ` 1 ´ -> 1 }T
T{ ` 2 + 3 ´ -> 5 }T
T{ ` 3 * 2 ´ -> 6 }T
T{ ` 3 - 4 ´ -> -1 }T
T{ ` 6 / 2 ´ -> 3 }T
T{ ` 2 ^ 3 ´ -> 8 }T

T{ ` 2 + 3 * 3 ´ -> 11 }T
T{ ` 2 * 3 + 3 ´ -> 9 }T
T{ ` 2 * 3 / 3 ´ -> 2 }T
T{ ` 2 * 3 ^ 3 - 64 / 2 ^ 3 ´ -> 46 }T
T{ ` 3 + 4 * 2 / 1 - 5  ^ 0 ^ 3 ´ -> 10 }T
T{ ` 3 + 4 * 2 / 1 - 5 + 3 - 2 ^ 2 * 3 - 6 ^ 2 ´ -> -39 }T
T{ ` 99 / 3 + 4 * 2 / 1 - 5 * 3 + 2 ^ 2 * 3 - 6 ^ 3 / 6 ^ 2 + 4 ´ -> 36 }T