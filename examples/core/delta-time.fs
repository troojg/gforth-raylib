require ../../raylib.fs

800 Constant screenWidth
450 Constant screenHeight

60 value currentFPS

\ The first 0 is the x position of our delta circle,
\ and for the second (y) value we convert the screen
\ width (which is an int) to a float, and divide by 3.
0.0e screenHeight s>f 3.0e f/
>Vector2 Value deltaCircle
\ Same idea as before, but we want this circle to be
\ two thirds of the way down the screen. The raylib
\ example does it this way, I'm not sure why, but who
\ am I to question it?
0.0e screenHeight s>f 2.0e 3.0e f/ f*
>Vector2 Value frameCircle

10.0e fConstant speed
32.0e fConstant circleRadius

: to-string ( n -- addr len )
    \ found this on reddit, i don't really get it
    s>d <# #s #>
;

: f-to-string ( r -- addr len )
    \ this one i figured out myself 😎 there may be a
    \ better way but this works.
    1000.0e f*
    6 3 3 f>str-rdp
;

: init-window ( -- )
    screenWidth screenHeight
    s" raylib [core] example - delta time"
    InitWindow
;

: reset-x ( Vec2-addr -- )
    0.0e vector2-x sf!
;
    
: cond-reset-x ( Vec2-addr -- )
    dup Vector2-x sf@
    screenWidth s>f f> if
        reset-x
    else
        drop
    then
;

: fps-text ( -- )
    currentFPS 0<= if
        s" FPS: unlimited ("
        GetFPS to-string s+
        s" )" s+
    else
        s" FPS: "
        GetFPS to-string s+
        s"  (target: " s+
        currentFPS to-string s+
        s" )" s+
    then
    10 10 20 DARKGRAY DrawText
;

: frame-text ( -- )
    s" Frame time: "
    GetFrameTime f-to-string s+
    s"  ms" s+
    10 30 20 DARKGRAY DrawText
;

: game-loop ( -- )
    begin
        GetMouseWheelMove \ leaves a float on the stack
        fdup f0<> if
            \ increment or decrement the currentFPS by
            \ the value of the mouse wheel.
            f>s +>currentFPS
            \ make sure we don't get a negative FPS
            currentFPS 0< if
                0 to currentFPS
            then
            currentFPS SetTargetFPS
        else
            fdrop
        then

        \ we get the frame time and multiply by 6 to try
        \ to match the ball that follows the framerate
        GetFrameTime 6.0e f* speed f*
        deltaCircle Vector2-x sf@ f+
        deltaCircle Vector2-x sf!
        \ this ball just follows the FPS
        0.1e speed f*
        frameCircle Vector2-x sf@ f+
        frameCircle Vector2-x sf!

        \ wraps the balls around the screen
        deltaCircle cond-reset-x
        frameCircle cond-reset-x

        \ reset circle positions
        KEY_R IsKeyPressed if
            deltaCircle reset-x
            frameCircle reset-x
        then
        
        BeginDrawing \ ----------------
        RAYWHITE ClearBackground

        \ Draw the balls
        deltaCircle circleRadius RED DrawCircleV
        frameCircle circleRadius BLUE DrawCircleV

        \ Draw the help text
        fps-text
        frame-text
        s" Use the scroll wheel to change the fps limit, r to reset"
        10 50 20 DARKGRAY DrawText

        \ Draw the text above the circles
        s" FUNC: x += GetFrameTime * speed"
        10 90 20 RED DrawText
        s" FUNC: x += speed"
        10 240 20 BLUE DrawText

        EndDrawing \ ----------------
     
    WindowShouldClose until
    ;

: main ( -- )
    init-window
    currentFPS SetTargetFPS
    game-loop
    CloseWindow
    ;

main
bye
