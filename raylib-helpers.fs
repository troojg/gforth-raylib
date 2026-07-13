require raylib.fs


\ Copied from ArnautDaniel's raylib 3 bindings. Thanks!
\ Example helpers for moving data from the stack to structures
\ or back.  Will add more as I need them.

: Vector2> ( Vector2 -- f: -- x y )
    dup dup sf@ Vector2-y sf@
    free throw ;

: >Vector2 ( f: -- x y -- Vector2 )
    Vector2 allocate throw
    dup dup sf! Vector2-y sf! ;

: >Vector3 ( f: -- x y z -- Vector3 )
    Vector3 allocate throw { Vec3 }
    Vec3 Vector3-z sf!
    Vec3 Vector3-y sf!
    Vec3 sf! Vec3 ;

: Vector3> ( Vector3 -- f: -- x y z )
    { Vec3 }
    Vec3 sf@
    Vec3 Vector3-y sf@
    Vec3 Vector3-z sf@ ;
