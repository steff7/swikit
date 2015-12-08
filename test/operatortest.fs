S" ../operator.fs" INCLUDED

CR CR

\ ------------------------------------------------------------------------
TESTING BASIC ASSUMPTIONS

T{ -> }T

\ ------------------------------------------------------------------------
TESTING '^'

T{ ' ^ #params  -> 2 }T
T{ ' ^ is-left?  -> FALSE }T
T{ ' ^ is-right?  -> TRUE }T
T{ ' ^ prec  -> 4 }T

\ ------------------------------------------------------------------------
TESTING '*'

T{ ' * #params  -> 2 }T
T{ ' * is-left?  -> TRUE }T
T{ ' * is-right?  -> FALSE }T
T{ ' * prec  -> 3 }T

\ ------------------------------------------------------------------------
TESTING '/'

T{ ' / #params  -> 2 }T
T{ ' / is-left?  -> TRUE }T
T{ ' / is-right?  -> FALSE }T
T{ ' / prec  -> 3 }T

\ ------------------------------------------------------------------------
TESTING '+'

T{ ' + #params  -> 2 }T
T{ ' + is-left?  -> TRUE }T
T{ ' + is-right?  -> FALSE }T
T{ ' + prec  -> 2 }T

\ ------------------------------------------------------------------------
TESTING '-'

T{ ' - #params  -> 2 }T
T{ ' - is-left?  -> TRUE }T
T{ ' - is-right?  -> FALSE }T
T{ ' - prec  -> 2 }T

\ ------------------------------------------------------------------------
