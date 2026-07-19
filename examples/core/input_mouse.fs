require ../../raylib.fs

800 constant screenWidth
450 constant screenHeight

-100.0e -100.0e
>Vector2 value ballPosition

DARKBLUE value ballColor

: init-window ( -- )
    screenWidth screenHeight
    s" raylib [core] example - input mouse"
    InitWindow
    60 SetTargetFPS
;

: draw ( -- )
    BeginDrawing

    RAYWHITE ClearBackground

    ballPosition 40.0e ballColor
    DrawCircleV

    s" Move ball with mouse and click mouse button to change color"
    10 10 20 DARKGRAY DrawText

    s" Press 'H' to toggle cursor visibility"
    10 30 20 DARKGRAY DrawText

    IsCursorHidden if
        s" CURSOR HIDDEN"
        20 60 20 RED DrawText
    else
        s" CURSOR VISIBLE"
        20 60 20 LIME DrawText
    then

    EndDrawing
;

: cursor-toggle ( -- )
    KEY_H IsKeyPressed if
        IsCursorHidden if
            ShowCursor
        else
            HideCursor
        then
    then
;

: handle-mouse ( -- )
    MOUSE_BUTTON_LEFT IsMouseButtonPressed if
        MAROON to ballColor then
    MOUSE_BUTTON_MIDDLE IsMouseButtonPressed if
        LIME to ballColor then
    MOUSE_BUTTON_RIGHT IsMouseButtonPressed if
        DARKBLUE to ballColor then
    MOUSE_BUTTON_SIDE IsMouseButtonPressed if
        PURPLE to ballColor then
    MOUSE_BUTTON_EXTRA IsMouseButtonPressed if
        YELLOW to ballColor then
    MOUSE_BUTTON_FORWARD IsMouseButtonPressed if
        ORANGE to ballColor then
    MOUSE_BUTTON_BACK IsMouseButtonPressed if
        BEIGE to ballColor then
;

: game-loop ( -- )
    begin
        cursor-toggle
        
        \ I'm doing this instead of using GetMousePosition
        \ because that's not working atm. I need to fix it.
        GetMouseX GetMouseY s>f s>f
        ballPosition Vector2-x sf!
        ballPosition Vector2-y sf!

        handle-mouse

        draw
    WindowShouldClose until
;

: main ( -- )
    init-window
    game-loop
    CloseWindow
;

main bye
