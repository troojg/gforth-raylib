require ../../raylib.fs

800 constant screenWidth
450 constant screenHeight

screenWidth s>f 2.0e f/
screenHeight s>f 2.0e f/
>Vector2 value ballPosition

: sf-! ( f-addr r -- )
    \ subtract r from float at the address
    dup sf@ fswap f- sf!
;

: init-window ( -- )
    screenWidth screenHeight
    s" raylib [core] example - input keys"
    InitWindow
    60 SetTargetFPS
;

: handle-input ( -- )
    KEY_RIGHT IsKeyDown if
        ballPosition Vector2-x 2.0e sf+! then
    
    KEY_LEFT IsKeyDown if
        ballPosition Vector2-x 2.0e sf-! then
    
    KEY_UP IsKeyDown if
        ballPosition Vector2-y 2.0e sf-! then
    
    KEY_DOWN IsKeyDown if
        ballPosition Vector2-y 2.0e sf+! then
;

: draw ( -- )
    BeginDrawing
    RAYWHITE ClearBackground

    s" move the ball with arrow keys"
    10 10 20 DARKGRAY DrawText

    ballPosition 50.0e MAROON DrawCircleV
    EndDrawing
;

: main ( -- )
    init-window
    begin
        handle-input
        draw
    WindowShouldClose until
    CloseWindow
;

main bye
